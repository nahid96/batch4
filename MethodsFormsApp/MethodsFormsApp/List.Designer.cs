namespace MethodsFormsApp
{
    partial class List
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
            this.InpuitTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InpuitTextBox
            // 
            this.InpuitTextBox.Location = new System.Drawing.Point(62, 67);
            this.InpuitTextBox.Name = "InpuitTextBox";
            this.InpuitTextBox.Size = new System.Drawing.Size(195, 20);
            this.InpuitTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(298, 67);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 29);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(62, 155);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(232, 253);
            this.showRichTextBox.TabIndex = 3;
            this.showRichTextBox.Text = "";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(62, 114);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(195, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.showRichTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InpuitTextBox);
            this.Name = "List";
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InpuitTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}