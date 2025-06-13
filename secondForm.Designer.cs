namespace VCOPresets
{
    partial class secondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(secondForm));
            valueName = new TextBox();
            SuspendLayout();
            // 
            // valueName
            // 
            valueName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            valueName.Font = new Font("Bahnschrift Light", 20F);
            valueName.Location = new Point(1, 1);
            valueName.Name = "valueName";
            valueName.Size = new Size(532, 40);
            valueName.TabIndex = 0;
            valueName.KeyDown += valueName_KeyDown;
            // 
            // secondForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 44);
            Controls.Add(valueName);
            Font = new Font("Bahnschrift Light", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "secondForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Placeholder";
            Load += AddWeapon_Load;
            KeyDown += AddWeapon_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox valueName;
    }
}