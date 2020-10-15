namespace Exercice6
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
            this.ex6Button = new System.Windows.Forms.Button();
            this.ex6TextBox = new System.Windows.Forms.TextBox();
            this.coloresGroupBox = new System.Windows.Forms.GroupBox();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.coloresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ex6Button
            // 
            this.ex6Button.Location = new System.Drawing.Point(128, 224);
            this.ex6Button.Name = "ex6Button";
            this.ex6Button.Size = new System.Drawing.Size(120, 32);
            this.ex6Button.TabIndex = 0;
            this.ex6Button.Text = "OK";
            this.ex6Button.UseVisualStyleBackColor = true;
            this.ex6Button.Click += new System.EventHandler(this.ex6Button_Click);
            // 
            // ex6TextBox
            // 
            this.ex6TextBox.Location = new System.Drawing.Point(128, 298);
            this.ex6TextBox.Name = "ex6TextBox";
            this.ex6TextBox.Size = new System.Drawing.Size(412, 20);
            this.ex6TextBox.TabIndex = 48;
            this.ex6TextBox.Text = "Choosen Colour: ";
            // 
            // coloresGroupBox
            // 
            this.coloresGroupBox.Controls.Add(this.whiteRadioButton);
            this.coloresGroupBox.Controls.Add(this.blueRadioButton);
            this.coloresGroupBox.Controls.Add(this.redRadioButton);
            this.coloresGroupBox.Location = new System.Drawing.Point(181, 29);
            this.coloresGroupBox.Name = "coloresGroupBox";
            this.coloresGroupBox.Size = new System.Drawing.Size(286, 131);
            this.coloresGroupBox.TabIndex = 51;
            this.coloresGroupBox.TabStop = false;
            this.coloresGroupBox.Text = "Colour";
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(21, 20);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 0;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(22, 43);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton.TabIndex = 52;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Location = new System.Drawing.Point(23, 66);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(53, 17);
            this.whiteRadioButton.TabIndex = 52;
            this.whiteRadioButton.TabStop = true;
            this.whiteRadioButton.Text = "White";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Exercice 6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 339);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.coloresGroupBox);
            this.Controls.Add(this.ex6TextBox);
            this.Controls.Add(this.ex6Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.coloresGroupBox.ResumeLayout(false);
            this.coloresGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ex6Button;
        private System.Windows.Forms.TextBox ex6TextBox;
        private System.Windows.Forms.GroupBox coloresGroupBox;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.Label label7;
    }
}

