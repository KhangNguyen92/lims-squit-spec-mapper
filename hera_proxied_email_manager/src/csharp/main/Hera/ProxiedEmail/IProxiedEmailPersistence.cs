/// This is an interface that defines methods for accessing proxy email mapping and email user data in the persistence. It is expected that implementations of this interface will be configured with use of Configuration API by calling Configure() method right after construction.
/// 
/// Thread Safety:
/// Implementations of this interface must be thread safe when Configure() method is called once right after construction.
using ;
using Hera.ProxiedEmail;
using TopCoder.Congfiguration;
namespace Hera.ProxiedEmail {
public interface IProxiedEmailPersistence{
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
public void Configure(IConfiguration configuration) {
}
/// Creates email user with the specified parameter sin persistence.
/// 
/// Parameters:
/// emailUserParams - the parameters of the email user
/// 
/// Throws:
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if emailUserParams is null
/// ArgumentException if emailUserParams.UserId <= 0 or any property of emailUserParams is null
/// ProxiedEmailPersistenceException if some error occurred when persisting the proxy email mapping data
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
/// <@throws>
/// ArgumentNullException if emailUserParams is null
/// </@throws>
/// <@throws>
/// ArgumentException if emailUserParams.UserId <= 0 or any property of emailUserParams is null
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some error occurred when persisting the proxy email mapping data
/// </@throws>
/// <param name="emailUserParams">
/// the parameters of the email user
/// </param>
/// <param name="Return">
/// void
/// </param>
public void CreateEmailUser(EmailUserParams emailUserParams) {
}
/// Updates the parameters of the specified email user in persistence.
/// 
/// Parameters:
/// existingUserParams - the parameters that indicate the email user record to be updated (only one of UserId, RealEmail and ProxyEmail must be specified)
/// updatedUserParams - the new parameters for the email user record (at least one property must be not null, null property indicates parameters that don't need to be updated)
/// 
/// Throws:
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if any argument is null
/// ArgumentException if existingUserParams.UserId <= 0, updatedUserParams.UserId <= 0, if not exactly one of existingUserParams.UserId, existingUserParams.RealEmail and existingUserParams.ProxyEmail is not null, if all properties of updatedUserParams are equal to null
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
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
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if emailUserParams is null
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
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
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if emailUserParams is null
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
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
/// Creates an email log record with the following parameters in persistence.
/// 
/// Parameters:
/// emailLog - the email log record parameters
/// 
/// Throws:
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if emailLog is null
/// ArgumentException if any property of emailLog is null,  emailLog.From is empty, emailLog.Recipients is empty, contains null/empty, emailLog.BccRecipients contains null/empty
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
/// <@throws>
/// ArgumentNullException if emailLog is null
/// </@throws>
/// <@throws>
/// ArgumentException if any property of emailLog is null,  emailLog.From is empty, emailLog.Recipients is empty, contains null/empty, emailLog.BccRecipients contains null/empty
/// </@throws>
/// <@throws>
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// </@throws>
/// <param name="Return">
/// void
/// </param>
/// <param name="emailLog">
/// the email log record parameters
/// </param>
public void CreateEmailLog(EmailLog emailLog) {
}
/// Sets the state of the block from one user to another to enabled or disabled.
/// 
/// Parameters:
/// blockedUserParams - the parameters that indicate the email user to be blocked/unblocked (only one of UserId, RealEmail and ProxyEmail must be specified)
/// blockedByUserParams - the parameters that indicate the email user who performs blocking/unblocking (only one of UserId, RealEmail and ProxyEmail must be specified)
/// enabled - true if blocking must be enabled, false otherwise
/// 
/// Throws:
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if any argument is null
/// ArgumentException if blockedUserParams.UserId <= 0, blockedByUserParams.UserId <= 0, if not exactly one of blockedUserParams.UserId, blockedUserParams.RealEmail and blockedUserParams.ProxyEmail is not null, if not exactly one of blockedByUserParams.UserId, blockedByUserParams.RealEmail and blockedByUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
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
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if any argument is null
/// ArgumentException if blockedUserParams.UserId <= 0, blockedByUserParams.UserId <= 0, if not exactly one of blockedUserParams.UserId, blockedUserParams.RealEmail and blockedUserParams.ProxyEmail is not null, if not exactly one of blockedByUserParams.UserId, blockedByUserParams.RealEmail and blockedByUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user with the given parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
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
/// Searches for email log records that match the given search parameters in the persistence. Returns an empty list if nothing found.
/// 
/// Parameters:
/// parameters - the list of search parameters (should be empty to retrieve all log records)
/// 
/// Returns:
/// the list of found log records (not null, doesn't contain null)
/// 
/// Throws:
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if parameters is null
/// ArgumentException if parameters contains empty key or null value
/// UnknownSearchParameterException if some parameter name is unknown
/// InvalidSearchParameterFormatException if value of some parameter has invalid format
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
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
/// Changes the flag indicating whether logging history is enabled for the user with the given parameters.
/// 
/// Parameters:
/// emailUserParams - the parameters that indicate the email user whose logging history must be enabled/disabled (only one of UserId, RealEmail and ProxyEmail must be specified)
/// enabled - true if logging history must be enabled, false - disabled
/// 
/// Throws:
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if emailUserParams is null
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user for the specified parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
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
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// ArgumentNullException if emailUserParams is null
/// ArgumentException if emailUserParams.UserId <= 0, if not exactly one of emailUserParams.UserId, emailUserParams.RealEmail and emailUserParams.ProxyEmail is not null
/// EmailUserNotFoundException if user for the specified parameters cannot be found
/// ProxiedEmailPersistenceException if some other error occurred when accessing the persistence
/// <@throws>
/// InvalidOperationException if this persistence was not properly configured with Configure() method
/// </@throws>
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

