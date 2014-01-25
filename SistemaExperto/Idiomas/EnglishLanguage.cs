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

            PIECE_DETAILS = "Details";
            HANDLING_1 = "Part can be manipulated with one hand without the use of tools";
            HANDLING_2 = "Part can be handled with one hand but only with the use of tools";
            HANDLING_3 = "Uses two hands for manipulation but is not big";
            HANDLING_4 = "Requires two hands to be manipulated and transported because it is big";
            HANDLING_EASY = "Easy to handle and manipulate";
            HANDLING_HARD = "Has dificulty of handling";
            HANDLING_DESCRIPTION = "Handling type";
            HANDLING_CHECK1 = "Requires additional tools";
            HANDLING_CHECK2 = "Requires magnification";
            HANDLING_CHECK3 = "Doesn't need special tools for handling";
            HANDLING_CHECK4 = "Parts do not nest nor are flexible";
            HANDLING_RBSUB1 = "Standard Tools";
            HANDLING_RBSUB2 = "Special tools";
            HANDLING_RBSUB3 = "Weight is less than 10P";
            HANDLING_RBSUB4 = "Weight is more than 10P";

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
