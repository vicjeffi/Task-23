using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрактическаяРабота23.Models
{
    internal interface IOwned
    {
        Owner Owner { get; set; }
    }
}
