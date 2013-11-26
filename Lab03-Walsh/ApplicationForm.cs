namespace Lab03_Walsh
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Lab01_FFTandDFT;
    using ZedGraph;

    public partial class ApplicationForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationForm"/> class.
        /// </summary>
        public ApplicationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Draws the values.
        /// </summary>
        /// <param name="functionVector">The function vector.</param>
        /// <param name="zedGraphControl">The zed graph control.</param>
        /// <param name="title">The title.</param>
        /// <param name="color">The color.</param>
        private void DrawValues(double[] functionVector, ZedGraphControl zedGraphControl, String title, Color color)
        {
            var graphPane = zedGraphControl.GraphPane;

            graphPane.XAxis.Title.Text = "Count number";
            graphPane.YAxis.Title.Text = "Value of the function";
            graphPane.Title.Text = title;

            graphPane.CurveList.Clear();

            var pointList = new PointPairList();

            for (var i = 0; i < functionVector.Length; i++)
            {
                pointList.Add(i, functionVector[i]);
            }

            graphPane.AddCurve(String.Empty, pointList, color);

            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        /// <summary>
        /// Draws the button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DrawButtonClick(object sender, EventArgs e)
        {
            var functionVector = WalshTransformUtils.GetFunctionVector();

            this.DrawValues(functionVector, originalFunction, "y = cos(x) + sin(2x)", Color.Blue);

            functionVector = WalshTransformUtils.GetFastWalshTransform(functionVector, TransformDirection.Direct);
            this.DrawValues(functionVector, walshTransform, "Walsh Transform", Color.Blue);

            functionVector = WalshTransformUtils.GetFastWalshTransform(functionVector, TransformDirection.Reverse);
            this.DrawValues(functionVector, reverseFunction, "Reverse Walsh Transform", Color.Blue);
        }
    }
}
