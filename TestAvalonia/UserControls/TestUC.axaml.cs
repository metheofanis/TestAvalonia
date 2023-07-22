using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;

namespace TestAvalonia.UserControls
{
    public partial class TestUC : UserControl
    {
        public static readonly DirectProperty<TestUC, string> ValueProperty =
           AvaloniaProperty.RegisterDirect<TestUC, string>(
               nameof(Value),
               o => o.Value,
               (o, v) => o.Value = v,
               defaultBindingMode: BindingMode.TwoWay);

        private string _value;

        public string Value
        {
            get { return _value; }
            set { SetAndRaise(ValueProperty, ref _value, value); }
        }

        public TestUC()
        {
            InitializeComponent();

            _value = string.Empty;

            DataContext = this;
        }
    }
}
