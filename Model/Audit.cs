namespace ApiAmaz.Model;
public class Audit
{
    public string? Creator { get; set; }
    public DateTime DateCreated { get; set; }
    public string? Updater { get; set; }
    public DateTime DateUpdate { get; set; }
}