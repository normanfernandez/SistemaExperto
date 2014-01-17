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
using SistemaExperto.Idiomas;

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
            this.PiezaActual.Text = Piezas.First().NombreNumeroPieza + " de " + Piezas.Count.ToString();
            this.radioNo_1.Text = Idiomas.SystemLanguage.SelectedLanguage().No;
            this.radioSi_1.Text = Idiomas.SystemLanguage.SelectedLanguage().Yes;
            this.radioNo_2.Text = Idiomas.SystemLanguage.SelectedLanguage().No;
            this.radioSi_2.Text = Idiomas.SystemLanguage.SelectedLanguage().Yes;
            this.radioNo_3.Text = Idiomas.SystemLanguage.SelectedLanguage().No;
            this.radioSi_3.Text = Idiomas.SystemLanguage.SelectedLanguage().Yes;
            this.botonAlante.Text = Idiomas.SystemLanguage.SelectedLanguage().ButtonNext;
            this.botonAtras.Text = Idiomas.SystemLanguage.SelectedLanguage().ButtonBack;
            this.Text = Idiomas.SystemLanguage.SelectedLanguage().MainTitle;
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            if (_numeroPiezaActual == 1)
                this.botonAtras.Enabled = false;
            _numeroPiezaActual--;
            this.LimpiarCondiciones();
            Piezas[_numeroPiezaActual].ReiniciarEstado();
            this.PiezaActual.Text = Piezas[_numeroPiezaActual].NombreNumeroPieza
                        + " de " + Piezas.Count.ToString();
        }

        private void botonAlante_Click(object sender, EventArgs e)
        {
            RadioButton[] piezaFormaArr = { rbPieza1, rbPieza2, rbPieza3, rbPieza4, rbPieza5, rbPieza6 };
            try
            {
                RevisarCondiciones();
                /*
                 * En caso de que se cumplan las condiciones entonces se marcan los valores
                 * de la pieza actual y se pasa a la siguiente
                 */
                Piezas[_numeroPiezaActual].CrearAnguloPieza(piezaFormaArr.Single<RadioButton>(ch => ch.Checked).TabIndex);
                Piezas[_numeroPiezaActual].CrearCondicionalesPagina_1(this.radioSi_1.Checked, 
                    this.radioSi_2.Checked, this.radioSi_3.Checked);
                Piezas[_numeroPiezaActual].NombrePieza = this.nombrePiezaText.Text;
                Piezas[_numeroPiezaActual].Ancho = Double.Parse(this.anchoText.Text);
                Piezas[_numeroPiezaActual].Largo = Double.Parse(this.largoText.Text);
                if (Piezas.Count > _numeroPiezaActual + 1)
                {
                    _numeroPiezaActual++;
                    this.PiezaActual.Text = Piezas[_numeroPiezaActual].NombreNumeroPieza
                        + " de " + Piezas.Count.ToString();
                    LimpiarCondiciones();
                    tabControl1.SelectTab("tabPage1");
                }
                else 
                {
                    DialogResult dialogResult = MessageBox.Show("Mostrar Resultados?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var pieza in Piezas)
                            MessageBox.Show("Simetrica: " + (pieza.EsSimetrica.Value ? "Si\n" : "No\n") +
                                "Incrustable: " + (pieza.EsIncrustable.Value ? "Si\n" : "No\n") +
                                "Enlasable: " + (pieza.EsEnlasable.Value ? "Si\n" : "No\n") +
                                "Alfa: " + pieza.Alfa.ToString() + "\nBeta: " + pieza.Beta.ToString() + "\nNombre: " + pieza.NombrePieza +
                                "Dimension: " + pieza.Largo.ToString() + "x" + pieza.Ancho.ToString()
                                , pieza.NombreNumeroPieza);
                        this.Dispose();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }   
                }
                this.botonAtras.Enabled = true;
            }
            catch(IncompleteSelectionException ise)
            {
                //Se muestra mensaje de error en caso que se lance una excepcion
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
                throw new IncompleteSelectionException();
            #endregion

            #region Pagina 2
            //Se revisa que se haya elegido la forma de la pieza
            RadioButton[] piezaFormaArr = { rbPieza1, rbPieza2, rbPieza3, rbPieza4, rbPieza5, rbPieza6 };
            if(!piezaFormaArr.Any<RadioButton>(ch => ch.Checked))
                throw new IncompleteSelectionException();
            #endregion

            #region Pagina 3
            if (nombrePiezaText.Text == "")
                throw new IncompleteSelectionException();
            if((largoText.Text == "") || (anchoText.Text == ""))
                throw new IncompleteSelectionException();
            try
            {
                double largo = Double.Parse(largoText.Text);
                double ancho = Double.Parse(anchoText.Text);

                if (largo < 0 || ancho < 0)
                    throw new Exception();
            }
            catch (Exception e)
            {
                throw new IncompleteSelectionException("Numero de dimension no valido");
            }
            #endregion
        }

        private void LimpiarCondiciones()
        {
            //Funcion que se encarga de limpiar los RadioButtons y TextFields

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

            #region Pagina 3
            nombrePiezaText.Text = "";
            largoText.Text = "";
            anchoText.Text = "";
            #endregion
        }
        #endregion
    }
}
