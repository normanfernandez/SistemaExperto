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
            BUTTON_BACK = "Atrás";
            BUTTON_ACCEPT = "Aceptar";
            LABEL_QUANTITY = "Cantidad de Piezas:";
            MAIN_TITLE = "Sistema Experto";
            YES = "Sí";
            NO = "No";
            ASSEMBLY_NAME = "Nombre Ensamble:";

            PIECE_DETAILS = "Dettalles";
            HANDLING_1 = "La parte se puede agarrar y manipular con una mano sin el uso de herramientas";
            HANDLING_2 = "La parte se puede agarrar con una mano pero solo con el uso de herramientas como pinzas";
            HANDLING_3 = "Usa dos manos para la manipulacion pero no es grande";
            HANDLING_4 = "Se requiere dos manos para manipular y transportar debido a que es grande";
            HANDLING_EASY = "Es facil de Agarrar y Manipular";
            HANDLING_HARD = "Posee dificultad de manejo";
            HANDLING_DESCRIPTION = "Tipo de manejo";
            HANDLING_CHECK1 = "Requiere de herramientas adicionales";
            HANDLING_CHECK2 = "Requiere el uso de magnificacion";
            HANDLING_CHECK3 = "No se necesitan herramientas especiales para manupulacion";
            HANDLING_CHECK4 = "Las partes no se anidan ni son flexibles";
            HANDLING_RBSUB1 = "Herramientas Estandar";
            HANDLING_RBSUB2 = "Heraminetas Especiales";
            HANDLING_RBSUB3 = "Pesa menos de 10lb";
            HANDLING_RBSUB4 = "Pesa mas de 10lb";

            RESULT_TITLE = "Resultado";
            EFFICIENCY = "Eficiencia:";
            TIP = "Sugerencias:";
            TIPS = new string[]
            {
                "Piense en los seis puntos claves:\r\n1. Estructurar en módulos\r\n"+
                   "2. Disminuir la complejidad\r\n3. Establecer un elemento de base\r\n4. Limitar las direcciones de montaje\r\n5. Facilitar la composición\r\n6. Simplificar las uniones",
                "La modularidad es un concepto básico para un buen diseño (o rediseño) para el ensamblaje.",
                 "Es clave establecer una correcta estructuración modular:\r\nmódulos e interfases bien definidas y adecuadas",
                "La modularidad consiste en agrupar las distintas funciones \nque debe cumplir un producto, o las distintas secuencias de su fabricación, \nen módulos conectados por interfases mecánicas de flujo de materiales, flujo de energía y flujo de señales claramente definidas.",
                 "Una de las ventajas de disminuir la complejidad:\r\nDisminuye el número de piezas a conformar y las agrupar en menos tipos de piezas distintas (aumenta los volúmenes de fabricación"
            };
            return this;
        }
    }
}
