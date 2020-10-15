namespace Exercice10
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
            this.label7 = new System.Windows.Forms.Label();
            this.ex10hScrollBar = new System.Windows.Forms.HScrollBar();
            this.scrollTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 56;
            this.label7.Text = "Exercice 10";
            // 
            // ex10hScrollBar
            // 
            this.ex10hScrollBar.LargeChange = 5;
            this.ex10hScrollBar.Location = new System.Drawing.Point(87, 183);
            this.ex10hScrollBar.Maximum = 84;
            this.ex10hScrollBar.Minimum = 50;
            this.ex10hScrollBar.Name = "ex10hScrollBar";
            this.ex10hScrollBar.Size = new System.Drawing.Size(530, 31);
            this.ex10hScrollBar.TabIndex = 57;
            this.ex10hScrollBar.Value = 50;
            this.ex10hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ex10hScrollBar_Scroll);
            // 
            // scrollTextBox
            // 
            this.scrollTextBox.Location = new System.Drawing.Point(87, 255);
            this.scrollTextBox.Name = "scrollTextBox";
            this.scrollTextBox.Size = new System.Drawing.Size(530, 20);
            this.scrollTextBox.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 317);
            this.Controls.Add(this.scrollTextBox);
            this.Controls.Add(this.ex10hScrollBar);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar ex10hScrollBar;
        private System.Windows.Forms.TextBox scrollTextBox;
    }
}

