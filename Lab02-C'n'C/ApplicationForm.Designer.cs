namespace Lab02_C_n_C
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Graphs = new System.Windows.Forms.TabControl();
            this.Functions = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drawFunctions = new System.Windows.Forms.Button();
            this.zFunction = new ZedGraph.ZedGraphControl();
            this.originalFunction = new ZedGraph.ZedGraphControl();
            this.Convulations = new System.Windows.Forms.TabPage();
            this.drawConvulation = new System.Windows.Forms.Button();
            this.convulationWithFFT = new ZedGraph.ZedGraphControl();
            this.convulation = new ZedGraph.ZedGraphControl();
            this.Correlations = new System.Windows.Forms.TabPage();
            this.drawCorrelation = new System.Windows.Forms.Button();
            this.correlationWithFFT = new ZedGraph.ZedGraphControl();
            this.correlation = new ZedGraph.ZedGraphControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Graphs.SuspendLayout();
            this.Functions.SuspendLayout();
            this.Convulations.SuspendLayout();
            this.Correlations.SuspendLayout();
            this.SuspendLayout();
            // 
            // Graphs
            // 
            this.Graphs.Controls.Add(this.Functions);
            this.Graphs.Controls.Add(this.Convulations);
            this.Graphs.Controls.Add(this.Correlations);
            this.Graphs.Location = new System.Drawing.Point(13, 12);
            this.Graphs.Name = "Graphs";
            this.Graphs.SelectedIndex = 0;
            this.Graphs.Size = new System.Drawing.Size(834, 450);
            this.Graphs.TabIndex = 0;
            // 
            // Functions
            // 
            this.Functions.Controls.Add(this.label3);
            this.Functions.Controls.Add(this.label2);
            this.Functions.Controls.Add(this.label1);
            this.Functions.Controls.Add(this.drawFunctions);
            this.Functions.Controls.Add(this.zFunction);
            this.Functions.Controls.Add(this.originalFunction);
            this.Functions.Location = new System.Drawing.Point(4, 22);
            this.Functions.Name = "Functions";
            this.Functions.Padding = new System.Windows.Forms.Padding(3);
            this.Functions.Size = new System.Drawing.Size(826, 424);
            this.Functions.TabIndex = 1;
            this.Functions.Text = "Functions";
            this.Functions.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(441, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "N = 8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(274, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "z = sin(2x)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "y = cos(x) + sin(2x)";
            // 
            // drawFunctions
            // 
            this.drawFunctions.Location = new System.Drawing.Point(650, 360);
            this.drawFunctions.Name = "drawFunctions";
            this.drawFunctions.Size = new System.Drawing.Size(130, 38);
            this.drawFunctions.TabIndex = 2;
            this.drawFunctions.Text = "Draw Functions";
            this.drawFunctions.UseVisualStyleBackColor = true;
            this.drawFunctions.Click += new System.EventHandler(this.DrawFunctionsClick);
            // 
            // zFunction
            // 
            this.zFunction.Location = new System.Drawing.Point(412, 7);
            this.zFunction.Name = "zFunction";
            this.zFunction.ScrollGrace = 0D;
            this.zFunction.ScrollMaxX = 0D;
            this.zFunction.ScrollMaxY = 0D;
            this.zFunction.ScrollMaxY2 = 0D;
            this.zFunction.ScrollMinX = 0D;
            this.zFunction.ScrollMinY = 0D;
            this.zFunction.ScrollMinY2 = 0D;
            this.zFunction.Size = new System.Drawing.Size(399, 320);
            this.zFunction.TabIndex = 1;
            // 
            // originalFunction
            // 
            this.originalFunction.Location = new System.Drawing.Point(7, 7);
            this.originalFunction.Name = "originalFunction";
            this.originalFunction.ScrollGrace = 0D;
            this.originalFunction.ScrollMaxX = 0D;
            this.originalFunction.ScrollMaxY = 0D;
            this.originalFunction.ScrollMaxY2 = 0D;
            this.originalFunction.ScrollMinX = 0D;
            this.originalFunction.ScrollMinY = 0D;
            this.originalFunction.ScrollMinY2 = 0D;
            this.originalFunction.Size = new System.Drawing.Size(399, 320);
            this.originalFunction.TabIndex = 0;
            // 
            // Convulations
            // 
            this.Convulations.Controls.Add(this.label7);
            this.Convulations.Controls.Add(this.label6);
            this.Convulations.Controls.Add(this.label5);
            this.Convulations.Controls.Add(this.label4);
            this.Convulations.Controls.Add(this.drawConvulation);
            this.Convulations.Controls.Add(this.convulationWithFFT);
            this.Convulations.Controls.Add(this.convulation);
            this.Convulations.Location = new System.Drawing.Point(4, 22);
            this.Convulations.Name = "Convulations";
            this.Convulations.Padding = new System.Windows.Forms.Padding(3);
            this.Convulations.Size = new System.Drawing.Size(826, 424);
            this.Convulations.TabIndex = 2;
            this.Convulations.Text = "Convulations";
            this.Convulations.UseVisualStyleBackColor = true;
            // 
            // drawConvulation
            // 
            this.drawConvulation.Location = new System.Drawing.Point(615, 357);
            this.drawConvulation.Name = "drawConvulation";
            this.drawConvulation.Size = new System.Drawing.Size(168, 38);
            this.drawConvulation.TabIndex = 4;
            this.drawConvulation.Text = "Draw Convulation of Functions";
            this.drawConvulation.UseVisualStyleBackColor = true;
            this.drawConvulation.Click += new System.EventHandler(this.DrawConvulationClick);
            // 
            // convulationWithFFT
            // 
            this.convulationWithFFT.Location = new System.Drawing.Point(411, 6);
            this.convulationWithFFT.Name = "convulationWithFFT";
            this.convulationWithFFT.ScrollGrace = 0D;
            this.convulationWithFFT.ScrollMaxX = 0D;
            this.convulationWithFFT.ScrollMaxY = 0D;
            this.convulationWithFFT.ScrollMaxY2 = 0D;
            this.convulationWithFFT.ScrollMinX = 0D;
            this.convulationWithFFT.ScrollMinY = 0D;
            this.convulationWithFFT.ScrollMinY2 = 0D;
            this.convulationWithFFT.Size = new System.Drawing.Size(399, 320);
            this.convulationWithFFT.TabIndex = 3;
            // 
            // convulation
            // 
            this.convulation.Location = new System.Drawing.Point(6, 6);
            this.convulation.Name = "convulation";
            this.convulation.ScrollGrace = 0D;
            this.convulation.ScrollMaxX = 0D;
            this.convulation.ScrollMaxY = 0D;
            this.convulation.ScrollMaxY2 = 0D;
            this.convulation.ScrollMinX = 0D;
            this.convulation.ScrollMinY = 0D;
            this.convulation.ScrollMinY2 = 0D;
            this.convulation.Size = new System.Drawing.Size(399, 320);
            this.convulation.TabIndex = 2;
            // 
            // Correlations
            // 
            this.Correlations.Controls.Add(this.label8);
            this.Correlations.Controls.Add(this.label9);
            this.Correlations.Controls.Add(this.label10);
            this.Correlations.Controls.Add(this.label11);
            this.Correlations.Controls.Add(this.drawCorrelation);
            this.Correlations.Controls.Add(this.correlationWithFFT);
            this.Correlations.Controls.Add(this.correlation);
            this.Correlations.Location = new System.Drawing.Point(4, 22);
            this.Correlations.Name = "Correlations";
            this.Correlations.Padding = new System.Windows.Forms.Padding(3);
            this.Correlations.Size = new System.Drawing.Size(826, 424);
            this.Correlations.TabIndex = 3;
            this.Correlations.Text = "Correlations";
            this.Correlations.UseVisualStyleBackColor = true;
            // 
            // drawCorrelation
            // 
            this.drawCorrelation.Location = new System.Drawing.Point(615, 357);
            this.drawCorrelation.Name = "drawCorrelation";
            this.drawCorrelation.Size = new System.Drawing.Size(168, 38);
            this.drawCorrelation.TabIndex = 5;
            this.drawCorrelation.Text = "Draw Correlation of Functions";
            this.drawCorrelation.UseVisualStyleBackColor = true;
            this.drawCorrelation.Click += new System.EventHandler(this.DrawCorrelationClick);
            // 
            // correlationWithFFT
            // 
            this.correlationWithFFT.Location = new System.Drawing.Point(411, 6);
            this.correlationWithFFT.Name = "correlationWithFFT";
            this.correlationWithFFT.ScrollGrace = 0D;
            this.correlationWithFFT.ScrollMaxX = 0D;
            this.correlationWithFFT.ScrollMaxY = 0D;
            this.correlationWithFFT.ScrollMaxY2 = 0D;
            this.correlationWithFFT.ScrollMinX = 0D;
            this.correlationWithFFT.ScrollMinY = 0D;
            this.correlationWithFFT.ScrollMinY2 = 0D;
            this.correlationWithFFT.Size = new System.Drawing.Size(399, 320);
            this.correlationWithFFT.TabIndex = 3;
            // 
            // correlation
            // 
            this.correlation.Location = new System.Drawing.Point(6, 6);
            this.correlation.Name = "correlation";
            this.correlation.ScrollGrace = 0D;
            this.correlation.ScrollMaxX = 0D;
            this.correlation.ScrollMaxY = 0D;
            this.correlation.ScrollMaxY2 = 0D;
            this.correlation.ScrollMinX = 0D;
            this.correlation.ScrollMinY = 0D;
            this.correlation.ScrollMinY2 = 0D;
            this.correlation.Size = new System.Drawing.Size(399, 320);
            this.correlation.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Convulation Complexibility = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(279, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(37, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Convulation Complexibility with FFT = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(353, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(348, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(32, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Correlation Complexibility with FFT = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(274, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(32, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Correlation Complexibility = ";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 474);
            this.Controls.Add(this.Graphs);
            this.Name = "ApplicationForm";
            this.Text = "Lab02 - Convolution and Correlation - v1";
            this.Graphs.ResumeLayout(false);
            this.Functions.ResumeLayout(false);
            this.Functions.PerformLayout();
            this.Convulations.ResumeLayout(false);
            this.Convulations.PerformLayout();
            this.Correlations.ResumeLayout(false);
            this.Correlations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Graphs;
        private System.Windows.Forms.TabPage Functions;
        private System.Windows.Forms.TabPage Convulations;
        private System.Windows.Forms.TabPage Correlations;
        private ZedGraph.ZedGraphControl zFunction;
        private ZedGraph.ZedGraphControl originalFunction;
        private System.Windows.Forms.Button drawFunctions;
        private System.Windows.Forms.Button drawConvulation;
        private ZedGraph.ZedGraphControl convulationWithFFT;
        private ZedGraph.ZedGraphControl convulation;
        private ZedGraph.ZedGraphControl correlationWithFFT;
        private ZedGraph.ZedGraphControl correlation;
        private System.Windows.Forms.Button drawCorrelation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

