using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaExperto
{
    public class Pieza
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
        private double _ancho;
        private double _largo;
        private double _handlingTime;
        private double _insertionTime;
        private string _handlingCode;
        private string _insertionCode;
        #endregion

        #region Metodos
        //Getters y Setters de los atributos
        public string NombrePieza { get { return this._nombre; } set { this._nombre = value; } }
        public string NombreNumeroPieza { get { return _nombreNumero; } }
        public int NumeroPieza { get {return this._numero; } }
        public int? Alfa { get { return this._alfa.HasValue ? _alfa : -1; } }
        public int? Beta { get { return this._beta.HasValue ? _beta : -1; } }
        public double Ancho { get { return this._ancho; } set { this._ancho = value; } }
        public double Largo { get { return this._largo; } set { this._largo = value; } }
        public double HandlingTime { get { return this._handlingTime; } set { this._handlingTime = value; } }
        public string HandlingCode { get { return this._handlingCode; } set { this._handlingCode = value; } }
        public double InsertionTime { get { return this._insertionTime; } set { this._insertionTime = value; } }
        public string InsertiongCode { get { return this._insertionCode; } set { this._insertionCode = value; } }
        //////////////////////////

        //Metodos para dar valores
        public void CrearAnguloPieza(int indice) 
        {
            if (indice < 1 || indice > 6)
            /*Exception en caso de que utilicen valores incorrectos para el indice de piezas*/
                throw new IncompleteSelectionException("Valores de Indice incorrectos");            
            int [][] arrConstantes = { PIEZA_1, PIEZA_2, PIEZA_3, PIEZA_4, PIEZA_5, PIEZA_6 };
            this._alfa = arrConstantes[indice - 1][0];
            this._beta = arrConstantes[indice - 1][1];
        }
        public void ReiniciarEstado() 
        {
            this._alfa = null;
            this._beta = null;

            this._nombre = "";
        }
        ///////////////////////////
        #endregion
    }
}
