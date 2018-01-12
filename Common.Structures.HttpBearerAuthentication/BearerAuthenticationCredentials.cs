namespace Common.Structures.HttpBearerAuthentication
{
    public class BearerAuthenticationCredentials : HttpAuthentication.HttpAuthentication
    {
        private const string Bearer = nameof(Bearer);

        public BearerAuthenticationCredentials(string secret) : base(Bearer, secret)
        {
        }
    }
}
