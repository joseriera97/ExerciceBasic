namespace Exercice8
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
            this.claseListBox = new System.Windows.Forms.ListBox();
            this.class1Button = new System.Windows.Forms.Button();
            this.class2Button = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // claseListBox
            // 
            this.claseListBox.FormattingEnabled = true;
            this.claseListBox.Location = new System.Drawing.Point(103, 87);
            this.claseListBox.Name = "claseListBox";
            this.claseListBox.Size = new System.Drawing.Size(120, 160);
            this.claseListBox.TabIndex = 0;
            this.claseListBox.SelectedIndexChanged += new System.EventHandler(this.claseListBox_SelectedIndexChanged);
            // 
            // class1Button
            // 
            this.class1Button.Location = new System.Drawing.Point(103, 273);
            this.class1Button.Name = "class1Button";
            this.class1Button.Size = new System.Drawing.Size(120, 23);
            this.class1Button.TabIndex = 1;
            this.class1Button.Text = "Classroom 1";
            this.class1Button.UseVisualStyleBackColor = true;
            this.class1Button.Click += new System.EventHandler(this.class1Button_Click);
            // 
            // class2Button
            // 
            this.class2Button.Location = new System.Drawing.Point(103, 315);
            this.class2Button.Name = "class2Button";
            this.class2Button.Size = new System.Drawing.Size(120, 23);
            this.class2Button.TabIndex = 2;
            this.class2Button.Text = "Classroom 2";
            this.class2Button.UseVisualStyleBackColor = true;
            this.class2Button.Click += new System.EventHandler(this.class2Button_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Location = new System.Drawing.Point(346, 183);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(120, 23);
            this.clearListButton.TabIndex = 3;
            this.clearListButton.Text = "Clear List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "Exercice 8";
            // 
            // personTextBox
            // 
            this.personTextBox.Location = new System.Drawing.Point(283, 87);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(280, 20);
            this.personTextBox.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 417);
            this.Controls.Add(this.personTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.class2Button);
            this.Controls.Add(this.class1Button);
            this.Controls.Add(this.claseListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox claseListBox;
        private System.Windows.Forms.Button class1Button;
        private System.Windows.Forms.Button class2Button;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox personTextBox;
    }
}

