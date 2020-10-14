namespace Exercice5
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
            this.ex5OkButton = new System.Windows.Forms.Button();
            this.ex5ListAnimalesTextBox = new System.Windows.Forms.TextBox();
            this.ex5DogCheckBox = new System.Windows.Forms.CheckBox();
            this.ex5CatCheckBox = new System.Windows.Forms.CheckBox();
            this.ex5MouseCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ex5OkButton
            // 
            this.ex5OkButton.Location = new System.Drawing.Point(453, 221);
            this.ex5OkButton.Name = "ex5OkButton";
            this.ex5OkButton.Size = new System.Drawing.Size(75, 23);
            this.ex5OkButton.TabIndex = 48;
            this.ex5OkButton.Text = "OK";
            this.ex5OkButton.UseVisualStyleBackColor = true;
            this.ex5OkButton.Click += new System.EventHandler(this.ex5OkButton_Click);
            // 
            // ex5ListAnimalesTextBox
            // 
            this.ex5ListAnimalesTextBox.Location = new System.Drawing.Point(311, 250);
            this.ex5ListAnimalesTextBox.Name = "ex5ListAnimalesTextBox";
            this.ex5ListAnimalesTextBox.Size = new System.Drawing.Size(375, 20);
            this.ex5ListAnimalesTextBox.TabIndex = 47;
            this.ex5ListAnimalesTextBox.Text = "Choosen Animals: ";
            // 
            // ex5DogCheckBox
            // 
            this.ex5DogCheckBox.AutoSize = true;
            this.ex5DogCheckBox.Location = new System.Drawing.Point(216, 253);
            this.ex5DogCheckBox.Name = "ex5DogCheckBox";
            this.ex5DogCheckBox.Size = new System.Drawing.Size(46, 17);
            this.ex5DogCheckBox.TabIndex = 46;
            this.ex5DogCheckBox.Text = "Dog";
            this.ex5DogCheckBox.UseVisualStyleBackColor = true;
            // 
            // ex5CatCheckBox
            // 
            this.ex5CatCheckBox.AutoSize = true;
            this.ex5CatCheckBox.Location = new System.Drawing.Point(216, 230);
            this.ex5CatCheckBox.Name = "ex5CatCheckBox";
            this.ex5CatCheckBox.Size = new System.Drawing.Size(42, 17);
            this.ex5CatCheckBox.TabIndex = 45;
            this.ex5CatCheckBox.Text = "Cat";
            this.ex5CatCheckBox.UseVisualStyleBackColor = true;
            // 
            // ex5MouseCheckBox
            // 
            this.ex5MouseCheckBox.AutoSize = true;
            this.ex5MouseCheckBox.Location = new System.Drawing.Point(216, 207);
            this.ex5MouseCheckBox.Name = "ex5MouseCheckBox";
            this.ex5MouseCheckBox.Size = new System.Drawing.Size(58, 17);
            this.ex5MouseCheckBox.TabIndex = 44;
            this.ex5MouseCheckBox.Text = "Mouse";
            this.ex5MouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Exercice 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ex5OkButton);
            this.Controls.Add(this.ex5ListAnimalesTextBox);
            this.Controls.Add(this.ex5DogCheckBox);
            this.Controls.Add(this.ex5CatCheckBox);
            this.Controls.Add(this.ex5MouseCheckBox);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ex5OkButton;
        private System.Windows.Forms.TextBox ex5ListAnimalesTextBox;
        private System.Windows.Forms.CheckBox ex5DogCheckBox;
        private System.Windows.Forms.CheckBox ex5CatCheckBox;
        private System.Windows.Forms.CheckBox ex5MouseCheckBox;
        private System.Windows.Forms.Label label7;
    }
}

