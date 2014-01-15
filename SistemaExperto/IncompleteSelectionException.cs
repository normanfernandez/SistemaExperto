using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaExperto
{
    public class IncompleteSelectionException : Exception
    {
        public IncompleteSelectionException() : base()
        {
            System.Windows.Forms.MessageBox.Show("Opciones Incompletas!", "Error");
        }
    }
}
