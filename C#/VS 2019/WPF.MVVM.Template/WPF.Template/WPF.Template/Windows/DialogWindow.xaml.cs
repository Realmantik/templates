using System.Windows;
using WPF.Template.Models;
using WPF.Template.ViewModels;

namespace WPF.Template.Windows
{
    /// <summary>
    /// Логика взаимодействия для DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        public DialogWindow(Car data)
        {
            InitializeComponent();
            this.DataContext = new DialogWindowViewModel(data);

        }
    }
}
