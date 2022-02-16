using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.User.Profile.Infrastructure
{
  interface ICustomerMedicalData
  {
    public int Id { get; set; }

    public double HeightInKg { get; set; }

    public double Weight { get; set; }

    public int BloodgroupId { get; set; }

    public int GenotypeId { get; set; }

  }
}
