/* =============================================================================*\
*
* Filename: RateBox.xaml.cs
* Description: 
*
* Version: 1.0
* Created: 8/4/2017 12:12:58(UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using AutumnBox.Basic.FlowFramework;
using AutumnBox.Basic.Function;
using AutumnBox.GUI.Helper;
using System.Windows;
using System.Windows.Input;

namespace AutumnBox.GUI.Windows
{
    /// <summary>
    /// RateBox.xaml 的交互逻辑
    /// </summary>
    public partial class RateBox : Window
    {
        private IForceStoppable stoppable;
        private FunctionModuleProxy ModuleProxy;
        public RateBox()
        {
            InitializeComponent();
            BtnCancel.Visibility = Visibility.Hidden;
            this.Owner = App.Current.MainWindow;
        }
        public RateBox(FunctionModuleProxy fmp)
        {
            InitializeComponent();
            this.ModuleProxy = fmp;
            this.Owner = App.Current.MainWindow;
        }
        public RateBox(IForceStoppable stoppable)
        {
            InitializeComponent();
            this.stoppable = stoppable;
            this.Owner = App.Current.MainWindow;
        }
        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            UIHelper.DragMove(this, e);
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ModuleProxy?.ForceStop();
            this.stoppable?.ForceStop();
            this.Close();
        }
    }
}
