using System;
using System.Threading.Tasks;
using Windows.Security.Credentials;
using Windows.Security.Credentials.UI;

namespace WindowsHelloAuthenticator
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            var keyCredentialAvailable = await KeyCredentialManager.IsSupportedAsync();
            if (!keyCredentialAvailable)
            {
                // Windows Hello has not been set up on the user account yet
                return 2;
            }

            UserConsentVerificationResult consentResult = await UserConsentVerifier.RequestVerificationAsync(string.Join(" ", args));
            if (consentResult.Equals(UserConsentVerificationResult.Verified))
            {
                // Authenticated successfully
                return 0;
            }

            // Authentication has failed / was cancelled
            return 1;
        }
    }
}