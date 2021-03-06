using CommonSurface.Other;
using CommonSurface.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Xml;

namespace AppPalaisRois
{
    /// <summary>
    /// Logique d'interaction pour ExpoWindow.xaml
    /// </summary>
    public partial class ExpoWindow : Window
    {
        #region Private Fields

        private string chemin = ConfigurationManager.AppSettings["cheminExpoVirtuelles"];
        private string CheminFondEcranExpo = ConfigurationManager.AppSettings["CheminFondEcranExpo"];
        private string CheminBoutonReturn = ConfigurationManager.AppSettings["CheminBoutonReturn"];
        private DiapoModel diapo = new DiapoModel();
        private ModelExpo ExpoElement = new ModelExpo();
        private int isopen = 0;
        private List<ModelExpo> listeExpo = new List<ModelExpo>();
        /* EFFECTS RESOURCE DICTIONARY */
        private ResourceDictionary myresourcedictionary;
        private Storyboard sbHide;

        #endregion Private Fields

        #region Public Constructors

        public ExpoWindow()
        {
            InitializeComponent();

            // Récupération du retour
            returnExpo.Source = ResourceAccessor.loadImage(CheminBoutonReturn);

            //image de fond
            BitmapDecoder decoder = BitmapDecoder.Create(
                new Uri(CheminFondEcranExpo, UriKind.RelativeOrAbsolute),
                BitmapCreateOptions.PreservePixelFormat,
                BitmapCacheOption.OnLoad);
            ImageBrush brush = new ImageBrush(decoder.Frames[0])
            {
                Stretch = Stretch.Fill
            };
            this.grille.Background = brush;

            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            //pour savoir le nom des elements traité
            string nameElement = "";

            /* EFFECTS RESOURCE DICTIONARY */
            myresourcedictionary = new ResourceDictionary
            {
                Source = new Uri("/CommonSurface;component/XAML/Effects.xaml", UriKind.RelativeOrAbsolute)
            };
            sbHide = myresourcedictionary["hideAnimSec"] as Storyboard;

            bool isDocument = false;
            //chemin vers le fichier xml. peut être mis en relatif
            using (XmlTextReader xmlString = new XmlTextReader(chemin))
            {
                //boucle de lecture du document xml des expos
                while (xmlString.Read())
                {
                    switch (xmlString.NodeType)
                    {
                        case XmlNodeType.Element: // le node est un element
                            nameElement = xmlString.Name; // recuperation de l'element
                            //si l'element est une expo initialisé l'expo
                            if (nameElement == "expo") ExpoElement = new ModelExpo();
                            //si l'element est une diapo changer la fariabla isDocument a true pour l'indiquer
                            if (nameElement == "document")
                            {
                                isDocument = true;
                                diapo = new DiapoModel();
                            }
                            break;

                        case XmlNodeType.Text: //le node est la valeur de l'element
                            //si on est dans une diapo
                            if (isDocument)
                            {
                                //envoie de la fonction de creation d'une diapo
                                FonctionDiapo(xmlString.Value, nameElement);
                            }
                            else //sinon on est dans une expo donc
                            {
                                //envoie de la création d'une expo
                                FonctionExpo(xmlString.Value, nameElement);
                            }
                            break;

                        case XmlNodeType.EndElement: //le node est la fin de l'element
                            //si c'est la fin d'une expo
                            if (xmlString.Name == "expo")
                            {
                                //ajouter l'expo a la liste des expos
                                listeExpo.Add(ExpoElement);
                            }
                            //si c'est la fin d'un document
                            if (xmlString.Name == "document")
                            {
                                //ajouté la diapo a la liste de l'expo actuelle
                                ExpoElement.ListeDiapo.Add(diapo);
                                //changemlent de la variable pour indiquer que la diapo est fini
                                isDocument = false;
                            }

                            break;
                    }
                }

                xmlString.Close();
            }

            //remise dans l'ordre des expos
            List<ModelExpo> listeOrdre = new List<ModelExpo>();
            int num = 1;
            foreach (ModelExpo i in listeExpo)
            {
                //recherche de l'id ordonné
                foreach (ModelExpo h in listeExpo)
                {
                    //si il est correcte ajout a la liste ordonné
                    if (num == h.id)
                    {
                        //initialisation des variables pour ordonner les diapos
                        int numdiapo = 1;
                        List<DiapoModel> listeOrdreDiapo = new List<DiapoModel>();

                        foreach (DiapoModel n in h.ListeDiapo)
                        {
                            //recherche des dipo dans l'ordre
                            foreach (DiapoModel m in h.ListeDiapo)
                            {
                                if (numdiapo == m.id)
                                {
                                    //ajout de la diapo a la liste ordonné
                                    listeOrdreDiapo.Add(m);
                                    break;
                                }
                            }
                            numdiapo++;
                        }

                        //recupération de la liste de diapo
                        h.ListeDiapo = listeOrdreDiapo;

                        //ajout de l'expo a la liste ordonné
                        listeOrdre.Add(h);
                        break;
                    }
                }
                //incrémentation du repère
                num++;
            }
            //redonner une liste ordonné
            listeExpo = listeOrdre;
        }

