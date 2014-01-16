using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaExperto.Idiomas
{
    public class SystemLanguage
    {
        #region Constantes y variables
        private const string DEFAULT = "ESPANOL";
        private static string ACTUAL_LANGUAGE = DEFAULT;
        private static Dictionary<string, AbstractLanguage> languages = new Dictionary<string, AbstractLanguage>();
        private static bool LanguageSetFlag = false;
        #endregion
   
        private SystemLanguage() 
        {
        }

        public static void LanguageAdd() 
        {
            if (LanguageSetFlag)
                return;
            languages.Add("ENGLISH", new EnglishLanguage().ElegirIdioma());
            languages.Add("ESPANOL", new EspanolLanguage().ElegirIdioma());
        }

        public static AbstractLanguage SelectedLanguage() 
        {
            return languages[ACTUAL_LANGUAGE];
        }
        public static void SelectLanguage(string lan) 
        {          
            ACTUAL_LANGUAGE = lan;
        }
    }
}
