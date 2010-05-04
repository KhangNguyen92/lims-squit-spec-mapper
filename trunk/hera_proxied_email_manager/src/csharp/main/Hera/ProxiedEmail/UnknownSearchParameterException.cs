/// This exception is thrown by HeraProxiedEmailManager and implementations of IProxiedEmailPersistence when some parameter name is unknown.
/// 
/// Thread Safety:
/// This class is not thread safe because its base class is not thread safe.
namespace Hera.ProxiedEmail {
public class UnknownSearchParameterException : ProxiedEmailPersistenceException{
/// Creates a new instance of this exception.
public UnknownSearchParameterException() {
}
/// Creates a new instance of this exception with the given message.
/// 
/// Parameter:
/// message - the detailed error message of this exception
/// <param name="message">
/// the detailed error message of this exception
/// </param>
public UnknownSearchParameterException(string message) {
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
public UnknownSearchParameterException(string message, Exception cause) {
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
protected UnknownSearchParameterException(SerializationInfo info, StreamingContext context) {
}
}
}

