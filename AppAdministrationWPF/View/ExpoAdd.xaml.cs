using AppAdministrationWPF.ViewModel;
using CommonSurface.Model;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Windows;
using System.Xml;

namespace AppAdministrationWPF.View
{
    public partial class ExpoAdd : Window
    {
        #region Private Fields

        private MediaDialogModel _viewModel;
        private string chemin = ConfigurationManager.AppSettings["cheminExpoVirtuelles"];
        private AdminMediathequeView lastPage;

        private int maxId;

        private int modifAdd; //Permet de savoir si on modifie ou si on ajoute: [1] = Modifier | [0] = Ajouter

        #endregion Private Fields

        #region Public Constructors

        public ExpoAdd(int modifOrAdd, int idMax, MediaDialogModel viewModel, AdminMediathequeView page)
        {
            InitializeComponent();
            ViewModel = viewModel;

            //Permet de tester si c'est une modification ou un ajout pour recupérer ou non les données existantes
            if (modifOrAdd != 0)
            {
                //récupération du document xml
                XmlDocument doc = new XmlDocument();
                doc.Load(chemin);
                XmlNodeList nodeList = doc.SelectNodes("descendant::listExpo/expo[IdExpo='" + modifOrAdd + "']");
                foreach (XmlNode xn in nodeList)
                {
                    //Récuperation de toute les anciennes données
                    ViewModel.Path = xn["cover"].InnerText;
                    txtNameFR.Text = xn["titre"].InnerText;
                    DescriptionFR.Text = xn["text"].InnerText;
                    //Récupération des traductions seulement si elles existent
                    if (xn["titreCAT"] != null) { txtNameCAT.Text = xn["titreCAT"].InnerText; }
                    if (xn["textCAT"] != null) { DescriptionCAT.Text = xn["textCAT"].InnerText;}
                    if (xn["titreEN"] != null) { txtNameEN.Text = xn["titreEN"].InnerText; }
                    if (xn["textEN"] != null) { DescriptionEN.Text = xn["textEN"].InnerText; }
                    if (xn["titreES"] != null) { txtNameES.Text = xn["titreES"].InnerText; }
                    if (xn["textES"] != null) { DescriptionES.Text = xn["textES"].InnerText; }
                    if (xn["titreDE"] != null) { txtNameDE.Text = xn["titreDE"].InnerText; }
                    if (xn["textDE"] != null) { DescriptionDE.Text = xn["textDE"].InnerText; }
                }
            }
            modifAdd = modifOrAdd;
            lastPage = page;
            maxId = idMax;
            DataContext = ViewModel;
        }

        #endregion Public Constructors

        #region Public Properties

        public Media Selected
        {
            get { return _viewModel.Selected; }
            set { _viewModel.Selected = value; }
        }

        public MediaDialogModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }

        #endregion Public Properties

        #region Private Methods

