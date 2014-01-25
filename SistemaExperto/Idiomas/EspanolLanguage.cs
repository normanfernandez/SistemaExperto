using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaExperto.Idiomas
{
    sealed class EspanolLanguage : AbstractLanguage
    {
        public AbstractLanguage ElegirIdioma()
        {
            QUANTITY_TITLE = "Cantidad de Piezas";
            BUTTON_NEXT = "Siguiente";
            BUTTON_BACK = "Atras";
            BUTTON_ACCEPT = "Aceptar";
            LABEL_QUANTITY = "Cantidad de Piezas:";
            MAIN_TITLE = "Sistema Experto";
            YES = "Sí";
            NO = "No";
            RESULT_TITLE = "Resultado";
            ASSEMBLY_NAME = "Nombre Ensamble:";
            return this;
        }
    }
}
