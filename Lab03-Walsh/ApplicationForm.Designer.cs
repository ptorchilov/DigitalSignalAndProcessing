namespace Lab03_Walsh
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
            this.originalFunction = new ZedGraph.ZedGraphControl();
            this.walshTransform = new ZedGraph.ZedGraphControl();
            this.reverseFunction = new ZedGraph.ZedGraphControl();
            this.drawButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originalFunction
            // 
            this.originalFunction.Location = new System.Drawing.Point(12, 12);
            this.originalFunction.Name = "originalFunction";
            this.originalFunction.ScrollGrace = 0D;
            this.originalFunction.ScrollMaxX = 0D;
            this.originalFunction.ScrollMaxY = 0D;
            this.originalFunction.ScrollMaxY2 = 0D;
            this.originalFunction.ScrollMinX = 0D;
            this.originalFunction.ScrollMinY = 0D;
            this.originalFunction.ScrollMinY2 = 0D;
            this.originalFunction.Size = new System.Drawing.Size(323, 332);
            this.originalFunction.TabIndex = 0;
            // 
            // walshTransform
            // 
            this.walshTransform.Location = new System.Drawing.Point(341, 12);
            this.walshTransform.Name = "walshTransform";
            this.walshTransform.ScrollGrace = 0D;
            this.walshTransform.ScrollMaxX = 0D;
            this.walshTransform.ScrollMaxY = 0D;
            this.walshTransform.ScrollMaxY2 = 0D;
            this.walshTransform.ScrollMinX = 0D;
            this.walshTransform.ScrollMinY = 0D;
            this.walshTransform.ScrollMinY2 = 0D;
            this.walshTransform.Size = new System.Drawing.Size(325, 332);
            this.walshTransform.TabIndex = 1;
            // 
            // reverseFunction
            // 
            this.reverseFunction.Location = new System.Drawing.Point(672, 12);
            this.reverseFunction.Name = "reverseFunction";
            this.reverseFunction.ScrollGrace = 0D;
            this.reverseFunction.ScrollMaxX = 0D;
            this.reverseFunction.ScrollMaxY = 0D;
            this.reverseFunction.ScrollMaxY2 = 0D;
            this.reverseFunction.ScrollMinX = 0D;
            this.reverseFunction.ScrollMinY = 0D;
            this.reverseFunction.ScrollMinY2 = 0D;
            this.reverseFunction.Size = new System.Drawing.Size(325, 332);
            this.reverseFunction.TabIndex = 2;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(804, 395);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(149, 40);
            this.drawButton.TabIndex = 3;
            this.drawButton.Text = "Draw Graphs";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.DrawButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "y = cos(x) + sin(2x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(336, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "N = 8";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.reverseFunction);
            this.Controls.Add(this.walshTransform);
            this.Controls.Add(this.originalFunction);
            this.Name = "ApplicationForm";
            this.Text = "Lab03 - Walsh Transform - v1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl originalFunction;
        private ZedGraph.ZedGraphControl walshTransform;
        private ZedGraph.ZedGraphControl reverseFunction;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

