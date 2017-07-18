namespace BoilerPlate.View
{
    using BoilerPlate.Source.ExampleWindow;
    using BoilerPlate.Source.WinformsExampleWindow;
    using System;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Provides the template required to view a pane.
    /// </summary>
    internal class ViewTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewTemplateSelector" /> class.
        /// </summary>
        public ViewTemplateSelector()
        {
        }

        /// <summary>
        /// Gets or sets the template for the Example Window.
        /// </summary>
        public DataTemplate ExampleWindowViewTemplate { get; set; }

        /// <summary>
        /// Gets or sets the template for the Winforms Example Window.
        /// </summary>
        public DataTemplate WinformsExampleWindowViewTemplate { get; set; }

        /// <summary>
        /// Returns the required template to display the given view model.
        /// </summary>
        /// <param name="item">The view model.</param>
        /// <param name="container">The dependency object.</param>
        /// <returns>The template associated with the provided view model.</returns>
        public override DataTemplate SelectTemplate(Object item, DependencyObject container)
        {
            if (item is ExampleWindowViewModel)
            {
                return this.ExampleWindowViewTemplate;
            }
            else if (item is WinformsExampleWindowViewModel)
            {
                return this.WinformsExampleWindowViewTemplate;
            }

            return base.SelectTemplate(item, container);
        }
    }
    //// End class
}
//// End namespace