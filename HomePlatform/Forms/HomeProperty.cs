namespace HomePlatform.Forms
{
    using HomePlatform.Data;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using System.Linq;
    using System.Data.Entity.Core;
    using System.Collections.Generic;
    
    public partial class HomeProperty : Form
    {
        private SqlConnection sqlConnection;
        private HomeContext context;
        private ICollection<Item> items;

        public HomeProperty()
        {
            this.context = new HomeContext();
            InitializeComponent();

            string connectionString = "data source=.;initial catalog=HomePlatformDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            this.sqlConnection = new SqlConnection(connectionString);

            this.items = new HashSet<Item>();
            foreach (var item in context.Items)
            {
                this.items.Add(item);
            }
        }

        private void buttonShowItems_Click(object sender, EventArgs e)
        {
            string whereClause = string.Empty;
            if (context.Locations.Any(l => l.Name == this.comboBoxAddress.Text))
            {
                whereClause = $"where l.Name = '{this.comboBoxAddress.Text}'";
            }

            string sql = "select i.id, it.Name as 'ItemName', i.Quantity, m.Name as 'Metric', i.Note, l.Name as 'Address' " +
                         "from Items i " +
                         "left join Metrics m " +
                         "  on m.Id = i.MetricId " +
                         "join ItemTypes it" +
                         "	on it.Id = i.ItemTypeId " +
                         "left join Locations l " +
                         "	on l.Id = i.LocationId " +
                         whereClause +
                         " order by it.Name ";
            SqlCommand command = new SqlCommand(sql, this.sqlConnection);

            ExecuteCommandInDataGrid(command);
        }

        private void ExecuteCommandInDataGrid(SqlCommand command)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable table = new DataTable("MyDataTable");
                sda.Fill(table);
                BindingSource bindingSource = new BindingSource();

                bindingSource.DataSource = table;
                this.dataGridView1.DataSource = bindingSource;
                sda.Update(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HomeProperty_Load(object sender, EventArgs e)
        {
            var locations = context.Locations
                .Select(l => l.Name)
                .ToArray();
            this.comboBoxAddress.Items.Add("All Items");
            this.comboBoxAddress.Items.AddRange(locations);

            var itemTypes = context.ItemTypes
                .Select(it => it.Name)
                .ToArray();
            this.comboBoxAddItemType.Items.AddRange(itemTypes);
            this.comboBoxAddItemType.DropDownStyle = ComboBoxStyle.DropDownList;

            var metrics = context.Metrics
                .Select(m => m.Name)
                .ToArray();
            this.comboBoxAddMetric.Items.AddRange(metrics);
            this.comboBoxAddMetric.DropDownStyle = ComboBoxStyle.DropDownList;

            this.comboBoxAddLocation.Items.AddRange(locations);
            this.comboBoxAddLocation.DropDownStyle = ComboBoxStyle.DropDownList;

            this.buttonAddNewItem.Enabled = false;
        }

        private void textBoxAddQuantity_TextChanged(object sender, EventArgs e)
        {
            this.VerifyButtonAddItem();
            this.VerifyButtonModify();
        }

        private void comboBoxAddItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.VerifyButtonAddItem();
            this.VerifyButtonModify();
        }

        private void buttonAddNewItem_Click(object sender, EventArgs e)
        {
            var itemType = context.ItemTypes
                .FirstOrDefault(it => it.Name == this.comboBoxAddItemType.Text);
            var quantity = int.Parse(this.textBoxAddQuantity.Text);
            var metric = context.Metrics
                .FirstOrDefault(m => m.Name == this.comboBoxAddMetric.Text);
            var note = this.textBoxAddNote.Text;
            var location = context.Locations
                .FirstOrDefault(l => l.Name == this.comboBoxAddLocation.Text);

            var item = new Item
            {
                ItemType = itemType,
                Quantity = quantity,
                Metric = metric,
                Note = note,
                Location = location
            };

            try
            {
                context.Items.Add(item);
                context.SaveChanges();
                this.buttonShowItems.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.textBoxAddNote.Text = string.Empty;
            this.textBoxAddQuantity.Text = string.Empty;
            this.comboBoxAddItemType.Text = string.Empty;
            this.comboBoxAddLocation.Text = string.Empty;
            this.comboBoxAddMetric.Text = string.Empty;
            this.buttonAddNewItem.Enabled = false;
        }

        private void VerifyButtonAddItem()
        {
            int quantity;
            if (int.TryParse(this.textBoxAddQuantity.Text, out quantity) &&
                this.comboBoxAddItemType.Text != null)
            {
                this.buttonAddNewItem.Enabled = true;
            }
            else
            {
                this.buttonAddNewItem.Enabled = false;
            }
        }

        private void VerifyButtonModify()
        {
            int quantity;
            if (int.TryParse(this.textBoxAddQuantity.Text, out quantity) &&
                this.comboBoxAddItemType.Text != null)
            {
                var itemToAdd = context.ItemTypes
                    .FirstOrDefault(it => it.Name == this.comboBoxAddItemType.Text);
                var item = context.Items.FirstOrDefault(i => i.ItemType.Name == itemToAdd.Name && i.Location.Name == this.comboBoxAddLocation.Text);
                if (item != null)
                {
                    this.buttonModify.Visible = true;
                }
                else
                    this.buttonModify.Visible = false;
            }
            else
            {
                this.buttonModify.Visible = false;
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var itemToModify = context.Items
                .FirstOrDefault(i => i.ItemType.Name == this.comboBoxAddItemType.Text &&
                                i.Location.Name == this.comboBoxAddLocation.Text);

            itemToModify.Quantity += int.Parse(this.textBoxAddQuantity.Text);

            if (!string.IsNullOrEmpty(this.textBoxAddNote.Text))
            {
                itemToModify.Note = this.textBoxAddNote.Text;
            }

            if (!string.IsNullOrEmpty(this.comboBoxAddMetric.Text))
            {
                itemToModify.Metric = context
                                     .Metrics
                                     .FirstOrDefault(m=>m.Name == this.comboBoxAddMetric.Text);
            }
            if (itemToModify.Quantity <= 0)
            {
                context.Items.Remove(itemToModify);
            }
            try
            {
                context.SaveChanges();
                this.buttonShowItems.PerformClick();
            }
            catch(EntityException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                VerifyButtonModify();
            }
            VerifyButtonModify();
        }

        private void comboBoxAddLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyButtonModify();
        }
    }
}
