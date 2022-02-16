using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.User.Profile.Infrastructure
{
   interface IBloodGroup
  {
    public int Id { get; set; }

    public string Name { get; set; }
  }
}
