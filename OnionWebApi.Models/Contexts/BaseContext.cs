using Microsoft.EntityFrameworkCore;
using OnionWebApi.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionWebApi.Models.Contexts
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> contextOptions) : base(contextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(IBaseEntity).IsAssignableFrom(type.ClrType))
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
            }
            //modelBuilder.Entity<Department>()
            //            .Property(a => a.Id)
            //            .HasAnnotation(DatabaseGeneratedOption.None);
                    
            //    //.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //base.OnModelCreating(modelBuilder);
        }
    }
}
