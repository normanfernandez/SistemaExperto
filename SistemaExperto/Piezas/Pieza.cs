using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaExperto
{
    class Pieza
    {
        public Pieza(int num) 
        {
            this._numero = num;
            this._nombre = "Pieza no." + num.ToString();
        }

        private int _numero;
        private string _nombre;

        public string NombrePieza { get { return _nombre; } }
        public int NumeroPieza { get {return this._numero; } }
    }
}
