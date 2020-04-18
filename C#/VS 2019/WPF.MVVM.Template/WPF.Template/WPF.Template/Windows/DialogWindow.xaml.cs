using System.Windows;
using WPF.Template.ViewModels;

namespace WPF.Template.Windows
{
    /// <summary>
    /// Логика взаимодействия для DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        public DialogWindow(string data)
        {
            InitializeComponent();
            this.DataContext = new DialogWindowViewModel(data);
        }
    }
}
