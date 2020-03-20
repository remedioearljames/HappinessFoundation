using HappinessFoundation.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HappinessFoundation.Models
{
     
    public class Choices : BaseViewModel
    {

        private int choiceID;
        private string choice;

        [JsonProperty(PropertyName = "ChoiceID")]
        public int ChoiceID
        {
            set
            {
                if (choiceID != value)
                {
                    choiceID = value;
                    OnPropertyChanged("ChoiceID"); 
                }
            }
            get
            {
                return choiceID;
            }
        }

        [JsonProperty(PropertyName = "Choice")]
        public string Choice 
        {
            set
            {
                if (choice != value)
                {
                    choice = value;
                    OnPropertyChanged("Choice");
                }
            }
            get
            {
                return choice;
            }
        }
    }

     
    public class Form1Model : BaseViewModel
    {
        private int questionID;
        private string question;
        private ObservableCollection<Choices> choices;

        [JsonProperty(PropertyName = "QuestionID")]
        public int QuestionID
        {
            set
            {
                if (questionID != value)
                {
                    questionID = value;
                    OnPropertyChanged("QuestionID");
                }
            }
            get
            {
                return questionID;
            }
        }

        [JsonProperty(PropertyName = "Question")]
        public string Question
        {
            set
            {
                if (question != value)
                {
                    question = value;
                    OnPropertyChanged("Question");
                }
            }
            get
            {
                return question;
            }
        }

        [JsonProperty(PropertyName = "Choices")]
        public ObservableCollection<Choices> Choices
        {
            set
            {
                if (choices != value)
                {
                    choices = value;
                    OnPropertyChanged("Choices");
                }
            }
            get
            {
                return choices;
            }
        }
    }
}
