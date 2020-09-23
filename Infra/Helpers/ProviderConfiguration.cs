namespace Infra.Helpers
{
    public static class ProviderConfiguration
    {
        private const string HOST = "localhost";
        private const string USERNAME = "guest";
        private const string PASSWORD = "guest";

        public static string StringConnection 
        {
            get
            {
                return string.Format("host={0};username={1};password={2}", HOST, USERNAME, PASSWORD);
            }
        }
    }
}
