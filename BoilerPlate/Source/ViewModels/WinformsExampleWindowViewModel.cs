namespace BoilerPlate.Source.WinformsExampleWindow
{
    using Docking;
    using Main;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// View model for the Winforms Example Window.
    /// </summary>
    internal class WinformsExampleWindowViewModel : ToolViewModel
    {
        /// <summary>
        /// The content id for the docking library associated with this view model.
        /// </summary>
        public const String ToolContentId = nameof(WinformsExampleWindowViewModel);

        /// <summary>
        /// Singleton instance of the <see cref="WinformsExampleWindowViewModel" /> class.
        /// </summary>
        private static Lazy<WinformsExampleWindowViewModel> winformsExampleWindowViewModelInstance = new Lazy<WinformsExampleWindowViewModel>(
                () => { return new WinformsExampleWindowViewModel(); },
                LazyThreadSafetyMode.ExecutionAndPublication);

        /// <summary>
        /// Prevents a default instance of the <see cref="WinformsExampleWindowViewModel" /> class from being created.
        /// </summary>
        private WinformsExampleWindowViewModel() : base("Winforms Example Window")
        {
            this.ContentId = WinformsExampleWindowViewModel.ToolContentId;

            Task.Run(() => MainViewModel.GetInstance().RegisterTool(this));
        }

        /// <summary>
        /// Gets a singleton instance of the <see cref="WinformsExampleWindowViewModel"/> class.
        /// </summary>
        /// <returns>A singleton instance of the class.</returns>
        public static WinformsExampleWindowViewModel GetInstance()
        {
            return WinformsExampleWindowViewModel.winformsExampleWindowViewModelInstance.Value;
        }
    }
    //// End class
}
//// End namespace