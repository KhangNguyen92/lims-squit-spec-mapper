/// This exception is a base class for all other custom checked exceptions defined in this component. It is never thrown directly, subclasses are used instead.
/// 
/// Thread Safety:
/// This class is not thread safe because its base class is not thread safe.
namespace Hera.ProxiedEmail {
public class HeraProxiedEmailManagementException : BaseException{
/// Creates a new instance of this exception.
public HeraProxiedEmailManagementException() {
}
/// Creates a new instance of this exception with the given message.
/// 
/// Parameter:
/// message - the detailed error message of this exception
/// <param name="message">
/// the detailed error message of this exception
/// </param>
public HeraProxiedEmailManagementException(string message) {
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
public HeraProxiedEmailManagementException(string message, Exception cause) {
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
protected HeraProxiedEmailManagementException(SerializationInfo info, StreamingContext context) {
}
}
}

