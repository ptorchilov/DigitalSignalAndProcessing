namespace Lab02_C_n_C
{
    using System;
    using System.Drawing;
    using System.Numerics;
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
        private void DrawValues(Complex[] functionVector, ZedGraphControl zedGraphControl, String title, Color color)
        {
            var graphPane = zedGraphControl.GraphPane;

            graphPane.XAxis.Title.Text = "Count number";
            graphPane.YAxis.Title.Text = "Value of the function";
            graphPane.Title.Text = title;

            graphPane.CurveList.Clear();

            var pointList = new PointPairList();

            for (var i = 0; i < functionVector.Length; i++)
            {
                pointList.Add(i, functionVector[i].Real);
            }

            graphPane.AddCurve(String.Empty, pointList, color);

            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        /// <summary>
        /// Draws the functions click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DrawFunctionsClick(object sender, EventArgs e)
        {
            var originalVector = TransformUtils.GetFunctionVector(ChooseFunction.OriginalFunction);

            this.DrawValues(originalVector, originalFunction, "y = cos(x) + sin(2x)", Color.Blue);

            var zVector = TransformUtils.GetFunctionVector(ChooseFunction.ConvolutionFunction);
            this.DrawValues(zVector, zFunction, "z = sin(2x)", Color.Blue);
        }

        private void DrawConvulationClick(object sender, EventArgs e)
        {
            var originalVector = TransformUtils.GetFunctionVector(ChooseFunction.OriginalFunction);
            var zVector = TransformUtils.GetFunctionVector(ChooseFunction.ConvolutionFunction);

            var convulationVector = ConvulationUtils.GetConvolution(originalVector, zVector);
            var convulationVectorWithFFT = ConvulationUtils.GetConvolutionWithFFT(originalVector, zVector);

            this.DrawValues(convulationVector, convulation, "Convulation Y and Z", Color.Red);
            this.DrawValues(convulationVectorWithFFT, convulationWithFFT, "Convulation Y and Z with FFT", Color.Red);
        }

        private void DrawCorrelationClick(object sender, EventArgs e)
        {
            var originalVector = TransformUtils.GetFunctionVector(ChooseFunction.OriginalFunction);
            var zVector = TransformUtils.GetFunctionVector(ChooseFunction.ConvolutionFunction);

            var correlationVector = CorrelationUtils.GetCorrelation(originalVector, zVector);
            var correlationVectorWithFFT = CorrelationUtils.GetCorrelationWithFFT(originalVector, zVector);

            this.DrawValues(correlationVector, correlation, "Correlation Y and Z", Color.Green);
            this.DrawValues(correlationVectorWithFFT, correlationWithFFT, "Correlation Y and Z with FFT", Color.Green);
        }
    }
}
