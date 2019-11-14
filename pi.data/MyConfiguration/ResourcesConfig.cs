using pi.domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.data.MyConfiguration
{
    class ResourcesConfig : EntityTypeConfiguration<Resources>
    {
        public ResourcesConfig()
        {
            HasRequired(c => c.PointOfSale)
                 .WithMany(cat => cat.Resources)
                 .HasForeignKey(c => c.PointOfSaleId)
                 .WillCascadeOnDelete(true);
            HasRequired(c => c.Employee)
                 .WithMany(cat => cat.Resources)
                 .HasForeignKey(c => c.EmployeeId)
                 .WillCascadeOnDelete(false);
        }
    }
}
