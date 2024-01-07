using System.ComponentModel.DataAnnotations;

namespace BillingControl.Domain;

public abstract class Entity
{
    [Key]
    public Guid Id { get; set; }

    public Entity()
    {
        Id = Guid.NewGuid();    
    }
}
