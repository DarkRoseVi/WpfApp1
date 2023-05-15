using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Componens
{
    public partial class Book
    {
        public string ColorDis 
        {
            get
            {
                if (PossibleDiscount > 15)
                    return "#7fff00";
                else
                    return "#FFFFFF";
            }
        }
        public string CostDuratoin 
        {
            get 
            {
                if (Discount == null || Discount == null)
                    return $"{Cost: F0}";
                else
                    return  $"{(double)Cost - ( ((double)Cost / 100 )* (double)PossibleDiscount):F} ";
            }
        }
    }
}
