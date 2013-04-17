using System.Windows;
using System.Windows.Controls.Primitives;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using Wp7Shared.Helpers;
using System.Collections.Generic;
using Microsoft.Phone.Reactive;
using System.Linq;
using System;
using System.Windows.Media.Imaging;
using System.Threading;

namespace Wp7Shared.UserControls
{
    public partial class OtherApps
    {

        //Dictionary<string, Guid> _appsGuid = new Dictionary<string, Guid>();
        private string _curApp = string.Empty;
        private List<MyHubTile> _knownApps = new List<MyHubTile>();

        public OtherApps()
        {
            InitializeComponent();

            //foreach (var item in currentCultureSupportedApps)
            //{
            //    mainPanel.Children.Add(item);
            //    item.Tap -= new EventHandler<System.Windows.Input.GestureEventArgs>(HubTile_Tap);
            //    item.Tap += new EventHandler<System.Windows.Input.GestureEventArgs>(HubTile_Tap);
            //}

            //<toolkit:HubTile Height="175" Width="175" Tag="Memessenger" Source="../Resources/Memessenger.png" Title="Memessenger" FontSize="12" Message="La miglior app di memessenging al mondo!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="Pingu" Source="../Resources/Pingu.png" Title="Pingu" FontSize="12" Message="Benvenuti nel fantastico mondo di Pingu!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="BanfiHits" Source="../Resources/BanfiHits.png" Title="BanfiHits" Message="Le migliori frasi del grande Lino Banfi!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="PozzettoHits" Source="../Resources/PozzettoHits.png" Title="PozzettoHits" Message="Le migliori battute di Renato Pozzetto!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="MonnezzaHits"  Source="../Resources/MonnezzaHits.png" Title="MonnezzaHits" Message="Le migliori battute der Monnezza!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="MusicStation" Source="../Resources/MusicStation.png" Title="MusicStation" FontSize="12" Message="L'app definitiva per i compositori!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="ScaleFinder" Source="../Resources/ScaleFinder.png" Title="ScaleFinder" Message="Cerca scale, accordi, e molto di più!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="TempoStation" Source="../Resources/TempoStation.png" Title="TempoStation" Message="Un preciso metronomo, completamente configurabile" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="Etymos" Source="../Resources/Etymos.png" Title="Etymos" Message="Scopri l'etimologia delle parole!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="IgnazioHits"  Source="../Resources/IgnazioHits.png" Title="IgnazioHits" Message="Le migliori battute di Ignazio la Russa!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            //<toolkit:HubTile Height="175" Width="175" Tag="DeveloperExcuses" Source="../Resources/DeveloperExcuses.png" Title="DeveloperExcuses" Message="Il migliore tool anti-bug al mondo!" Tap="HubTile_Tap" Style="{StaticResource HubTileStyle1}" GroupTag="apps"></toolkit:HubTile>
            InitApps();
        }

