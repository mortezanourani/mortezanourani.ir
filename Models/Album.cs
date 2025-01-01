using System.Collections.ObjectModel;

namespace mortezanourani.ir.Models;

#nullable disable
public class Album
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public virtual Collection<Image> Images { get; set; }
}
