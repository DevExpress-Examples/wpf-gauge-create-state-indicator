using System.Windows;
using System.Windows.Input;

namespace DXGauges_StateIndicator {
 
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void stateIndicatorControl1_MouseEnter(object sender, MouseEventArgs e) {
            stateIndicatorControl1.StateIndex = 0;
        }

        private void stateIndicatorControl1_MouseLeave(object sender, MouseEventArgs e) {
            stateIndicatorControl1.StateIndex = 2;
        }
            
    }
}
