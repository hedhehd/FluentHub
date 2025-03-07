﻿using FluentHub.Services;
using FluentHub.ViewModels.Home;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using muxc = Microsoft.UI.Xaml.Controls;

namespace FluentHub.Views.Home
{
    public sealed partial class UserHomePage : Page
    {
        public UserHomePage()
        {
            InitializeComponent();

            var provider = App.Current.Services;
            ViewModel = provider.GetRequiredService<UserHomeViewModel>();
            navigationService = provider.GetRequiredService<INavigationService>();
        }

        private readonly INavigationService navigationService;
        public UserHomeViewModel ViewModel { get; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentItem = navigationService.TabView.SelectedItem.NavigationHistory.CurrentItem;
            currentItem.Header = $"Home";
            currentItem.Description = $"Home";
            currentItem.Url = $"fluenthub://home";
            currentItem.Icon = new muxc.FontIconSource
            {
                Glyph = "\uE9D5",
                FontFamily = new Windows.UI.Xaml.Media.FontFamily("/Assets/Glyphs/Octions.ttf#octions")
            };

            var command = ViewModel.LoadHomeContentsCommand;
            if (command.CanExecute(null))
                command.Execute(null);
        }
    }
}
