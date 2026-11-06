using _01_PickerObservableDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_PickerObservableDemo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string simpleText = "Hello from C#!";

        public string SimpleText => simpleText;

        private Person? selectedPerson;

        public Person? SelectedPerson
        {
            get => selectedPerson;
            set
            {
                if (selectedPerson != value)
                {
                    selectedPerson = value;
                    OnPropertyChanged();
                }
            }
        }

        public static ObservableCollection<Person> People { get; } = new()
        {
            new Person("Aladár", 26),
            new Person("Béla", 32),
            new Person("Cecília", 58)
        };
    }
}
