namespace CommonSurface.ViewModel
{
    public class DiapoModel
    {
        #region Public Fields

        public string element;
        public int id;
        public string image1;
        public string image2;
        public string source;
        public string text;
        public string textCAT;
        public string textEN;
        public string textES;
        public string textDE;
        public string titre;
        public string type;

        #endregion Public Fields

        #region Public Constructors

        public DiapoModel()
        {
        }

        #endregion Public Constructors

        #region Private Destructors

        ~DiapoModel()
        {
            id = 0;
            type = source = titre = text = textCAT = textEN = textES = textDE = element = image1 = image2 = null;
        }

        #endregion Private Destructors
    }
}