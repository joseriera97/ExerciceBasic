namespace Exercice9
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
            this.numerosComboBox = new System.Windows.Forms.ComboBox();
            this.parButton = new System.Windows.Forms.Button();
            this.imparButton = new System.Windows.Forms.Button();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "Exercice 9";
            // 
            // numerosComboBox
            // 
            this.numerosComboBox.FormattingEnabled = true;
            this.numerosComboBox.Location = new System.Drawing.Point(106, 77);
            this.numerosComboBox.Name = "numerosComboBox";
            this.numerosComboBox.Size = new System.Drawing.Size(121, 21);
            this.numerosComboBox.TabIndex = 56;
            this.numerosComboBox.SelectedIndexChanged += new System.EventHandler(this.numerosComboBox_SelectedIndexChanged);
            // 
            // parButton
            // 
            this.parButton.Location = new System.Drawing.Point(327, 77);
            this.parButton.Name = "parButton";
            this.parButton.Size = new System.Drawing.Size(127, 23);
            this.parButton.TabIndex = 57;
            this.parButton.Text = "Even(Par)";
            this.parButton.UseVisualStyleBackColor = true;
            this.parButton.Click += new System.EventHandler(this.parButton_Click);
            // 
            // imparButton
            // 
            this.imparButton.Location = new System.Drawing.Point(503, 77);
            this.imparButton.Name = "imparButton";
            this.imparButton.Size = new System.Drawing.Size(127, 23);
            this.imparButton.TabIndex = 58;
            this.imparButton.Text = "Odd(Impar)";
            this.imparButton.UseVisualStyleBackColor = true;
            this.imparButton.Click += new System.EventHandler(this.imparButton_Click);
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(106, 236);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(524, 20);
            this.numeroTextBox.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 308);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.imparButton);
            this.Controls.Add(this.parButton);
            this.Controls.Add(this.numerosComboBox);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox numerosComboBox;
        private System.Windows.Forms.Button parButton;
        private System.Windows.Forms.Button imparButton;
        private System.Windows.Forms.TextBox numeroTextBox;
    }
}

