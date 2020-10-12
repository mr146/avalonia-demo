using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Application.Styling
{
    public partial class Styling : UserControl
    {
        public Styling()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}