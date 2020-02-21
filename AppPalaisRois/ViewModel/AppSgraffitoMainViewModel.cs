using CommonSurface.DAO;
using CommonSurface.Model;
using CommonSurface.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AppPalaisRois.ViewModel
{
    public class AppSgraffitoMainViewModel : ViewModelBase
    {
        #region Private Fields

        // Variables
        private string _scatterViewVisibility = "Visible";

        private Map _selected;

        #endregion Private Fields

        #region Public Constructors

        public AppSgraffitoMainViewModel()
        {
        }

        #endregion Public Constructors

        #region Private Destructors

        ~AppSgraffitoMainViewModel()
        {
            _scatterViewVisibility = null;
            _selected = null;
        }

        #endregion Private Destructors

        #region Getters and Setters
        public string ScatterViewVisibility
        {
            get { return _scatterViewVisibility; }
            set { _scatterViewVisibility = value; OnPropertyChanged("ScatterViewVisibility"); }
        }

        public Map Selected
        {
            get { return _selected; }
            set { _selected = value; OnPropertyChanged("Selected"); }
        }

        #endregion Getters and Setters
    }
}