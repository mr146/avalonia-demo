using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Application.Enumerables
{
    public partial class Enumerables : UserControl
    {
        public Enumerables()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}