using AppPalaisRois.ViewModel;
using CommonSurface.Model;
using CommonSurface.Other;
using FluidKit.Controls;
using Microsoft.Surface.Presentation.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Input;

namespace AppPalaisRois
{
    public partial class AppSgraffitoMainView : Window
    {
        #region Private Fields
        private AppSgraffitoMainViewModel ViewModel;
        private string CheminBoutonReturn = ConfigurationManager.AppSettings["CheminBoutonReturn"];
        private string CheminBoutonReset = ConfigurationManager.AppSettings["CheminBoutonResetSgraffito"];
        //private string BackgroundSgraffito = "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_FR.jpg";
        private float penWidth = 5;
        Bitmap image1;
        BitmapImage bitmapImage;
        List<System.Drawing.Point> currentLine = new List<System.Drawing.Point>();
        #endregion Private Fields

        #region Public Constructors

        public AppSgraffitoMainView()
        {
            InitializeComponent();

            ViewModel = new AppSgraffitoMainViewModel();
            this.DataContext = ViewModel;
            returnSgraffito.Source = ResourceAccessor.loadImage(CheminBoutonReturn);
            ImageResetSgraffito.Source = ResourceAccessor.loadImage(CheminBoutonReset);

            SelectBackground();
            cb_clear_Click(null, null);
            image_WPF.MouseMove += pictureBox1_MouseMove;
            image_WPF.MouseDown += pictureBox1_MouseDown;
            image_WPF.MouseUp += pictureBox1_MouseUp;
        }

        #endregion Public Constructors

        #region Private Destructors

        ~AppSgraffitoMainView()
        {
            ViewModel = null;
            currentLine.Clear();
        }

        #endregion Private Destructors

        

        #region Protected Methods

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            DataContext = null;
            ViewModel = null;
        }

        #endregion Protected Methods

        #region Events

        //Bouton de fermeture et ouverture du menu principale
        private void BoutonQuit_click(object sender, RoutedEventArgs e)
        {
            //Fermeture et ouverture des fenetres
            MainWindow fenetre = new MainWindow();
            fenetre.Show();
            this.Close();

        }


        #endregion Events

        #region Private Methods
        /// <summary>
        // Fonction qui initialise notre image source avec un bitmap, la fonction remet à zero notre liste de point egalement.
        /// </summary>
        private void ClearSheet()
        {
            image1 = new Bitmap(@"C:\Session Grand Public\Données\Administrateur\Application Public\Fond d'ecran\Sgraffito\couche.png", true);
            // Set the image source.
            using (MemoryStream memory = new MemoryStream())
            {
                image1.Save(memory, ImageFormat.Png);
                memory.Position = 0;
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                image_WPF.Source = bitmapImage;
            }
            currentLine.Clear();
        }
        private void SelectBackground()
        {
            switch (MainWindow.selectedLanguage)
            {
                case "French":
                    // Background FR
                    ImageBrush myBrushFR = new ImageBrush();
                    System.Windows.Controls.Image imageFR = new System.Windows.Controls.Image();
                    imageFR.Source = new BitmapImage(
                        new Uri(
                           "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_FR.jpg"));
                    myBrushFR.ImageSource = imageFR.Source;
                    SgraffitoPanel.Background = myBrushFR;
                    break;
                case "Catalan":
                    // Background CAT
                    ImageBrush myBrushCAT = new ImageBrush();
                    System.Windows.Controls.Image imageCAT = new System.Windows.Controls.Image();
                    if (File.Exists("C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_CAT.jpg"))
                    {
                        imageCAT.Source = new BitmapImage(
                        new Uri(
                           "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_CAT.jpg"));
                        myBrushCAT.ImageSource = imageCAT.Source;
                        SgraffitoPanel.Background = myBrushCAT;
                    }
                    else
                    {
                        ImageBrush myBrushDefault = new ImageBrush();
                        System.Windows.Controls.Image imageDefault = new System.Windows.Controls.Image();
                        imageDefault.Source = new BitmapImage(
                            new Uri(
                               "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_FR.jpg"));
                        myBrushDefault.ImageSource = imageDefault.Source;
                        SgraffitoPanel.Background = myBrushDefault;
                    }
                    break;
                case "English":
                    // Background EN
                    ImageBrush myBrushEN = new ImageBrush();
                    System.Windows.Controls.Image imageEN = new System.Windows.Controls.Image();
                    if (File.Exists("C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_EN.jpg"))
                    {
                        imageEN.Source = new BitmapImage(
                        new Uri(
                           "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_EN.jpg"));
                        myBrushEN.ImageSource = imageEN.Source;
                        SgraffitoPanel.Background = myBrushEN;
                    }
                    else
                    {
                        ImageBrush myBrushDefault = new ImageBrush();
                        System.Windows.Controls.Image imageDefault = new System.Windows.Controls.Image();
                        imageDefault.Source = new BitmapImage(
                            new Uri(
                               "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_FR.jpg"));
                        myBrushDefault.ImageSource = imageDefault.Source;
                        SgraffitoPanel.Background = myBrushDefault;
                    }
                    break;
                case "Spanish":
                    // Background ES
                    ImageBrush myBrushES = new ImageBrush();
                    System.Windows.Controls.Image imageES = new System.Windows.Controls.Image();
                    if (File.Exists("C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_ES.jpg"))
                    {
                        imageES.Source = new BitmapImage(
                        new Uri(
                           "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_ES.jpg"));
                        myBrushES.ImageSource = imageES.Source;
                        SgraffitoPanel.Background = myBrushES;
                    }
                    else
                    {
                        ImageBrush myBrushDefault = new ImageBrush();
                        System.Windows.Controls.Image imageDefault = new System.Windows.Controls.Image();
                        imageDefault.Source = new BitmapImage(
                            new Uri(
                               "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_FR.jpg"));
                        myBrushDefault.ImageSource = imageDefault.Source;
                        SgraffitoPanel.Background = myBrushDefault;
                    }
                    break;
                case "German":
                    // Background DE
                    ImageBrush myBrushDE = new ImageBrush();
                    System.Windows.Controls.Image imageDE = new System.Windows.Controls.Image();
                    if (File.Exists("C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_DE.jpg"))
                    {
                        imageDE.Source = new BitmapImage(
                        new Uri(
                           "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_DE.jpg"));
                        myBrushDE.ImageSource = imageDE.Source;
                        SgraffitoPanel.Background = myBrushDE;
                    }
                    else
                    {
                        ImageBrush myBrushDefault = new ImageBrush();
                        System.Windows.Controls.Image imageDefault = new System.Windows.Controls.Image();
                        imageDefault.Source = new BitmapImage(
                            new Uri(
                               "C:/Session Grand Public/Données/Administrateur/Application Public/Fond d'ecran/Sgraffito/arriere_plan_FR.jpg"));
                        myBrushDefault.ImageSource = imageDefault.Source;
                        SgraffitoPanel.Background = myBrushDefault;
                    }
                    break;
            }
        }

