﻿// --------------------------------------------------------------------------------------------------------------------
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
            this.SuspendLayout();
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Name = "ApplicationForm";
            this.Text = "ApplicationForm";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
