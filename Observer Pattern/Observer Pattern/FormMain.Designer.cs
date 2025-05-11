namespace Observer_Pattern
{
    partial class FormMain
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
            this.Decrease = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Decrease
            // 
            this.Decrease.Location = new System.Drawing.Point(288, 51);
            this.Decrease.Name = "Decrease";
            this.Decrease.Size = new System.Drawing.Size(172, 62);
            this.Decrease.TabIndex = 0;
            this.Decrease.Text = "Decrease";
            this.Decrease.UseVisualStyleBackColor = true;
            this.Decrease.Click += new System.EventHandler(this.button1_Click);
            // 
            // Increase
            // 
            this.Increase.Location = new System.Drawing.Point(37, 51);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(172, 61);
            this.Increase.TabIndex = 1;
            this.Increase.Text = "Increase";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 153);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.Decrease);
            this.Name = "FormMain";
            this.Text = "Counting Application";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Decrease;
        private System.Windows.Forms.Button Increase;
    }
}

