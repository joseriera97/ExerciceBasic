namespace Exercice1
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
            this.helloText = new System.Windows.Forms.Label();
            this.titleExercice1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloText
            // 
            this.helloText.AutoSize = true;
            this.helloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloText.Location = new System.Drawing.Point(370, 151);
            this.helloText.Name = "helloText";
            this.helloText.Size = new System.Drawing.Size(45, 20);
            this.helloText.TabIndex = 3;
            this.helloText.Text = "Hello";
            this.helloText.Click += new System.EventHandler(this.helloText_Click_1);
            // 
            // titleExercice1
            // 
            this.titleExercice1.AutoSize = true;
            this.titleExercice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleExercice1.Location = new System.Drawing.Point(190, 144);
            this.titleExercice1.Name = "titleExercice1";
            this.titleExercice1.Size = new System.Drawing.Size(135, 29);
            this.titleExercice1.TabIndex = 2;
            this.titleExercice1.Text = "Exercice 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helloText);
            this.Controls.Add(this.titleExercice1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloText;
        private System.Windows.Forms.Label titleExercice1;
    }
}

