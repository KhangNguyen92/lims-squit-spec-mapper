/// This class is an implementation of IProxiedEmailPersistence that uses Data Access Interface component and stored procedures to access data in the database. It must be configured by calling the Configure() method.
/// 
/// Thread Safety:
/// This class is mutable, but thread safe when Configure() method is called once right after construction. In this case mutable attributes never change after initialization. This class uses thread safe IDataAccess instance.
/// Transactions are used in SPs that modify data in the database to preserve data integrity.
using ;
using Hera.ProxiedEmail;
using TopCoder.Congfiguration;
using TopCoder.Util.DataAccessInterface;
namespace Hera.ProxiedEmail.Persistence {
public class ProxiedEmailPersistence{
/// The data access instance used for calling stored procedures. Is initialized in Configure() and never changed after that. Cannot be null after initialization. Is used in all public methods.
private IDataAccess dataAccess;
/// The connection name used for creating DB connections with use of IDataAccess instance. Is initialized in Configure() and never changed after that. Cannot be empty after initialization. Is used in all public methods.
private string connectionName;
/// Creates an instance of ProxiedEmailPersistence.
/// 
/// Implementation Notes:
/// Do nothing.
public ProxiedEmailPersistence() {
}
/// Configures this class with use of the given configuration object.
/// 
/// Please see section 3.2.2 of CS for details about configuration parameters. Please use value constraints provided in that section to check whether values read from the configuration are valid.
/// 
/// Parameters:
/// configuration - the configuration for this class
/// 
/// Throws:
/// ArgumentNullException if configuration is null
/// HeraProxiedEmailManagementConfigurationException if error occurred when reading the configuration (e.g. when some required property is missing or has invalid format)
/// 
/// Implementation Notes:
/// 1. Get object factory configuration:
///      IConfiguration objectFactoryConfig = configuration.GetChild("objectFactoryConfig");
/// 2. Create object factory from config:
///      ObjectFactory objectFactory = new ConfigurationAPIObjectFactory(objectFactoryConfig);
/// 3. Get data access OF key:
///      dataAccessKey = configuration.GetSimpleAttribute("dataAccessKey");
/// 4. Create data access with OF:
///      dataAccess = objectFactory.CreateDefinedObject(dataAccessKey);
/// 5. Get connection name from configuration:
///      connectionName = configuration.GetSimpleAttribute("connectionName");
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2. Call stored procedure "spCreateEmailUser". See sections 1.3.2 and 1.3.3.1 of CS for details. Use properties of emailUserParams as SP parameters.
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2. Call stored procedure "spUpdateEmailUser". See sections 1.3.2 and 1.3.3.2 of CS for details. Use properties of existingUserParams and updatedUserParams as SP parameters.
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2. Call stored procedure "spGetEmailUser". See sections 1.3.2 and 1.3.3.3 of CS for details. Use properties of emailUserParams.
/// 3. If result dataset is empty then return null.
/// 4. result = new EmailUserParams();
/// 5. Get all fields from the first row of the result dataset and set them to result's properties.
/// 6. Return result.
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2. Call stored procedure "spDeleteEmailUser". See sections 1.3.2 and 1.3.3.4 of CS for details. Use properties of emailUserParams as SP parameters.
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2.  string toRecipientsXml = <emailLog.Recipients in format "<addresses><address>...</address><address>...</address> ... </addresses>">;
/// 3.  string bccRecipientsXml = <emailLog.BccRecipients in format "<addresses><address>...</address><address>...</address> ... </addresses>">;
/// 4. Call stored procedure "spCreateEmailLog". See sections 1.3.2 and 1.3.3.5 of CS for details. Use toRecipientsXml, bccRecipientsXml, emailLog.From, emailLog.Subject and emailLog.Body as SP parameters.
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2. Call stored procedure "spSetUsersBlock". See sections 1.3.2 and 1.3.3.6 of CS for details. Use properties of blockedUserParams, blockedByUserParams and enabled as SP parameters.
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2. Call stored procedure "spGetUserBlocked". See sections 1.3.2 and 1.3.3.7 of CS for details. Use properties of blockedUserParams, blockedByUserParams as SP parameters.
/// 3. Return value returned by SP via dataAccess.
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
/// <returns>
/// true if user is blocked globally or by another user, false otherwise
/// </returns>
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2. For each (string paramName; string paramValue) from parameters do:
///      2.1. If paramName == "FromUser" then
///              2.1.1. Create IDataParameter for "@FromUser" parameter. Use paramValue as IDataParameter value.
///      2.2. Else if paramName == "Subject" then
///              2.2.1. Create IDataParameter for "@Subject" parameter. Use paramValue as IDataParameter value.
///      2.3. Else if paramName == "RecipientId" then
///              2.3.1. Parse paramValue as a comma-separated list of long user IDs to recipients:long[]. Throw InvalidSearchParameterFormatException if parsing error occurred.
///              2.3.2. string recipientsXml = <recipients in format "<ids><id>...</id><id>...</id> ... </ids>">;
///              2.3.3. Create IDataParameter for "@RecipientId" parameter. Use recipientsXml as IDataParameter value.
///      2.4. Else if paramName == "BccRecipientId" then
///              2.4.1. Parse paramValue as a comma-separated list of long user IDs to recipients:long[].
///              2.4.2. string recipientsXml = <recipients in format "<ids><id>...</id><id>...</id> ... </ids>">;
///              2.4.3. Create IDataParameter for "@BccRecipientId" parameter. Use recipientsXml as IDataParameter value.
///      2.5. Else if paramName == "TimeStamp" then
///              2.5.1. DateTime timestamp = DateTime.Parse(paramValue); // wrap parsing exceptions to InvalidSearchParameterFormatException
///              2.5.2. Create IDataParameter for "@TimeStamp" parameter. Use timestamp as IDataParameter value.
///      2.6. Else throw UnknownSearchParameterException.
/// 3. Call stored procedure "spSearchEmailLogs". See sections 1.3.2 and 1.3.3.8 of CS for details. Use parameters created above as SP parameters, for other not set parameters use null value.
/// 4. result = new List<EmailLog>();
/// 5. For each row in the current dataset do:
///      5.1. emailLog = new EmailLog();
///      5.2. Get all row fields from result set and set them to emailLog.
///      5.3. result.Add(emailLog);
/// 6. For each emailLog from result do:
///      6.1. For i = 1 .. 2 do:
///              6.1.1. Move to to the next dataset (see IDataReader.NextResult() method).
///              6.1.2. recipients = new List<string>();
///              6.1.3. For each row in the current dataset do:
///                         6.1.3.1. Get recipient:string from the data reader.
///                         6.1.3.2. recipients.Add(recipient);
///              6.1.4. If i == 1 then
///                         6.1.4.1. emailLog.Recipients = recipients;
///              6.1.5. Else
///                         6.1.5.1. emailLog.BccRecipients = recipients;
/// 7. Return result.
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
/// <returns>
/// the list of found log records (not null, doesn't contain null)
/// </returns>
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2. Call stored procedure "spChangeLoggingHistoryEnabled". See sections 1.3.2 and 1.3.3.9 of CS for details. Use properties of emailUserParams and enabled as SP parameters.
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
/// 
/// Implementation Notes:
/// 1. If dataAccess is null then throw InvalidOperationException.
/// 2. Call stored procedure "spGetLoggingHistoryEnabled". See sections 1.3.2 and 1.3.3.10 of CS for details. Use properties of emailUserParams as SP parameters.
/// 3. Return value returned by SP via dataAccess.
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