        #endregion Public Constructors

        #region Public Methods

        //fonction de lecture et de création d'une diapo
        public void FonctionDiapo(string value, string nameElement)
        {
            //le switch envoie la valeur dans la bonne variable selon le nom de l'element
            switch (nameElement)
            {
                case "ID":
                    diapo.id = Int32.Parse(value);
                    break;

                case "element":
                    diapo.element = value;
                    break;

                case "titreFR":
                    diapo.titre = value;
                    break;

                case "textFR":
                    diapo.text = value;
                    break;

                case "textCAT":
                    diapo.textCAT = value;
                    break;

                case "textEN":
                    diapo.textEN = value;
                    break;

                case "textES":
                    diapo.textES = value;
                    break;

                case "textDE":
                    diapo.textDE = value;
                    break;

                case "source":
                    diapo.source = value;
                    break;
            }
        }

        //fonction de lecture et de création d'une expo
        public void FonctionExpo(string value, string nameElement)
        {
            //le switch envoie la valeur dans la bonne variable selon le nom de l'element
            switch (nameElement)
            {
                case "IdExpo":
                    ExpoElement.id = Int32.Parse(value);
                    break;

                case "cover":
                    ExpoElement.cover = value;
                    break;

                case "titre":
                    ExpoElement.titre = value;
                    break;

                case "titreCAT":
                    ExpoElement.titreCAT = value;
                    break;

                case "titreEN":
                    ExpoElement.titreEN = value;
                    break;

                case "titreES":
                    ExpoElement.titreES = value;
                    break;

                case "titreDE":
                    ExpoElement.titreDE = value;
                    break;

                case "text":
                    ExpoElement.text = value;
                    break;

                case "textCAT":
                    ExpoElement.textCAT = value;
                    break;

                case "textEN":
                    ExpoElement.textEN = value;
                    break;

                case "textES":
                    ExpoElement.textES = value;
                    break;

                case "textDE":
                    ExpoElement.textDE = value;
                    break;
            }
        }

        //lancement de l'expo
        public void launchExpo(object sender, EventArgs e)
        {
            if (isopen == 0)
            {
                isopen = 1;
                if (sender is StackPanel)
                {
                    ExpoModel fenetre = new ExpoModel(sender, e);
                    fenetre.Show();
                    this.Close();
                }
            }
        }

        #endregion Public Methods

        #region Protected Methods

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            listeExpo.Clear();
            listeExpo = null;
            ExpoElement = null;
            diapo = null;
            chemin = null;
            sbHide = null;
            myresourcedictionary = null;
        }

        #endregion Protected Methods

        #region Private Methods

