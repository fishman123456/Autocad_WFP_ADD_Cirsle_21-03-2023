using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocad_WFP_ADD_Cirsle_21_03_2023
{
    internal class broker_
    {
        public List<string> list_broker { get; set; }

        public broker_ (){}
        public broker_ (List<string> list_broker_constr)
        {
            list_broker = list_broker_constr;
        }
    }
}