        //Bouton de fermeture
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            //Récupération du document xml
            XmlDocument doc = new XmlDocument();
            doc.Load(chemin);
            if (modifAdd == 0)
            {
                //Ajouter une expo
                XmlNode node = doc.DocumentElement;

                //Ajout de tous les noeuds
                XmlElement newNode = doc.CreateElement("expo");

                XmlNode IdExpoNode = doc.CreateElement("IdExpo");

                IdExpoNode.InnerText = "" + (maxId + 1);

                XmlNode coverNode = doc.CreateElement("cover");

                coverNode.InnerText = txtPath.Text;

                XmlNode titreNodeFR = doc.CreateElement("titre");

                titreNodeFR.InnerText = txtNameFR.Text;

                XmlNode textNodeFR = doc.CreateElement("text");

                textNodeFR.InnerText = DescriptionFR.Text;

                XmlNode titreNodeCAT = doc.CreateElement("titreCAT");

                titreNodeCAT.InnerText = txtNameCAT.Text;

                XmlNode textNodeCAT = doc.CreateElement("textCAT");

                textNodeCAT.InnerText = DescriptionCAT.Text;

                XmlNode titreNodeEN = doc.CreateElement("titreEN");

                titreNodeEN.InnerText = txtNameEN.Text;

                XmlNode textNodeEN = doc.CreateElement("textEN");

                textNodeEN.InnerText = DescriptionFR.Text;

                XmlNode titreNodeES = doc.CreateElement("titreES");

                titreNodeES.InnerText = txtNameES.Text;

                XmlNode textNodeES = doc.CreateElement("textES");

                textNodeES.InnerText = DescriptionES.Text;

                XmlNode titreNodeDE = doc.CreateElement("titreDE");

                titreNodeDE.InnerText = txtNameES.Text;

                XmlNode textNodeDE = doc.CreateElement("textDE");

                textNodeDE.InnerText = DescriptionDE.Text;

                XmlNode numberDiapo = doc.CreateElement("numberDiapo");

                numberDiapo.InnerText = "0";

                XmlNode contenuNode = doc.CreateElement("contenu");

                //Emboitement de tous les noeuds
                newNode.AppendChild(IdExpoNode);

                newNode.AppendChild(coverNode);

                newNode.AppendChild(titreNodeFR);

                newNode.AppendChild(textNodeFR);

                newNode.AppendChild(titreNodeCAT);

                newNode.AppendChild(textNodeCAT);

                newNode.AppendChild(titreNodeEN);

                newNode.AppendChild(textNodeEN);

                newNode.AppendChild(titreNodeES);

                newNode.AppendChild(textNodeES);

                newNode.AppendChild(titreNodeDE);

                newNode.AppendChild(textNodeDE);

                newNode.AppendChild(numberDiapo);

                newNode.AppendChild(contenuNode);

                node.AppendChild(newNode);

                modifAdd = maxId + 1;
            }
            else
            {
                //Modifier une expo
                XmlNodeList nodeList = doc.SelectNodes("descendant::listExpo/expo[IdExpo='" + modifAdd + "']");
                foreach (XmlNode xn in nodeList)
                {
                    // On vérifie si l'expo possède un titre par langue, dans le cas contraire, on créé les clés correspondante
                    if (xn["titreCAT"] == null) { XmlNode newElem = doc.CreateNode("element","titreCAT",""); xn.AppendChild(newElem); }
                    if (xn["textCAT"] == null) { XmlNode newElem = doc.CreateNode("element", "textCAT", ""); xn.AppendChild(newElem); }
                    if (xn["titreEN"] == null) { XmlNode newElem = doc.CreateNode("element", "titreEN", ""); xn.AppendChild(newElem); }
                    if (xn["textEN"] == null) { XmlNode newElem = doc.CreateNode("element", "textEN", ""); xn.AppendChild(newElem); }
                    if (xn["titreES"] == null) { XmlNode newElem = doc.CreateNode("element", "titreES", ""); xn.AppendChild(newElem); }
                    if (xn["textES"] == null) { XmlNode newElem = doc.CreateNode("element", "textES", ""); xn.AppendChild(newElem); }
                    if (xn["titreDE"] == null) { XmlNode newElem = doc.CreateNode("element", "titreDE", ""); xn.AppendChild(newElem); }
                    if (xn["textDE"] == null) { XmlNode newElem = doc.CreateNode("element", "textDE", ""); xn.AppendChild(newElem); }

                    // Modification de tous les element de l'expo
                    xn["cover"].InnerText = txtPath.Text;
                    xn["titre"].InnerText = txtNameFR.Text;
                    xn["text"].InnerText = DescriptionFR.Text;
                    xn["titreCAT"].InnerText = txtNameCAT.Text;
                    xn["textCAT"].InnerText = DescriptionCAT.Text;
                    xn["titreEN"].InnerText = txtNameEN.Text;
                    xn["textEN"].InnerText = DescriptionEN.Text;
                    xn["titreES"].InnerText = txtNameES.Text;
                    xn["textES"].InnerText = DescriptionES.Text;
                    xn["titreDE"].InnerText = txtNameDE.Text;
                    xn["textDE"].InnerText = DescriptionDE.Text;

                }
            }
            //Sauvegarde et lecture de la liste
            doc.Save(chemin);

