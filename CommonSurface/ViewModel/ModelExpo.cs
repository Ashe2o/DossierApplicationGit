using System.Collections.Generic;

namespace CommonSurface.ViewModel
{
    public class ModelExpo
    {
        #region Public Fields

        public string cover;
        public int id;
        public List<DiapoModel> ListeDiapo = new List<DiapoModel>();
        public string text;
        public string textCAT;
        public string textEN;
        public string textES;
        public string textDE;
        public string titre;
        public string titreCAT;
        public string titreEN;
        public string titreES;
        public string titreDE;

        #endregion Public Fields

        #region Public Constructors

        public ModelExpo()
        {
        }

        #endregion Public Constructors

        #region Private Destructors

        ~ModelExpo()
        {
            id = 0;
            cover = titre = titreCAT = titreEN = titreES = titreDE = text = textCAT = textEN = textES = textDE = null;
            ListeDiapo.Clear();
            ListeDiapo = null;
        }

        #endregion Private Destructors
    }
}