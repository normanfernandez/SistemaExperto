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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.PiezaActual.Text = PiezaManager.PiezaList.First.Value.NombrePieza + " de " +
                PiezaManager.PiezaList.Count.ToString();
        }
    }
}
