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
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 474);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.reverseFunction);
            this.Controls.Add(this.walshTransform);
            this.Controls.Add(this.originalFunction);
            this.Name = "ApplicationForm";
            this.Text = "Lab03 - Walsh Transform - v1";
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl originalFunction;
        private ZedGraph.ZedGraphControl walshTransform;
        private ZedGraph.ZedGraphControl reverseFunction;
        private System.Windows.Forms.Button drawButton;
    }
}

