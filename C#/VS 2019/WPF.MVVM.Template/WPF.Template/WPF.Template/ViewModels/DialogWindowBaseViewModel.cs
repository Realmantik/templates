namespace WPF.Template.ViewModels
{
    internal abstract class DialogWindowBaseViewModel : BaseViewModel
    {
        private bool _closeTrigger;
        public bool CloseTrigger
        {
            get => _closeTrigger;
            set => SetField(ref _closeTrigger, value);
        }
    }
}
