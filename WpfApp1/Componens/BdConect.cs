using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Componens
{
   internal class BdConect
    {
        public static bookEntities bd = new bookEntities();
        public static Book book;
    }
}
