using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CommonSurface.Model
{
    [Serializable]
    public class Media : INotifyPropertyChanged, IDisposable
    {
        #region Private Fields

        private string _name;

        private string _nameCAT;

        private string _nameEN;

        private string _nameES;

        private string _nameDE;

        private string _path;

        private string _pathCAT;

        private string _pathEN;

        private string _pathES;

        private string _pathDE;

        private Section _section;

        private MediaType _type;

        private double _x;

        private double _y;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Serialization constructor DO NOT USE!
        /// </summary>
        public Media()
        {
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="copy"></param>
        public Media(Media copy)
        {
            this.X = copy.X;
            this.Y = copy.Y;
            this.Name = copy.Name;
            this.NameCAT = copy.NameCAT;
            this.NameEN = copy.NameEN;
            this.NameES = copy.NameES;
            this.NameDE = copy.NameDE;
            this.Type = copy.Type;
            this.Section = copy.Section;
            this.Path = copy.Path;
            this.PathCAT = copy.PathCAT;
            this.PathEN = copy.PathEN;
            this.PathES = copy.PathES;
            this.PathDE = copy.PathDE;
        }

        public Media(string Name, string NameCAT, string NameEN, string NameES, string NameDE, string Path, string PathCAT, string PathEN, string PathES, string PathDE)
        {
            this.X = 0;
            this.Y = 0;
            this.Name = Name;
            this.NameCAT = NameCAT;
            this.NameEN = NameEN;
            this.NameES = NameES;
            this.NameDE = NameDE;
            this.Type = MediaType.DEFAUT;
            this.Section = Section.DEFAUT;
            this.Path = Path;
            this.PathCAT = PathCAT;
            this.PathEN = PathEN;
            this.PathES = PathES;
            this.PathDE = PathDE;
        }

        public Media(string Name, string NameCAT, string NameEN, string NameES, string NameDE, string Path, string PathCAT, string PathEN, string PathES, string PathDE, MediaType Type)
        {
            this.X = 0;
            this.Y = 0;
            this.Name = Name;
            this.NameCAT = NameCAT;
            this.NameEN = NameEN;
            this.NameES = NameES;
            this.NameDE = NameDE;
            this.Type = Type;
            this.Section = Section.DEFAUT;
            this.Path = Path;
            this.PathCAT = PathCAT;
            this.PathEN = PathEN;
            this.PathES = PathES;
            this.PathDE = PathDE;
        }

        public Media(string Name, string Path, MediaType Type)
        {
            this.X = 0;
            this.Y = 0;
            this.Name = Name;
            this.Type = Type;
            this.Section = Section.DEFAUT;
            this.Path = Path;
        }

        public Media(double X, double Y, string Name, string NameCAT, string NameEN, string NameES, string NameDE, MediaType Type, Section Section)
        {
            this.X = X;
            this.Y = Y;
            this.Name = Name;
            this.NameCAT = NameCAT;
            this.NameEN = NameEN;
            this.NameES = NameES;
            this.NameDE = NameDE;
            this.Type = Type;
            this.Section = Section;
            this.Path = "";
            this.PathCAT = "";
            this.PathEN = "";
            this.PathES = "";
            this.PathDE = "";
        }

        public Media(double X, double Y, string Name, string NameCAT, string NameEN, string NameES, string NameDE, string Path, string PathCAT, string PathEN, string PathES, string PathDE, MediaType Type, Section Section)
        {
            this.X = X;
            this.Y = Y;
            this.Name = Name;
            this.NameCAT = NameCAT;
            this.NameEN = NameEN;
            this.NameES = NameES;
            this.NameDE = NameDE;
            this.Type = Type;
            this.Section = Section;
            this.Path = Path;
            this.PathCAT = PathCAT;
            this.PathEN = PathEN;
            this.PathES = PathES;
            this.PathDE = PathDE;
        }

        #endregion Public Constructors

        #region Private Destructors

        ~Media()
        {
            this._x = 0;
            this._y = 0;
            this._name = null;
            this._nameCAT = null;
            this._nameEN = null;
            this._nameES = null;
            this._nameDE = null;
            this._path = null;
            this._pathCAT = null;
            this._pathEN = null;
            this._pathES = null;
            this._pathDE = null;
        }

        #endregion Private Destructors

        #region Public Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Public Events

        #region getters and setters

        [XmlElement]
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        [XmlElement]
        public string NameCAT
        {
            get { return _nameCAT; }
            set { _nameCAT = value; OnPropertyChanged("NameCAT"); }
        }

        [XmlElement]
        public string NameEN
        {
            get { return _nameEN; }
            set { _nameEN = value; OnPropertyChanged("NameEN"); }
        }

        [XmlElement]
        public string NameES
        {
            get { return _nameES; }
            set { _nameES = value; OnPropertyChanged("NameES"); }
        }

        [XmlElement]
        public string NameDE
        {
            get { return _nameDE; }
            set { _nameDE = value; OnPropertyChanged("NameDE"); }
        }

        [XmlElement]
        public string Path
        {
            get { return _path; }
            set { _path = value; OnPropertyChanged("Path"); }
        }

        [XmlElement]
        public string PathCAT
        {
            get { return _pathCAT; }
            set { _pathCAT = value; OnPropertyChanged("PathCAT"); }
        }

        [XmlElement]
        public string PathEN
        {
            get { return _pathEN; }
            set { _pathEN = value; OnPropertyChanged("PathEN"); }
        }

        [XmlElement]
        public string PathES
        {
            get { return _pathES; }
            set { _pathES = value; OnPropertyChanged("PathES"); }
        }

        [XmlElement]
        public string PathDE
        {
            get { return _pathDE; }
            set { _pathDE = value; OnPropertyChanged("PathDE"); }
        }

        [XmlElement]
        public Section Section
        {
            get { return _section; }
            set { _section = value; OnPropertyChanged("Section"); }
        }

        [XmlElement]
        public MediaType Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        [XmlElement]
        public double X
        {
            get { return _x; }
            set { _x = value; OnPropertyChanged("X"); }
        }

        [XmlElement]
        public double Y
        {
            get { return _y; }
            set { _y = value; OnPropertyChanged("Y"); }
        }

        #endregion getters and setters

        #region Public Methods

        /// <summary>
        /// Create a blank media
        /// </summary>
        /// <returns></returns>
        public static Media Blank()
        {
            return new Media(0, 0, "","","","","", "","","","","", MediaType.DEFAUT, Section.DEFAUT);
        }

        public void Dispose()
        {
            this._x = 0;
            this._y = 0;
            this._name = null;
            this._nameCAT = null;
            this._nameEN = null;
            this._nameES = null;
            this._nameDE = null;
            this._path = null;
            this._pathCAT = null;
            this._pathEN = null;
            this._pathES = null;
            this._pathDE = null;
        }

        public void Copy(Media copy)
        {
            this.X = copy.X;
            this.Y = copy.Y;
            this.Name = copy.Name;
            this.NameCAT = copy.NameCAT;
            this.NameEN = copy.NameEN;
            this.NameES = copy.NameES;
            this.NameDE = copy.NameDE;
            this.Type = copy.Type;
            this.Section = copy.Section;
            this.Path = copy.Path;
            this.PathCAT = copy.PathCAT;
            this.PathEN = copy.PathEN;
            this.PathES = copy.PathES;
            this.PathDE = copy.PathDE;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Media))
                return false;
            Media other = (Media)obj;

            if (other._x != _x)
                return false;
            else if (other._y != _y)
                return false;
            else if (other._path != _path)
                return false;
            else if (other._pathCAT != _pathCAT)
                return false;
            else if (other._pathEN != _pathEN)
                return false;
            else if (other._pathES != _pathES)
                return false;
            else if (other._pathDE != _pathDE)
                return false;
            else if (other._name != _name)
                return false;
            else if (other._nameCAT != _nameCAT)
                return false;
            else if (other._nameEN != _nameEN)
                return false;
            else if (other._nameES != _nameES)
                return false;
            else if (other._nameDE != _nameDE)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return "Media[X=" + this.X + ", " +
                "Y=" + this.Y + ", " +
                "Nom=" + this.Name + ", " +
                "NomCAT=" + this.NameCAT + ", " +
                "NomEN=" + this.NameEN + ", " +
                "NomES=" + this.NameES + ", " +
                "NomDE=" + this.NameDE + ", " +
                "Type=" + this.Type + ", " +
                "Section=" + this.Section + ", " +
                "Path" + this.Path + ", " +
                "PathCAT" + this.PathCAT + ", " +
                "PathEN" + this.PathEN + ", " +
                "PathES" + this.PathES + ", " +
                "PathDE" + this.PathDE +
                "]";
        }

        #endregion Public Methods

        #region Protected Methods

        protected void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        #endregion Protected Methods
    }
}