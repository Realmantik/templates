using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
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
        }

        private ObservableCollection<string> _data;
        public ObservableCollection<string> Data
        {
            get => _data;
            set => SetField(ref _data, value);
        }

        private string _currentData;
        public string CurrentData
        {
            get => _currentData;
            set => SetField(ref _currentData, value);
        }

        public ICommand SelectDataCommand => new RelayCommand(obj =>
        {
            new DialogWindow(CurrentData).ShowDialog();
        });

        public ICommand SelectedItemChangedCommand => new RelayCommand(obj =>
        {
            Debug.Write($"\nSelected: {CurrentData}") ;
        });
    }
}