﻿namespace FlayoutPageApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutPageMenu();
        }
    }
}
