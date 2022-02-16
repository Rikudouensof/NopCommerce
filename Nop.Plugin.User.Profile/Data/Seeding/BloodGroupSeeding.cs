using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.User.Profile.Models;

namespace Nop.Plugin.User.Profile.Data.Seeding
{
  public class BloodGroupSeeding
  {


    public static List<BloodGroup> GetAllBloodgroups()
    {
      List<BloodGroup> bloodGroups = new List<BloodGroup>();
      bloodGroups.Add(new BloodGroup(){Name = "A+"});
      bloodGroups.Add(new BloodGroup() { Name = "O+" });
      bloodGroups.Add(new BloodGroup() { Name = "B+" });
      bloodGroups.Add(new BloodGroup() { Name = "AB+" });
      bloodGroups.Add(new BloodGroup() { Name = "A-" });
      bloodGroups.Add(new BloodGroup() { Name = "O-" });
      bloodGroups.Add(new BloodGroup() { Name = "B-" });
      bloodGroups.Add(new BloodGroup() { Name = "AB-" });


      return bloodGroups;
    }
  }

}

