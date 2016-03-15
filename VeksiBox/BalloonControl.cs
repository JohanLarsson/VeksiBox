using System.Windows;
using System.Windows.Controls;

namespace VeksiBox
{
    public class BalloonControl : ContentControl
    {
        static BalloonControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BalloonControl), new FrameworkPropertyMetadata(typeof(BalloonControl)));
        }
    }
}
