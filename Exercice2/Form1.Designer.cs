namespace Exercice2
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
            this.exercice2CheckBox = new System.Windows.Forms.CheckBox();
            this.titleExercice2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exercice2CheckBox
            // 
            this.exercice2CheckBox.AutoSize = true;
            this.exercice2CheckBox.Location = new System.Drawing.Point(403, 182);
            this.exercice2CheckBox.Name = "exercice2CheckBox";
            this.exercice2CheckBox.Size = new System.Drawing.Size(80, 17);
            this.exercice2CheckBox.TabIndex = 5;
            this.exercice2CheckBox.Text = "checkBox1";
            this.exercice2CheckBox.UseVisualStyleBackColor = true;
            this.exercice2CheckBox.CheckedChanged += new System.EventHandler(this.exercice2CheckBox_CheckedChanged);
            // 
            // titleExercice2
            // 
            this.titleExercice2.AutoSize = true;
            this.titleExercice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleExercice2.Location = new System.Drawing.Point(227, 176);
            this.titleExercice2.Name = "titleExercice2";
            this.titleExercice2.Size = new System.Drawing.Size(110, 24);
            this.titleExercice2.TabIndex = 4;
            this.titleExercice2.Text = "Exercice 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exercice2CheckBox);
            this.Controls.Add(this.titleExercice2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox exercice2CheckBox;
        private System.Windows.Forms.Label titleExercice2;
    }
}

