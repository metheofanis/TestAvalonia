using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Data;

namespace TestAvalonia.Controls;

public class MyControl : TemplatedControl
{
    public static readonly StyledProperty<string> ValueProperty =
       AvaloniaProperty.Register<MyControl, string>(
           nameof(Value),
           defaultBindingMode: BindingMode.TwoWay);

    public string Value
    {
        get => GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }
}