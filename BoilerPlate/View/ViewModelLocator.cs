namespace BoilerPlate.View
{
    using BoilerPlate.Source.ExampleWindow;
    using BoilerPlate.Source.WinformsExampleWindow;
    using Source.Main;

    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    internal class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
        }

        /// <summary>
        /// Gets the Main view model.
        /// </summary>
        public MainViewModel MainViewModel
        {
            get
            {
                return MainViewModel.GetInstance();
            }
        }

        /// <summary>
        /// Gets the Example Window view model.
        /// </summary>
        public ExampleWindowViewModel ExampleWindowViewModel
        {
            get
            {
                return ExampleWindowViewModel.GetInstance();
            }
        }

        /// <summary>
        /// Gets the Winforms Example Window view model.
        /// </summary>
        public WinformsExampleWindowViewModel WinformsExampleWindowViewModel
        {
            get
            {
                return WinformsExampleWindowViewModel.GetInstance();
            }
        }
    }
    //// End class
}
//// End namespace