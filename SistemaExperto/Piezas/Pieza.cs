using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaExperto
{
    class Pieza
    {
        #region Constantes para grados de piezas
        //El primer valor es el alfa y el segundo es el beta
        private int [] PIEZA_1 = { 0, 0 };
        private int [] PIEZA_2 = { 180, 0 };
        private int [] PIEZA_3 = { 180, 90 };
        private int [] PIEZA_4 = { 90, 180 };
        private int [] PIEZA_5 = { 360, 0 };
        private int [] PIEZA_6 = { 360, 360 };
        #endregion

        #region Constructor
        public Pieza(int num) 
        {
            this._numero = num;
            this._nombreNumero = "Pieza no." + num.ToString();
        }
        #endregion

        #region Atributos
        private int _numero;
        private string _nombre;
        private string _nombreNumero;
        private int? _alfa;
        private int? _beta;
        private bool? _simetrica;
        private bool? _incruste;
        private bool? _enlace_tipo;
        #endregion

        #region Metodos
        //Getters de los atributos
        public string NombrePieza { get { return _nombre; } }
        public string NombreNumeroPieza { get { return _nombreNumero; } }
        public int NumeroPieza { get {return this._numero; } }
        public int? Alfa { get { return _alfa.HasValue ? _alfa : -1; } }
        public int? Beta { get { return _beta.HasValue ? _beta : -1; } }
        public bool? EsSimetrica { get { return _simetrica.HasValue ? _simetrica : null; } }
        public bool? EsIncrustable { get { return _incruste.HasValue ? _incruste : null; } }
        public bool? EsEnlasable { get { return _enlace_tipo.HasValue ? _enlace_tipo : null; } }
        //////////////////////////

        //Metodos para dar valores
        public void CrearCondicionalesPagina_1(bool sim, bool inc, bool enl) 
        {
            this._simetrica = sim;
            this._incruste = inc;
            this._enlace_tipo = enl;
        }
        public void CrearAnguloPieza(int indice) 
        {
            if (indice < 1 || indice > 6)
            /*Exception en caso de que utilicen valores incorrectos para el indice de piezas*/
                throw new IncompleteSelectionException("Valores de Indice incorrectos");            
            int [][] arrConstantes = { PIEZA_1, PIEZA_2, PIEZA_3, PIEZA_4, PIEZA_5, PIEZA_6 };
            this._alfa = arrConstantes[indice - 1][0];
            this._beta = arrConstantes[indice - 1][1];
        }
        ///////////////////////////
        #endregion
    }
}