            //Recharge la page avec les modifications
            lastPage.rest();
            lastPage.launchExpo2(modifAdd);

            Close();
        }

        private void btOpen_Click(object sender, RoutedEventArgs e)
        {
            //Ouverture de la fenêtre de recherche de fichier sur des fichiers video image ou panorama
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Videos(*.mov, *.wmv, *.mp4)|*.mov;*.wmv;*.mp4|Photos (*.jpg, *.png)|*.jpg;*.png|Photos & Videos|*.mov;*.wmv;*.jpg;*.png; *.mp4; *.*";
            fileDialog.FilterIndex = 4;
            fileDialog.Multiselect = false;
            Nullable<bool> result = fileDialog.ShowDialog();
            if (result == true)
            {
                //Ajouter les données à la fenêtre
                ViewModel.Path = fileDialog.FileName;
            }
        }

        #endregion Private Methods

        private void LangageType_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //On masque toutes les cases et labels de toutes les langues.
            lblNameFR.Visibility = Visibility.Hidden;
            lblDescriptionFR.Visibility = Visibility.Hidden;
            txtNameFR.Visibility = Visibility.Hidden;
            DescriptionFR.Visibility = Visibility.Hidden;

            lblNameCAT.Visibility = Visibility.Hidden;
            lblDescriptionCAT.Visibility = Visibility.Hidden;
            txtNameCAT.Visibility = Visibility.Hidden;
            DescriptionCAT.Visibility = Visibility.Hidden;

            lblNameEN.Visibility = Visibility.Hidden;
            lblDescriptionEN.Visibility = Visibility.Hidden;
            txtNameEN.Visibility = Visibility.Hidden;
            DescriptionEN.Visibility = Visibility.Hidden;

            lblNameES.Visibility = Visibility.Hidden;
            lblDescriptionES.Visibility = Visibility.Hidden;
            txtNameES.Visibility = Visibility.Hidden;
            DescriptionES.Visibility = Visibility.Hidden;

            lblNameDE.Visibility = Visibility.Hidden;
            lblDescriptionDE.Visibility = Visibility.Hidden;
            txtNameDE.Visibility = Visibility.Hidden;
            DescriptionDE.Visibility = Visibility.Hidden;

            switch (((System.Windows.Controls.ContentControl)((System.Windows.Controls.Primitives.Selector)sender).SelectedItem).Content)
            {
                //On affiche les cases et labels correspondants à la langues sélectionné dans le menu déroulant
                case "FR":
                case null:
                    lblNameFR.Visibility = Visibility.Visible;
                    lblDescriptionFR.Visibility = Visibility.Visible;
                    txtNameFR.Visibility = Visibility.Visible;
                    DescriptionFR.Visibility = Visibility.Visible;
                    break;
                case "CAT":
                    lblNameCAT.Visibility = Visibility.Visible;
                    lblDescriptionCAT.Visibility = Visibility.Visible;
                    txtNameCAT.Visibility = Visibility.Visible;
                    DescriptionCAT.Visibility = Visibility.Visible;
                    break;
                case "EN":
                    lblNameEN.Visibility = Visibility.Visible;
                    lblDescriptionEN.Visibility = Visibility.Visible;
                    txtNameEN.Visibility = Visibility.Visible;
                    DescriptionEN.Visibility = Visibility.Visible;
                    break;
                case "ES":
                    lblNameES.Visibility = Visibility.Visible;
                    lblDescriptionES.Visibility = Visibility.Visible;
                    txtNameES.Visibility = Visibility.Visible;
                    DescriptionES.Visibility = Visibility.Visible;
                    break;
                case "DE":
                    lblNameDE.Visibility = Visibility.Visible;
                    lblDescriptionDE.Visibility = Visibility.Visible;
                    txtNameDE.Visibility = Visibility.Visible;
                    DescriptionDE.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}