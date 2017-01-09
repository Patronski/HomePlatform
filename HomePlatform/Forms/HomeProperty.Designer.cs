namespace HomePlatform.Forms
{
    partial class HomeProperty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeProperty));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.textBoxAddQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxAddItemType = new System.Windows.Forms.ComboBox();
            this.comboBoxAddMetric = new System.Windows.Forms.ComboBox();
            this.textBoxAddNote = new System.Windows.Forms.TextBox();
            this.comboBoxAddLocation = new System.Windows.Forms.ComboBox();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonShowItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(12, 19);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(145, 21);
            this.comboBoxAddress.TabIndex = 3;
            this.comboBoxAddress.Text = "All Items";
            // 
            // textBoxAddQuantity
            // 
            this.textBoxAddQuantity.Location = new System.Drawing.Point(663, 19);
            this.textBoxAddQuantity.Name = "textBoxAddQuantity";
            this.textBoxAddQuantity.Size = new System.Drawing.Size(39, 20);
            this.textBoxAddQuantity.TabIndex = 4;
            this.textBoxAddQuantity.TextChanged += new System.EventHandler(this.textBoxAddQuantity_TextChanged);
            // 
            // comboBoxAddItemType
            // 
            this.comboBoxAddItemType.FormattingEnabled = true;
            this.comboBoxAddItemType.Location = new System.Drawing.Point(481, 19);
            this.comboBoxAddItemType.Name = "comboBoxAddItemType";
            this.comboBoxAddItemType.Size = new System.Drawing.Size(176, 21);
            this.comboBoxAddItemType.TabIndex = 5;
            this.comboBoxAddItemType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddItemType_SelectedIndexChanged);
            // 
            // comboBoxAddMetric
            // 
            this.comboBoxAddMetric.FormattingEnabled = true;
            this.comboBoxAddMetric.Location = new System.Drawing.Point(708, 19);
            this.comboBoxAddMetric.Name = "comboBoxAddMetric";
            this.comboBoxAddMetric.Size = new System.Drawing.Size(66, 21);
            this.comboBoxAddMetric.TabIndex = 6;
            // 
            // textBoxAddNote
            // 
            this.textBoxAddNote.Location = new System.Drawing.Point(481, 73);
            this.textBoxAddNote.Name = "textBoxAddNote";
            this.textBoxAddNote.Size = new System.Drawing.Size(293, 20);
            this.textBoxAddNote.TabIndex = 7;
            // 
            // comboBoxAddLocation
            // 
            this.comboBoxAddLocation.FormattingEnabled = true;
            this.comboBoxAddLocation.Location = new System.Drawing.Point(481, 46);
            this.comboBoxAddLocation.Name = "comboBoxAddLocation";
            this.comboBoxAddLocation.Size = new System.Drawing.Size(293, 21);
            this.comboBoxAddLocation.TabIndex = 8;
            this.comboBoxAddLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddLocation_SelectedIndexChanged);
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.Location = new System.Drawing.Point(387, 19);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewItem.TabIndex = 9;
            this.buttonAddNewItem.Text = "Add Item";
            this.buttonAddNewItem.UseVisualStyleBackColor = true;
            this.buttonAddNewItem.Click += new System.EventHandler(this.buttonAddNewItem_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(387, 48);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 10;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Visible = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(100, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "View items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(428, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add/Modify items";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "buttonSaveContext";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonShowItems
            // 
            this.buttonShowItems.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonShowItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowItems.Location = new System.Drawing.Point(163, 12);
            this.buttonShowItems.Name = "buttonShowItems";
            this.buttonShowItems.Size = new System.Drawing.Size(87, 32);
            this.buttonShowItems.TabIndex = 14;
            this.buttonShowItems.Text = "Show Items";
            this.buttonShowItems.UseVisualStyleBackColor = false;
            this.buttonShowItems.Click += new System.EventHandler(this.buttonShowItems_Click);
            // 
            // HomeProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 417);
            this.Controls.Add(this.buttonShowItems);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAddNewItem);
            this.Controls.Add(this.comboBoxAddLocation);
            this.Controls.Add(this.textBoxAddNote);
            this.Controls.Add(this.comboBoxAddMetric);
            this.Controls.Add(this.comboBoxAddItemType);
            this.Controls.Add(this.textBoxAddQuantity);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Views";
            this.Load += new System.EventHandler(this.HomeProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.TextBox textBoxAddQuantity;
        private System.Windows.Forms.ComboBox comboBoxAddItemType;
        private System.Windows.Forms.ComboBox comboBoxAddMetric;
        private System.Windows.Forms.TextBox textBoxAddNote;
        private System.Windows.Forms.ComboBox comboBoxAddLocation;
        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonShowItems;
    }
}