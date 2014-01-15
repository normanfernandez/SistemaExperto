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
        public IncompleteSelectionException(string str) : base(str) 
        {
            System.Windows.Forms.MessageBox.Show(str, "Error");
        }
    }
}
