using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LetItSnow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RectAnimation animation = new RectAnimation();

            animation.From = new Rect(0, 0, 100, 100);
            animation.To = new Rect (0, 100, 100, 100);
            animation.Duration = new TimeSpan(0, 0, 0, 10);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            
            farBrush.BeginAnimation(ImageBrush.ViewportProperty, animation);

            animation.From = new Rect(0, 0, 200, 200);
            animation.To = new Rect(200, 1000, 200, 200);
            animation.Duration = new TimeSpan(0, 0, 0, 30);
            animation.RepeatBehavior = RepeatBehavior.Forever;
        
            nearBrush.BeginAnimation(ImageBrush.ViewportProperty, animation);
        }
    }
}
