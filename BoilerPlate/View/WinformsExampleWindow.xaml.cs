namespace BoilerPlate.View
{
    using BoilerPlate.Source.Controls;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for WinformsExampleWindow.xaml.
    /// </summary>
    internal partial class WinformsExampleWindow : UserControl
    {
        private WinformsExampleControl winformsExampleControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="WinformsExampleWindow" /> class.
        /// </summary>
        public WinformsExampleWindow()
        {
            this.InitializeComponent();

            this.winformsExampleControl = new WinformsExampleControl();
            winformsExampleControl.BackColor = DarkBrushes.BaseColor8;

            this.buttonPlaceHolder.Children.Add(WinformsHostingHelper.CreateHostedControl(this.winformsExampleControl));
        }
    }
    //// End class
}
//// End namespace