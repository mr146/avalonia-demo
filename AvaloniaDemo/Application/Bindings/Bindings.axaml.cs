using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Application.Bindings
{
    public partial class Bindings : UserControl
    {
        public Bindings()
        {
            InitializeComponent();
            DataContext = new BindingsModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}