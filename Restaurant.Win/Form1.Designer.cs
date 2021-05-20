
namespace Restaurant.Win
{
    partial class CreateFoodForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IngredientsTextBox = new System.Windows.Forms.TextBox();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CreateFoodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(104, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(333, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // IngredientsTextBox
            // 
            this.IngredientsTextBox.Location = new System.Drawing.Point(104, 74);
            this.IngredientsTextBox.Multiline = true;
            this.IngredientsTextBox.Name = "IngredientsTextBox";
            this.IngredientsTextBox.Size = new System.Drawing.Size(333, 63);
            this.IngredientsTextBox.TabIndex = 3;
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Location = new System.Drawing.Point(12, 77);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(86, 20);
            this.IngredientsLabel.TabIndex = 2;
            this.IngredientsLabel.Text = "Ingredients:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(104, 159);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(333, 92);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 162);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description:";
            // 
            // CreateFoodButton
            // 
            this.CreateFoodButton.Location = new System.Drawing.Point(104, 286);
            this.CreateFoodButton.Name = "CreateFoodButton";
            this.CreateFoodButton.Size = new System.Drawing.Size(333, 29);
            this.CreateFoodButton.TabIndex = 6;
            this.CreateFoodButton.Text = "Create Food";
            this.CreateFoodButton.UseVisualStyleBackColor = true;
            this.CreateFoodButton.Click += new System.EventHandler(this.CreateFoodButton_Click);
            // 
            // CreateFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(763, 333);
            this.Controls.Add(this.CreateFoodButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.IngredientsTextBox);
            this.Controls.Add(this.IngredientsLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "CreateFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Food";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IngredientsTextBox;
        private System.Windows.Forms.Label IngredientsLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button CreateFoodButton;
    }
}

