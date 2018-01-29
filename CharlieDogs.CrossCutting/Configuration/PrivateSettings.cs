namespace CharlieDogs.CrossCutting.Configuration
{
    public static class PrivateSettings
    {
        public static string HEADERS_CORS = AppSettings.Get<string>(nameof(HEADERS_CORS));
        public static string HOST_EMAIL = AppSettings.Get<string>(nameof(HOST_EMAIL));
        public static string MAIL_CREDENTIALS_EMAIL = AppSettings.Get<string>(nameof(MAIL_CREDENTIALS_EMAIL));
        public static string FROM_EMAIL = AppSettings.Get<string>(nameof(FROM_EMAIL));
        public static bool SSL_HOST_EMAIL = AppSettings.Get<bool>(nameof(SSL_HOST_EMAIL));
        public static string METHODS_CORS = AppSettings.Get<string>(nameof(METHODS_CORS));
        public static string ORIGINS_CORS = AppSettings.Get<string>(nameof(ORIGINS_CORS));
        public static int PORT_EMAIL = AppSettings.Get<int>(nameof(PORT_EMAIL));
    }
}