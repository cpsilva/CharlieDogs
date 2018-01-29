using System;
using System.Configuration;

namespace CharlieDogs.CrossCutting.Configuration
{
    public static class AppSettings
    {
        public static T Get<T>(string name)
        {
            if (ConfigurationManager.AppSettings[name] == null)
                return default(T);

            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[name], typeof(T));
        }
    }
}