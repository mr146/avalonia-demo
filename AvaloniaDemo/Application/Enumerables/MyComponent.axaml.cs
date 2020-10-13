using System.Collections.Generic;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Metadata;

namespace Application.Enumerables
{
    public partial class MyComponent : UserControl
    {
        private AvaloniaList<Control> myContent;

        public MyComponent()
        {
            InitializeComponent();
            DataContext = this;
        }

        public AvaloniaList<Control> ContentEnumerable => myContent ??= new AvaloniaList<Control>();

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}