        private void cb_clear_Click(object sender, EventArgs e)
        {
            ClearSheet();
        }
        /// <summary>
        //Fonction qui permet de dessiner sur notre bitmap, le principe est qu'on dessine avec une couleur transparente puis rend transparent tous ce qui est dessiner avec la couleur transparente. (seule methode trouve pour rendre transparent une image)
        /// </summary>
        void drawIntoImage()
        {
            using (Graphics G = Graphics.FromImage(image1))
            {
                // we want the tranparency to copy over the black pixels
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                G.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                using (System.Drawing.Pen somePen = new System.Drawing.Pen(System.Drawing.Color.Transparent, penWidth))

                {
                    somePen.MiterLimit = penWidth / 2;
                    somePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    somePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                    somePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    if (currentLine.Count > 1)
                        G.DrawCurve(somePen, currentLine.ToArray());
                    image1.MakeTransparent(System.Drawing.Color.Transparent);
                }

            }
            // On initialise la source de notre image avec le bitmap sur lequel on dessine
            using (MemoryStream memory = new MemoryStream())
            {
                image1.Save(memory, ImageFormat.Png);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                image_WPF.Source = bitmapImage;
            }
        }

        //Event Mouse qui initialise une liste de point quand on click sur notre image puis dessine avec drawIntoImage.
        private void pictureBox1_MouseDown(object sender, System.Windows.Input.MouseEventArgs e)
        {
            currentLine.Add(new System.Drawing.Point(Convert.ToInt32(((e.MouseDevice.GetPosition(image_WPF).X)) * bitmapImage.PixelWidth / image_WPF.ActualWidth), Convert.ToInt32((e.MouseDevice.GetPosition(image_WPF).Y) * bitmapImage.PixelHeight / image_WPF.ActualHeight)));
            drawIntoImage();
        }

        //Event Mouse qui initialise une liste de point quand on bouge la souris sur notre image puis dessine avec drawIntoImage.
        private void pictureBox1_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                currentLine.Add(new System.Drawing.Point(Convert.ToInt32(((e.MouseDevice.GetPosition(image_WPF).X)) * bitmapImage.PixelWidth / image_WPF.ActualWidth), Convert.ToInt32((e.MouseDevice.GetPosition(image_WPF).Y) * bitmapImage.PixelHeight / image_WPF.ActualHeight)));
                drawIntoImage();
            }
        }

        //Fonction qui remet a zero la liste de point quand l utilisateur relache le bouton droit de la souris
        private void pictureBox1_MouseUp(object sender, System.Windows.Input.MouseEventArgs e)
        {
            currentLine.Clear();
        }
        #endregion Private Methods
    }
}