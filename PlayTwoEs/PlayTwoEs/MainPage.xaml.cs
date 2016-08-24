﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlayTwoEs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void ListenToMusic(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MusicList());
        }
    }
}
