using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Multiplicación
{
    internal class clmul
    {
        private int n1;
        private int n2;

        public clmul(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }

        public int OP()
        {
            return N1 * N2;
        }

        public clmul()
        {

        }
    }
}
