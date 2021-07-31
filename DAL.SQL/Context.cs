using DAL.SQL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQL
{
    public class Context : DbContext
    {
        private const string SUFFIX = "Entity";

        DbSet<ClassEntity> Classes { get; set; }
        DbSet<StudentEntity> Students { get; set; }

        public Context(DbContextOptions<Context> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            NormalizeNames(modelBuilder);
        }

        private void NormalizeNames(ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.SetTableName(Normalize(entityType.DisplayName()));

                List<IMutableForeignKey> foreignKeys = entityType.GetForeignKeys().ToList();

                foreach(IMutableForeignKey foreignKey in foreignKeys)
                    foreignKey.SetDependentToPrincipal(Normalize(foreignKey.PrincipalEntityType.DisplayName()));
            }
        }

        private string Normalize(string name) => name.Replace(SUFFIX, String.Empty).Split(' ').First();
    }
}
