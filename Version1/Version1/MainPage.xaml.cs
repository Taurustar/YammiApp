using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Version1.Resources;

namespace Version1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            btnFlipTile_Click();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }


        private void btnFlipTile_Click()
        {
            // find the tile object for the application tile that using "flip" contains string in it.
            ShellTile oTile = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("flip".ToString()));


            if (oTile != null && oTile.NavigationUri.ToString().Contains("flip"))
            {
                FlipTileData oFliptile = new FlipTileData();
                oFliptile.Title = "";
                oFliptile.Count = 0;
                oFliptile.BackTitle = "YAMI";

                oFliptile.BackContent = "";
                oFliptile.WideBackContent = "Elige tus Frutas Frescas";

                oFliptile.SmallBackgroundImage = new Uri("Assets/LosTiles/chico.png", UriKind.Relative);
                oFliptile.BackgroundImage = new Uri("Assets/LosTiles/medio3.png", UriKind.Relative);
                oFliptile.WideBackgroundImage = new Uri("Assets/LosTiles/grande.png", UriKind.Relative);

                oFliptile.BackBackgroundImage = new Uri("/Assets/LosTiles/medio2.png", UriKind.Relative);
                oFliptile.WideBackBackgroundImage = new Uri("/Assets/LosTiles/grande2.png", UriKind.Relative);

                //oFliptile.BackBackgroundImage = new Uri("/Assets/LosTiles/medio1.png", UriKind.Relative);
                oTile.Update(oFliptile);
                //MessageBox.Show("Flip Tile Data successfully update.");
            }
            else
            {
                // once it is created flip tile
                Uri tileUri = new Uri("/MainPage.xaml?tile=flip", UriKind.Relative);
                ShellTileData tileData = this.CreateFlipTileData();
                ShellTile.Create(tileUri, tileData, true);
            }
        }

        private ShellTileData CreateFlipTileData()
        {
            return new FlipTileData()
            {
                Title = "YAMI",
                BackTitle = "frutas ricas",
                BackContent = "Live Tile Demo",
                WideBackContent = "Hello Nokia Lumia 920",
                Count = 8,
                SmallBackgroundImage = new Uri("/Assets/Tiles/FlipCycleTileSmall.png", UriKind.Relative),
                BackgroundImage = new Uri("/Assets/Tiles/FlipCycleTileMedium.png", UriKind.Relative),
                WideBackgroundImage = new Uri("/Assets/Tiles/FlipCycleTileLarge.png", UriKind.Relative),
            };
        }


        private void irATomate(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tomate.xaml", UriKind.Relative));
        }

        private void irAMelon(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Melon.xaml", UriKind.Relative));
        }

        private void irASandia(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sandia.xaml", UriKind.Relative));
        }

        private void irAPalta(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Palta.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}