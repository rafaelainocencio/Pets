using System;

public abstract class BaseEntity
{
    public Guid Id { get; private set; }
    public DateTime CreatedDate { get; private set; }

    protected BaseEntity()
    {
        Id = Guid.NewGuid;
        CreatedDate = DateTime.UtcNow;
    }

}
