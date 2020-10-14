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
            this.ex4Operant1TextBox = new System.Windows.Forms.TextBox();
            this.ex4Operant2TextBox = new System.Windows.Forms.TextBox();
            this.ex4ResultatTextBox = new System.Windows.Forms.TextBox();
            this.ex4Label = new System.Windows.Forms.Label();
            this.ex4SumarButton = new System.Windows.Forms.Button();
            this.ex4RestarButton = new System.Windows.Forms.Button();
            this.ex4OperacionLabel = new System.Windows.Forms.Label();
            this.ex4OperacionTextBox = new System.Windows.Forms.TextBox();
            this.ex4ResetButton = new System.Windows.Forms.Button();
            this.ex4CalcularButton = new System.Windows.Forms.Button();
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
            // ex4Operant1TextBox
            // 
            this.ex4Operant1TextBox.Location = new System.Drawing.Point(117, 428);
            this.ex4Operant1TextBox.Name = "ex4Operant1TextBox";
            this.ex4Operant1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ex4Operant1TextBox.TabIndex = 14;
            // 
            // ex4Operant2TextBox
            // 
            this.ex4Operant2TextBox.Location = new System.Drawing.Point(117, 471);
            this.ex4Operant2TextBox.Name = "ex4Operant2TextBox";
            this.ex4Operant2TextBox.Size = new System.Drawing.Size(100, 20);
            this.ex4Operant2TextBox.TabIndex = 15;
            // 
            // ex4ResultatTextBox
            // 
            this.ex4ResultatTextBox.Location = new System.Drawing.Point(418, 451);
            this.ex4ResultatTextBox.Name = "ex4ResultatTextBox";
            this.ex4ResultatTextBox.Size = new System.Drawing.Size(100, 20);
            this.ex4ResultatTextBox.TabIndex = 16;
            // 
            // ex4Label
            // 
            this.ex4Label.AutoSize = true;
            this.ex4Label.Location = new System.Drawing.Point(253, 391);
            this.ex4Label.Name = "ex4Label";
            this.ex4Label.Size = new System.Drawing.Size(160, 13);
            this.ex4Label.TabIndex = 17;
            this.ex4Label.Text = "Selecione la operacion a realizar";
            // 
            // ex4SumarButton
            // 
            this.ex4SumarButton.Location = new System.Drawing.Point(301, 428);
            this.ex4SumarButton.Name = "ex4SumarButton";
            this.ex4SumarButton.Size = new System.Drawing.Size(75, 23);
            this.ex4SumarButton.TabIndex = 18;
            this.ex4SumarButton.Text = "Sumar";
            this.ex4SumarButton.UseVisualStyleBackColor = true;
            this.ex4SumarButton.Click += new System.EventHandler(this.ex4SumarButton_Click);
            // 
            // ex4RestarButton
            // 
            this.ex4RestarButton.Location = new System.Drawing.Point(301, 471);
            this.ex4RestarButton.Name = "ex4RestarButton";
            this.ex4RestarButton.Size = new System.Drawing.Size(75, 23);
            this.ex4RestarButton.TabIndex = 19;
            this.ex4RestarButton.Text = "Restar";
            this.ex4RestarButton.UseVisualStyleBackColor = true;
            this.ex4RestarButton.Click += new System.EventHandler(this.ex4RestarButton_Click);
            // 
            // ex4OperacionLabel
            // 
            this.ex4OperacionLabel.AutoSize = true;
            this.ex4OperacionLabel.Location = new System.Drawing.Point(279, 510);
            this.ex4OperacionLabel.Name = "ex4OperacionLabel";
            this.ex4OperacionLabel.Size = new System.Drawing.Size(122, 13);
            this.ex4OperacionLabel.TabIndex = 20;
            this.ex4OperacionLabel.Text = "Operacion seleccionada";
            // 
            // ex4OperacionTextBox
            // 
            this.ex4OperacionTextBox.Location = new System.Drawing.Point(312, 526);
            this.ex4OperacionTextBox.Name = "ex4OperacionTextBox";
            this.ex4OperacionTextBox.Size = new System.Drawing.Size(49, 20);
            this.ex4OperacionTextBox.TabIndex = 21;
            // 
            // ex4ResetButton
            // 
            this.ex4ResetButton.Location = new System.Drawing.Point(418, 526);
            this.ex4ResetButton.Name = "ex4ResetButton";
            this.ex4ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ex4ResetButton.TabIndex = 22;
            this.ex4ResetButton.Text = "Reset";
            this.ex4ResetButton.UseVisualStyleBackColor = true;
            this.ex4ResetButton.Click += new System.EventHandler(this.ex4ResetButton_Click);
            // 
            // ex4CalcularButton
            // 
            this.ex4CalcularButton.Location = new System.Drawing.Point(117, 523);
            this.ex4CalcularButton.Name = "ex4CalcularButton";
            this.ex4CalcularButton.Size = new System.Drawing.Size(134, 23);
            this.ex4CalcularButton.TabIndex = 23;
            this.ex4CalcularButton.Text = "Calcular";
            this.ex4CalcularButton.UseVisualStyleBackColor = true;
            this.ex4CalcularButton.Click += new System.EventHandler(this.ex4CalcularButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 848);
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
        private System.Windows.Forms.TextBox ex4Operant1TextBox;
        private System.Windows.Forms.TextBox ex4Operant2TextBox;
        private System.Windows.Forms.TextBox ex4ResultatTextBox;
        private System.Windows.Forms.Label ex4Label;
        private System.Windows.Forms.Button ex4SumarButton;
        private System.Windows.Forms.Button ex4RestarButton;
        private System.Windows.Forms.Label ex4OperacionLabel;
        private System.Windows.Forms.TextBox ex4OperacionTextBox;
        private System.Windows.Forms.Button ex4ResetButton;
        private System.Windows.Forms.Button ex4CalcularButton;
    }
}

