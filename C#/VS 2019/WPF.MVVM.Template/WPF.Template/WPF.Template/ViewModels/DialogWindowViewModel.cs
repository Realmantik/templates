using System.Windows.Input;

namespace WPF.Template.ViewModels
{
    internal class DialogWindowViewModel : DialogWindowBaseViewModel
    {
        public DialogWindowViewModel(string data)
        {
            CurrentData = data;
        }
        
        private string _currentData;
        public string CurrentData
        {
            get => _currentData;
            set => SetField(ref _currentData, value);
        }

        public ICommand CloseCommand => new RelayCommand(obj =>
        {
            CloseTrigger = true;
        });
    }
}
