/// This exception is thrown by HeraProxiedEmailManager and implementations of IProxiedEmailPersistence when user with the specified parameters cannot be found in persistence.
/// 
/// Thread Safety:
/// This class is not thread safe because its base class is not thread safe.
namespace Hera.ProxiedEmail {
public class EmailUserNotFoundException : ProxiedEmailPersistenceException{
/// Creates a new instance of this exception.
public EmailUserNotFoundException() {
}
/// Creates a new instance of this exception with the given message.
/// 
/// Parameter:
/// message - the detailed error message of this exception
/// <param name="message">
/// the detailed error message of this exception
/// </param>
public EmailUserNotFoundException(string message) {
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
public EmailUserNotFoundException(string message, Exception cause) {
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
protected EmailUserNotFoundException(SerializationInfo info, StreamingContext context) {
}
}
}

