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

            INSERTION_RB1 = "Part added: proccess on which it ends";
            INSERTION_RB2 = "Separated Proccess: assembly proccess where solid parts are setted";
            INSERTION_DESTINY = "Doesn't reach destiny easily";
            INSERTION_SECURED = "Inmediately secured";
            INSERTION_DEFORMATION = "Plastic Deformation";
            INSERTION_SCREW = "Needs screw";
            INSERTION_MECHANIC = "Mechanical Proccess";
            INSERTION_NONMECHANIC = "Non Mechanical Proccess";
            INSERTION_NO_FASTENING = "No Fastening Process";
            INSERTION_GBEXTRA = "Extra Data";
            INSERTION_GBDEFORMATION = "Deformation";
            INSERTION_RBSUB1 = "Due to obstructed access or restricted vision";
            INSERTION_RBSUB2 = "Due to obstructed access and restricted vision";
            INSERTION_RBSUB3 = "By torsion";
            INSERTION_RBSUB4 = "By riveting";
            INSERTION_RBSUB5 = "Union";
            INSERTION_RBSUB6 = "Riveting";
            INSERTION_RBSUB7 = "Screw Tightening";
            INSERTION_RBSUB8 = "Soldering";
            INSERTION_RBSUB9 = "Welding";
            INSERTION_RBSUB10 = "Sub-Asssembly";
            INSERTION_RBSUB11 = "Other Process";
            INSERTION_CH1 = "Requires to be pressed";
            INSERTION_CH2 = "Hard to aline";
            INSERTION_CH3 = "Has resistance against insertion";
            INSERTION_CH4 = "Plastic deformation";
            INSERTION_CH5 = "Metal process";
            INSERTION_CH6 = "Additional material required";

            DETAIL_PIECE_NAME = "Piece name";
            DETAIL_DIMENSIONS = "Dimension";
            DETAIL_WIDTH = "Width";
            DETAIL_SIZE = "Size";
            DETAIL_ESSENTIAL = "Essential";
            DETAIL_PICTURE = "Select your piece's shape";
            DETAIL_DIFFERENT = "Different material";
            DETAIL_RELATIVE = "Relative movement with respect to others";
            DETAIL_SEPARATED = "Must be separated to allow assembly";

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
