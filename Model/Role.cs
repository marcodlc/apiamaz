using System.Text.Json.Serialization;

namespace ApiAmaz.Model;
public class Role : Audit
{
    public Guid Code { get; set; }
    public string? Name { get; set; }
    public bool IsActive { get; set; }
    [JsonIgnore]
    public virtual ICollection<Worker> Workers {get;set;}
}