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

            INSERTION_RB1 = "Parte agregada: proceso en el cual se termina";
            INSERTION_RB2 = "Proceso por separdado: procesos de ensamble donde todas las partes solidas estan en sitio";
            INSERTION_DESTINY = "No alcanza facilmente su destino";
            INSERTION_SECURED = "Asegurada de inmediato";
            INSERTION_DEFORMATION = "Deformacion Plastica";
            INSERTION_SCREW = "Necesita apretarse con tornillo";
            INSERTION_MECHANIC = "Proceso Mecanico";
            INSERTION_NONMECHANIC = "Proceso No Mecanico";
            INSERTION_NO_FASTENING = "Proceso sin amarre";
            INSERTION_GBEXTRA = "Data Extra";
            INSERTION_GBDEFORMATION = "Demormacion";
            INSERTION_RBSUB1 = "Debido a acceso obstruido o vision restrigida";
            INSERTION_RBSUB2 = "Debido a acceso obstruido y vision restrigida";
            INSERTION_RBSUB3 = "Por torsion";
            INSERTION_RBSUB4 = "Por remache";
            INSERTION_RBSUB5 = "Union";
            INSERTION_RBSUB6 = "Remache";
            INSERTION_RBSUB7 = "Apriete de tornillo";
            INSERTION_RBSUB8 = "Soldadura blanda";
            INSERTION_RBSUB9 = "Soldadura";
            INSERTION_RBSUB10 = "Sub-Ensamble";
            INSERTION_RBSUB11 = "Otros Procesos";
            INSERTION_CH1 = "Se requiere mantenerse presionada";
            INSERTION_CH2 = "Dificil de alinear";
            INSERTION_CH3 = "Tiene resistencia al insertarse";
            INSERTION_CH4 = "Deformacion Plastica";
            INSERTION_CH5 = "Proceso Metalurgico";
            INSERTION_CH6 = "Material adicional requerido";

            DETAIL_PIECE_NAME = "Nombre de la pieza";
            DETAIL_DIMENSIONS = "Dimensión";
            DETAIL_WIDTH = "Ancho";
            DETAIL_SIZE = "Largo";
            DETAIL_ESSENTIAL = "Esencial";
            DETAIL_PICTURE = "Seleccione la forma de la pieza";
            DETAIL_DIFFERENT = "Material diferente a los demas";
            DETAIL_RELATIVE = "Movimiento relativo con respecto a los demas";
            DETAIL_SEPARATED = "Debe ser separada para permitir ensamble";

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
