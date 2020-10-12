using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Application.CompiledBindings
{
    public partial class CompiledBindings : UserControl
    {
        public CompiledBindings()
        {
            InitializeComponent();
            Model = new CompiledBindingsModel();
            DataContext = this;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public CompiledBindingsModel Model { get; }

        public string Prop { get; }
    }
}