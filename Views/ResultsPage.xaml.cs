﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappinessFoundation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultsPage : ContentPage
    {   
        
        public ResultsPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {   

            Navigation.PushAsync(new LanguageLearningCategory());
        }
    }
}