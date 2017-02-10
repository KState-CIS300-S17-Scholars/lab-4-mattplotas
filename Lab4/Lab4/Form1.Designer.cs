namespace Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxBoundBox = new System.Windows.Forms.TextBox();
            this.uxResultBox = new System.Windows.Forms.TextBox();
            this.uxFindButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter positive bound:";
            // 
            // uxBoundBox
            // 
            this.uxBoundBox.Location = new System.Drawing.Point(125, 18);
            this.uxBoundBox.Name = "uxBoundBox";
            this.uxBoundBox.Size = new System.Drawing.Size(100, 20);
            this.uxBoundBox.TabIndex = 1;
            // 
            // uxResultBox
            // 
            this.uxResultBox.Location = new System.Drawing.Point(15, 82);
            this.uxResultBox.Multiline = true;
            this.uxResultBox.Name = "uxResultBox";
            this.uxResultBox.ReadOnly = true;
            this.uxResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResultBox.Size = new System.Drawing.Size(210, 97);
            this.uxResultBox.TabIndex = 2;
            // 
            // uxFindButton
            // 
            this.uxFindButton.Location = new System.Drawing.Point(78, 50);
            this.uxFindButton.Name = "uxFindButton";
            this.uxFindButton.Size = new System.Drawing.Size(75, 23);
            this.uxFindButton.TabIndex = 3;
            this.uxFindButton.Text = "Find Primes";
            this.uxFindButton.UseVisualStyleBackColor = true;
            this.uxFindButton.Click += new System.EventHandler(this.uxFindButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 197);
            this.Controls.Add(this.uxFindButton);
            this.Controls.Add(this.uxResultBox);
            this.Controls.Add(this.uxBoundBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxBoundBox;
        private System.Windows.Forms.TextBox uxResultBox;
        private System.Windows.Forms.Button uxFindButton;
    }
}

