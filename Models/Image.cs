namespace mortezanourani.ir.Models;

#nullable disable
public class Image
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string FileName { get; set; }

    public string FileExtension { get; set; }

    public virtual Album Album { get; set; }
}
