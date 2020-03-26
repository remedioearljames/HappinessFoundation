using HappinessFoundation.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HappinessFoundation.ViewModels
{
    class Form1ViewModel : BaseViewModel
    {
        
        public Form1ViewModel()
        {
            Title = "Questions";
            Questions = new ObservableCollection<Form1Model>();
            LoadQuestions = new Command(async () => await ExecuteLoadQuestionsCommand());
        }
        public ObservableCollection<Form1Model> question { get; set; }

        public ObservableCollection<Form1Model> Questions
        {
            set
            {
                if (question != value)
                {
                    question = value;
                    OnPropertyChanged("Questions");
                }
            }
            get
            {
                return question;
            }
        }
        public Command LoadQuestions { get; set; }
        async Task ExecuteLoadQuestionsCommand() 
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                Questions.Clear();
                #region Load Sample Json File From MockData Folder

                string jsonFileName = "QuestionsDataSet.json";
                var assembly = typeof(Form1ViewModel).GetTypeInfo().Assembly;
                Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");

                Debug.WriteLine(assembly.GetName().Name + jsonFileName);
                using (var reader = new StreamReader(stream))
                {
                    var jsonString = reader.ReadToEnd();

                    //Converting JSON Array Objects into generic list    
                    Questions = JsonConvert.DeserializeObject<ObservableCollection<Form1Model>>(jsonString);
                }
                
                #endregion
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
 
        }
}
}
