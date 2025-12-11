namespace assignment_6
{
    partial class AddForm
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            phoneLabel = new Label();
            phoneTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(38, 32);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "&Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(38, 50);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 1;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(38, 87);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(41, 15);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "&Phone";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(38, 105);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(100, 23);
            phoneTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            okButton.Location = new Point(178, 214);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(259, 214);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 249);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddForm";
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label phoneLabel;
        private TextBox phoneTextBox;
        private Button okButton;
        private Button cancelButton;
    }
}