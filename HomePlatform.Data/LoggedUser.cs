namespace HomePlatform.Data
{
    public static class LoggedUser
    {
        static LoggedUser()
        {
            Name = string.Empty;
        }
        public static string Name { get; set; }

        public static void LogOut()
        {
            Name = string.Empty;
        }
    }
}
