using System.Text.Json.Serialization;

namespace ApiAmaz.Model;

public class User : Audit
{
    public Guid WorkerCode { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    [JsonIgnore]
    public string SoftwareName { get; set; }
    public bool IsActive { get; set; }
    [JsonIgnore]
    public virtual Worker Worker { get; set; }
}