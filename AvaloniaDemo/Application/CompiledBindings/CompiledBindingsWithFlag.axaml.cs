using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Application.CompiledBindings
{
    public partial class CompiledBindingsWithFlag : UserControl
    {
        public CompiledBindingsWithFlag()
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