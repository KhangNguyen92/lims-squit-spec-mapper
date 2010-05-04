/// This class is an implementation of IProxyEmailGenerator that generates proxy email address by concatenating user ID, hash of the real email address and domain name.
/// 
/// Thread Safety:
/// This class is immutable and thread safe.
using ;
using TopCoder.Congfiguration;
namespace Hera.ProxiedEmail.Generators {
public class HashBasedProxyEmailGenerator{
/// Creates an instance of HashBasedProxyEmailGenerator.
/// 
/// Implementation Notes:
/// Do nothing.
public HashBasedProxyEmailGenerator() {
}
/// Configures this class with use of the given configuration object. Currently this method uses no configuration parameters and does nothing.
/// 
/// Parameters:
/// configuration - the configuration for this class
/// 
/// Throws:
/// ArgumentNullException if configuration is null
/// 
/// Implementation Notes:
/// Do nothing.
/// <@throws>
/// ArgumentNullException if configuration is null
/// </@throws>
/// <param name="Return">
/// void
/// </param>
/// <param name="configuration">
/// the configuration for this class
/// </param>
public void Configure(IConfiguration configuration) {
}
/// Generates a proxy email address for the user with the specified ID and real email address.
/// 
/// Parameters:
/// userId - the ID of the user
/// emailAddress - the real email address of the user
/// domainName - the domain name to be used
/// 
/// Returns:
/// the generated proxy email address (not null)
/// 
/// Throws:
/// ArgumentNullException if any argument is null
/// ArgumentException if any argument is empty
/// ProxyEmailGenerationException if some error occurred when generating a proxy email address
/// 
/// Implementation Notes:
/// 1. string result = userId + "_" + emailAddress.GetHashCode().ToString();
/// 2. If result.Length > 64 then throw ProxyEmailGenerationException.
/// 3. result += "@" + domainName;
/// 4. Return result.
/// <@throws>
/// ArgumentNullException if any argument is null
/// </@throws>
/// <@throws>
/// ArgumentException if any argument is empty
/// </@throws>
/// <@throws>
/// ProxyEmailGenerationException if some error occurred when generating a proxy email address
/// </@throws>
/// <param name="userId">
/// the ID of the user
/// </param>
/// <param name="Return">
/// the generated proxy email address (not null)
/// </param>
/// <param name="emailAddress">
/// the real email address of the user
/// </param>
/// <param name="domainName">
/// the domain name to be used
/// </param>
/// <returns>
/// the generated proxy email address (not null)
/// </returns>
public string GenerateProxyEmailAddress(string userId, string emailAddress, string domainName) {
    string result = userId + "_" + emailAddress.GetHashCode().ToString();
    if (result.Length > 64) {
        throw ProxyEmailGenerationException("Some error occurred when generating a proxy email address");
    }
    result += "@" + domainName;
    return result;
}
}
}

