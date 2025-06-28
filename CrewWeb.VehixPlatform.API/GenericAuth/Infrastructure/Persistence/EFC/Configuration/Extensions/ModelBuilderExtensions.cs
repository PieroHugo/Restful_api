// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
// Extension methods for configuring the Generic Authentication module.
// Customize entity mappings and constraints here.

{
    public static void ApplyGenericAuthConfiguration(this ModelBuilder builder)
    {
        builder.Entity<Role>().HasKey(r => r.Id);
        builder.Entity<Role>().Property(r => r.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Role>().Property(r => r.Name).IsRequired().HasMaxLength(50);

        builder.Entity<User>().HasKey(u => u.Id);
        builder.Entity<User>().Property(u => u.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<User>().Property(u => u.Name).IsRequired().HasMaxLength(50);
        builder.Entity<User>().Property(u => u.Lastname).IsRequired().HasMaxLength(50);
        builder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(50);
        builder.Entity<User>().Property(u => u.PasswordHash).IsRequired();
        builder.Entity<User>().Property(u => u.PhoneNumber).IsRequired().HasMaxLength(15);
        builder.Entity<User>().Property(u => u.Dni).IsRequired().HasMaxLength(20);
        builder.Entity<User>().Property(u => u.Gender).IsRequired().HasMaxLength(10);
        builder.Entity<User>().Property(u => u.PlanId).IsRequired();

        builder.Entity<User>()
            .HasOne(u => u.Role)
            .WithMany()
            .HasForeignKey(u => u.RoleId);
    }
}