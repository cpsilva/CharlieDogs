using System;

namespace CharlieDogs.CrossCutting.Exceptions
{
    public class RedirectValidationException : Exception
    {
        public string Url { get; set; }

        public RedirectValidationException(string message, string url) : base(message)
        {
            Url = url;
        }
    }
}