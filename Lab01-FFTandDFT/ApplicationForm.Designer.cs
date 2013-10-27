// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationForm.Designer.cs" company="BSUIR">
//   Torchilov Pavel
// </copyright>
// <summary>
//   Defines the ApplicationForm type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab01_FFTandDFT
{
    /// <summary>
    /// The application form.
    /// </summary>
    public partial class ApplicationForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDFT = new System.Windows.Forms.TabPage();
            this.tabPageFFT = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageDFT.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(6, 6);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(381, 272);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDFT);
            this.tabControl.Controls.Add(this.tabPageFFT);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(860, 538);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageDFT
            // 
            this.tabPageDFT.Controls.Add(this.button1);
            this.tabPageDFT.Controls.Add(this.zedGraphControl1);
            this.tabPageDFT.Location = new System.Drawing.Point(4, 22);
            this.tabPageDFT.Name = "tabPageDFT";
            this.tabPageDFT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDFT.Size = new System.Drawing.Size(852, 512);
            this.tabPageDFT.TabIndex = 0;
            this.tabPageDFT.Text = "DFT";
            this.tabPageDFT.UseVisualStyleBackColor = true;
            // 
            // tabPageFFT
            // 
            this.tabPageFFT.Location = new System.Drawing.Point(4, 22);
            this.tabPageFFT.Name = "tabPageFFT";
            this.tabPageFFT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFFT.Size = new System.Drawing.Size(852, 512);
            this.tabPageFFT.TabIndex = 1;
            this.tabPageFFT.Text = "FFT";
            this.tabPageFFT.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DrawDftButtonClick);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.tabControl);
            this.Name = "ApplicationForm";
            this.Text = "ApplicationForm";
            this.tabControl.ResumeLayout(false);
            this.tabPageDFT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The zed graph control 1.
        /// </summary>
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDFT;
        private System.Windows.Forms.TabPage tabPageFFT;
        private System.Windows.Forms.Button button1;
    }
}
