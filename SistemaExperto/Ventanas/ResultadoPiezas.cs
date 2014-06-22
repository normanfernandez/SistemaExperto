using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaExperto.Idiomas;

namespace SistemaExperto.Ventanas
{
    public sealed partial class ResultadoPiezas : Form
    {
        private LinkedListNode<Pieza> piezaActual;
        private double Tta = 0.00;
        private readonly double ta = 2.63;

        public ResultadoPiezas(LinkedList<Pieza> piezas)
        {
            InitializeComponent();

            #region Multiples idiomas
            this.Text = SystemLanguage.SelectedLanguage().RESULT_TITLE;
            this.labelNombreEnsable.Text = SystemLanguage.SelectedLanguage().ASSEMBLY_NAME;
            this.label1.Text = SystemLanguage.SelectedLanguage().EFFICIENCY;
            #endregion

            this.piezaActual = piezas.First;
            labelNombreEnsable.Text += CantidadPiezas.NombreEnsamble != "" ? CantidadPiezas.NombreEnsamble : "";
            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("nMin");
            dt.Columns.Add("Handling Code");
            dt.Columns.Add("Handling Time");
            dt.Columns.Add("Insertion Code");
            dt.Columns.Add("Insertion Time");
            dt.Columns.Add("Assembly Time");

            foreach(var p in piezaActual.List)
            {
                dt.Rows.Add(new object[] 
                    { 
                        p.NumeroPieza.ToString(),
                        p.NombrePieza,
                        piezas.Count(pi => pi.NombrePieza.ToLower() == p.NombrePieza.ToLower()).ToString(),
                        p.HandlingCode,
                        p.HandlingTime.ToString(),
                        p.InsertionCode,
                        p.InsertionTime.ToString(),
                        (p.InsertionTime + p.HandlingTime).ToString()
                    });
                Tta += p.InsertionTime + p.HandlingTime;
            }
            this.dataPiezas.DataSource = dt;
            this.textBox1.Text = CalcularEficiencia(piezas);
        }

        private string CalcularEficiencia(LinkedList<Pieza> piezas)
        {
            //E = Nmin * (ta/Tta) 100%
            return Math.Round((piezas.Count(p => p.EsEsencial))*(ta/Tta)*100,2).ToString();
        }
    }
}
