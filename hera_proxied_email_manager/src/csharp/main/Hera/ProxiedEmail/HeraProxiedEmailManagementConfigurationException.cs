/// This exception is thrown by HeraProxiedEmailManager and implementations of IProxyEmailGenerator and IProxiedEmailPersistence interfaces when some error occurs while reading the configuration (e.g. when some required property is missing or has invalid format) or initializing the class using this configuration.
/// 
/// Thread Safety:
/// This class is not thread safe because its base class is not thread safe.
namespace Hera.ProxiedEmail {
public class HeraProxiedEmailManagementConfigurationException : BaseException{
/// Creates a new instance of this exception.
public HeraProxiedEmailManagementConfigurationException() {
}
/// Creates a new instance of this exception with the given message.
/// 
/// Parameter:
/// message - the detailed error message of this exception
/// <param name="message">
/// the detailed error message of this exception
/// </param>
public HeraProxiedEmailManagementConfigurationException(string message) {
}
/// Creates a new instance of this exception with the given message and cause.
/// 
/// Parameters:
/// message - the detailed error message of this exception
/// cause - the inner cause of this exception
/// <param name="message">
/// the detailed error message of this exception
/// </param>
/// <param name="cause">
/// the inner cause of this exception
/// </param>
public HeraProxiedEmailManagementConfigurationException(string message, Exception cause) {
}
/// Creates a new instance of this exception with serialized data.
/// 
/// Parameters:
/// info - the object that holds the serialized object data
/// context - contextual information about the source or destination
/// <param name="context">
/// contextual information about the source or destination
/// </param>
/// <param name="info">
/// the object that holds the serialized object data
/// </param>
protected HeraProxiedEmailManagementConfigurationException(SerializationInfo info, StreamingContext context) {
}
}
}

