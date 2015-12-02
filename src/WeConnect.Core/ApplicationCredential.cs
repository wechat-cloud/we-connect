using System;

namespace WeConnect.Core
{
    public sealed class ApplicationCredential : IEquatable<ApplicationCredential>
    {
        public ApplicationCredential(string appId, string appSecret)
        {
            if (string.IsNullOrEmpty(appId)) {
                throw new ArgumentNullException(nameof(appId));
            }

            if (string.IsNullOrEmpty(appSecret))
            {
                throw new ArgumentNullException(nameof(appSecret));
            }

            ApplicationId = appId;
            ApplicationSecret = appSecret;
        }

        public string ApplicationId { get; }
        public string ApplicationSecret { get; }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = 0;
                result = (result * 397) ^ ApplicationId.GetHashCode();
                result = (result * 397) ^ ApplicationSecret.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            return $"appId: {ApplicationId}, appSecret: {ApplicationSecret}";
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is ApplicationCredential)
            {
                return Equals(obj as ApplicationCredential);
            }

            return false;
        }

        public bool Equals(ApplicationCredential other)
        {
            return
                string.Equals(ApplicationId, other.ApplicationId, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(ApplicationSecret, other.ApplicationSecret, StringComparison.OrdinalIgnoreCase);
        }
    }
}
