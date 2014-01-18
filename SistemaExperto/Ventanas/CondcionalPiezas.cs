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
            this.Piezas = PiezaManager.PiezaList;
            this.PiezaActual = Piezas.First;
            InitializeComponent();
        }
        #endregion

        #region Atributos
        private LinkedList<Pieza> Piezas;
        private LinkedListNode<Pieza> PiezaActual;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LabelPiezaActual.Text = PiezaActual.Value.NombreNumeroPieza + " de " + Piezas.Count.ToString();
            /*this.radioNo_1.Text = Idiomas.SystemLanguage.SelectedLanguage().No;
            this.radioSi_1.Text = Idiomas.SystemLanguage.SelectedLanguage().Yes;
            this.radioNo_2.Text = Idiomas.SystemLanguage.SelectedLanguage().No;
            this.radioSi_2.Text = Idiomas.SystemLanguage.SelectedLanguage().Yes;
            this.radioNo_3.Text = Idiomas.SystemLanguage.SelectedLanguage().No;
            this.radioSi_3.Text = Idiomas.SystemLanguage.SelectedLanguage().Yes;
            this.botonAlante.Text = Idiomas.SystemLanguage.SelectedLanguage().ButtonNext;
            this.botonAtras.Text = Idiomas.SystemLanguage.SelectedLanguage().ButtonBack;
            this.Text = Idiomas.SystemLanguage.SelectedLanguage().MainTitle;
          */
        }

        #region Eventos RadioButtons
        private void rbHandlingSeccion1_CheckedChanged(object sender, EventArgs e)
        {
            panelSeccion2.Enabled = false;
            panelSeccion4.Enabled = false;
            grupoGeneral.Enabled = true;
        }

        private void rbHandlingSeccion2_CheckedChanged(object sender, EventArgs e)
        {
            panelSeccion2.Enabled = true;
            panelSeccion4.Enabled = false;
            grupoGeneral.Enabled = true;
        }

        private void rbHandlingSeccion3_CheckedChanged(object sender, EventArgs e)
        {
            panelSeccion2.Enabled = false;
            panelSeccion4.Enabled = false;
            grupoGeneral.Enabled = true;
        }

        private void rbHandlingSeccion4_CheckedChanged(object sender, EventArgs e)
        {
            panelSeccion2.Enabled = false;
            panelSeccion4.Enabled = true;
            grupoGeneral.Enabled = false;
        }
        #endregion

        #region Eventos checkbox
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            panelSeccion4Sub.Enabled = checkBox3.Checked;
            rbPesado.Enabled = rbLigero.Enabled = !checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            grupoGeneral.Enabled = rbPesado.Enabled = rbLigero.Enabled = checkBox4.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            grupoGeneral.Enabled = checkBox1.Enabled = !(panelSeccion2Sub.Enabled = checkBox2.Checked);
        }
        #endregion

        #region Evento Buttons
        private void botonAtras_Click(object sender, EventArgs e)
        {
            LimpiarCondiciones();
            /*if (_numeroPiezaActual == 1)
                this.botonAtras.Enabled = false;
            _numeroPiezaActual--;
            this.LimpiarCondiciones();
            Piezas[_numeroPiezaActual].ReiniciarEstado();
            this.PiezaActual.Text = Piezas[_numeroPiezaActual].NombreNumeroPieza
                        + " de " + Piezas.Count.ToString();*/
        }

        private void botonAlante_Click(object sender, EventArgs e)
        {
            try
            {
                RevisarCondiciones();
                this.PiezaActual.Value.CrearAnguloPieza(this.tabPage3.Controls.OfType<RadioButton>().Single(rb => rb.Checked).TabIndex);
                this.PiezaActual.Value.NombrePieza = this.nombrePiezaText.Text;
                CalcularTiempoManejo(PiezaActual.Value);
                if (PiezaActual.Next != null)
                {
                    PiezaActual = PiezaActual.Next;
                    this.LabelPiezaActual.Text = PiezaActual.Value.NombreNumeroPieza
                        + " de " + Piezas.Count.ToString();
                    LimpiarCondiciones();
                    tabControl1.SelectTab("tabPage1");
             
                }
                else 
                {
                    DialogResult dialogResult = MessageBox.Show("Mostrar Resultados?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
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
            if(!this.grupoGeneral.Controls.OfType<RadioButton>().Any(rb => rb.Checked) 
                && this.grupoGeneral.Enabled)
                    throw new IncompleteSelectionException();
            if (!this.tabPage1.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                throw new IncompleteSelectionException();
            if (!this.panelSeccion2Sub.Controls.OfType<RadioButton>().Any(rb => rb.Checked)
                && this.panelSeccion2Sub.Enabled)
                    throw new IncompleteSelectionException();
            if(!this.panelSeccion4Sub.Controls.OfType<RadioButton>().Any(rb => rb.Checked) && this.checkBox4.Checked)
                throw new IncompleteSelectionException();
            #endregion

            #region Pagina 3
            //Se revisa que se haya elegido la forma de la pieza
            if (!tabPage3.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                throw new IncompleteSelectionException();
            #endregion
            
            #region Pagina 4
            if (nombrePiezaText.Text == "")
                throw new IncompleteSelectionException();
            if((largoText.Text == "") || (anchoText.Text == ""))
                throw new IncompleteSelectionException();
            try
            {
                double largo = Double.Parse(largoText.Text);
                double ancho = Double.Parse(anchoText.Text);

                if (largo <= 0 || ancho <= 0)
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

            #region Pagina 1
            foreach (var rad in this.tabPage1.Controls.OfType<RadioButton>())
                rad.Checked = false;
            this.checkBox1.Checked = this.checkBox2.Checked = this.checkBox3.Checked = this.checkBox4.Checked = false;
            this.rbPesado.Checked = this.rbLigero.Checked = false;
            this.rbEstandar.Checked = this.rbEspecial.Checked = false;
            this.rbDificil.Checked = this.rbFacil.Checked = false;

            this.panelSeccion2.Enabled = false;
            this.panelSeccion4.Enabled = false;
            this.grupoGeneral.Enabled = true;
            #endregion
            
            #region Pagina 3
            foreach (var rad in this.tabPage3.Controls.OfType<RadioButton>().Where(rb => rb.Checked))
                rad.Checked = false;
            this.nombrePiezaText.Text = "";
            this.anchoText.Text = "";
            this.largoText.Text = "";
            #endregion
        }

        private void CalcularTiempoManejo(Pieza p)
        {
            int columna = -1;
            int fila = -1;
            short[] columnaHandling = {0,1,2,3,4,5,6,7,8,9};
            short[] filaHandling = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            #region Analizando Numero de la izquierda
            switch(this.tabPage1.Controls.OfType<RadioButton>().Single(rb => rb.Checked).TabIndex)
            {
                case 1:
                    int? theta = p.Alfa + p.Beta;
                    if (theta < 360)
                        fila = 0;
                    else if (theta < 540)
                        fila = 1;
                    else if (theta < 720)
                        theta = 2;
                    else
                        theta = 3;
                    break;
                case 2:
                    if(p.Alfa == 360)
                    {
                        if (p.Beta <= 180)
                            fila = 6;
                        else
                            fila = 7;
                    }
                    else
                    {
                        if (p.Beta <= 180)
                            fila = 4;
                        else
                            fila = 5;
                    }
                    break;
                case 3:
                    fila = 8;
                    break;
                case 4:
                    fila = 9;
                    break;
            }
            #endregion

            #region Analizando Numero de la derecha
            switch (this.tabPage1.Controls.OfType<RadioButton>().Single(rb => rb.Checked).TabIndex)
            {
                case 1:
                    if (rbFacil.Checked)
                    {
                        if (p.Ancho > 2) 
                        {
                            columna = p.Largo > 15 ? 0 : p.Largo > 6 ? 1 : 2;
                        } 
                        else 
                        {
                            columna = p.Largo > 6 ? 3 : 4;
                        }
                    } 
                    else 
                    {
                        if (p.Ancho > 2)
                        {
                            columna = p.Largo > 15 ? 5 : p.Largo > 6 ? 6 : 7;
                        }
                        else
                        {
                            columna = p.Largo > 6 ? 8 : 9;
                        }
                    }
                    break;
                case 2:
                    if (this.panelSeccion2Sub.Enabled)
                    {
                        columna = this.panelSeccion2Sub.Controls.
                            OfType<RadioButton>().Single(rb => rb.Checked).TabIndex;
                        break;
                    }
                    else 
                    {
                        if (!checkBox2.Checked)
                        {
                            if (rbFacil.Checked)
                                columna = p.Ancho > 0.25 ? 0 : 1;
                            else
                                columna = p.Ancho > 0.25 ? 2 : 3;
                        }
                        else 
                        {
                            if (rbFacil.Checked)
                                columna = p.Ancho > 0.25 ? 4 : 5;
                            else
                                columna = p.Ancho > 0.25 ? 6 : 7;
                        }
                    }
                    break;
                case 3:
                    if(rbFacil.Checked)
                    {
                        if (p.Alfa <= 180)
                        {
                            columna = p.Largo > 15 ? 0 : p.Largo > 6 ? 1 : 2;
                        }
                        else 
                        {
                            columna = p.Largo > 6 ? 3 : 4;
                        }
                    }
                    else
                    {
                        if (p.Alfa <= 180)
                        {
                            columna = p.Largo > 15 ? 5 : p.Largo > 6 ?  6: 7;
                        }
                        else
                        {
                            columna = p.Largo > 6 ? 8 : 9;
                        }
                    }
                    break;
                case 4:
                    if (!checkBox3.Checked)
                        columna = 9;
                    else 
                    {
                        if (!checkBox4.Checked)
                        {
                            columna = 8;
                            break;
                        }
                        else 
                        {
                            if (rbLigero.Checked) 
                            {
                                if (rbFacil.Checked)
                                    columna = p.Alfa <= 180 ? 0 : 1;
                                else 
                                    columna = p.Alfa <= 180 ? 2 : 3;
                            } 
                            else 
                            {
                                if (rbFacil.Checked)
                                    columna = p.Alfa <= 180 ? 4 : 5;
                                else
                                    columna = p.Alfa <= 180 ? 6 : 7;
                            }
                        }
                    }
                    break;
            }
            #endregion
            p.HandlingCode = fila.ToString() + columna.ToString();
            p.HandlingTime = TablaPiezaData.HandlingTime(fila, columna);
        }
        #endregion
    }
}
