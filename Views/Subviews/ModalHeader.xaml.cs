using HappinessFoundation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappinessFoundation.Views.Subviews
{
   

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalHeader : ContentView
    {
      
        public static readonly BindableProperty TitleProperty = 
            BindableProperty.Create("CardTitle", typeof(String), typeof(ModalHeader), string.Empty );
         
        public string Title
        {
            get { return (String)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public ModalHeader()
        {
            InitializeComponent();
        }

        private void CloseClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(false);
        }
        static void OnTitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {   

        }
    }
}