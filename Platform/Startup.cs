namespace HomePlatform
{
    using System;
    using System.Windows.Forms;

    public class Startup
    {
        [STAThread]
        static void Main()
        {
            //var login = new Forms.Login();
            //login.Show();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Login());
        }
    }
}
