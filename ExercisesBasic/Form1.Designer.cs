namespace ExercisesBasic
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
            this.titleExercice1 = new System.Windows.Forms.Label();
            this.helloText = new System.Windows.Forms.Label();
            this.titleExercice2 = new System.Windows.Forms.Label();
            this.exercice2CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.operador1Label = new System.Windows.Forms.Label();
            this.operador2Label = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.operador1TextBox = new System.Windows.Forms.TextBox();
            this.operador2TextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.operant1TextBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleExercice1
            // 
            this.titleExercice1.AutoSize = true;
            this.titleExercice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleExercice1.Location = new System.Drawing.Point(22, 13);
            this.titleExercice1.Name = "titleExercice1";
            this.titleExercice1.Size = new System.Drawing.Size(110, 24);
            this.titleExercice1.TabIndex = 0;
            this.titleExercice1.Text = "Exercice 1";
            // 
            // helloText
            // 
            this.helloText.AutoSize = true;
            this.helloText.Location = new System.Drawing.Point(195, 23);
            this.helloText.Name = "helloText";
            this.helloText.Size = new System.Drawing.Size(31, 13);
            this.helloText.TabIndex = 1;
            this.helloText.Text = "Hello";
            this.helloText.Click += new System.EventHandler(this.helloText_Click);
            // 
            // titleExercice2
            // 
            this.titleExercice2.AutoSize = true;
            this.titleExercice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleExercice2.Location = new System.Drawing.Point(22, 67);
            this.titleExercice2.Name = "titleExercice2";
            this.titleExercice2.Size = new System.Drawing.Size(110, 24);
            this.titleExercice2.TabIndex = 2;
            this.titleExercice2.Text = "Exercice 2";
            // 
            // exercice2CheckBox
            // 
            this.exercice2CheckBox.AutoSize = true;
            this.exercice2CheckBox.Location = new System.Drawing.Point(198, 73);
            this.exercice2CheckBox.Name = "exercice2CheckBox";
            this.exercice2CheckBox.Size = new System.Drawing.Size(80, 17);
            this.exercice2CheckBox.TabIndex = 3;
            this.exercice2CheckBox.Text = "checkBox1";
            this.exercice2CheckBox.UseVisualStyleBackColor = true;
            this.exercice2CheckBox.CheckedChanged += new System.EventHandler(this.exercice2CheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exercice 3";
            // 
            // operador1Label
            // 
            this.operador1Label.AutoSize = true;
            this.operador1Label.Location = new System.Drawing.Point(198, 161);
            this.operador1Label.Name = "operador1Label";
            this.operador1Label.Size = new System.Drawing.Size(63, 13);
            this.operador1Label.TabIndex = 5;
            this.operador1Label.Text = "Operador 1:";
            // 
            // operador2Label
            // 
            this.operador2Label.AutoSize = true;
            this.operador2Label.Location = new System.Drawing.Point(198, 220);
            this.operador2Label.Name = "operador2Label";
            this.operador2Label.Size = new System.Drawing.Size(63, 13);
            this.operador2Label.TabIndex = 6;
            this.operador2Label.Text = "Operador 2:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(211, 301);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result:";
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(214, 260);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 8;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(418, 260);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // operador1TextBox
            // 
            this.operador1TextBox.Location = new System.Drawing.Point(301, 161);
            this.operador1TextBox.Name = "operador1TextBox";
            this.operador1TextBox.Size = new System.Drawing.Size(100, 20);
            this.operador1TextBox.TabIndex = 10;
            // 
            // operador2TextBox
            // 
            this.operador2TextBox.Location = new System.Drawing.Point(301, 217);
            this.operador2TextBox.Name = "operador2TextBox";
            this.operador2TextBox.Size = new System.Drawing.Size(100, 20);
            this.operador2TextBox.TabIndex = 11;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(301, 301);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Exercice 4";
            // 
            // operant1TextBox1
            // 
            this.operant1TextBox1.Location = new System.Drawing.Point(88, 409);
            this.operant1TextBox1.Name = "operant1TextBox1";
            this.operant1TextBox1.Size = new System.Drawing.Size(100, 20);
            this.operant1TextBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 468);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(502, 409);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 848);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.operant1TextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.operador2TextBox);
            this.Controls.Add(this.operador1TextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.operador2Label);
            this.Controls.Add(this.operador1Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exercice2CheckBox);
            this.Controls.Add(this.titleExercice2);
            this.Controls.Add(this.helloText);
            this.Controls.Add(this.titleExercice1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleExercice1;
        private System.Windows.Forms.Label helloText;
        private System.Windows.Forms.Label titleExercice2;
        private System.Windows.Forms.CheckBox exercice2CheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label operador1Label;
        private System.Windows.Forms.Label operador2Label;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox operador1TextBox;
        private System.Windows.Forms.TextBox operador2TextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox operant1TextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

