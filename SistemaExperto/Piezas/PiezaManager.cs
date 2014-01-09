using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaExperto.Piezas
{
    class PiezaManager
    {
        private PiezaManager(int lim){ 
        }

        public static LinkedList<Pieza> PiezaList;

        public static void Create(int lim)
        {
            if (PiezaList != null)
                return;
            PiezaList = new LinkedList<Pieza>();
            for (int i = 1; i <= lim; i++)
                PiezaList.AddLast(new Pieza(i));
        }
    }
}