        //Création de la liste et du slide du menu expo virtelle
        private void init_MainWindow()
        {
            foreach (ModelExpo j in listeExpo)
            {
                double tailleText;
                //déclaration
                //grid utile
                Grid grid1 = new Grid();
                Grid grid2 = new Grid();
                Grid grid3 = new Grid();
                Grid grid4 = new Grid();
                Grid grid6 = new Grid();
                Grid grid7 = new Grid();

                //texte boxe pour la description
                TextBlock textblocktitle = new TextBlock();
                TextBlock textblocktext = new TextBlock();

                //element a ajouté a la liste qui contient tous les elements
                StackPanel stack = new StackPanel();

                //media element au centre du cadre
                MediaElement imgB2 = new MediaElement();

                //image de fond de cadre
                Image imgGrey3 = new Image();
                Image imgBlanc = new Image();

                //caractéristique de l'élément
                stack.Orientation = Orientation.Horizontal;
                stack.Height = 400;
                stack.Width = 850;

                //evenement de clique et touche et récupération de l'image
                imgB2.BeginInit();
                imgB2.Source = new Uri(j.cover, UriKind.RelativeOrAbsolute);
                imgB2.HorizontalAlignment = HorizontalAlignment.Center;
                imgB2.VerticalAlignment = VerticalAlignment.Center;
                imgB2.Margin = new Thickness(20, 20, 20, 20);
                imgB2.Height = 400;
                imgB2.Width = 450;
                imgB2.Volume = 0;
                imgB2.MediaEnded += new RoutedEventHandler(Media_Ended);
                imgB2.EndInit();

                //récupération de l'image fond cadre1
                imgGrey3.Source = ResourceAccessor.loadImage(ConfigurationManager.AppSettings["CheminFondExpoCadre"]); 
                imgGrey3.Height = 400;
                imgGrey3.HorizontalAlignment = HorizontalAlignment.Center;
                imgGrey3.VerticalAlignment = VerticalAlignment.Center;

                //récupération de l'image fond cadre3 collé a l'element
                imgBlanc.Source = ResourceAccessor.loadImage(ConfigurationManager.AppSettings["CheminFondExpoCadreInterieur"]);
                imgBlanc.Width = 850;
                imgBlanc.Height = 400;
                imgBlanc.HorizontalAlignment = HorizontalAlignment.Center;
                imgBlanc.VerticalAlignment = VerticalAlignment.Center;

                //Cadre de l'image
                grid3.Visibility = Visibility.Visible;
                grid3.Height = 400;
                grid3.Width = 850;
                grid4.Margin = new Thickness(20, 20, 20, 20);
                grid4.Visibility = Visibility.Visible;

                //Caractéristique du texte : titre
                textblocktitle.Visibility = Visibility.Visible;
                textblocktitle.FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Luciole");
                textblocktitle.FontSize = 18;
                textblocktitle.Foreground = new SolidColorBrush(Colors.White);

                //Affichage du Titre en fonction de la Langue
                switch (MainWindow.selectedLanguage)
                {
                    case "French":
                        textblocktitle.Text = j.titre;
                        break;
                    case "Catalan":
                        if (j.titreCAT != null)
                        {
                            textblocktitle.Text = j.titreCAT;
                        }else{
                            textblocktitle.Text = j.titre;
                        }
                        break;
                    case "English":
                        if (j.titreEN != null)
                        {
                            textblocktitle.Text = j.titreEN;
                        }else{
                            textblocktitle.Text = j.titre;
                        }
                        break;
                    case "Spanish":
                        if (j.titreES != null){
                            textblocktitle.Text = j.titreES;
                        }else{
                            textblocktitle.Text = j.titre;
                        }
                        break;
                    case "German":
                        if (j.titreDE != null){
                            textblocktitle.Text = j.titreDE;
                        }else{
                            textblocktitle.Text = j.titre;
                        }
                        break;
                }
                                
                textblocktitle.Margin = new Thickness(0, 0, 0, 30);
                textblocktitle.HorizontalAlignment = HorizontalAlignment.Center;
                textblocktitle.VerticalAlignment = VerticalAlignment.Top;
                textblocktitle.TextAlignment = TextAlignment.Center;
                textblocktitle.TextWrapping = TextWrapping.WrapWithOverflow;
                //Paragraphe
                textblocktext.Visibility = Visibility.Visible;
                textblocktext.FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Luciole");
                textblocktext.FontSize = 12;
                textblocktext.Foreground = new SolidColorBrush(Colors.White);

                //Affichage du Texte en fonction de la Langue
                switch(MainWindow.selectedLanguage)
                {
                    case "French":
                        textblocktext.Text = j.text;
                    break;
                    case "Catalan":
                        if (j.textCAT != null)
                        {
                            textblocktext.Text = j.textCAT;
                        }else{
                            textblocktext.Text = j.text;
                        }
                    break;
                    case "English":
                        if (j.textEN != null)
                        {
                            textblocktext.Text = j.textEN;
                        }else{
                            textblocktext.Text = j.text;
                        }
                    break;
                    case "Spanish":
                        if (j.textES != null)
                        {
                            textblocktext.Text = j.textES;
                        }else{
                            textblocktext.Text = j.text;
                        }
                    break;
                    case "German":
                        if (j.textDE != null){
                            textblocktext.Text = j.textDE;
                        }else{
                            textblocktext.Text = j.text;
                        }
                        break;
                }
                textblocktext.Margin = new Thickness(0, 30, 0, 0);
                textblocktext.HorizontalAlignment = HorizontalAlignment.Center;
                textblocktext.VerticalAlignment = VerticalAlignment.Bottom;
                textblocktext.TextAlignment = TextAlignment.Center;
                textblocktext.TextWrapping = TextWrapping.WrapWithOverflow;

                //déterminer la taille maximum du text
                if (textblocktitle.Width >= textblocktext.Width)
                {
                    tailleText = textblocktitle.Width;
                }
                else
                {
                    tailleText = textblocktext.Width;
                }

                //cadre du texte
                grid1.Visibility = Visibility.Visible;
                grid2.Visibility = Visibility.Visible;
                grid2.HorizontalAlignment = HorizontalAlignment.Center;
                grid2.VerticalAlignment = VerticalAlignment.Center;
                grid2.Margin = new Thickness(20, 20, 20, 10);
                grid7.Visibility = Visibility.Visible;
                grid7.HorizontalAlignment = HorizontalAlignment.Center;
                grid7.VerticalAlignment = VerticalAlignment.Top;
                grid7.Margin = new Thickness(20, 10, 20, 20);
                grid6.Visibility = Visibility.Visible;
                grid6.Width = grid3.Width;
                grid6.Height = textblocktitle.Height + textblocktext.Height;
                grid6.HorizontalAlignment = HorizontalAlignment.Center;
                grid6.VerticalAlignment = VerticalAlignment.Bottom;
                grid6.Margin = new Thickness(0, 0, 0, -100);
                grid6.Background = new SolidColorBrush(Colors.Transparent);

                //assemblement de l'élément
                grid1.Children.Add(grid6);
                grid6.Children.Add(grid2);
                grid6.Children.Add(grid7);
                grid7.Children.Add(textblocktitle);
                grid2.Children.Add(textblocktext);
                grid3.Children.Add(imgGrey3);
                grid3.Children.Add(grid4);
                grid4.Children.Add(imgBlanc);
                grid4.Children.Add(imgB2);
                grid3.Children.Add(grid1);
                stack.Children.Add(grid3);

                //détection de la selection
                stack.MouseUp += (sender, e) => launchExpo(sender, e);
                stack.TouchDown += (sender, e) => launchExpo(sender, e);

                stack.Name = "stack" + j.id;

                //envoie de l'élément
                main_photos_slider.Items.Add(stack);
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            init_MainWindow();
        }

        //A la fin de la video la relancer
        private void Media_Ended(object sender, RoutedEventArgs e)
        {
            if (sender is MediaElement)
            {
                MediaElement media = (MediaElement)sender;
                media.LoadedBehavior = MediaState.Manual;
                media.Position = new TimeSpan(0, 0, 0);
                media.Play();
            }
        }

        //bouton retour et fermeture de cette fenetre
        private void Quit_button_Click(object sender, RoutedEventArgs e)
        {
            //Effet de fermeture
            Storyboard.SetTarget(sbHide, grille);
            sbHide.Completed += (s, t) =>
            {
                //Fermeture et ouverture des fenetres
                MainWindow fenetre = new MainWindow();
                fenetre.Show();
                this.Close();
            };
            sbHide.Begin();
        }

        #endregion Private Methods

        private void Quit_button_Click(object sender, System.Windows.Input.TouchEventArgs e)
        {
            //Effet de fermeture
            Storyboard.SetTarget(sbHide, grille);
            sbHide.Completed += (s, t) =>
            {
                //Fermeture et ouverture des fenetres
                MainWindow fenetre = new MainWindow();
                fenetre.Show();
                this.Close();
            };
            sbHide.Begin();
        }
    }
}