﻿namespace SporManagmenet.WebApi.Models.Entities;

public abstract class Entity<TId>
{
    public TId Id { get; set; }
}
