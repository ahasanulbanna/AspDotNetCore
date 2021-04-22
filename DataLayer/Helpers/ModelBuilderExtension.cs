using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Helpers
{
    public static class ModelBuilderExtension
    {
        public static void ManageNonEntities(this ModelBuilder modelBuilder)
        {
            var ignorableEntities = typeof(IgnorableEntity)
                 .Assembly
                 .GetTypes()
                 .Where(x => typeof(IgnorableEntity).IsAssignableFrom(x))
                 .ToList();

            ignorableEntities.ForEach(vm =>
            {
                //For Migration this code is uncommented
                modelBuilder.Entity(vm).HasNoKey();

                //This code commented when application run
              // modelBuilder.Ignore(vm);
            });
        }
    }
}
