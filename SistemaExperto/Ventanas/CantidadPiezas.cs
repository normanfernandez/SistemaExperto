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
    public partial class CantidadPiezas : Form
    {
        private static string _nombreEnsamble = "";
        public static string NombreEnsamble { get { return _nombreEnsamble; } set { _nombreEnsamble = value; } }

        public CantidadPiezas()
        {
            InitializeComponent();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
                e.Handled = false;
            if ((e.KeyChar == 8 || e.KeyChar == 127) && numericUpDown1.Value.ToString().Length <= 1)
                numericUpDown1.Value = 1;
        }

        private void BotonConfirmarPieza_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                    throw new IncompleteSelectionException();
                Piezas.PiezaManager.Create(Int32.Parse(this.numericUpDown1.Value.ToString()));
                CondicionalPieza form = new CondicionalPieza();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            catch (Exception ex) 
            {
                // se muestra error
            }
        }

        private void rbEspanol_CheckedChanged(object sender, EventArgs e)
        {
            Idiomas.SystemLanguage.SelectLanguage("ESPANOL");
            this.Text = Idiomas.SystemLanguage.SelectedLanguage().QUANTITY_TITLE;
            this.label1.Text = Idiomas.SystemLanguage.SelectedLanguage().LABEL_QUANTITY;
            this.BotonConfirmarPieza.Text = Idiomas.SystemLanguage.SelectedLanguage().BUTTON_ACCEPT;
            this.labelNombreEnsamble.Text = Idiomas.SystemLanguage.SelectedLanguage().ASSEMBLY_NAME;
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            Idiomas.SystemLanguage.SelectLanguage("ENGLISH");
            this.Text = Idiomas.SystemLanguage.SelectedLanguage().QUANTITY_TITLE;
            this.label1.Text = Idiomas.SystemLanguage.SelectedLanguage().LABEL_QUANTITY;
            this.BotonConfirmarPieza.Text = Idiomas.SystemLanguage.SelectedLanguage().BUTTON_ACCEPT;
            this.labelNombreEnsamble.Text = Idiomas.SystemLanguage.SelectedLanguage().ASSEMBLY_NAME;
        }

        private void CantidadPiezas_Load(object sender, EventArgs e)
        {
            this.label1.Text = Idiomas.SystemLanguage.SelectedLanguage().LABEL_QUANTITY;
            this.Text = Idiomas.SystemLanguage.SelectedLanguage().QUANTITY_TITLE;
            this.label1.Text = Idiomas.SystemLanguage.SelectedLanguage().LABEL_QUANTITY;
            this.BotonConfirmarPieza.Text = Idiomas.SystemLanguage.SelectedLanguage().BUTTON_ACCEPT;
            this.labelNombreEnsamble.Text = Idiomas.SystemLanguage.SelectedLanguage().ASSEMBLY_NAME;
        }
    }
}