namespace Exercice3
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.operador2TextBox = new System.Windows.Forms.TextBox();
            this.operador1TextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.operador2Label = new System.Windows.Forms.Label();
            this.operador1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(359, 293);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 21;
            // 
            // operador2TextBox
            // 
            this.operador2TextBox.Location = new System.Drawing.Point(359, 209);
            this.operador2TextBox.Name = "operador2TextBox";
            this.operador2TextBox.Size = new System.Drawing.Size(100, 20);
            this.operador2TextBox.TabIndex = 20;
            // 
            // operador1TextBox
            // 
            this.operador1TextBox.Location = new System.Drawing.Point(359, 153);
            this.operador1TextBox.Name = "operador1TextBox";
            this.operador1TextBox.Size = new System.Drawing.Size(100, 20);
            this.operador1TextBox.TabIndex = 19;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(476, 252);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(272, 252);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 17;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(269, 293);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 16;
            this.resultLabel.Text = "Result:";
            // 
            // operador2Label
            // 
            this.operador2Label.AutoSize = true;
            this.operador2Label.Location = new System.Drawing.Point(256, 212);
            this.operador2Label.Name = "operador2Label";
            this.operador2Label.Size = new System.Drawing.Size(63, 13);
            this.operador2Label.TabIndex = 15;
            this.operador2Label.Text = "Operador 2:";
            // 
            // operador1Label
            // 
            this.operador1Label.AutoSize = true;
            this.operador1Label.Location = new System.Drawing.Point(256, 153);
            this.operador1Label.Name = "operador1Label";
            this.operador1Label.Size = new System.Drawing.Size(63, 13);
            this.operador1Label.TabIndex = 14;
            this.operador1Label.Text = "Operador 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Exercice 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.operador2TextBox);
            this.Controls.Add(this.operador1TextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.operador2Label);
            this.Controls.Add(this.operador1Label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exercice 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox operador2TextBox;
        private System.Windows.Forms.TextBox operador1TextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label operador2Label;
        private System.Windows.Forms.Label operador1Label;
        private System.Windows.Forms.Label label1;
    }
}

