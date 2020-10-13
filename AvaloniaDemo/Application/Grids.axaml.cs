using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Application
{
    public partial class Grids : UserControl
    {
        public Grids()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}