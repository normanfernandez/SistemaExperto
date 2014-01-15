using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaExperto.Ventanas;
using SistemaExperto.Piezas;

namespace SistemaExperto
{
    public partial class CondicionalPieza : Form
    {
        #region Constructor
        public CondicionalPieza()
        {
            this.Piezas = PiezaManager.PiezaList.ToList<Pieza>();
            PiezaManager.PiezaList.Clear();
            InitializeComponent();
        }
        #endregion

        #region Atributos
        private List<Pieza> Piezas;
        private int _numeroPiezaActual = 0;
        #endregion

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            this.PiezaActual.Text = Piezas.First().NombrePieza + " de " + Piezas.Count.ToString();
        }

        private void botonAlante_Click(object sender, EventArgs e)
        {
            RadioButton[] piezaFormaArr = { rbPieza1, rbPieza2, rbPieza3, rbPieza4, rbPieza5, rbPieza6 };
            try
            {
                RevisarCondiciones();
                Piezas[_numeroPiezaActual].CrearAnguloPieza(piezaFormaArr.Single<RadioButton>(ch => ch.Checked).TabIndex);
                if (Piezas.Count > _numeroPiezaActual + 1)
                {
                    _numeroPiezaActual++;
                    this.PiezaActual.Text = Piezas[_numeroPiezaActual].NombrePieza
                        + " de " + Piezas.Count.ToString();
                    LimpiarCondiciones();
                    tabControl1.SelectTab("tabPage1");
                }
                else 
                {
                    foreach(var pieza in Piezas)
                        MessageBox.Show("Alfa: " + pieza.Alfa.ToString() +"\nBeta: " + pieza.Beta.ToString(), pieza.NombrePieza);
                    this.Dispose();
                }
            }
            catch(IncompleteSelectionException ise)
            {
                MessageBox.Show(ise.Message, "Error!");
            }
        }
        #endregion

        #region Metodos
        private void RevisarCondiciones()
        {
            #region Pagina 1
            //Se revisa si cada una de las preguntas esta respondida
            if (!(radioNo_1.Checked ^ radioSi_1.Checked
                && radioNo_2.Checked ^ radioSi_2.Checked
                && radioNo_3.Checked ^ radioSi_3.Checked))
                throw new IncompleteSelectionException("Opciones Incompletas!");
            #endregion

            #region Pagina 2
            //Se revisa que se haya elegido la forma de la pieza
            RadioButton[] piezaFormaArr = { rbPieza1, rbPieza2, rbPieza3, rbPieza4, rbPieza5, rbPieza6 };
            if(!piezaFormaArr.Any<RadioButton>(ch => ch.Checked))
                throw new IncompleteSelectionException("Opciones Incompletas!");
            #endregion
        }

        private void LimpiarCondiciones()
        {
            //Funcion que se encarga de limpiar los radio Buttons

            #region Pagina 1
            RadioButton[] arrPanel1 = {radioNo_1, radioSi_1};
            RadioButton[] arrPanel2 = { radioNo_2, radioSi_2 };
            RadioButton[] arrPanel3 = { radioNo_3, radioSi_3 };
          
            foreach (var rad in arrPanel1)
                rad.Checked = false;
            foreach (var rad in arrPanel2)
                rad.Checked = false;
            foreach (var rad in arrPanel3)
                rad.Checked = false;
            #endregion
            
            #region Pagina 2
                RadioButton[] piezaFormaArr = { rbPieza1, rbPieza2, rbPieza3, rbPieza4, rbPieza5, rbPieza6 };
                foreach (var rad in piezaFormaArr)
                    rad.Checked = false;
            #endregion
        }
        #endregion
    }
}
