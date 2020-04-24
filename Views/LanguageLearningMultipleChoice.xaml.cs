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
    public partial class LanguageLearningMultipleChoice : ContentPage
    {
        LanguageLearningMultipleChoiceViewModel viewModel;
        public LanguageLearningMultipleChoice()
        {
            InitializeComponent();
            BindingContext = viewModel = new LanguageLearningMultipleChoiceViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Questions.Count == 0)
                viewModel.LoadQuestions.Execute(null);
            BindingContext = viewModel;

        }
        private void SubmitTapped(object sender, EventArgs e)
        {
        }
    }
}