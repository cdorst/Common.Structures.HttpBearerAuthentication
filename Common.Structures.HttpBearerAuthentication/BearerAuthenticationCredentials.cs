using Common.Structures.HttpAuthentication;

namespace Common.Structures.HttpBearerAuthentication
{
    public class BearerAuthenticationCredentials : HttpAuthentication.HttpAuthentication
    {
        public BearerAuthenticationCredentials(string secret) : base(PrefixType.Bearer, secret)
        {
        }
    }
}
