namespace HelloWorld
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    // Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
    /// <summary>
    /// Defines the <see cref="MainPage" />
    /// </summary>
    [DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
			InitializeComponent();

            slider.Value = 0.5;
       
        }
    }
}
