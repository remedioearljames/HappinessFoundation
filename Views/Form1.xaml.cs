using HappinessFoundation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappinessFoundation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Form1 : ContentPage
    {
        Form1ViewModel viewModel;

        public Form1()
        {
          
            InitializeComponent();
            BindingContext = viewModel = new Form1ViewModel();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Questions.Count == 0)
                viewModel.LoadQuestions.Execute(null);
            BindingContext = viewModel;
        }
    }
}