namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            HyButton = new Button();
            Close2Button = new Button();
            SuspendLayout();
            // 
            // HyButton
            // 
            HyButton.FlatStyle = FlatStyle.Flat;
            HyButton.Image = (Image)resources.GetObject("HyButton.Image");
            HyButton.Location = new Point(36, 63);
            HyButton.Name = "HyButton";
            HyButton.Size = new Size(158, 65);
            HyButton.TabIndex = 0;
            HyButton.UseVisualStyleBackColor = true;
            HyButton.Click += HyButton_Click;
            // 
            // Close2Button
            // 
            Close2Button.FlatStyle = FlatStyle.Flat;
            Close2Button.Image = (Image)resources.GetObject("Close2Button.Image");
            Close2Button.Location = new Point(275, 63);
            Close2Button.Name = "Close2Button";
            Close2Button.Size = new Size(176, 65);
            Close2Button.TabIndex = 1;
            Close2Button.UseVisualStyleBackColor = true;
            Close2Button.Click += Close2Button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Close2Button;
            ClientSize = new Size(479, 246);
            Controls.Add(Close2Button);
            Controls.Add(HyButton);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Button HyButton;
        private Button Close2Button;
    }
}