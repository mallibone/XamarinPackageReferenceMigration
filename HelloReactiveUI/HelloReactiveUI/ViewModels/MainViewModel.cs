using System.Windows.Input;
using ReactiveUI;

namespace HelloNetStandard.ViewModels
{
    class MainViewModel : ReactiveObject
    {
        private int _clickCount = 0;
        private string _buttonText;

        public MainViewModel()
        {
            ButtonSelectedCommand = ReactiveCommand.Create(() => { ButtonText = $"Clicked {++_clickCount} times"; });

            ButtonText = "Click me";
        }

        public string ButtonText
        {
            get => _buttonText;
            set => this.RaiseAndSetIfChanged(ref _buttonText, value);
        }

        public ICommand ButtonSelectedCommand { get; }
    }
}
