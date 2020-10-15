namespace Exercice7
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
            this.ex7TextBox = new System.Windows.Forms.TextBox();
            this.coloursComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ex7TextBox
            // 
            this.ex7TextBox.Location = new System.Drawing.Point(42, 178);
            this.ex7TextBox.Name = "ex7TextBox";
            this.ex7TextBox.Size = new System.Drawing.Size(468, 20);
            this.ex7TextBox.TabIndex = 49;
            this.ex7TextBox.Text = "The choosen colour is: ";
            // 
            // coloursComboBox
            // 
            this.coloursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coloursComboBox.FormattingEnabled = true;
            this.coloursComboBox.Items.AddRange(new object[] {
            "Yellow",
            "Blue",
            "Red",
            "White",
            "Black",
            "Orange"});
            this.coloursComboBox.Location = new System.Drawing.Point(250, 83);
            this.coloursComboBox.Name = "coloursComboBox";
            this.coloursComboBox.Size = new System.Drawing.Size(121, 21);
            this.coloursComboBox.TabIndex = 50;
            this.coloursComboBox.SelectedIndexChanged += new System.EventHandler(this.coloursComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Exercice 7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 211);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.coloursComboBox);
            this.Controls.Add(this.ex7TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ex7TextBox;
        private System.Windows.Forms.ComboBox coloursComboBox;
        private System.Windows.Forms.Label label7;
    }
}

