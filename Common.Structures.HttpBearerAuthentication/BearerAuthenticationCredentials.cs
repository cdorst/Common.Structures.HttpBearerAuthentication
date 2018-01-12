using Common.Structures.HttpAuthentication;

namespace Common.Structures.HttpBearerAuthentication
{
    public class BearerAuthenticationCredentials : HttpAuthentication
    {
        private const string Bearer = nameof(Bearer);
        private readonly string _secret;

        public BearerAuthenticationCredentials(string secret) : base(Bearer)
        {
            _secret = secret;
        }

        protected override string Value => _secret;
    }
}
