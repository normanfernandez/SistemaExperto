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
        
        public string BUTTON_NEXT;
        public string BUTTON_BACK;
        public string MAIN_TITLE;
        public  string YES;
        public string NO;

        #region Form 3
        public string RESULT_TITLE;
        public string TIP;
        public string EFFICIENCY;
        public string [] TIPS = new string[5];
        #endregion
    }
}
