using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace griselda
{
    class GriseldaMember: Rapper
    {
        string _name;
        public GriseldaMember(string name)
        {
            _name = name;
            haveBars = true;
            canSing = false;
        }
    }
}
