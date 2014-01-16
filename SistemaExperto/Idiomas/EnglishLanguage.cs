using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaExperto.Idiomas
{
    sealed class EnglishLanguage : AbstractLanguage
    {
        public AbstractLanguage ElegirIdioma()
        {
            QUANTITY_TITLE = "Pieces Quantity";
            BUTTON_NEXT = "Next";
            BUTTON_ACCEPT = "Accept";
            LABEL_QUANTITY = "Pieces quantity:";
            MAIN_TITLE = "Expert System";
            YES = "Yes";
            NO = "No";
            return this; 
        }
    }
}
