﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.User.Profile.Infrastructure
{
  internal interface IGenotype
  {
    public int Id { get; set; }

    public string Name { get; set; }
  }
}
