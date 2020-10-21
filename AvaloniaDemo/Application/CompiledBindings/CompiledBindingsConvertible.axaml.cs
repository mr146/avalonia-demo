using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Application.CompiledBindings
{
    public partial class CompiledBindingsConvertible : UserControl
    {
        public CompiledBindingsConvertible()
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

    public class ResourceInstance
    {
        public ResourceInstance()
        {
            
        }

        public string Property => "Property from dynamic resource";
    }
}