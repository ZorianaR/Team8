using System;


namespace Team8.Framework
{
    public static class Settings
    {
        public static readonly string url = "http://52.177.12.77:8080";
        public static readonly TimeSpan ImplicitWait = TimeSpan.FromSeconds(3);
        public static readonly Drivers Driver = Drivers.Chrome;
    }
}
