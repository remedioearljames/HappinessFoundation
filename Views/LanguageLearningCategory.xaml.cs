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
    public partial class LanguageLearningCategory : ContentPage
    {
        public LanguageLearningCategory()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IntroductionTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LanguageLearningIntroduction());
        }
        private void BeginnerClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LanguageLearningMultipleChoice());
        }
        private void IntermediateTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LanguageLearningIntroduction());
        }
        private void AdvanceTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LanguageLearningIntroduction());
        }
    }
}