using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
namespace ApiAmaz.Model;
public class IdentityDocumentType : Audit
{
    public string DocumentType { get; set; }
    public string Name { get; set; }
    public string NameShort { get; set; }
    public bool isActive { get; set; }
}