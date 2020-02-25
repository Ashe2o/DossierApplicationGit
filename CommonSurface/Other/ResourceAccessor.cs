using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CommonSurface.Other
{
    public static class ResourceAccessor
    {
        #region Public Methods

        /// <summary>
        /// Chargement d'une image présente dans les ressources
        /// </summary>
        /// <param name="path">Uri de l'image</param>
        /// <returns>BitmapImage de la ressource</returns>
        public static BitmapImage loadImage(string path, UriKind kind = UriKind.RelativeOrAbsolute)
        {
            BitmapImage image = new BitmapImage();
            try
            {
                image.BeginInit();
                image.UriSource = new Uri(path, kind);
                image.EndInit();
                return image;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Chargement d'un média (Video ou Photo)
        /// </summary>
        /// <param name="path">Uri de l'image</param>
        /// <returns>MediaElement de la ressource</returns>
        public static MediaElement loadMedia(string path, UriKind kind = UriKind.RelativeOrAbsolute)
        {
            MediaElement media = new MediaElement();
            try
            {
                media.BeginInit();
                media.Source = new Uri(path, kind);
                media.Volume = 0;
                media.EndInit();
                return media;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion Public Methods
    }
}