using System.Collections.Generic;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Metadata;

namespace Application.Enumerables
{
    public partial class MyComponent : UserControl
    {
        private List<Control> myContent;

        public MyComponent()
        {
            InitializeComponent();
            DataContext = this;
        }

        public List<Control> ContentEnumerable => myContent ??= new List<Control>();

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public string Zzz { get; set; }
    }
}