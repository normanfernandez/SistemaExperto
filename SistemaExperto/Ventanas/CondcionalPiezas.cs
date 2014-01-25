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

        #region Evento Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Idiomas.SystemLanguage.SelectedLanguage().MAIN_TITLE;
            this.LabelPiezaActual.Text = PiezaActual.Value.NombreNumeroPieza + " de " + Piezas.Count.ToString();
            
            #region pagina 1
            this.rbHandlingSeccion1.Text = SystemLanguage.SelectedLanguage().HANDLING_1;
            this.rbHandlingSeccion2.Text = SystemLanguage.SelectedLanguage().HANDLING_2;
            this.rbHandlingSeccion3.Text = SystemLanguage.SelectedLanguage().HANDLING_3;
            this.rbHandlingSeccion4.Text = SystemLanguage.SelectedLanguage().HANDLING_4;
            this.rbFacil.Text = SystemLanguage.SelectedLanguage().HANDLING_EASY;
            this.rbDificil.Text = SystemLanguage.SelectedLanguage().HANDLING_HARD;
            this.gbExtra.Text = SystemLanguage.SelectedLanguage().HANDLING_DESCRIPTION;
            this.checkBox2.Text = SystemLanguage.SelectedLanguage().HANDLING_CHECK1;
            this.checkBox1.Text = SystemLanguage.SelectedLanguage().HANDLING_CHECK2;
            this.rbEstandar.Text = SystemLanguage.SelectedLanguage().HANDLING_RBSUB1;
            this.rbEspecial.Text = SystemLanguage.SelectedLanguage().HANDLING_RBSUB2;
            this.checkBox3.Text = SystemLanguage.SelectedLanguage().HANDLING_CHECK3;
            this.checkBox4.Text = SystemLanguage.SelectedLanguage().HANDLING_CHECK4;
            this.rbPesado.Text = SystemLanguage.SelectedLanguage().HANDLING_RBSUB3;
            this.rbLigero.Text = SystemLanguage.SelectedLanguage().HANDLING_RBSUB4;
            #endregion

            #region pagina 2
            this.rbAgregada.Text = SystemLanguage.SelectedLanguage().INSERTION_RB1;
            this.rbSeparado.Text = SystemLanguage.SelectedLanguage().INSERTION_RB2;
            this.chDestinoNoAlcanzado.Text = SystemLanguage.SelectedLanguage().INSERTION_DESTINY;
            this.rbObstruidoOr.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB1;
            this.rbObtruidoAnd.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB2;
            this.chAseguradaInmediato.Text = SystemLanguage.SelectedLanguage().INSERTION_SECURED;
            this.chDeformacionPlastica.Text = SystemLanguage.SelectedLanguage().INSERTION_DEFORMATION;
            this.chTornillo.Text = SystemLanguage.SelectedLanguage().INSERTION_SCREW;
            this.gbExtra.Text = SystemLanguage.SelectedLanguage().INSERTION_GBEXTRA;
            this.gbPlastico.Text = SystemLanguage.SelectedLanguage().INSERTION_GBDEFORMATION;
            this.rbTorsion.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB3;
            this.rbRemache.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB4;
            this.rbUnion.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB5;
            this.rbRemache2.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB6;
            this.rbTornillo.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB7;
            this.rbSoldadura1.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB8;
            this.rbSoldadura2.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB9;
            this.rbSubEnsamble.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB10;
            this.rbOtrosProcesos.Text = SystemLanguage.SelectedLanguage().INSERTION_RBSUB11;
            this.chPresion.Text = SystemLanguage.SelectedLanguage().INSERTION_CH1;
            this.chDificilAlinear.Text = SystemLanguage.SelectedLanguage().INSERTION_CH2;
            this.chResistencia.Text = SystemLanguage.SelectedLanguage().INSERTION_CH3;
            this.rbProcesoMecanico.Text = SystemLanguage.SelectedLanguage().INSERTION_MECHANIC;
            this.rbProcesoNoMecanico.Text = SystemLanguage.SelectedLanguage().INSERTION_NONMECHANIC;
            this.rbProcesoSinAmarre.Text = SystemLanguage.SelectedLanguage().INSERTION_NO_FASTENING;
            this.chDeformacionPlastica2.Text = SystemLanguage.SelectedLanguage().INSERTION_CH4;
            this.chMaterialAdicional.Text = SystemLanguage.SelectedLanguage().INSERTION_CH5;
            #endregion

            #region pagina 3
            this.label5.Text = SystemLanguage.SelectedLanguage().DETAIL_PIECE_NAME;
            this.groupBox1.Text = SystemLanguage.SelectedLanguage().DETAIL_DIMENSIONS;
            this.label6.Text = SystemLanguage.SelectedLanguage().DETAIL_WIDTH;
            this.label7.Text = SystemLanguage.SelectedLanguage().DETAIL_SIZE;
            this.label4.Text = SystemLanguage.SelectedLanguage().DETAIL_PICTURE;
            this.gbEsencial.Text = SystemLanguage.SelectedLanguage().DETAIL_ESSENTIAL;
            this.checkBox5.Text = SystemLanguage.SelectedLanguage().DETAIL_DIFFERENT;
            this.checkBox6.Text = SystemLanguage.SelectedLanguage().DETAIL_RELATIVE;
            this.checkBox6.Text = SystemLanguage.SelectedLanguage().DETAIL_SEPARATED;
            #endregion

            this.botonAlante.Text = Idiomas.SystemLanguage.SelectedLanguage().BUTTON_NEXT;
            this.botonAtras.Text = Idiomas.SystemLanguage.SelectedLanguage().BUTTON_BACK;
            this.Text = Idiomas.SystemLanguage.SelectedLanguage().MAIN_TITLE;

        }
        #endregion

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelInsercion1.Enabled = true;
            panelInsercion1Sub2.Enabled = chDestinoNoAlcanzado.Checked;
            panelInsercion2.Enabled = false;
            gbProcesoSeparado.Enabled = false;
            gbExtra.Enabled = true;
            gbPlastico.Enabled = chDeformacionPlastica.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panelInsercion1.Enabled = false;
            gbPlastico.Enabled = false;
            gbProcesoSeparado.Enabled = true;
            panelInsercion2.Enabled = true;
            gbExtra.Enabled = false;
        }

        private void rbProcesoSinAmarre_CheckedChanged(object sender, EventArgs e)
        {
            panelInsercion2.Enabled = true;
            chProcesoMetalurgico.Enabled = false;
            panelProceso2.Enabled = false;
            panelProceso1.Enabled = false;
            chDeformacionPlastica2.Enabled = false;
        }

        private void rbProcesoNoMecanico_CheckedChanged(object sender, EventArgs e)
        {
            panelSeccion2Sub.Enabled = false;
            panelProceso1.Enabled = false;
            chDeformacionPlastica2.Enabled = false;
            chProcesoMetalurgico.Enabled = true;
        }

        private void rbProcesoMecanico_CheckedChanged(object sender, EventArgs e)
        {
            panelSeccion2Sub.Enabled = false;
            chDeformacionPlastica2.Enabled = true;
            chProcesoMetalurgico.Enabled = false;
            panelProceso1.Enabled = true;
            panelProceso2.Enabled = false;
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

        private void chTornillo_CheckedChanged(object sender, EventArgs e)
        {
            gbPlastico.Enabled = false;
            chDeformacionPlastica.Enabled = !chTornillo.Checked;
            chDeformacionPlastica.Checked = false;
        }

        private void chDeformacionPlastica2_CheckedChanged(object sender, EventArgs e)
        {
            panelProceso1.Enabled = chDeformacionPlastica2.Checked;
        }

        private void chMaterialAdicional_CheckedChanged(object sender, EventArgs e)
        {
            panelProceso2Sub.Enabled = chMaterialAdicional.Checked;
        }

        private void chProcesoMetalurgico_CheckedChanged(object sender, EventArgs e)
        {
            panelProceso2.Enabled = chProcesoMetalurgico.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            gbPlastico.Enabled = chDeformacionPlastica.Checked;
            chTornillo.Enabled = !chDeformacionPlastica.Checked;
            chTornillo.Checked = false;

        }
        #endregion

        #region Evento Buttons
        private void botonAtras_Click(object sender, EventArgs e)
        {
            LimpiarCondiciones();
            if (PiezaActual.Previous == null)
                this.botonAtras.Enabled = false;
            PiezaActual = PiezaActual.Previous;
            PiezaActual.Value.ReiniciarEstado();
            this.LabelPiezaActual.Text = PiezaActual.Value.NombreNumeroPieza
                        + " de " + Piezas.Count.ToString();
        }

        private void botonAlante_Click(object sender, EventArgs e)
        {
            try
            {
                RevisarCondiciones();
                this.PiezaActual.Value.CrearAnguloPieza(this.tabPage3.Controls.OfType<RadioButton>().Single(rb => rb.Checked).TabIndex);
                this.PiezaActual.Value.NombrePieza = this.nombrePiezaText.Text;
                this.PiezaActual.Value.Largo = double.Parse(largoText.Text);
                this.PiezaActual.Value.Ancho = double.Parse(anchoText.Text);
                CalcularTiempoManejo(PiezaActual.Value);
                CalcularTiempoInsercion(PiezaActual.Value);
                if (gbEsencial.Controls.OfType<CheckBox>().Any(ch => ch.Checked))
                    this.PiezaActual.Value.EsEsencial = true;
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
                    if (!Piezas.Any(p => p.EsEsencial))
                        throw new IncompleteSelectionException("No hay por lo menos una pieza esencial!");

                    DialogResult dialogResult = MessageBox.Show("Mostrar Resultados?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Hide();
                        ResultadoPiezas rwin = new ResultadoPiezas(Piezas);
                        rwin.ShowDialog();
                        this.Close();
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

        private void chDestinoNoAlcanzado_CheckedChanged(object sender, EventArgs e)
        {
            panelInsercion1Sub2.Enabled = chDestinoNoAlcanzado.Checked;
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

            #region Pagina 2
            if (!tabPage2.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                throw new IncompleteSelectionException();
            if(panelInsercion1Sub2.Enabled && !panelInsercion1Sub2.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                throw new IncompleteSelectionException();
            if(gbPlastico.Enabled && !gbPlastico.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                throw new IncompleteSelectionException();
            /*
             * Division para la parte de abajo
             * de la pagina 2
             */
            if(panelProceso1.Enabled && !panelProceso1.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                throw new IncompleteSelectionException();
            if(panelInsercion2Sub.Enabled && !panelInsercion2Sub.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                throw new IncompleteSelectionException();
            if (panelProceso2Sub.Enabled && !panelProceso2Sub.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                throw new IncompleteSelectionException();
            #endregion

            #region Pagina 3
            //Se revisa que se haya elegido la forma de la pieza
            if (!tabPage3.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                throw new IncompleteSelectionException();
            if (nombrePiezaText.Text == "")
                throw new IncompleteSelectionException();
            if ((largoText.Text == "") || (anchoText.Text == ""))
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

            #region Pagina 2
            foreach (var rad in tabPage2.Controls.OfType<RadioButton>())
                rad.Checked = false;
            foreach (var ch in panelInsercion1.Controls.OfType<CheckBox>())
                ch.Checked = false;
            foreach (var rad in panelInsercion1Sub2.Controls.OfType<RadioButton>())
                rad.Checked = false;
            foreach (var rad in panelInsercion2Sub.Controls.OfType<RadioButton>())
                rad.Checked = false;
            foreach (var rad in gbPlastico.Controls.OfType<RadioButton>())
                rad.Checked = false;
            foreach (var ch in gbExtra.Controls.OfType<CheckBox>())
                ch.Checked = false;
            panelInsercion1.Enabled = false;
            panelInsercion2.Enabled = false;
            gbPlastico.Enabled = false;
            gbProcesoSeparado.Enabled = false;
            #endregion

            #region Pagina 3
            foreach (var rad in this.tabPage3.Controls.OfType<RadioButton>())
                rad.Checked = false;
            foreach (var ch in this.tabPage3.Controls.OfType<CheckBox>())
                ch.Checked = false;
            foreach (var ch in this.gbEsencial.Controls.OfType<CheckBox>())
                ch.Checked = false;
            this.nombrePiezaText.Text = "";
            this.anchoText.Text = "";
            this.largoText.Text = "";
            #endregion
        }

        #region Handling Time
        private void CalcularTiempoManejo(Pieza p)
        {
            int columna = -1;
            int fila = -1;

            #region Analizando Numero de la izquierda (fila)
            switch(this.tabPage1.Controls.OfType<RadioButton>().Single(rb => rb.Checked).TabIndex)
            {
                case 1:
                    int? theta = p.Alfa + p.Beta;
                    if (theta < 360)
                        fila = 0;
                    else if (theta < 540)
                        fila = 1;
                    else if (theta < 720)
                        fila = 2;
                    else
                        fila = 3;
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

            #region Analizando Numero de la derecha (Columna)
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
                        if (!checkBox1.Checked)
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

        #region Insertion Time
        private void CalcularTiempoInsercion(Pieza p)
        {
            int fila = -1;
            int columna = -1;

            #region Numero de la izquierda (fila)
            if (rbSeparado.Checked)
                fila = 9;
            else
                fila = (chAseguradaInmediato.Checked ? 3 : 0) + 
                    (chDestinoNoAlcanzado.Checked ? (rbObstruidoOr.Checked ? 1 : 2): 0);
            #endregion

            #region Numero de la derecha (columna)
            if (rbAgregada.Checked)
            {
                //Sacando numero columna si es de la primera seccion
                if (!chAseguradaInmediato.Checked)
                {
                    columna = (chPresion.Checked ? 6 : 0);
                    columna += (!chDificilAlinear.Checked ? 0 : 2);
                    columna += (chResistencia.Checked ? 1 : 0);
                }
                //Sacando numero de columna en caso de ser la segunda seccion
                else
                {
                    if (chDeformacionPlastica.Checked)
                    {
                        columna = rbRemache.Checked ? 5 : 2;
                        columna += !chDificilAlinear.Checked ? 0 :
                            (chResistencia.Checked ? 2 : 1);
                    }
                    else
                    {
                        columna = chTornillo.Checked ? 8 : 0;
                        columna += !chDificilAlinear.Checked ? 0 : 1;
                    }
                }
            }
            //Caso ultima seccion
            else 
            {
                if(rbProcesoSinAmarre.Checked)
                {
                    columna = rbSubEnsamble.Checked ? 8 : 9;
                }
                else if (rbProcesoMecanico.Checked)
                {
                    if (chDeformacionPlastica2.Checked)
                        columna = 3;
                    else
                        columna = panelProceso1.Controls.OfType<RadioButton>().Single(rb => rb.Checked).TabIndex;
                } 
                else
                {
                    if(chProcesoMetalurgico.Checked)
                        columna = chMaterialAdicional.Checked ? (rbSoldadura1.Checked ? 5 : 6) : 4;
                    else
                        columna = 7;
                }
            }
            #endregion

            p.InsertionCode = fila.ToString() + columna.ToString();
            p.InsertionTime = TablaPiezaData.InsertionTime(fila, columna);
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
