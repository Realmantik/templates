using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using WPF.Template.Models;
using WPF.Template.Windows;

namespace WPF.Template.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            Data = new ObservableCollection<string>(new string[] {
             "One", "Two", "Three"
            });

            CarData = new ObservableCollection<Car>
            {
                new Car("Ferrari","LaFerrari","/Images/ferrari-laferrari_cr.jpg"),
                new Car("Ferrari","360 GTC","/Images/ferrari_360_gtc_cr.jpg"),
                new Car("Porsche","718 Cayman","/Images/porsche-718-Cayman_cr.jpg"),
                new Car("Porsche","911 Turbo S","/Images/porsche-911-turbo-s_cr.jpg")
            };
        }



        private ObservableCollection<Car> _car_data;
        public ObservableCollection<Car> CarData
        {
            get => _car_data;
            set => SetField(ref _car_data, value);
        }



        private ObservableCollection<string> _data;
        public ObservableCollection<string> Data
        {
            get => _data;
            set => SetField(ref _data, value);
        }



        private Car _currentCarData;
        public Car CurrentCarData
        {
            get => _currentCarData;
            set => SetField(ref _currentCarData, value);
        }



        private string _currentData;
        public string CurrentData
        {
            get => _currentData;
            set => SetField(ref _currentData, value);
        }

        public ICommand SelectDataCommand => new RelayCommand(obj =>
        {
            new DialogWindow(CurrentCarData).ShowDialog();
        });

        public ICommand SelectedItemChangedCommand => new RelayCommand(obj =>
        {
            Debug.Write($"\nSelected: {CurrentData}") ;
        });
    }
}