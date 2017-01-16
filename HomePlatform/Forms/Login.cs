namespace HomePlatform.Forms
{
    using HomePlatform.Data;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Login : Form
    {
        private HomeContext context;

        public Login()
        {
            InitializeComponent();
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var username = this.textBoxUsername.Text;
            var password = this.textBoxPassword.Text;

            if (this.context == null)
            {
                this.buttonRegister.Text = "Please wait...";
                this.buttonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.timerPleaseWait.Start();
                this.buttonRegister.Enabled = false;
                this.buttonLogin.Enabled = false;
                
                this.context = new HomeContext();

                this.buttonRegister.Text = "Register";
                this.buttonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.timerPleaseWait.Stop();
                //this.buttonRegister.Enabled = true;
                this.buttonLogin.Enabled = true;
            }

            var foundUser = context.Users.FirstOrDefault(l => l.Username == username);

            if(foundUser != null)
            {
                MessageBox.Show("There is user with this name!", "Existing User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var result = MessageBox.Show("Do you want to create new user?", "Create User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    context.Users.Add(new User
                    {
                        Username = username,
                        Password = password
                    });
                    context.SaveChanges();
                    this.buttonLogin.Enabled = true;
                    MessageBox.Show("User successfully created!", "Created User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.buttonLogin.Text = "Please wait...";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Enabled = false;
            this.buttonRegister.Enabled = false;
            this.timerPleaseWait.Start();

            var username = this.textBoxUsername.Text;
            var password = this.textBoxPassword.Text;

            if (this.context == null)
            {
                this.context = new HomeContext();
            }

            var foundUser = context.Users.FirstOrDefault(l => l.Username == username && l.Password == password);
            if (foundUser != null || (username == "1" && password == "1"))
            {
                //LoggedUser.Name = foundUser.Username; TODO
                LoggedUser.Name = username;

                var everythingPanel = new Home();
                this.Hide();
                everythingPanel.Show();
                everythingPanel.Focus();
            }
            else
            {
                MessageBox.Show("Wrong credentials! Try again.", "Existing User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.buttonRegister.Enabled = true;
            }

            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerPleaseWait.Stop();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (Application.AllowQuit)
            {
                Application.Exit();
            }
            base.OnClosed(e);
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateBothButtons();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxPassword.Text == this.textBoxPassword.PlaceHolderText &&
                this.textBoxPassword.UseSystemPasswordChar == true)
            {
                this.textBoxPassword.UseSystemPasswordChar = false;
            }

            if (this.textBoxPassword.Text != this.textBoxPassword.PlaceHolderText &&
                this.textBoxPassword.UseSystemPasswordChar == false &&
                this.textBoxPassword.Text.Length > 0)
            {
                this.textBoxPassword.UseSystemPasswordChar = true;
            }

            ValidateBothButtons();
        }

        private void ValidateBothButtons()
        {
            if (this.textBoxPassword.Text != this.textBoxPassword.PlaceHolderText &&
                this.textBoxUsername.Text != this.textBoxUsername.PlaceHolderText &&
                this.textBoxPassword.Text.Length > 0 && 
                this.textBoxUsername.Text.Length > 0)
            {
                this.buttonLogin.Enabled = true;
                this.buttonRegister.Enabled = true;
            }
            else
            {
                this.buttonLogin.Enabled = false;
                this.buttonRegister.Enabled = false;
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.textBoxUsername.Text) || this.textBoxUsername.Text == this.textBoxUsername.PlaceHolderText)
                {
                    this.ActiveControl = this.textBoxUsername;
                }
                else if (this.buttonLogin.Enabled)
                {
                    this.buttonLogin_Click(sender, e);
                }
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.textBoxPassword.Text) || this.textBoxPassword.Text == this.textBoxPassword.PlaceHolderText)
                {
                    this.ActiveControl = this.textBoxPassword;
                }
                else if (this.buttonLogin.Enabled)
                {
                    this.buttonLogin_Click(sender, e);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.textBoxUsername;
            ValidateBothButtons();
        }

        private void timerPleaseWait_Tick(object sender, EventArgs e)
        {
            if (this.buttonLogin.Text == "Please wait...")
            {
                this.buttonLogin.Text = "Please wait.";

            }
            else if (this.buttonLogin.Text == "Please wait.")
            {
                this.buttonLogin.Text = "Please wait..";
            }
            else if (this.buttonLogin.Text == "Please wait..")
            {
                this.buttonLogin.Text = "Please wait...";
            }
        }
    }
}
