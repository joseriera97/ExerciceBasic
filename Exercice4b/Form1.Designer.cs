namespace Exercice4b
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
            this.ex4bOperadorListBox = new System.Windows.Forms.ListBox();
            this.ex4bCalcularButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ex4bOperacionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ex4bResultatTextBox = new System.Windows.Forms.TextBox();
            this.ex4bOperant2TextBox = new System.Windows.Forms.TextBox();
            this.ex4bOperant1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ex4Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ex4bOperadorListBox
            // 
            this.ex4bOperadorListBox.FormattingEnabled = true;
            this.ex4bOperadorListBox.Items.AddRange(new object[] {
            "+",
            "-"});
            this.ex4bOperadorListBox.Location = new System.Drawing.Point(371, 171);
            this.ex4bOperadorListBox.Name = "ex4bOperadorListBox";
            this.ex4bOperadorListBox.Size = new System.Drawing.Size(46, 43);
            this.ex4bOperadorListBox.TabIndex = 44;
            this.ex4bOperadorListBox.SelectedIndexChanged += new System.EventHandler(this.ex4bOperadorListBox_SelectedIndexChanged);
            // 
            // ex4bCalcularButton
            // 
            this.ex4bCalcularButton.Location = new System.Drawing.Point(173, 266);
            this.ex4bCalcularButton.Name = "ex4bCalcularButton";
            this.ex4bCalcularButton.Size = new System.Drawing.Size(134, 23);
            this.ex4bCalcularButton.TabIndex = 43;
            this.ex4bCalcularButton.Text = "Calcular";
            this.ex4bCalcularButton.UseVisualStyleBackColor = true;
            this.ex4bCalcularButton.Click += new System.EventHandler(this.ex4bCalcularButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ex4bOperacionTextBox
            // 
            this.ex4bOperacionTextBox.Location = new System.Drawing.Point(368, 269);
            this.ex4bOperacionTextBox.Name = "ex4bOperacionTextBox";
            this.ex4bOperacionTextBox.Size = new System.Drawing.Size(49, 20);
            this.ex4bOperacionTextBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Operacion seleccionada";
            // 
            // ex4bResultatTextBox
            // 
            this.ex4bResultatTextBox.Location = new System.Drawing.Point(474, 194);
            this.ex4bResultatTextBox.Name = "ex4bResultatTextBox";
            this.ex4bResultatTextBox.Size = new System.Drawing.Size(100, 20);
            this.ex4bResultatTextBox.TabIndex = 39;
            // 
            // ex4bOperant2TextBox
            // 
            this.ex4bOperant2TextBox.Location = new System.Drawing.Point(173, 214);
            this.ex4bOperant2TextBox.Name = "ex4bOperant2TextBox";
            this.ex4bOperant2TextBox.Size = new System.Drawing.Size(100, 20);
            this.ex4bOperant2TextBox.TabIndex = 38;
            // 
            // ex4bOperant1TextBox
            // 
            this.ex4bOperant1TextBox.Location = new System.Drawing.Point(173, 171);
            this.ex4bOperant1TextBox.Name = "ex4bOperant1TextBox";
            this.ex4bOperant1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ex4bOperant1TextBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Exercice 4 b";
            // 
            // ex4Label
            // 
            this.ex4Label.AutoSize = true;
            this.ex4Label.Location = new System.Drawing.Point(311, 145);
            this.ex4Label.Name = "ex4Label";
            this.ex4Label.Size = new System.Drawing.Size(160, 13);
            this.ex4Label.TabIndex = 46;
            this.ex4Label.Text = "Selecione la operacion a realizar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ex4Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ex4bOperadorListBox);
            this.Controls.Add(this.ex4bCalcularButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ex4bOperacionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ex4bResultatTextBox);
            this.Controls.Add(this.ex4bOperant2TextBox);
            this.Controls.Add(this.ex4bOperant1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ex4bOperadorListBox;
        private System.Windows.Forms.Button ex4bCalcularButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ex4bOperacionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ex4bResultatTextBox;
        private System.Windows.Forms.TextBox ex4bOperant2TextBox;
        private System.Windows.Forms.TextBox ex4bOperant1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ex4Label;
    }
}

