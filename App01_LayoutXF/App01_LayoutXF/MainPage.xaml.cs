﻿using System;
using System.ComponentModel;
using App01_LayoutXF.Layouts.Relative;
using App01_LayoutXF.Layouts.Scroll;
using Xamarin.Forms;

namespace App01_LayoutXF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoPaginaStack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }

        private void GoPaginaGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }

        private void GoPaginaAbsolute(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }

        private void GoPaginaRelative(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativePage());
        }

        private void GoPaginaScroll(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollPage());
        }
    }
}
