﻿using Hardware.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hardware.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraView : ContentPage
    {
        public CameraView()
        {
            InitializeComponent();
            BindingContext = new CameraViewModel();
        }
    }
}