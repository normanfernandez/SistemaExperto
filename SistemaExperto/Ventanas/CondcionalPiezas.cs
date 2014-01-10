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
        public CondicionalPieza()
        {
            _numeroPiezas = PiezaManager.PiezaList.Count;
            piezas = PiezaManager.PiezaList.ToArray();
            PiezaManager.PiezaList.Clear();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.PiezaActual.Text = piezas[_numeroPiezaActual].NombrePieza 
               + " de " + _numeroPiezas.ToString();
        }

        private Pieza [] piezas;
        private int _numeroPiezas;
        private int _numeroPiezaActual = 0;

        private void botonAlante_Click(object sender, EventArgs e)
        {
            try
            {
                RevisarCondiciones();
                if (_numeroPiezas > _numeroPiezaActual + 1)
                {
                    _numeroPiezaActual++;
                    this.PiezaActual.Text = piezas[_numeroPiezaActual].NombrePieza
                        + " de " + _numeroPiezas.ToString();
                }
                else 
                {
                    MessageBox.Show("Done", "Done");
                    this.Dispose();
                }
            }
            catch(IncompleteSelectionException ise)
            {
                MessageBox.Show(ise.Message, "Error!");
            }
        }

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
            
            #endregion
        }
    }
}
