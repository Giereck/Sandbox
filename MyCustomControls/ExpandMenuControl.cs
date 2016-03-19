using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MyCustomControls
{
    public class ExpandMenuControl : Control
    {
        static ExpandMenuControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExpandMenuControl), new FrameworkPropertyMetadata(typeof(ExpandMenuControl)));
        }
    }
}
