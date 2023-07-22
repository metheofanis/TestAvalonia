using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TestAvalonia.UserControls
{
    public partial class TestUC : UserControl
    {
        public static readonly DirectProperty<TestUC, string> ValueProperty =
           AvaloniaProperty.RegisterDirect<TestUC, string>(
               nameof(Value),                               // The name of the property     
               o => o.Value,                                // The getter of the property
               (o, v) => o.Value = v,                       // The setter of the property
               defaultBindingMode: BindingMode.TwoWay);     // Enables DataValidation

        // For direct properties we need to have a backing field
        private string _value;

        /// <summary>
        /// Gets or sets the current value
        /// </summary>
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
