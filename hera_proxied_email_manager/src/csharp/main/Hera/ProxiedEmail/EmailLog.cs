/// This class is a simple container of data for a single logged email message. All contained data are represented with public auto-implemented properties. This class is a DTO used by HeraProxiedEmailManager and IProxiedEmailPersistence.
/// 
/// Attributes:
/// [Serializable]
/// 
/// Thread Safety:
/// This class is mutable and not thread safe.
using ;
namespace Hera.ProxiedEmail {
public class EmailLog{
/// The ID of the email log record. Can be any value. This is an auto-implemented property.
public long Id;
/// The proxy email address of the sender. Can be any value. This is an auto-implemented property.
public string From;
/// The proxy addresses of "TO" recipients. Can be any value, can contain any values. This is an auto-implemented property.
public IList<string> Recipients;
/// The proxy addresses of "BCC" recipients. Can be any value, can contain any values. This is an auto-implemented property.
public IList<string> BccRecipients;
/// The subject of the email message. Can be any value. This is an auto-implemented property.
public string Subject;
/// The body of the email message. Can be any value. This is an auto-implemented property.
public byte[] Body;
/// Creates an instance of EmailLog.
/// 
/// Implementation Notes:
/// Do nothing.
public EmailLog() {
}
}
}

