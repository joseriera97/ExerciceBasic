namespace Exercice4a
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
            this.ex4CalcularButton = new System.Windows.Forms.Button();
            this.ex4ResetButton = new System.Windows.Forms.Button();
            this.ex4OperacionTextBox = new System.Windows.Forms.TextBox();
            this.ex4OperacionLabel = new System.Windows.Forms.Label();
            this.ex4RestarButton = new System.Windows.Forms.Button();
            this.ex4SumarButton = new System.Windows.Forms.Button();
            this.ex4Label = new System.Windows.Forms.Label();
            this.ex4ResultatTextBox = new System.Windows.Forms.TextBox();
            this.ex4Operant2TextBox = new System.Windows.Forms.TextBox();
            this.ex4Operant1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ex4CalcularButton
            // 
            this.ex4CalcularButton.Location = new System.Drawing.Point(186, 288);
            this.ex4CalcularButton.Name = "ex4CalcularButton";
            this.ex4CalcularButton.Size = new System.Drawing.Size(134, 23);
            this.ex4CalcularButton.TabIndex = 34;
            this.ex4CalcularButton.Text = "Calcular";
            this.ex4CalcularButton.UseVisualStyleBackColor = true;
            this.ex4CalcularButton.Click += new System.EventHandler(this.ex4CalcularButton_Click);
            // 
            // ex4ResetButton
            // 
            this.ex4ResetButton.Location = new System.Drawing.Point(487, 291);
            this.ex4ResetButton.Name = "ex4ResetButton";
            this.ex4ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ex4ResetButton.TabIndex = 33;
            this.ex4ResetButton.Text = "Reset";
            this.ex4ResetButton.UseVisualStyleBackColor = true;
            this.ex4ResetButton.Click += new System.EventHandler(this.ex4ResetButton_Click);
            // 
            // ex4OperacionTextBox
            // 
            this.ex4OperacionTextBox.Location = new System.Drawing.Point(381, 291);
            this.ex4OperacionTextBox.Name = "ex4OperacionTextBox";
            this.ex4OperacionTextBox.Size = new System.Drawing.Size(49, 20);
            this.ex4OperacionTextBox.TabIndex = 32;
            // 
            // ex4OperacionLabel
            // 
            this.ex4OperacionLabel.AutoSize = true;
            this.ex4OperacionLabel.Location = new System.Drawing.Point(348, 275);
            this.ex4OperacionLabel.Name = "ex4OperacionLabel";
            this.ex4OperacionLabel.Size = new System.Drawing.Size(122, 13);
            this.ex4OperacionLabel.TabIndex = 31;
            this.ex4OperacionLabel.Text = "Operacion seleccionada";
            // 
            // ex4RestarButton
            // 
            this.ex4RestarButton.Location = new System.Drawing.Point(370, 236);
            this.ex4RestarButton.Name = "ex4RestarButton";
            this.ex4RestarButton.Size = new System.Drawing.Size(75, 23);
            this.ex4RestarButton.TabIndex = 30;
            this.ex4RestarButton.Text = "Restar";
            this.ex4RestarButton.UseVisualStyleBackColor = true;
            this.ex4RestarButton.Click += new System.EventHandler(this.ex4RestarButton_Click);
            // 
            // ex4SumarButton
            // 
            this.ex4SumarButton.Location = new System.Drawing.Point(370, 193);
            this.ex4SumarButton.Name = "ex4SumarButton";
            this.ex4SumarButton.Size = new System.Drawing.Size(75, 23);
            this.ex4SumarButton.TabIndex = 29;
            this.ex4SumarButton.Text = "Sumar";
            this.ex4SumarButton.UseVisualStyleBackColor = true;
            this.ex4SumarButton.Click += new System.EventHandler(this.ex4SumarButton_Click);
            // 
            // ex4Label
            // 
            this.ex4Label.AutoSize = true;
            this.ex4Label.Location = new System.Drawing.Point(322, 156);
            this.ex4Label.Name = "ex4Label";
            this.ex4Label.Size = new System.Drawing.Size(160, 13);
            this.ex4Label.TabIndex = 28;
            this.ex4Label.Text = "Selecione la operacion a realizar";
            // 
            // ex4ResultatTextBox
            // 
            this.ex4ResultatTextBox.Location = new System.Drawing.Point(487, 216);
            this.ex4ResultatTextBox.Name = "ex4ResultatTextBox";
            this.ex4ResultatTextBox.Size = new System.Drawing.Size(100, 20);
            this.ex4ResultatTextBox.TabIndex = 27;
            // 
            // ex4Operant2TextBox
            // 
            this.ex4Operant2TextBox.Location = new System.Drawing.Point(186, 236);
            this.ex4Operant2TextBox.Name = "ex4Operant2TextBox";
            this.ex4Operant2TextBox.Size = new System.Drawing.Size(100, 20);
            this.ex4Operant2TextBox.TabIndex = 26;
            // 
            // ex4Operant1TextBox
            // 
            this.ex4Operant1TextBox.Location = new System.Drawing.Point(186, 193);
            this.ex4Operant1TextBox.Name = "ex4Operant1TextBox";
            this.ex4Operant1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ex4Operant1TextBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Exercice 4 a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ex4CalcularButton);
            this.Controls.Add(this.ex4ResetButton);
            this.Controls.Add(this.ex4OperacionTextBox);
            this.Controls.Add(this.ex4OperacionLabel);
            this.Controls.Add(this.ex4RestarButton);
            this.Controls.Add(this.ex4SumarButton);
            this.Controls.Add(this.ex4Label);
            this.Controls.Add(this.ex4ResultatTextBox);
            this.Controls.Add(this.ex4Operant2TextBox);
            this.Controls.Add(this.ex4Operant1TextBox);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Exercice 4 a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ex4CalcularButton;
        private System.Windows.Forms.Button ex4ResetButton;
        private System.Windows.Forms.TextBox ex4OperacionTextBox;
        private System.Windows.Forms.Label ex4OperacionLabel;
        private System.Windows.Forms.Button ex4RestarButton;
        private System.Windows.Forms.Button ex4SumarButton;
        private System.Windows.Forms.Label ex4Label;
        private System.Windows.Forms.TextBox ex4ResultatTextBox;
        private System.Windows.Forms.TextBox ex4Operant2TextBox;
        private System.Windows.Forms.TextBox ex4Operant1TextBox;
        private System.Windows.Forms.Label label2;
    }
}

