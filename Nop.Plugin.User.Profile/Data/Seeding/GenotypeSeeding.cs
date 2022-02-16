using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.User.Profile.Models;

namespace Nop.Plugin.User.Profile.Data.Seeding
{
  public class GenotypeSeeding
  {

    public static List<GenoType> GetAllGenoTypes()
    {
      List<GenoType> genoTypes = new List<GenoType>();
      genoTypes.Add(new GenoType(){Name = "HH"});
      genoTypes.Add(new GenoType() { Name = "SO" });
      return genoTypes;
    }
  }
}
