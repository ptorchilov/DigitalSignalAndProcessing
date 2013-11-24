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
    using System.Drawing;
    using System.Numerics;
    using System.Windows.Forms;

    using ZedGraph;

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
            var originalValuesVector = TransformUtils.GetFunctionVector(ChooseFunction.OriginalFunction);

            this.DrawOriginal(originalValuesVector, zedGraphControl1);
            DrawDFT(originalValuesVector, zedGraphControl2, zedGraphControl3, zedGraphControl4);
            label4.Text = TransformUtils.Complexibility.ToString();
        }

        /// <summary>
        /// Draws the original.
        /// </summary>
        /// <param name="funcValues">The function values.</param>
        /// <param name="zedGraphControl">The zed graph control.</param>
        private void DrawOriginal(Complex[] funcValues, ZedGraphControl zedGraphControl)
        {
            GraphPane pane = zedGraphControl.GraphPane;

            pane.Title.Text = "Исходная функция";

            pane.CurveList.Clear();

            PointPairList list = new PointPairList();

            for (int i = 0; i < funcValues.Length; i++)
            {                
                list.Add(i, funcValues[i].Real);
            }

            LineItem myCurve = pane.AddCurve("", list, Color.Blue, SymbolType.None);

            zedGraphControl.AxisChange();

            zedGraphControl.Invalidate();
        }

        /// <summary>
        /// Draws the DFT.
        /// </summary>
        /// <param name="funcValues">The function values.</param>
        /// <param name="zedGraphControl_abs">The zed graph control_abs.</param>
        /// <param name="zedGraphControl_phase">The zed graph control_phase.</param>
        /// <param name="zedGraphControl_revers">The zed graph control_revers.</param>
        private void DrawDFT(Complex[] funcValues, ZedGraphControl zedGraphControl_abs, ZedGraphControl zedGraphControl_phase,
            ZedGraphControl zedGraphControl_revers)
        {
            GraphPane pane_abs = zedGraphControl_abs.GraphPane;
            GraphPane pane_phase = zedGraphControl_phase.GraphPane;
            GraphPane pane_revers = zedGraphControl_revers.GraphPane;


            pane_abs.Title.Text = "Амплитудный спектр";

            pane_phase.Title.Text = "Фазовый спектр";

            pane_revers.Title.Text = "Обратное преобразование";

            pane_abs.CurveList.Clear();
            pane_phase.CurveList.Clear();
            pane_revers.CurveList.Clear();

            PointPairList list_abs = new PointPairList();
            PointPairList list_phase = new PointPairList();
            PointPairList list_revers = new PointPairList();

            Complex[] values = TransformUtils.MakeDFT(funcValues, TransformDirection.Direct);           
            Complex[] reverseValues = TransformUtils.MakeDFT(values, TransformDirection.Reverse);


            for (int i = 0; i < values.Length; i++)
            {

                list_abs.Add(i, values[i].Magnitude);
                list_phase.Add(i, values[i].Phase);
                list_revers.Add(i, reverseValues[i].Real);
            }


            LineItem curve_abs = pane_abs.AddCurve("", list_abs, Color.Blue, SymbolType.None);
            LineItem curve_phase = pane_phase.AddCurve("", list_phase, Color.Blue, SymbolType.None);
            LineItem curve_revers = pane_revers.AddCurve("", list_revers, Color.Blue, SymbolType.None);

            zedGraphControl_abs.AxisChange();
            zedGraphControl_phase.AxisChange();
            zedGraphControl_revers.AxisChange();

            zedGraphControl_abs.Invalidate();
            zedGraphControl_phase.Invalidate();
            zedGraphControl_revers.Invalidate();
        }

        /// <summary>
        /// Draws the FFT.
        /// </summary>
        /// <param name="funcValues">The function values.</param>
        /// <param name="zedGraphControl_abs">The zed graph control_abs.</param>
        /// <param name="zedGraphControl_phase">The zed graph control_phase.</param>
        /// <param name="zedGraphControl_revers">The zed graph control_revers.</param>
        private void DrawFFT(Complex[] funcValues, ZedGraphControl zedGraphControl_abs, ZedGraphControl zedGraphControl_phase,
    ZedGraphControl zedGraphControl_revers)
        {
            GraphPane pane_abs = zedGraphControl_abs.GraphPane;
            GraphPane pane_phase = zedGraphControl_phase.GraphPane;
            GraphPane pane_revers = zedGraphControl_revers.GraphPane;

            pane_abs.Title.Text = "Амплитудный спектр";

            pane_phase.Title.Text = "Фазовый спектр сигнала";

            pane_revers.Title.Text = "Обратное преобразование";

            pane_abs.CurveList.Clear();
            pane_phase.CurveList.Clear();
            pane_revers.CurveList.Clear();

            PointPairList list_abs = new PointPairList();
            PointPairList list_phase = new PointPairList();
            PointPairList list_revers = new PointPairList();

            Complex[] values = TransformUtils.MakeFFT(funcValues, TransformDirection.Direct);            
            Complex[] reverseValues = TransformUtils.MakeFFT(values, TransformDirection.Reverse);  


            for (int i = 0; i < values.Length; i++)
            {
                list_abs.Add(i, values[i].Magnitude);
                list_phase.Add(i, values[i].Phase);
                list_revers.Add(i, reverseValues[i].Real);
            }


            LineItem curve_abs = pane_abs.AddCurve("", list_abs, Color.Blue, SymbolType.None);
            LineItem curve_phase = pane_phase.AddCurve("", list_phase, Color.Blue, SymbolType.None);
            LineItem curve_revers = pane_revers.AddCurve("", list_revers, Color.Blue, SymbolType.None);

            zedGraphControl_abs.AxisChange();
            zedGraphControl_phase.AxisChange();
            zedGraphControl_revers.AxisChange();

            zedGraphControl_abs.Invalidate();
            zedGraphControl_phase.Invalidate();
            zedGraphControl_revers.Invalidate();
        }     

        private void button2_Click(object sender, System.EventArgs e)
        {
            var originalValuesVector = TransformUtils.GetFunctionVector(ChooseFunction.OriginalFunction);

            this.DrawOriginal(originalValuesVector, zedGraphControl8);
            DrawFFT(originalValuesVector, zedGraphControl7, zedGraphControl6, zedGraphControl5);
            label5.Text = TransformUtils.Complexibility.ToString();
        }



    }
}
