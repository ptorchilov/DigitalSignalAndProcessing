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
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageFFT = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.zedGraphControl5 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl6 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl7 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl8 = new ZedGraph.ZedGraphControl();
            this.tabControl.SuspendLayout();
            this.tabPageDFT.SuspendLayout();
            this.tabPageFFT.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(18, 6);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(381, 260);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDFT);
            this.tabControl.Controls.Add(this.tabPageFFT);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(860, 654);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageDFT
            // 
            this.tabPageDFT.Controls.Add(this.zedGraphControl4);
            this.tabPageDFT.Controls.Add(this.zedGraphControl3);
            this.tabPageDFT.Controls.Add(this.zedGraphControl2);
            this.tabPageDFT.Controls.Add(this.label4);
            this.tabPageDFT.Controls.Add(this.label3);
            this.tabPageDFT.Controls.Add(this.label2);
            this.tabPageDFT.Controls.Add(this.label1);
            this.tabPageDFT.Controls.Add(this.button1);
            this.tabPageDFT.Controls.Add(this.zedGraphControl1);
            this.tabPageDFT.Location = new System.Drawing.Point(4, 22);
            this.tabPageDFT.Name = "tabPageDFT";
            this.tabPageDFT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDFT.Size = new System.Drawing.Size(852, 628);
            this.tabPageDFT.TabIndex = 0;
            this.tabPageDFT.Text = "DFT";
            this.tabPageDFT.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Location = new System.Drawing.Point(418, 272);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 0D;
            this.zedGraphControl4.ScrollMaxY = 0D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(404, 277);
            this.zedGraphControl4.TabIndex = 8;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Location = new System.Drawing.Point(18, 272);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(381, 277);
            this.zedGraphControl3.TabIndex = 7;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(418, 6);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(404, 260);
            this.zedGraphControl2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(456, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(330, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Complexity =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(233, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "N = 8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "y = cos(x) + sin(2x)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Do transform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DrawDftButtonClick);
            // 
            // tabPageFFT
            // 
            this.tabPageFFT.Controls.Add(this.zedGraphControl5);
            this.tabPageFFT.Controls.Add(this.zedGraphControl6);
            this.tabPageFFT.Controls.Add(this.zedGraphControl7);
            this.tabPageFFT.Controls.Add(this.zedGraphControl8);
            this.tabPageFFT.Controls.Add(this.label5);
            this.tabPageFFT.Controls.Add(this.label6);
            this.tabPageFFT.Controls.Add(this.label7);
            this.tabPageFFT.Controls.Add(this.label8);
            this.tabPageFFT.Controls.Add(this.button2);
            this.tabPageFFT.Location = new System.Drawing.Point(4, 22);
            this.tabPageFFT.Name = "tabPageFFT";
            this.tabPageFFT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFFT.Size = new System.Drawing.Size(852, 628);
            this.tabPageFFT.TabIndex = 1;
            this.tabPageFFT.Text = "FFT";
            this.tabPageFFT.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(461, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(335, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Complexity =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(238, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "N = 8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "y = cos(x) + sin(2x)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(735, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Do transform";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zedGraphControl5
            // 
            this.zedGraphControl5.Location = new System.Drawing.Point(417, 272);
            this.zedGraphControl5.Name = "zedGraphControl5";
            this.zedGraphControl5.ScrollGrace = 0D;
            this.zedGraphControl5.ScrollMaxX = 0D;
            this.zedGraphControl5.ScrollMaxY = 0D;
            this.zedGraphControl5.ScrollMaxY2 = 0D;
            this.zedGraphControl5.ScrollMinX = 0D;
            this.zedGraphControl5.ScrollMinY = 0D;
            this.zedGraphControl5.ScrollMinY2 = 0D;
            this.zedGraphControl5.Size = new System.Drawing.Size(404, 277);
            this.zedGraphControl5.TabIndex = 14;
            // 
            // zedGraphControl6
            // 
            this.zedGraphControl6.Location = new System.Drawing.Point(17, 272);
            this.zedGraphControl6.Name = "zedGraphControl6";
            this.zedGraphControl6.ScrollGrace = 0D;
            this.zedGraphControl6.ScrollMaxX = 0D;
            this.zedGraphControl6.ScrollMaxY = 0D;
            this.zedGraphControl6.ScrollMaxY2 = 0D;
            this.zedGraphControl6.ScrollMinX = 0D;
            this.zedGraphControl6.ScrollMinY = 0D;
            this.zedGraphControl6.ScrollMinY2 = 0D;
            this.zedGraphControl6.Size = new System.Drawing.Size(381, 277);
            this.zedGraphControl6.TabIndex = 13;
            // 
            // zedGraphControl7
            // 
            this.zedGraphControl7.Location = new System.Drawing.Point(417, 6);
            this.zedGraphControl7.Name = "zedGraphControl7";
            this.zedGraphControl7.ScrollGrace = 0D;
            this.zedGraphControl7.ScrollMaxX = 0D;
            this.zedGraphControl7.ScrollMaxY = 0D;
            this.zedGraphControl7.ScrollMaxY2 = 0D;
            this.zedGraphControl7.ScrollMinX = 0D;
            this.zedGraphControl7.ScrollMinY = 0D;
            this.zedGraphControl7.ScrollMinY2 = 0D;
            this.zedGraphControl7.Size = new System.Drawing.Size(404, 260);
            this.zedGraphControl7.TabIndex = 12;
            // 
            // zedGraphControl8
            // 
            this.zedGraphControl8.Location = new System.Drawing.Point(17, 6);
            this.zedGraphControl8.Name = "zedGraphControl8";
            this.zedGraphControl8.ScrollGrace = 0D;
            this.zedGraphControl8.ScrollMaxX = 0D;
            this.zedGraphControl8.ScrollMaxY = 0D;
            this.zedGraphControl8.ScrollMaxY2 = 0D;
            this.zedGraphControl8.ScrollMinX = 0D;
            this.zedGraphControl8.ScrollMinY = 0D;
            this.zedGraphControl8.ScrollMinY2 = 0D;
            this.zedGraphControl8.Size = new System.Drawing.Size(381, 260);
            this.zedGraphControl8.TabIndex = 11;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 678);
            this.Controls.Add(this.tabControl);
            this.Name = "ApplicationForm";
            this.Text = "ApplicationForm";
            this.tabControl.ResumeLayout(false);
            this.tabPageDFT.ResumeLayout(false);
            this.tabPageDFT.PerformLayout();
            this.tabPageFFT.ResumeLayout(false);
            this.tabPageFFT.PerformLayout();
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
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private ZedGraph.ZedGraphControl zedGraphControl5;
        private ZedGraph.ZedGraphControl zedGraphControl6;
        private ZedGraph.ZedGraphControl zedGraphControl7;
        private ZedGraph.ZedGraphControl zedGraphControl8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}
