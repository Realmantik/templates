using System.Windows.Input;
using WPF.Template.Models;

namespace WPF.Template.ViewModels
{
    internal class DialogWindowViewModel : DialogWindowBaseViewModel
    {
        public DialogWindowViewModel(object data)
        {
            if (data is Car)
            {
                CurrentData = data as Car;
            }
            //CurrentData = data;
        }
        
        private Car _currentData;
        public Car CurrentData
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
