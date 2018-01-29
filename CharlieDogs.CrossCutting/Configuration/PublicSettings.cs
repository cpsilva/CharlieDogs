namespace CharlieDogs.CrossCutting.Configuration
{
    public class PublicSettings
    {
        public bool BYPASS_CAPTCHA = AppSettings.Get<bool>(nameof(BYPASS_CAPTCHA));
        public string CAPTCHA_SITE_KEY = AppSettings.Get<string>(nameof(CAPTCHA_SITE_KEY));
    }
}