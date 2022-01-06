using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCore.DataAccess.Helpers
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

                //This code commented when application run and Migration this code is uncommented
                //modelBuilder.Ignore(vm);
            });
        }
    }
}
