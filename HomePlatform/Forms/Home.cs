namespace HomePlatform.Forms
{
    using HomePlatform.Data;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms;

    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Text += " : " + LoggedUser.Name;
        }

        protected override void OnClosed(EventArgs e)
        {
            if (Application.AllowQuit)
            {
                Application.Exit();
            }
            base.OnClosed(e);
        }

        private void buttonGridView_Click(object sender, EventArgs e)
        {
            HomeProperty view = new HomeProperty();
            view.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LoggedUser.LogOut();
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void buttonGamePacman_Click(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo();
            var path = Directory.GetCurrentDirectory();
            startInfo.WorkingDirectory = path + @"\Pacman_1_0_0_2\";// working directory
            startInfo.FileName = @"Pacman.application";
            Process.Start(startInfo);
        }

        private void buttonGameSnake_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            Process.Start(@"SnakeProjectFundamentals.jar");
        }
    }
}
