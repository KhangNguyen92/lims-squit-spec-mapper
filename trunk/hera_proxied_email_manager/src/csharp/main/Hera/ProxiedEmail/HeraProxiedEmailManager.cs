/// This is the main class of this component. It represents a manager for proxied email data in persistence. It uses pluggable IProxyEmailGenerator instance to generate proxy email addresses and IProxiedEmailPersistence instance to access data in persistence. This class can be configured using Configuration API and File Based Configuration components. This class can perform logging of errors and debug information using Logging Wrapper component.
/// 
/// Thread Safety:
/// This class is immutable and thread safe. It uses IProxyEmailGenerator and IProxiedEmailPersistence instances in thread safe manner.
using ;
using Hera.ProxiedEmail;
using TopCoder.Congfiguration;
using TopCoder.LoggingWrapper;
namespace Hera.ProxiedEmail {
public class HeraProxiedEmailManager{
/// The default configuration name used by this class. This is a string constant. It is used in the default constructor.
public static const string DEFAULT_CONFIG_NAME = "Hera.ProxiedEmail.HeraProxiedEmailManager";
/// The domain name to be used when generating proxy email addresses. Is initialized in the constructor and never changed after that. Cannot be null or empty. Is used in CreateProxyEmailAddress().
private const string domainName;
/// The proxy email generator used by this class. Is initialized in the constructor and never changed after that. Cannot be null. Is used in CreateProxyEmailAddress().
private const IProxyEmailGenerator proxyEmailGenerator;
/// The proxied email persistence used by this class. Is initialized in the constructor and never changed after that. Cannot be null. Is used in all public methods.
private const IProxiedEmailPersistence persistence;
/// The logger used by this class for logging errors and debug information. Is initialized in the constructor and never changed after that. Is null when logging is not required. Is used in all public methods.
/// See section 1.3.1 of CS for details about the logging.
private const Logger logger;
/// Creates an instance of HeraProxiedEmailManager using the default configuration name.
/// 
/// Throws:
/// HeraProxiedEmailManagementConfigurationException if any error occurs while reading the configuration or initializing the class using this configuration
/// 
/// Implementation Notes:
/// this(DEFAULT_CONFIG_NAME);
/// <@throws>
/// HeraProxiedEmailManagementConfigurationException if any error occurs while reading the configuration or initializing the class using this configuration
/// </@throws>
public HeraProxiedEmailManager() {
}
/// Creates an instance of HeraProxiedEmailManager. Uses File Based Configuration component to load the configuration for this class.
/// 
/// Parameters:
/// configName - the configuration name to be used
/// 
/// Throws:
/// ArgumentNullException if argument is null
/// ArgumentException if argument is empty
/// HeraProxiedEmailManagementConfigurationException if any error occurs while reading the configuration or initializing the class using this configuration
/// 
/// Implementation Notes:
/// 1. Create configuration provider:
///      FileModifiableConfigurationPersistenceProvider provider = new FileModifiableConfigurationPersistenceProvider();
/// 2. Get configuration for this class:
///      IConfiguration config = provider.GetConfiguration(configName);
/// 3. Call another constructor:
///      this(config);
/// 
/// NOTE: Actually steps 1-2 must be implemented in a private method, call to which will be used as an argument for another constructor.
/// <@throws>
/// ArgumentNullException if argument is null
/// </@throws>
/// <@throws>
/// ArgumentException if argument is empty
/// </@throws>
/// <@throws>
/// HeraProxiedEmailManagementConfigurationException if any error occurs while reading the configuration or initializing the class using this configuration
/// </@throws>
/// <param name="configName">
/// the configuration name to be used
/// </param>
public HeraProxiedEmailManager(string configName) {
}
/// Creates an instance of HeraProxiedEmailManager.
/// 
/// Please see section 3.2.1 of CS for details about configuration parameters. Please use value constraints provided in that section to check whether values read from the configuration are valid.
/// 
/// Parameters:
/// config - the configuration for this class
/// 
/// Throws:
/// ArgumentNullException if argument is null
/// HeraProxiedEmailManagementConfigurationException if any error occurs while reading the configuration or initializing the class using this configuration
/// 
/// Implementation Notes:
/// 1. Get logger configuration:
///      IConfiguration loggerConfig = config.GetChild("loggerConfig");
/// 2. If loggerConfig != null then
///      2.1. Create logger instance:
///              logger = LogManager.CreateLogger(loggerConfig);
/// 3. Get object factory configuration:
///      IConfiguration objectFactoryConfig = config.GetChild("objectFactoryConfig");
/// 4. Create object factory from config:
///      ObjectFactory objectFactory = new ConfigurationAPIObjectFactory(objectFactoryConfig);
/// 5. Get persistence OF key:
///      persistenceKey = config.GetSimpleAttribute("persistenceKey");
/// 6. Create persistence with OF:
///      persistence = objectFactory.CreateDefinedObject(persistenceKey);
/// 7. Get persistence configuration:
///      persistenceConfig = config.GetChild("persistenceConfig");
/// 8. Configure persistence:
///      persistence.Configure(persistenceConfig);
/// 9. Get proxy email generator OF key:
///      proxyEmailGeneratorKey = config.GetSimpleAttribute("proxyEmailGeneratorKey");
/// 10. If proxyEmailGeneratorKey != null then
///        10.1. Create proxy email generator with OF:
///                  proxyEmailGenerator = objectFactory.CreateDefinedObject(proxyEmailGeneratorKey);
/// 11. Else
///        11.1. proxyEmailGenerator = new HashBasedProxyEmailGenerator();
/// 12. Get proxy email generator configuration:
///        proxyEmailGeneratorConfig = config.GetChild("proxyEmailGeneratorConfig");
/// 13. Configure proxy email generator:
///        proxyEmailGenerator.Configure(proxyEmailGeneratorConfig);
/// 14. Get domain name from config:
///        domainName = config.GetSimpleAttribute("domainName");
/// <@throws>
/// ArgumentNullException if argument is null
/// </@throws>
/// <@throws>
/// HeraProxiedEmailManagementConfigurationException if any error occurs while reading the configuration or initializing the class using this configuration
/// </@throws>
/// <param name="config">
/// the configuration for this class
/// </param>
public HeraProxiedEmailManager(IConfiguration config) {
}
/// Creates an instance of HeraProxiedEmailManager with the given parameters.
/// 
/// Parameters:
/// generator - the proxy email generator to be used by this class (must be properly configured)
/// persistence - the proxied email persistence to be used by this class (must be properly configured)
/// domainName - the domain name to be used when generating proxy email addresses
/// logger - the logger to be used by this class for logging errors and debug information (null if logging is not required)
/// 
/// Throws:
/// ArgumentNullException if generator, persistence or domainName is null
/// ArgumentException if domainName is empty
/// 
/// Implementation Notes:
/// Set values of all arguments to the namesake private attributes.
/// <@throws>
/// ArgumentNullException if generator, persistence or domainName is null
/// </@throws>
/// <@throws>
/// ArgumentException if domainName is empty
/// </@throws>
/// <param name="persistence">
/// the proxied email persistence to be used by this class (must be properly configured)
/// </param>
/// <param name="logger">
/// the logger to be used by this class for logging errors and debug information (null if logging is not required)
/// </param>
/// <param name="generator">
/// the proxy email generator to be used by this class (must be properly configured)
/// </param>
/// <param name="domainName">
/// the domain name to be used when generating proxy email addresses
/// </param>
public HeraProxiedEmailManager(IProxyEmailGenerator generator, IProxiedEmailPersistence persistence, string domainName, Logger logger) {
}
/// Creates a proxy email address for the user with the specified ID and real email address. If addToDatabase is true, additionally persists the given user parameters and the generated proxy address.
/// 
/// Parameters:
/// userId - the ID of the user
/// emailAddress - the real email address of the user
/// addToDatabase - true if information about the proxy email mapping must be persisted, false otherwise
/// 
/// Returns:
/// the generated proxy email address (not null)
/// 
/// Throws:
/// ArgumentNullException if emailAddress is null
/// ArgumentException if userId <= 0, emailAddress is empty
/// ProxyEmailGenerationException if an error occurred when generating the proxy email address
/// ProxiedEmailPersistenceException if some error occurred when persisting the proxy email mapping data
/// 
/// Implementation Notes:
/// 1. string proxyAddress = proxyEmailGenerator.GenerateProxyEmailAddress(userId.ToString(), emailAddress, domainName);
/// 2. If addToDatabase then
///      2.1. emailUserParams = new EmailUserParams();
///      2.2. emailUserParams.UserId = userId;
///      2.3. emailUserParams.RealEmail = emailAddress;
///      2.4. emailUserParams.ProxyEmail = proxyAddress;
///      2.5. emailUserParams.Blocked = false;
///      2.6. persistence.CreateEmailUser(emailUserParams);
/// 3. Return proxyAddress.
/// <@throws>
/// ArgumentNullException if emailAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if userId <= 0, emailAddress is empty
/// </@throws>
/// <@throws>
/// ProxyEmailGenerationException if an error occurred when generating the proxy email address
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some error occurred when persisting the proxy email mapping data
/// </@throws>
/// <param name="addToDatabase">
/// true if information about the proxy email mapping must be persisted, false otherwise
/// </param>
/// <param name="userId">
/// the ID of the user
/// </param>
/// <param name="Return">
/// the generated proxy email address (not null)
/// </param>
/// <param name="emailAddress">
/// the real email address of the user
/// </param>
<returns>
the generated proxy email address (not null)
</returns>
public string CreateProxyEmailAddress(long userId, string emailAddress, bool addToDatabase) {
return 0;
}
/// Retrieves the proxy email address by the real email address of the user.
/// 
/// Parameters:
/// realAddress - the real email address
/// 
/// Returns:
/// the retrieved proxy email address (not null)
/// 
/// Throws:
/// ArgumentNullException if realAddress is null
/// ArgumentException if realAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.RealEmail = realAddress;
/// 3. emailUserParams = persistence.GetEmailUser(emailUserParams);
/// 4. Return emailUserParams.ProxyEmail.
/// <@throws>
/// ArgumentNullException if realAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if realAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// the retrieved proxy email address (not null)
/// </param>
/// <param name="realAddress">
/// the real email address
/// </param>
<returns>
the retrieved proxy email address (not null)
</returns>
public string GetProxyAddressByRealAddress(string realAddress) {
return 0;
}
/// Retrieves the real email address by the proxy email address of the user.
/// 
/// Parameters:
/// proxyAddress - the proxy email address
/// 
/// Returns:
/// the retrieved real email address (not null)
/// 
/// Throws:
/// ArgumentNullException if proxyAddress is null
/// ArgumentException if proxyAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.ProxyEmail = proxyAddress;
/// 3. emailUserParams = persistence.GetEmailUser(emailUserParams);
/// 4. Return emailUserParams.RealEmail.
/// <@throws>
/// ArgumentNullException if proxyAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if proxyAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// the retrieved real email address (not null)
/// </param>
/// <param name="proxyAddress">
/// the proxy email address
/// </param>
<returns>
the retrieved real email address (not null)
</returns>
public string GetRealAddressByProxyAddress(string proxyAddress) {
return 0;
}
/// Retrieves the proxy email address by the specified ID of the user.
/// 
/// Parameters:
/// userId - the ID of the user
/// 
/// Returns:
/// the retrieved proxy email address (not null)
/// 
/// Throws:
/// ArgumentException if userId <= 0
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.UserId = userId;
/// 3. emailUserParams = persistence.GetEmailUser(emailUserParams);
/// 4. Return emailUserParams.ProxyEmail.
/// <@throws>
/// ArgumentException if userId <= 0
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="userId">
/// the ID of the user
/// </param>
/// <param name="Return">
/// the retrieved proxy email address (not null)
/// </param>
<returns>
the retrieved proxy email address (not null)
</returns>
public string GetProxyAddressByUserId(long userId) {
return 0;
}
/// Retrieves the real email address by the specified ID of the user.
/// 
/// Parameters:
/// userId - the ID of the user
/// 
/// Returns:
/// the retrieved real email address (not null)
/// 
/// Throws:
/// ArgumentException if userId <= 0
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.UserId = userId;
/// 3. emailUserParams = persistence.GetEmailUser(emailUserParams);
/// 4. Return emailUserParams.RealEmail.
/// <@throws>
/// ArgumentException if userId <= 0
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="userId">
/// the ID of the user
/// </param>
/// <param name="Return">
/// the retrieved real email address (not null)
/// </param>
<returns>
the retrieved real email address (not null)
</returns>
public string GetRealAddressByUserId(long userId) {
return 0;
}
/// Updates the proxy email address for user with the specified ID.
/// 
/// Parameters:
/// userId - the ID of the user
/// newProxyAddress - the new proxy email address
/// 
/// Throws:
/// ArgumentNullException if newProxyAddress is null
/// ArgumentException if userId <= 0 or newProxyAddress is empty
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. existingUserParams = new EmailUserParams();
/// 2. existingUserParams.UserId = userId;
/// 3. updatedUserParams = new EmailUserParams();
/// 4. updatedUserParams.ProxyEmail = newProxyAddress;
/// 5. persistence.UpdateEmailUser(existingUserParams, updatedUserParams);
/// <@throws>
/// ArgumentNullException if newProxyAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if userId <= 0 or newProxyAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="userId">
/// the ID of the user
/// </param>
/// <param name="Return">
/// void
/// </param>
/// <param name="newProxyAddress">
/// the new proxy email address
/// </param>
public void UpdateProxyAddressForUser(long userId, string newProxyAddress) {
}
/// Updates the real email address for user with the specified ID.
/// 
/// Parameters:
/// userId - the ID of the user
/// newRealAddress - the new real email address
/// 
/// Throws:
/// ArgumentNullException if newRealAddress is null
/// ArgumentException if userId <= 0 or newRealAddress is empty
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. existingUserParams = new EmailUserParams();
/// 2. existingUserParams.UserId = userId;
/// 3. updatedUserParams = new EmailUserParams();
/// 4. updatedUserParams.RealEmail = newRealAddress;
/// 5. persistence.UpdateEmailUser(existingUserParams, updatedUserParams);
/// <@throws>
/// ArgumentNullException if newRealAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if userId <= 0 or newRealAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="newRealAddress">
/// the new real email address
/// </param>
/// <param name="userId">
/// the ID of the user
/// </param>
/// <param name="Return">
/// void
/// </param>
public void UpdateRealAddressForUser(long userId, string newRealAddress) {
}
/// Deletes the email address mappings for the user with the specified ID.
/// 
/// Parameters:
/// userId - the ID of the user
/// 
/// Throws:
/// ArgumentException if userId <= 0
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.UserId = userId;
/// 3. persistence.DeleteEmailUser(emailUserParams);
/// <@throws>
/// ArgumentException if userId <= 0
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="userId">
/// the ID of the user
/// </param>
/// <param name="Return">
/// void
/// </param>
public void DeleteAddressMappingsForUser(long userId) {
}
/// Deletes the email address mappings for the user with the specified real email address.
/// 
/// Parameters:
/// realAddress - the real email address
/// 
/// Throws:
/// ArgumentNullException if realAddress is null
/// ArgumentException if realAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.RealEmail = realAddress;
/// 3. persistence.DeleteEmailUser(emailUserParams);
/// <@throws>
/// ArgumentNullException if realAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if realAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// void
/// </param>
/// <param name="realAddress">
/// the real email address
/// </param>
public void DeleteAddressMappingsByRealAddress(string realAddress) {
}
/// Blocks one user with the specified real email address by another user with the given real email address. If blocking already exists, exception is not thrown.
/// 
/// Parameters:
/// blockedUserAddress - the real email address of the user to be blocked
/// blockedByAddress - the real email address of the user who performs blocking
/// 
/// Throws:
/// ArgumentNullException if blockedUserAddress or blockedByAddress is null
/// ArgumentException if blockedUserAddress or blockedByAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. blockedUserParams = new EmailUserParams();
/// 2. blockedUserParams.RealEmail = blockedUserAddress;
/// 3. blockedByUserParams = new EmailUserParams();
/// 4. blockedByUserParams.RealEmail = blockedByAddress;
/// 5. persistence.SetUsersBlock(blockedUserParams, blockedByUserParams, true);
/// <@throws>
/// ArgumentNullException if blockedUserAddress or blockedByAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if blockedUserAddress or blockedByAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="blockedUserAddress">
/// the real email address of the user to be blocked
/// </param>
/// <param name="Return">
/// void
/// </param>
/// <param name="blockedByAddress">
/// the real email address of the user who performs blocking
/// </param>
public void BlockUserByRealAddress(string blockedUserAddress, string blockedByAddress) {
}
/// Blocks one user with the specified proxy email address by another user with the given proxy email address. If blocking already exists, exception is not thrown.
/// 
/// Parameters:
/// blockedUserAddress - the proxy email address of the user to be blocked
/// blockedByAddress - the proxy email address of the user who performs blocking
/// 
/// Throws:
/// ArgumentNullException if blockedUserAddress or blockedByAddress is null
/// ArgumentException if blockedUserAddress or blockedByAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. blockedUserParams = new EmailUserParams();
/// 2. blockedUserParams.ProxyEmail = blockedUserAddress;
/// 3. blockedByUserParams = new EmailUserParams();
/// 4. blockedByUserParams.ProxyEmail = blockedByAddress;
/// 5. persistence.SetUsersBlock(blockedUserParams, blockedByUserParams, true);
/// <@throws>
/// ArgumentNullException if blockedUserAddress or blockedByAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if blockedUserAddress or blockedByAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="blockedUserAddress">
/// the proxy email address of the user to be blocked
/// </param>
/// <param name="Return">
/// void
/// </param>
/// <param name="blockedByAddress">
/// the proxy email address of the user who performs blocking
/// </param>
public void BlockUserByProxyAddress(string blockedUserAddress, string blockedByAddress) {
}
/// Blocks the user with specified real email address globally. If blocking already exists, exception is not thrown.
/// 
/// Parameters:
/// realAddress - the real email address of the user to be blocked
/// 
/// Throws:
/// ArgumentNullException if realAddress is null
/// ArgumentException if realAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. existingUserParams = new EmailUserParams();
/// 2. existingUserParams.RealEmail = realAddress;
/// 3. updatedUserParams = new EmailUserParams();
/// 4. updatedUserParams.Blocked = true;
/// 5. persistence.UpdateEmailUser(existingUserParams, updatedUserParams);
/// <@throws>
/// ArgumentNullException if realAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if realAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// void
/// </param>
/// <param name="realAddress">
/// the real email address of the user to be blocked
/// </param>
public void BlockByRealAddress(string realAddress) {
}
/// Blocks the user with specified proxy email address globally. If blocking already exists, exception is not thrown.
/// 
/// Parameters:
/// proxyAddress - the proxy email address of the user to be blocked
/// 
/// Throws:
/// ArgumentNullException if proxyAddress is null
/// ArgumentException if proxyAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. existingUserParams = new EmailUserParams();
/// 2. existingUserParams.ProxyEmail = proxyAddress;
/// 3. updatedUserParams = new EmailUserParams();
/// 4. updatedUserParams.Blocked = true;
/// 5. persistence.UpdateEmailUser(existingUserParams, updatedUserParams);
/// <@throws>
/// ArgumentNullException if proxyAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if proxyAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// void
/// </param>
/// <param name="proxyAddress">
/// the proxy email address of the user to be blocked
/// </param>
public void BlockByProxyAddress(string proxyAddress) {
}
/// Unblocks one user with the specified real email address blocked by another user with the given real email address. If blocking doesn't exist, exception is not thrown.
/// 
/// Parameters:
/// blockedUserAddress - the real email address of the user to be unblocked
/// blockedByAddress - the real email address of the user who performed blocking
/// 
/// Throws:
/// ArgumentNullException if blockedUserAddress or blockedByAddress is null
/// ArgumentException if blockedUserAddress or blockedByAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. blockedUserParams = new EmailUserParams();
/// 2. blockedUserParams.RealEmail = blockedUserAddress;
/// 3. blockedByUserParams = new EmailUserParams();
/// 4. blockedByUserParams.RealEmail = blockedByAddress;
/// 5. persistence.SetUsersBlock(blockedUserParams, blockedByUserParams, false);
/// <@throws>
/// ArgumentNullException if blockedUserAddress or blockedByAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if blockedUserAddress or blockedByAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="blockedUserAddress">
/// the real email address of the user to be unblocked
/// </param>
/// <param name="Return">
/// void
/// </param>
/// <param name="blockedByAddress">
/// the real email address of the user who performed blocking
/// </param>
public void UnblockUserByRealAddress(string blockedUserAddress, string blockedByAddress) {
}
/// Unblocks one user with the specified proxy email address blocked by another user with the given proxy email address. If blocking doesn't exist, exception is not thrown.
/// 
/// Parameters:
/// blockedUserAddress - the proxy email address of the user to be unblocked
/// blockedByAddress - the proxy email address of the user who performed blocking
/// 
/// Throws:
/// ArgumentNullException if blockedUserAddress or blockedByAddress is null
/// ArgumentException if blockedUserAddress or blockedByAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. blockedUserParams = new EmailUserParams();
/// 2. blockedUserParams.ProxyEmail = blockedUserAddress;
/// 3. blockedByUserParams = new EmailUserParams();
/// 4. blockedByUserParams.ProxyEmail = blockedByAddress;
/// 5. persistence.SetUsersBlock(blockedUserParams, blockedByUserParams, false);
/// <@throws>
/// ArgumentNullException if blockedUserAddress or blockedByAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if blockedUserAddress or blockedByAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="blockedUserAddress">
/// the proxy email address of the user to be unblocked
/// </param>
/// <param name="Return">
/// void
/// </param>
/// <param name="blockedByAddress">
/// the proxy email address of the user who performed blocking
/// </param>
public void UnblockUserByProxyAddress(string blockedUserAddress, string blockedByAddress) {
}
/// Unblocks the user with specified real email address globally. If blocking doesn't exist, exception is not thrown.
/// 
/// Parameters:
/// realAddress - the real email address of the user to be unblocked
/// 
/// Throws:
/// ArgumentNullException if realAddress is null
/// ArgumentException if realAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. existingUserParams = new EmailUserParams();
/// 2. existingUserParams.RealEmail = realAddress;
/// 3. updatedUserParams = new EmailUserParams();
/// 4. updatedUserParams.Blocked = false;
/// 5. persistence.UpdateEmailUser(existingUserParams, updatedUserParams);
/// <@throws>
/// ArgumentNullException if realAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if realAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// void
/// </param>
/// <param name="realAddress">
/// the real email address of the user to be unblocked
/// </param>
public void UnblockByRealAddress(string realAddress) {
}
/// Unblocks the user with specified proxy email address globally. If blocking doesn't exist, exception is not thrown.
/// 
/// Parameters:
/// proxyAddress - the proxy email address of the user to be unblocked
/// 
/// Throws:
/// ArgumentNullException if proxyAddress is null
/// ArgumentException if proxyAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. existingUserParams = new EmailUserParams();
/// 2. existingUserParams.ProxyEmail = proxyAddress;
/// 3. updatedUserParams = new EmailUserParams();
/// 4. updatedUserParams.Blocked = false;
/// 5. persistence.UpdateEmailUser(existingUserParams, updatedUserParams);
/// <@throws>
/// ArgumentNullException if proxyAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if proxyAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// void
/// </param>
/// <param name="proxyAddress">
/// the proxy email address of the user to be unblocked
/// </param>
public void UnblockByProxyAddress(string proxyAddress) {
}
/// Checks whether mapping for the specified proxy email address exists in persistence.
/// 
/// Parameters:
/// proxyEmail - the proxy email address
/// 
/// Returns:
/// true if mapping for the specified proxy email address exists in persistence, false otherwise
/// 
/// Throws:
/// ArgumentNullException if proxyEmail is null
/// ArgumentException if proxyEmail is empty
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.ProxyEmail = proxyEmail;
/// 3. emailUserParams = persistence.GetEmailUser(emailUserParams);
/// 4. Return (emailUserParams != null).
/// <@throws>
/// ArgumentNullException if proxyEmail is null
/// </@throws>
/// <@throws>
/// ArgumentException if proxyEmail is empty
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="proxyEmail">
/// the proxy email address
/// </param>
/// <param name="Return">
/// true if mapping for the specified proxy email address exists in persistence, false otherwise
/// </param>
<returns>
true if mapping for the specified proxy email address exists in persistence, false otherwise
</returns>
public bool IsProxyEmailExist(string proxyEmail) {
return false;
}
/// Checks whether mapping for the specified real email address exists in persistence.
/// 
/// Parameters:
/// realEmail - the real email address
/// 
/// Returns:
/// true if mapping for the specified real email address exists in persistence, false otherwise
/// 
/// Throws:
/// ArgumentNullException if realEmail is null
/// ArgumentException if realEmail is empty
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.RealEmail = realEmail;
/// 3. emailUserParams = persistence.GetEmailUser(emailUserParams);
/// 4. Return (emailUserParams != null).
/// <@throws>
/// ArgumentNullException if realEmail is null
/// </@throws>
/// <@throws>
/// ArgumentException if realEmail is empty
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// true if mapping for the specified real email address exists in persistence, false otherwise
/// </param>
/// <param name="realEmail">
/// the real email address
/// </param>
<returns>
true if mapping for the specified real email address exists in persistence, false otherwise
</returns>
public bool IsRealEmailExist(string realEmail) {
return false;
}
/// Logs email message with the given parameters to database.
/// 
/// Parameters:
/// fromAddress - the proxy email address of the sender
/// toAddresses - the proxy email address of recipients specified in "To" field of the message
/// bccAddresses - the proxy email address of recipients specified in "BCC" field of the message
/// subject - the subject of the message
/// body - the body of the message
/// 
/// Throws:
/// ArgumentNullException if any argument is null
/// ArgumentException if fromAddress is empty, toAddresses is empty, contains null/empty, bccAddresses contains null/empty
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailLog = new EmailLog();
/// 2. emailLog.From = fromAddress;
/// 3. emailLog.Recipients = toAddresses;
/// 4. emailLog.BccRecipients = bccAddresses;
/// 5. emailLog.Subject = subject;
/// 6. emailLog.Body = body;
/// 7. persistence.CreateEmailLog(emailLog);
/// <@throws>
/// ArgumentNullException if any argument is null
/// </@throws>
/// <@throws>
/// ArgumentException if fromAddress is empty, toAddresses is empty, contains null/empty, bccAddresses contains null/empty
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="body">
/// the body of the message
/// </param>
/// <param name="toAddresses">
/// the proxy email address of recipients specified in "To" field of the message
/// </param>
/// <param name="subject">
/// the subject of the message
/// </param>
/// <param name="Return">
/// void
/// </param>
/// <param name="bccAddresses">
/// the proxy email address of recipients specified in "BCC" field of the message
/// </param>
/// <param name="fromAddress">
/// the proxy email address of the sender
/// </param>
public void LogEmail(string fromAddress, IList<string> toAddresses, IList<string> bccAddresses, string subject, byte[] body) {
}
/// Searches for email log records that match the given search parameters in the persistence. Returns an empty list if nothing found.
/// 
/// Parameters:
/// parameters - the list of search parameters (should be empty to retrieve all log records)
/// 
/// Returns:
/// the list of found log records (not null, doesn't contain null)
/// 
/// Throws:
/// ArgumentNullException if parameters is null
/// ArgumentException if parameters contains empty key or null value
/// UnknownSearchParameterException if some parameter name is unknown
/// InvalidSearchParameterFormatException if value of some parameter has invalid format
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. Return persistence.SearchEmailLogs(parameters).
/// <@throws>
/// ArgumentNullException if parameters is null
/// </@throws>
/// <@throws>
/// ArgumentException if parameters contains empty key or null value
/// </@throws>
/// <@throws>
/// UnknownSearchParameterException if some parameter name is unknown
/// </@throws>
/// <@throws>
/// InvalidSearchParameterFormatException if value of some parameter has invalid format
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// the list of found log records (not null, doesn't contain null)
/// </param>
/// <param name="parameters">
/// the list of search parameters (should be empty to retrieve all log records)
/// </param>
<returns>
the list of found log records (not null, doesn't contain null)
</returns>
public IList<EmailLog> SearchEmailLogs(IDictionary<string,string> parameters) {
return null;
}
/// Checks if one user is blocked globally or by another user using the specified proxy email addresses of the users.
/// 
/// Parameters:
/// blockedUserProxyAddress - the proxy email address of the (possibly) blocked user
/// blockedByProxyAddress - the proxy email address of the blocking user
/// 
/// Returns:
/// true if user is blocked globally or by another user, false otherwise
/// 
/// Throws:
/// ArgumentNullException if blockedUserProxyAddress or blockedByProxyAddress is null
/// ArgumentException if blockedUserProxyAddress or blockedByProxyAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. blockedUserParams = new EmailUserParams();
/// 2. blockedUserParams.ProxyEmail = blockedUserAddress;
/// 3. blockedByUserParams = new EmailUserParams();
/// 4. blockedByUserParams.ProxyEmail = blockedByAddress;
/// 5. Return persistence.IsUserBlocked(blockedUserParams, blockedByUserParams);
/// <@throws>
/// ArgumentNullException if blockedUserProxyAddress or blockedByProxyAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if blockedUserProxyAddress or blockedByProxyAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// true if user is blocked globally or by another user, false otherwise
/// </param>
/// <param name="blockedByProxyAddress">
/// the proxy email address of the blocking user
/// </param>
/// <param name="blockedUserProxyAddress">
/// the proxy email address of the (possibly) blocked user
/// </param>
<returns>
true if user is blocked globally or by another user, false otherwise
</returns>
public bool IsBlocked(string blockedUserProxyAddress, string blockedByProxyAddress) {
return false;
}
/// Changes the flag indicating whether logging history is enabled for the user with the given ID.
/// 
/// Parameters:
/// enabled - true if logging history must be enabled, false - disabled
/// userId - the ID of the user
/// 
/// Throws:
/// ArgumentException if userId <= 0
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.UserId = userId;
/// 3. persistence.ChangeLoggingHistoryEnabledForUser(emailUserParams, enabled);
/// <@throws>
/// ArgumentException if userId <= 0
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified ID cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="enabled">
/// true if logging history must be enabled, false - disabled
/// </param>
/// <param name="userId">
/// the ID of the user
/// </param>
/// <param name="Return">
/// void
/// </param>
public void ChangeLoggingHistoryEnabledForUser(bool enabled, long userId) {
}
/// Retrieves the value indicating whether logging history is enabled for user with the given proxy email address.
/// 
/// Parameters:
/// userProxyAddress - the proxy email address of the user
/// 
/// Returns:
/// true if logging history is enabled for this user, false otherwise
/// 
/// Throws:
/// ArgumentNullException if userProxyAddress is null
/// ArgumentException if userProxyAddress is empty
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. emailUserParams = new EmailUserParams();
/// 2. emailUserParams.ProxyEmail = userProxyAddress;
/// 3. Return persistence.IsLoggingHistoryEnabledForUser(emailUserParams).
/// <@throws>
/// ArgumentNullException if userProxyAddress is null
/// </@throws>
/// <@throws>
/// ArgumentException if userProxyAddress is empty
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified email address cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="userProxyAddress">
/// the proxy email address of the user
/// </param>
/// <param name="Return">
/// true if logging history is enabled for this user, false otherwise
/// </param>
<returns>
true if logging history is enabled for this user, false otherwise
</returns>
public bool IsLoggingHistoryEnabledForUser(string userProxyAddress) {
return false;
}
/// Updates the parameters of the specified email user in persistence.
/// 
/// Parameters:
/// existingUserParams - the parameters that indicate the email user record to be updated (only one of UserId, RealEmail and ProxyEmail must be specified)
/// updatedUserParams - the new parameters for the email user record (at least one property must be not null, null property indicates parameters that don't need to be updated)
/// 
/// Throws:
/// ArgumentNullException if any argument is null
/// ArgumentException if existingUserParams.UserId <= 0, updatedUserParams.UserId <= 0, if not exactly one of existingUserParams.UserId, existingUserParams.RealEmail and existingUserParams.ProxyEmail is not null, if all properties of updatedUserParams are equal to null
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. persistence.UpdateEmailUser(existingUserParams, updatedUserParams);
/// <@throws>
/// ArgumentNullException if any argument is null
/// </@throws>
/// <@throws>
/// ArgumentException if existingUserParams.UserId <= 0, updatedUserParams.UserId <= 0, if not exactly one of existingUserParams.UserId, existingUserParams.RealEmail and existingUserParams.ProxyEmail is not null, if all properties of updatedUserParams are equal to null
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="updatedUserParams">
/// the new parameters for the email user record (at least one property must be not null, null property indicates parameters that don't need to be updated)
/// </param>
/// <param name="existingUserParams">
/// the parameters that indicate the email user record to be updated (only one of UserId, RealEmail and ProxyEmail must be specified)
/// </param>
/// <param name="Return">
/// void
/// </param>
public void UpdateEmailUser(EmailUserParams existingUserParams, EmailUserParams updatedUserParams) {
}
/// Retrieves details for the email user record that matches the given parameters from persistence.
/// 
/// Parameters:
/// emailUserParams - the parameters that indicate the email user record to be retrieved (only one of UserId, RealEmail and ProxyEmail must be specified)
/// 
/// Returns:
/// the retrieved email user details (null if email user with the specified parameters cannot be found)
/// 
/// Throws:
/// ArgumentNullException if emailUserParams is null
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. Return persistence.GetEmailUser(emailUserParams).
/// <@throws>
/// ArgumentNullException if emailUserParams is null
/// </@throws>
/// <@throws>
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="emailUserParams">
/// the parameters that indicate the email user record to be retrieved (only one of UserId, RealEmail and ProxyEmail must be specified)
/// </param>
/// <param name="Return">
/// the retrieved email user details (null if email user with the specified parameters cannot be found)
/// </param>
<returns>
the retrieved email user details (null if email user with the specified parameters cannot be found)
</returns>
public EmailUserParams GetEmailUser(EmailUserParams emailUserParams) {
return null;
}
/// Deletes the email user record that matches the given parameters from persistence.
/// 
/// Parameters:
/// emailUserParams - the parameters that indicate the email user record to be deleted (only one of UserId, RealEmail and ProxyEmail must be specified)
/// 
/// Throws:
/// ArgumentNullException if emailUserParams is null
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. persistence.DeleteEmailUser(emailUserParams).
/// <@throws>
/// ArgumentNullException if emailUserParams is null
/// </@throws>
/// <@throws>
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="emailUserParams">
/// the parameters that indicate the email user record to be deleted (only one of UserId, RealEmail and ProxyEmail must be specified)
/// </param>
/// <param name="Return">
/// void
/// </param>
public void DeleteEmailUser(EmailUserParams emailUserParams) {
}
/// Sets the state of the block from one user to another to enabled or disabled.
/// 
/// Parameters:
/// blockedUserParams - the parameters that indicate the email user to be blocked/unblocked (only one of UserId, RealEmail and ProxyEmail must be specified)
/// blockedByUserParams - the parameters that indicate the email user who performs blocking/unblocking (only one of UserId, RealEmail and ProxyEmail must be specified)
/// enabled - true if blocking must be enabled, false otherwise
/// 
/// Throws:
/// ArgumentNullException if any argument is null
/// ArgumentException if blockedUserParams.UserId <= 0, blockedByUserParams.UserId <= 0, if not exactly one of blockedUserParams.UserId, blockedUserParams.RealEmail and blockedUserParams.ProxyEmail is not null, if not exactly one of blockedByUserParams.UserId, blockedByUserParams.RealEmail and blockedByUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. persistence.SetUsersBlock(blockedUserParams, blockedByUserParams, enabled);
/// <@throws>
/// ArgumentNullException if any argument is null
/// </@throws>
/// <@throws>
/// ArgumentException if blockedUserParams.UserId <= 0, blockedByUserParams.UserId <= 0, if not exactly one of blockedUserParams.UserId, blockedUserParams.RealEmail and blockedUserParams.ProxyEmail is not null, if not exactly one of blockedByUserParams.UserId, blockedByUserParams.RealEmail and blockedByUserParams.ProxyEmail is not null
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="enabled">
/// true if blocking must be enabled, false otherwise
/// </param>
/// <param name="blockedByUserParams">
/// the parameters that indicate the email user who performs blocking/unblocking (only one of UserId, RealEmail and ProxyEmail must be specified)
/// </param>
/// <param name="blockedUserParams">
/// the parameters that indicate the email user to be blocked/unblocked (only one of UserId, RealEmail and ProxyEmail must be specified)
/// </param>
/// <param name="Return">
/// void
/// </param>
public void SetUsersBlock(EmailUserParams blockedUserParams, EmailUserParams blockedByUserParams, bool enabled) {
}
/// Checks if one user is blocked globally or by another user using the specified user parameters.
/// 
/// Parameters:
/// blockedUserParams - the parameters that indicate the email user to be blocked/unblocked (only one of UserId, RealEmail and ProxyEmail must be specified)
/// blockedByUserParams - the parameters that indicate the email user who performs blocking/unblocking (only one of UserId, RealEmail and ProxyEmail must be specified)
/// 
/// Returns:
/// true if user is blocked globally or by another user, false otherwise
/// 
/// Throws:
/// ArgumentNullException if any argument is null
/// ArgumentException if blockedUserParams.UserId <= 0, blockedByUserParams.UserId <= 0, if not exactly one of blockedUserParams.UserId, blockedUserParams.RealEmail and blockedUserParams.ProxyEmail is not null, if not exactly one of blockedByUserParams.UserId, blockedByUserParams.RealEmail and blockedByUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. Return persistence.IsUserBlocked(blockedUserParams, blockedByUserParams).
/// <@throws>
/// ArgumentNullException if any argument is null
/// </@throws>
/// <@throws>
/// ArgumentException if blockedUserParams.UserId <= 0, blockedByUserParams.UserId <= 0, if not exactly one of blockedUserParams.UserId, blockedUserParams.RealEmail and blockedUserParams.ProxyEmail is not null, if not exactly one of blockedByUserParams.UserId, blockedByUserParams.RealEmail and blockedByUserParams.ProxyEmail is not null
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="blockedByUserParams">
/// the parameters that indicate the email user who performs blocking/unblocking (only one of UserId, RealEmail and ProxyEmail must be specified)
/// </param>
/// <param name="blockedUserParams">
/// the parameters that indicate the email user to be blocked/unblocked (only one of UserId, RealEmail and ProxyEmail must be specified)
/// </param>
/// <param name="Return">
/// true if user is blocked globally or by another user, false otherwise
/// </param>
<returns>
true if user is blocked globally or by another user, false otherwise
</returns>
public bool IsUserBlocked(EmailUserParams blockedUserParams, EmailUserParams blockedByUserParams) {
return false;
}
/// Changes the flag indicating whether logging history is enabled for the user with the given parameters.
/// 
/// Parameters:
/// emailUserParams - the parameters that indicate the email user whose logging history must be enabled/disabled (only one of UserId, RealEmail and ProxyEmail must be specified)
/// enabled - true if logging history must be enabled, false - disabled
/// 
/// Throws:
/// ArgumentNullException if emailUserParams is null
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user for the specified parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. persistence.ChangeLoggingHistoryEnabledForUser(emailUserParams, enabled);
/// <@throws>
/// ArgumentNullException if emailUserParams is null
/// </@throws>
/// <@throws>
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified parameters cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="enabled">
/// true if logging history must be enabled, false - disabled
/// </param>
/// <param name="emailUserParams">
/// the parameters that indicate the email user whose logging history must be enabled/disabled (only one of UserId, RealEmail and ProxyEmail must be specified)
/// </param>
/// <param name="Return">
/// void
/// </param>
public void ChangeLoggingHistoryEnabledForUser(EmailUserParams emailUserParams, bool enabled) {
}
/// Retrieves the value indicating whether logging history is enabled for user with the given parameters.
/// 
/// Parameters:
/// emailUserParams - the parameters that indicate the email user whose logging history status must be retrieved (only one of UserId, RealEmail and ProxyEmail must be specified)
/// 
/// Returns:
/// true if logging history is enabled for this user, false otherwise
/// 
/// Throws:
/// ArgumentNullException if emailUserParams is null
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user for the specified parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// 
/// Implementation Notes:
/// 1. Return persistence.IsLoggingHistoryEnabledForUser(emailUserParams).
/// <@throws>
/// ArgumentNullException if emailUserParams is null
/// </@throws>
/// <@throws>
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// </@throws>
/// <@throws>
/// EmailUserNotFoundException if user for the specified parameters cannot be found
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="emailUserParams">
/// the parameters that indicate the email user whose logging history status must be retrieved (only one of UserId, RealEmail and ProxyEmail must be specified)
/// </param>
/// <param name="Return">
/// true if logging history is enabled for this user, false otherwise
/// </param>
<returns>
true if logging history is enabled for this user, false otherwise
</returns>
public bool IsLoggingHistoryEnabledForUser(EmailUserParams emailUserParams) {
return false;
}
}
}

