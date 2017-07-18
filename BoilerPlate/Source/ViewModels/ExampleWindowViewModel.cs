namespace BoilerPlate.Source.ExampleWindow
{
    using Docking;
    using Main;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// View model for the Example Window.
    /// </summary>
    internal class ExampleWindowViewModel : ToolViewModel
    {
        /// <summary>
        /// The content id for the docking library associated with this view model.
        /// </summary>
        public const String ToolContentId = nameof(ExampleWindowViewModel);

        /// <summary>
        /// Singleton instance of the <see cref="ExampleWindowViewModel" /> class.
        /// </summary>
        private static Lazy<ExampleWindowViewModel> exampleWindowViewModelInstance = new Lazy<ExampleWindowViewModel>(
                () => { return new ExampleWindowViewModel(); },
                LazyThreadSafetyMode.ExecutionAndPublication);

        /// <summary>
        /// Prevents a default instance of the <see cref="ExampleWindowViewModel" /> class from being created.
        /// </summary>
        private ExampleWindowViewModel() : base("Example Window")
        {
            this.ContentId = ExampleWindowViewModel.ToolContentId;

            Task.Run(() => MainViewModel.GetInstance().RegisterTool(this));
        }

        /// <summary>
        /// Gets a singleton instance of the <see cref="ExampleWindowViewModel"/> class.
        /// </summary>
        /// <returns>A singleton instance of the class.</returns>
        public static ExampleWindowViewModel GetInstance()
        {
            return ExampleWindowViewModel.exampleWindowViewModelInstance.Value;
        }
    }
    //// End class
}
//// End namespace