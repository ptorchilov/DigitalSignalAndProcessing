// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationForm.cs" company="BSUIR">
//   Torchilov Pavel
// </copyright>
// <summary>
//   Defines the ApplicationForm type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab01_FFTandDFT
{
    using System.Windows.Forms;

    /// <summary>
    /// The application form.
    /// </summary>
    public partial class ApplicationForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationForm"/> class.
        /// </summary>
        public ApplicationForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Draws the DFT button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void DrawDftButtonClick(object sender, System.EventArgs e)
        {
            var originalValuesVector = TransformUtils.GetFunctionVector();

//            var DFTvaluesVector = 

        }
    }
}