        private void InitApps()
        {
            _knownApps = new List<MyHubTile>() {
                        new MyHubTile()
                        {
                            Tag = "Memessenger",
                            SupportedCultures = new List<string>() { "it", "en" },
                            Guid = new Guid("c53e39aa-9248-466b-aaab-78931c23c158"),
                            Height = 175,
                            Width = 175,
                            Title = "Memessenger",
                            Source = new BitmapImage(new Uri("../Resources/Memessenger.png", UriKind.Relative)),
                            FontSize = 12,
                            Style = (Style)this.Resources["HubTileStyle1"],
                            GroupTag = "apps"
                        },
                        new MyHubTile()
                        {
                            Tag = "Pingu",
                            SupportedCultures = new List<string>() { "it", "en", "pt" },
                            Guid = new Guid("8ead178a-a84e-48d9-9e4b-4a8f4f7860e9"),
                            Height = 175,
                            Width = 175,
                            Title = "Pingu",
                            Source = new BitmapImage(new Uri("../Resources/Pingu.png", UriKind.Relative)),
                            FontSize = 12,
                            Style = (Style)this.Resources["HubTileStyle1"],
                            GroupTag = "apps"
                        },
                        new MyHubTile()
                        {
                            Tag = "BanfiHits",
                            SupportedCultures = new List<string>() { "it" },
                            Guid = new Guid("eedf562f-c645-4a75-8222-92df4c0035fd"),
                            Height = 175,
                            Width = 175,
                            Title = "BanfiHits",
                            Source = new BitmapImage(new Uri("../Resources/BanfiHits.png", UriKind.Relative)),
                            FontSize = 12,
                            Style = (Style)this.Resources["HubTileStyle1"],
                            GroupTag = "apps"
                        },
                        new MyHubTile()
                        {
                            Tag = "PozzettoHits",
                            SupportedCultures = new List<string>() { "it" },
                            Guid = new Guid("eeb4cba4-f648-4409-9e66-550651b879e1"),
                            Height = 175,
                            Width = 175,
                            Title = "PozzettoHits",
                            Source = new BitmapImage(new Uri("../Resources/PozzettoHits.png", UriKind.Relative)),
                            FontSize = 12,
                            Style = (Style)this.Resources["HubTileStyle1"],
                            GroupTag = "apps"
                        },
                        new MyHubTile()
                        {
                            Tag = "MonnezzaHits",
                            SupportedCultures = new List<string>() { "it" },
                            Guid = new Guid("9a29f30b-0f15-482d-b383-a3b120daa28e"),
                            Height = 175,
                            Width = 175,
                            Title = "MonnezzaHits",
                            Source = new BitmapImage(new Uri("../Resources/MonnezzaHits.png", UriKind.Relative)),
                            FontSize = 12,
                            Style = (Style)this.Resources["HubTileStyle1"],
                            GroupTag = "apps"
                        },
                        new MyHubTile()
                        {
                            Tag = "MusicStation",
                            SupportedCultures = new List<string>() { "it", "en", "es" },
                            Guid = new Guid("b9298255-f2a4-4dc5-afc1-568cb4413e03"),
                            Height = 175,
                            Width = 175,
                            Title = "MusicStation",
                            Source = new BitmapImage(new Uri("../Resources/MusicStation.png", UriKind.Relative)),
                            FontSize = 12,
                            Style = (Style)this.Resources["HubTileStyle1"],
                            GroupTag = "apps"
                        },
                        new MyHubTile()
                        {
                            Tag = "ScaleFinder",
                            SupportedCultures = new List<string>() { "it", "en", "es" },
                            Guid = new Guid("35827306-ffc5-41d6-ba7c-467e03b61c2f"),
                            Height = 175,
                            Width = 175,
                            Title = "ScaleFinder",
                            Source = new BitmapImage(new Uri("../Resources/ScaleFinder.png", UriKind.Relative)),
                            FontSize = 12,
                            Style = (Style)this.Resources["HubTileStyle1"],
                            GroupTag = "apps"
                        },
                        new MyHubTile()
                        {
                            Tag = "TempoStation",
                            SupportedCultures = new List<string>() { "it", "en" },
                            Guid = new Guid("253a9c97-546f-40ed-be0e-6be265788be4"),
                            Height = 175,
                            Width = 175,
                            Title = "TempoStation",
                            Source = new BitmapImage(new Uri("../Resources/TempoStation.png", UriKind.Relative)),
                            FontSize = 12,
                            Style = (Style)this.Resources["HubTileStyle1"],
                            GroupTag = "apps"
                        }
            };
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Animate();
        }

        public void Animate()
        {
            mainPanel.Children.Clear();

            var currentCultureSupportedApps = _knownApps.Where(a => a.Tag != _curApp
                                                                    &&
                                                                    (a.SupportedCultures.Contains("en") ||
                                                                     a.SupportedCultures.Contains(Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)));

            currentCultureSupportedApps.ToObservable()
                                        .OnTimeline(TimeSpan.FromSeconds(.2))
                                        .ObserveOnDispatcher()
                                        .Subscribe(AddItem);
        }

        public void AddItem(MyHubTile item)
        {
            try
            {
                mainPanel.Children.Add(item);
                item.Tap -= new EventHandler<System.Windows.Input.GestureEventArgs>(HubTile_Tap);
                item.Tap += new EventHandler<System.Windows.Input.GestureEventArgs>(HubTile_Tap);
            }
            catch (Exception)
            {
            }
        }

        private void HubTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                MarketplaceDetailTask marketplaceDetailTask = new MarketplaceDetailTask();
                string guidToStr = (sender as MyHubTile).Guid.ToString();

                marketplaceDetailTask.ContentIdentifier = guidToStr;
                marketplaceDetailTask.ContentType = MarketplaceContentType.Applications;
                marketplaceDetailTask.Show();

            }
            catch (InvalidOperationException ignored)
            {

            }
        }

        public void SetCurrentApp(string appName)
        {
            _curApp = appName;
            //var curAppHubTile = MyVisualTreeHelper.FindChilds<MyHubTile>(mainPanel).ToList().FirstOrDefault(ht => ht.Tag.Equals(appName));
            //if (curAppHubTile == null) return;
            //curAppHubTile.Visibility = System.Windows.Visibility.Collapsed;
        }

        public void FreezeAll()
        {
            HubTileService.FreezeGroup("apps");
        }

        public void UnFreezeAll()
        {
            HubTileService.UnfreezeGroup("apps");
        }


    }
}