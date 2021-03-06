﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SoundCloudClone.Views;
using SoundCloudClone.Interfaces;
using SoundCloudClone.Services;
using SoundCloudClone.Enums;

namespace SoundCloudClone
{
    public partial class App : Application
    {
        private readonly IStorage _storage;
        private readonly ITheme _theme;

        public App()
        {
            InitializeComponent();

            RegisterDependencies();

            _storage = DependencyService.Get<IStorage>();
            _theme = DependencyService.Get<ITheme>();

            MainPage = new MainPage();
        }

        private void RegisterDependencies()
        {
            DependencyService.Register<IApi, ApiService>();
            DependencyService.Register<ITheme, ThemeService>();
            DependencyService.Register<IStorage, StorageService>();
        }

        private void ChangeTheme()
        {
            var themeValue = _storage.Get(Constants.SelectedThemeKey, (int)ThemeEnum.NonSelected);
            var themeEnum = (ThemeEnum)themeValue;
            _theme.Change(themeEnum);
        }

        protected override void OnStart()
        {
            ChangeTheme();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            ChangeTheme();
        }
    }
}
