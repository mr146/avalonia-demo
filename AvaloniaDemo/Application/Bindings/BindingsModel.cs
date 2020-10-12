using Avalonia;

namespace Application.Bindings
{
    public class BindingsModel : AvaloniaObject, IInterface
    {
        public BindingsModel()
        {
            Observable = new ObservableValue<string>(x => $"Clicked {x} time(s)");
            this.Prop = "asdf";
        }

        public string Prop { get; set; }
        int IInterface.Prop { get; }

        public static readonly StyledProperty<string> PropertyProperty = AvaloniaProperty.Register<BindingsModel, string>("Property");
        public static readonly StyledProperty<bool> CheckBoxStateProperty = AvaloniaProperty.Register<BindingsModel, bool>("CheckBoxState");
        public static readonly StyledProperty<int> CounterProperty = AvaloniaProperty.Register<BindingsModel, int>("Counter");

        public string Property
        {
            get { return (string) GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public ObservableValue<string> Observable { get; }

        public bool CheckBoxState
        {
            get { return (bool) GetValue(CheckBoxStateProperty); }
            set { SetValue(CheckBoxStateProperty, value); }
        }

        public int Counter
        {
            get { return (int) GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }

        public void OnButtonClick()
        {
            Observable.Increment();
            Counter = 1 - Counter;
        }
    }
}