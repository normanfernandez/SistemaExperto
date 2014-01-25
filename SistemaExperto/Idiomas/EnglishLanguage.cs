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
            BUTTON_BACK = "Back";
            BUTTON_ACCEPT = "Accept";
            LABEL_QUANTITY = "Pieces quantity:";
            MAIN_TITLE = "Expert System";
            YES = "Yes";
            NO = "No";
            ASSEMBLY_NAME = "Assembly Name:";

            RESULT_TITLE = "Result";
            EFFICIENCY = "Efficiency:";
            TIP = "Tip:";
            TIPS = new string[]
            {
                "Think of the six key points . \r \n1 Structure in \r \n2 Reduce complexity modules \r \n3 Establish a base \r \n4 . . . limit mounting directions \r \n5 facilitate the composition \r \n6 Simplify unions . ",
                "Modularity is a basic concept for good design (or redesign) for assembly.",
                "It is essential to establish a correct modular structure : \r \nmodules and well-defined interfaces and adequate",
                "Modularity is to group the different functions that a product must meet , or different sequences of manufacturing in mechanical interface modules connected by material flow , energy flow and flow signals clearly defined .",
                 "One advantage of decreasing the complexity : \r \nDisminuye assembly operations ( fewer pieces , fewer joints ) ."
            };
            return this; 
        }
    }
}
