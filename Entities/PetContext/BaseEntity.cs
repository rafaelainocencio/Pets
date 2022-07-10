using System;

public abstract class BaseEntity
{
    public Guid Id { get; private set; } //Global Unique Identifier - Gera um hash onde podemos trabalhar dentro do proprio C#
    public string FirstName { get; private set; }
    public string LastName { get; set; }
    public DateTime DateCreated { get; set; }



}
