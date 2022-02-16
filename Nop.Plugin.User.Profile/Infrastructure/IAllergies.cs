using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.User.Profile.Infrastructure
{
  interface IAllergies
  {

     int Id { get; set; }

     string UserId { get; set; }
     bool HasDiabities { get; set; }

     bool HasHypertension { get; set; }

     bool HasDisabilities { get; set; }

     bool IsBlind { get; set; }
     bool IsEpileptic { get; set; }

     bool IsAsthmatic { get; set; }

     bool UsesSpectacles { get; set; }

     bool IsBloodgroupSS { get; set; }
     string AboutAllergy { get; set; }

  }
}
