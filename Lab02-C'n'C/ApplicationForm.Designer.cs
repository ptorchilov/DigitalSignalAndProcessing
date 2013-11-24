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
            this.zFunction = new ZedGraph.ZedGraphControl();
            this.originalFunction = new ZedGraph.ZedGraphControl();
            this.Convulations = new System.Windows.Forms.TabPage();
            this.Correlations = new System.Windows.Forms.TabPage();
            this.drawFunctions = new System.Windows.Forms.Button();
            this.Graphs.SuspendLayout();
            this.Functions.SuspendLayout();
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
            this.Convulations.Location = new System.Drawing.Point(4, 22);
            this.Convulations.Name = "Convulations";
            this.Convulations.Padding = new System.Windows.Forms.Padding(3);
            this.Convulations.Size = new System.Drawing.Size(826, 424);
            this.Convulations.TabIndex = 2;
            this.Convulations.Text = "Convulations";
            this.Convulations.UseVisualStyleBackColor = true;
            // 
            // Correlations
            // 
            this.Correlations.Location = new System.Drawing.Point(4, 22);
            this.Correlations.Name = "Correlations";
            this.Correlations.Padding = new System.Windows.Forms.Padding(3);
            this.Correlations.Size = new System.Drawing.Size(826, 424);
            this.Correlations.TabIndex = 3;
            this.Correlations.Text = "Correlations";
            this.Correlations.UseVisualStyleBackColor = true;
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
    }
}

