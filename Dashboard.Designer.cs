namespace RegistrationForm
{
    partial class Dashboard
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
            this.rTOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTOutput
            // 
            this.rTOutput.Location = new System.Drawing.Point(41, 43);
            this.rTOutput.Name = "rTOutput";
            this.rTOutput.Size = new System.Drawing.Size(733, 396);
            this.rTOutput.TabIndex = 21;
            this.rTOutput.Text = "";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 488);
            this.Controls.Add(this.rTOutput);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTOutput;
    }
}