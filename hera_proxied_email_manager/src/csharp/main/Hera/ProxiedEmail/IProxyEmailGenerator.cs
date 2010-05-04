/// This interface represents a proxy email generator used by HeraProxiedEmailManager for generating proxy email addresses by user ID, real email address and domain name. It is expected that implementations of this interface will be configured with use of Configuration API by calling Configure() method right after construction.
/// 
/// Thread Safety:
/// Implementations of this interface must be thread safe when Configure() method is called once right after construction.
using TopCoder.Congfiguration;
namespace Hera.ProxiedEmail {
    public interface IProxyEmailGenerator{
    /// Configures this class with use of the given configuration object.
    /// 
    /// Parameters:
    /// configuration - the configuration for this class
    /// 
    /// Throws:
    /// ArgumentNullException if configuration is null
    /// HeraProxiedEmailManagementConfigurationException if error occurred when reading the configuration (e.g. when some required property is missing or has invalid format)
    /// <@throws>
    /// ArgumentNullException if configuration is null
    /// </@throws>
    /// <@throws>
    /// HeraProxiedEmailManagementConfigurationException if error occurred when reading the configuration (e.g. when some required property is missing or has invalid format)
    /// </@throws>
    /// <param name="Return">
    /// void
    /// </param>
    /// <param name="configuration">
    /// the configuration for this class
    /// </param>
public void Configure(IConfiguration configuration)£»
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
public string GenerateProxyEmailAddress(string userId, string emailAddress, string domainName)£»
}
}

