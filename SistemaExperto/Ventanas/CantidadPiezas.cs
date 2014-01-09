using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaExperto.Ventanas
{
    public partial class CantidadPiezas : Form
    {
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
            Form1 form = new Form1();
            Piezas.PiezaManager.Create(Int32.Parse(this.numericUpDown1.Value.ToString()));
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}