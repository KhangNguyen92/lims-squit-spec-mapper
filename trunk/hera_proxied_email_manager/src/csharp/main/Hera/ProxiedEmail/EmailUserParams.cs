/// This class is a simple container of data for a single email user. It can be used in three different situations: 1) when it holds some identifier of a user only - in this case only one of UserId, RealEmail and ProxyEmail properties are expected to be set; values of each of these properties are unique among all users; 2) when it holds parameters of the updated email user data - in this case null property means that this property is not required to be updated; 3) when all properties are not null - in this case it holds complete data for a single email user. This class is a DTO used by HeraProxiedEmailManager and IProxiedEmailPersistence.
/// 
/// Attributes:
/// [Serializable]
/// 
/// Thread Safety:
/// This class is mutable and not thread safe.
using ;
namespace Hera.ProxiedEmail {
public class EmailUserParams{
/// The ID of the user. Can be any value. This is an auto-implemented property.
public long? UserId;
/// The real email address of the user. Can be any value. This is an auto-implemented property.
public string RealEmail;
/// The proxy email address of the user. Can be any value. This is an auto-implemented property.
public string ProxyEmail;
/// The flag indicating whether the user is blocked. This is an auto-implemented property.
public bool? Blocked;
/// Creates an instance of EmailUserParams.
/// 
/// Implementation Notes:
/// Do nothing.
public EmailUserParams() {
}
}
}

