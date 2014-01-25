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

        #region details
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
