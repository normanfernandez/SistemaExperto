using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaExperto.Idiomas
{
    public abstract class AbstractLanguage
    {
        public AbstractLanguage() 
        {
        }
        #region Form 1
        public string LABEL_QUANTITY;
        public string QUANTITY_TITLE;
        public string BUTTON_ACCEPT;
        public string ASSEMBLY_NAME;
        #endregion

        #region Form 2
        public string HANDLING_TIME = "Handling Time";
        public string INSERTION_TIME = "Insertion Time";
        public string PIECE_DETAILS;
        public string BUTTON_NEXT;
        public string BUTTON_BACK;
        public string MAIN_TITLE;
        public  string YES;
        public string NO;

        #region Handling Time
        public string HANDLING_1;
        public string HANDLING_2;
        public string HANDLING_3;
        public string HANDLING_4;
        public string HANDLING_DESCRIPTION;
        public string HANDLING_EASY;
        public string HANDLING_HARD;
        public string HANDLING_CHECK1;
        public string HANDLING_CHECK2;
        public string HANDLING_CHECK3;
        public string HANDLING_CHECK4;
        public string HANDLING_RBSUB1;
        public string HANDLING_RBSUB2;
        public string HANDLING_RBSUB3;
        public string HANDLING_RBSUB4;
        #endregion

        #region Insertion Time
        public string INSERTION_RB1;
        public string INSERTION_RB2;
        public string INSERTION_DESTINY;
        public string INSERTION_SECURED;
        public string INSERTION_DEFORMATION;
        public string INSERTION_SCREW;
        public string INSERTION_MECHANIC;
        public string INSERTION_NONMECHANIC;
        public string INSERTION_NO_FASTENING;
        public string INSERTION_GBEXTRA;
        public string INSERTION_GBDEFORMATION;
        public string INSERTION_RBSUB1;
        public string INSERTION_RBSUB2;
        public string INSERTION_RBSUB3;
        public string INSERTION_RBSUB4;
        public string INSERTION_RBSUB5;
        public string INSERTION_RBSUB6;
        public string INSERTION_RBSUB7;
        public string INSERTION_RBSUB8;
        public string INSERTION_RBSUB9;
        public string INSERTION_RBSUB10;
        public string INSERTION_RBSUB11;
        public string INSERTION_CH1;
        public string INSERTION_CH2;
        public string INSERTION_CH3;
        public string INSERTION_CH4;
        public string INSERTION_CH5;
        public string INSERTION_CH6;
        #endregion

        #region Details
        public string DETAIL_PIECE_NAME;
        public string DETAIL_DIMENSIONS;
        public string DETAIL_WIDTH;
        public string DETAIL_SIZE;
        public string DETAIL_ESSENTIAL;
        public string DETAIL_PICTURE;
        public string DETAIL_DIFFERENT;
        public string DETAIL_RELATIVE;
        public string DETAIL_SEPARATED;
        #endregion

        #endregion

        #region Form 3
        public string RESULT_TITLE;
        public string TIP;
        public string EFFICIENCY;
        public string [] TIPS = new string[5];
        #endregion
    }
}
