using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Model.Model.Utils
{
    public enum Gender : byte //tinyint
    {
        Notknown = 0,
        Male = 1,
        Female = 2,
        NotApplicable = 9            
    }
}
