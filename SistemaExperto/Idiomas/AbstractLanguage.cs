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
        protected string LABEL_QUANTITY;
        protected string QUANTITY_TITLE;
        protected string BUTTON_ACCEPT;
        protected string BUTTON_NEXT;
        protected string MAIN_TITLE;
        protected string YES;
        protected string NO;

        public string ButtonNext { get { return BUTTON_NEXT; } }
        public string ButtonAccept { get { return BUTTON_ACCEPT; } }
        public string QuantityTitle { get { return QUANTITY_TITLE; } }
        public string LabelQuantity { get { return LABEL_QUANTITY; } }
        public string MainTitle { get { return MAIN_TITLE; } }
        public string Yes { get { return YES; } }
        public string No { get { return NO; } }
    }
}
