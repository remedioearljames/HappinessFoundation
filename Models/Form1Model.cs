using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HappinessFoundation.Models
{
    public class Choices 
    {
        [JsonProperty(PropertyName = "ChoiceID")]
        public int ChoiceID { get; set; }

        [JsonProperty(PropertyName = "Choice")]
        public string Choice { get; set; }
    }

    public class Questions 
    {
        [JsonProperty(PropertyName = "QuestionID")]
        public int QuestionID { get; set; }

        [JsonProperty(PropertyName = "Question")]
        public string Question { get; set; }

        [JsonProperty(PropertyName = "Choices")]
        public ObservableCollection<Choices> Choices { get; set; }
    }

    
    public class Form1Model
    {
        [JsonProperty(PropertyName = "Questions")]
        public ObservableCollection<Questions> QuestionList { get; set; }
    }
}
