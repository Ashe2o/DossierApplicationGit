using CommonSurface.Model;
using CommonSurface.ViewModel;

namespace AppAdministrationWPF.ViewModel
{
    public class MediaDialogModel : ViewModelBase
    {
        #region Private Fields

        private Media _media;

        #endregion Private Fields

        #region Public Constructors

        public MediaDialogModel(Media media)
        {
            Selected = media;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Name
        {
            get { return _media.Name; }
            set { _media.Name = value; OnPropertyChanged("Name"); }
        }

        public string NameCAT
        {
            get { return _media.NameCAT; }
            set { _media.NameCAT = value; OnPropertyChanged("NameCAT"); }
        }

        public string NameEN
        {
            get { return _media.NameEN; }
            set { _media.NameEN = value; OnPropertyChanged("NameEN"); }
        }

        public string NameES
        {
            get { return _media.NameES; }
            set { _media.NameES = value; OnPropertyChanged("NameES"); }
        }

        public string NameDE
        {
            get { return _media.NameDE; }
            set { _media.NameDE = value; OnPropertyChanged("NameDE"); }
        }

        public string Path
        {
            get { return _media.Path; }
            set { _media.Path = value; OnPropertyChanged("Path"); }
        }

        public string PathCAT
        {
            get { return _media.PathCAT; }
            set { _media.PathCAT = value; OnPropertyChanged("PathCAT"); }
        }

        public string PathEN
        {
            get { return _media.PathEN; }
            set { _media.PathEN = value; OnPropertyChanged("PathEN"); }
        }

        public string PathES
        {
            get { return _media.PathES; }
            set { _media.PathES = value; OnPropertyChanged("PathES"); }
        }

        public string PathDE
        {
            get { return _media.PathDE; }
            set { _media.PathDE = value; OnPropertyChanged("PathDE"); }
        }

        /// <summary>
        /// Set a copy of the given media or a Media.Blank() value
        /// </summary>
        public Media Selected
        {
            get { return _media; }
            set { _media = (value == null) ? Media.Blank() : new Media(value); OnPropertyChanged("Selected"); }
        }

        #endregion Public Properties
    }
}