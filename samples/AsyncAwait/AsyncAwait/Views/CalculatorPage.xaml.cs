﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AsyncAwait.Views
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
        }

        partial void buttonCalculateSynchronous_Clicked(object sender, EventArgs args);
    }
}