﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MicroAnimationsWithLottie
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public bool IsFavorite { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LottieAnimationView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (LottieAnimationView.IsAnimating)
            {
                LottieAnimationView.PauseAnimation();
            }

            if (!IsFavorite)
            {
                LottieAnimationView.PlayAnimation();
            }
            else
            {
                LottieAnimationView.Progress = 0.0f;
            }

            IsFavorite = !IsFavorite;
        }
    }
}
