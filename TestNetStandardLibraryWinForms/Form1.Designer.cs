namespace TestNetStandardLibraryWinForms
{
    partial class Form1
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
            this.txtChecker = new System.Windows.Forms.TextBox();
            this.btnTestChecker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChecker
            // 
            this.txtChecker.Location = new System.Drawing.Point(48, 36);
            this.txtChecker.Name = "txtChecker";
            this.txtChecker.Size = new System.Drawing.Size(195, 22);
            this.txtChecker.TabIndex = 0;
            // 
            // btnTestChecker
            // 
            this.btnTestChecker.Location = new System.Drawing.Point(64, 81);
            this.btnTestChecker.Name = "btnTestChecker";
            this.btnTestChecker.Size = new System.Drawing.Size(148, 23);
            this.btnTestChecker.TabIndex = 1;
            this.btnTestChecker.Text = "Test .NET Standard Libaray";
            this.btnTestChecker.UseVisualStyleBackColor = true;
            this.btnTestChecker.Click += new System.EventHandler(this.btnTestChecker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 157);
            this.Controls.Add(this.btnTestChecker);
            this.Controls.Add(this.txtChecker);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TestNetStandardLibraryWinForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChecker;
        private System.Windows.Forms.Button btnTestChecker;
    }
}

