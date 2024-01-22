using Microsoft.AspNetCore.Mvc;
using LitterBox.Api.Models;
using LitterBox.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LitterBox.Api.Data
{
    public class LitterBoxContext : DbContext
    {
        public LitterBoxContext(DbContextOptions<LitterBoxContext> options) : base(options) { }

        public LitterBoxContext() { }

        public DbSet<ChatMessage> ChatMessages { get; set; }

        public DbSet<Fellowship> Fellowships { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var sqlNow = "NOW()";
            foreach (var entityType in modelBuilder.Model.GetEntityTypes().Where(t => t.ClrType.IsSubclassOf(typeof(BaseEntity))))
            {
                modelBuilder.Entity(entityType.Name, entity =>
                {
                    entity.Property("CreatedTime").ValueGeneratedOnAdd();
                    entity.Property("UpdatedTime").ValueGeneratedOnAddOrUpdate();

                    //entity.Property("CreatedTime").Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
                    //entity.Property("CreatedTime").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
                    //entity.Property("UpdatedTime").Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
                    //entity.Property("UpdatedTime").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
                });
            }
        }
    }
}
