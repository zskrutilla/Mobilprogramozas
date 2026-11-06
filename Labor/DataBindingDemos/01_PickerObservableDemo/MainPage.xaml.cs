using _01_PickerObservableDemo.Models;
using _01_PickerObservableDemo.ViewModels;

namespace _01_PickerObservableDemo
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel viewModel = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void addNewBtn_Clicked(object sender, EventArgs e)
        {
            MainViewModel.People.Add(new Person("Dénes", 19));
        }
    }
}
