namespace VCOPresets
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            topPanel = new Panel();
            topPanelContent = new Panel();
            mainLink = new Label();
            mainVersion = new Label();
            mainTitle = new Label();
            separator3 = new Panel();
            separator1 = new Panel();
            iconBox = new PictureBox();
            mainSeparator1 = new Panel();
            containerWeapons = new GroupBox();
            listWeapons = new ListBox();
            btnAddWeapon = new Button();
            btnRemovePreset = new Button();
            btnClearWeaponList = new Button();
            containerPresets = new GroupBox();
            listPresets = new ListBox();
            btnRemoveCurrentPreset = new Button();
            btnAddPreset = new Button();
            btnClearPresetList = new Button();
            separator4 = new Panel();
            mainPanelContent = new Panel();
            btnSavePresetConfiguration = new Button();
            displayPreset = new Label();
            valuePreset = new TextBox();
            displayOffsetZ = new Label();
            valueZ = new TextBox();
            displayOffsetY = new Label();
            valueY = new TextBox();
            displayOffsetX = new Label();
            valueX = new TextBox();
            topPanel.SuspendLayout();
            topPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBox).BeginInit();
            containerWeapons.SuspendLayout();
            containerPresets.SuspendLayout();
            mainPanelContent.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topPanel.Controls.Add(topPanelContent);
            topPanel.Controls.Add(separator3);
            topPanel.Controls.Add(separator1);
            topPanel.Controls.Add(iconBox);
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(844, 98);
            topPanel.TabIndex = 0;
            // 
            // topPanelContent
            // 
            topPanelContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topPanelContent.Controls.Add(mainLink);
            topPanelContent.Controls.Add(mainVersion);
            topPanelContent.Controls.Add(mainTitle);
            topPanelContent.Location = new Point(90, 4);
            topPanelContent.Margin = new Padding(3, 4, 3, 4);
            topPanelContent.Name = "topPanelContent";
            topPanelContent.Size = new Size(717, 90);
            topPanelContent.TabIndex = 3;
            // 
            // mainLink
            // 
            mainLink.Font = new Font("Bahnschrift", 12F);
            mainLink.ForeColor = SystemColors.ControlText;
            mainLink.Location = new Point(60, 48);
            mainLink.Name = "mainLink";
            mainLink.Size = new Size(549, 20);
            mainLink.TabIndex = 2;
            mainLink.Text = "Visit the VCO modpage (click to open in browser)";
            mainLink.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainVersion
            // 
            mainVersion.Font = new Font("Bahnschrift", 12F);
            mainVersion.ForeColor = Color.DodgerBlue;
            mainVersion.Location = new Point(3, 48);
            mainVersion.Name = "mainVersion";
            mainVersion.Size = new Size(54, 20);
            mainVersion.TabIndex = 1;
            mainVersion.Text = "1.0.4";
            mainVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainTitle
            // 
            mainTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mainTitle.Font = new Font("Bahnschrift Light", 16F);
            mainTitle.Location = new Point(3, 5);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(711, 40);
            mainTitle.TabIndex = 0;
            mainTitle.Text = "VCO - Presets Configurator";
            mainTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // separator3
            // 
            separator3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            separator3.Location = new Point(826, 0);
            separator3.Margin = new Padding(3, 4, 3, 4);
            separator3.Name = "separator3";
            separator3.Size = new Size(18, 98);
            separator3.TabIndex = 2;
            // 
            // separator1
            // 
            separator1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            separator1.Location = new Point(0, 0);
            separator1.Margin = new Padding(3, 4, 3, 4);
            separator1.Name = "separator1";
            separator1.Size = new Size(18, 98);
            separator1.TabIndex = 1;
            // 
            // iconBox
            // 
            iconBox.Image = Properties.Resources._2754_ezgif_com_webp_to_png_converter;
            iconBox.Location = new Point(24, 19);
            iconBox.Margin = new Padding(3, 4, 3, 4);
            iconBox.Name = "iconBox";
            iconBox.Size = new Size(60, 60);
            iconBox.SizeMode = PictureBoxSizeMode.StretchImage;
            iconBox.TabIndex = 1;
            iconBox.TabStop = false;
            // 
            // mainSeparator1
            // 
            mainSeparator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mainSeparator1.Location = new Point(0, 97);
            mainSeparator1.Name = "mainSeparator1";
            mainSeparator1.Size = new Size(844, 10);
            mainSeparator1.TabIndex = 1;
            mainSeparator1.Paint += mainSeparator1_Paint;
            // 
            // containerWeapons
            // 
            containerWeapons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            containerWeapons.Controls.Add(listWeapons);
            containerWeapons.Location = new Point(12, 122);
            containerWeapons.Name = "containerWeapons";
            containerWeapons.Size = new Size(249, 306);
            containerWeapons.TabIndex = 2;
            containerWeapons.TabStop = false;
            containerWeapons.Text = "Weapon detection list";
            // 
            // listWeapons
            // 
            listWeapons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listWeapons.FormattingEnabled = true;
            listWeapons.ItemHeight = 18;
            listWeapons.Location = new Point(6, 24);
            listWeapons.Name = "listWeapons";
            listWeapons.Size = new Size(237, 274);
            listWeapons.TabIndex = 0;
            // 
            // btnAddWeapon
            // 
            btnAddWeapon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddWeapon.Cursor = Cursors.Hand;
            btnAddWeapon.Location = new Point(267, 130);
            btnAddWeapon.Name = "btnAddWeapon";
            btnAddWeapon.Size = new Size(35, 35);
            btnAddWeapon.TabIndex = 3;
            btnAddWeapon.Text = "➕";
            btnAddWeapon.UseVisualStyleBackColor = true;
            // 
            // btnRemovePreset
            // 
            btnRemovePreset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemovePreset.Cursor = Cursors.Hand;
            btnRemovePreset.Location = new Point(267, 171);
            btnRemovePreset.Name = "btnRemovePreset";
            btnRemovePreset.Size = new Size(35, 35);
            btnRemovePreset.TabIndex = 4;
            btnRemovePreset.Text = "➖";
            btnRemovePreset.UseVisualStyleBackColor = true;
            // 
            // btnClearWeaponList
            // 
            btnClearWeaponList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearWeaponList.Cursor = Cursors.Hand;
            btnClearWeaponList.Location = new Point(267, 393);
            btnClearWeaponList.Name = "btnClearWeaponList";
            btnClearWeaponList.Size = new Size(35, 35);
            btnClearWeaponList.TabIndex = 5;
            btnClearWeaponList.Text = "🗑";
            btnClearWeaponList.UseVisualStyleBackColor = true;
            // 
            // containerPresets
            // 
            containerPresets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            containerPresets.Controls.Add(listPresets);
            containerPresets.Location = new Point(335, 122);
            containerPresets.Name = "containerPresets";
            containerPresets.Size = new Size(249, 306);
            containerPresets.TabIndex = 6;
            containerPresets.TabStop = false;
            containerPresets.Text = "Presets management";
            // 
            // listPresets
            // 
            listPresets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listPresets.FormattingEnabled = true;
            listPresets.ItemHeight = 18;
            listPresets.Location = new Point(6, 24);
            listPresets.Name = "listPresets";
            listPresets.Size = new Size(237, 274);
            listPresets.TabIndex = 0;
            // 
            // btnRemoveCurrentPreset
            // 
            btnRemoveCurrentPreset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveCurrentPreset.Cursor = Cursors.Hand;
            btnRemoveCurrentPreset.Location = new Point(103, 280);
            btnRemoveCurrentPreset.Name = "btnRemoveCurrentPreset";
            btnRemoveCurrentPreset.Size = new Size(35, 35);
            btnRemoveCurrentPreset.TabIndex = 8;
            btnRemoveCurrentPreset.Text = "➖";
            btnRemoveCurrentPreset.UseVisualStyleBackColor = true;
            // 
            // btnAddPreset
            // 
            btnAddPreset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPreset.Cursor = Cursors.Hand;
            btnAddPreset.Location = new Point(590, 130);
            btnAddPreset.Name = "btnAddPreset";
            btnAddPreset.Size = new Size(35, 35);
            btnAddPreset.TabIndex = 7;
            btnAddPreset.Text = "➕";
            btnAddPreset.UseVisualStyleBackColor = true;
            // 
            // btnClearPresetList
            // 
            btnClearPresetList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearPresetList.Cursor = Cursors.Hand;
            btnClearPresetList.Location = new Point(590, 393);
            btnClearPresetList.Name = "btnClearPresetList";
            btnClearPresetList.Size = new Size(35, 35);
            btnClearPresetList.TabIndex = 9;
            btnClearPresetList.Text = "🗑";
            btnClearPresetList.UseVisualStyleBackColor = true;
            // 
            // separator4
            // 
            separator4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            separator4.Location = new Point(631, 131);
            separator4.Name = "separator4";
            separator4.Size = new Size(10, 297);
            separator4.TabIndex = 10;
            separator4.Paint += separator4_Paint;
            // 
            // mainPanelContent
            // 
            mainPanelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            mainPanelContent.Controls.Add(btnSavePresetConfiguration);
            mainPanelContent.Controls.Add(displayPreset);
            mainPanelContent.Controls.Add(valuePreset);
            mainPanelContent.Controls.Add(btnRemoveCurrentPreset);
            mainPanelContent.Controls.Add(displayOffsetZ);
            mainPanelContent.Controls.Add(valueZ);
            mainPanelContent.Controls.Add(displayOffsetY);
            mainPanelContent.Controls.Add(valueY);
            mainPanelContent.Controls.Add(displayOffsetX);
            mainPanelContent.Controls.Add(valueX);
            mainPanelContent.Location = new Point(647, 113);
            mainPanelContent.Name = "mainPanelContent";
            mainPanelContent.Size = new Size(185, 315);
            mainPanelContent.TabIndex = 11;
            // 
            // btnSavePresetConfiguration
            // 
            btnSavePresetConfiguration.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSavePresetConfiguration.Cursor = Cursors.Hand;
            btnSavePresetConfiguration.Location = new Point(144, 280);
            btnSavePresetConfiguration.Name = "btnSavePresetConfiguration";
            btnSavePresetConfiguration.Size = new Size(38, 35);
            btnSavePresetConfiguration.TabIndex = 8;
            btnSavePresetConfiguration.Text = "💾";
            btnSavePresetConfiguration.UseVisualStyleBackColor = true;
            // 
            // displayPreset
            // 
            displayPreset.Location = new Point(3, 12);
            displayPreset.Name = "displayPreset";
            displayPreset.Size = new Size(179, 25);
            displayPreset.TabIndex = 7;
            displayPreset.Text = "Preset";
            displayPreset.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valuePreset
            // 
            valuePreset.Font = new Font("Bahnschrift Light", 14F);
            valuePreset.Location = new Point(3, 40);
            valuePreset.Name = "valuePreset";
            valuePreset.ReadOnly = true;
            valuePreset.Size = new Size(179, 30);
            valuePreset.TabIndex = 6;
            // 
            // displayOffsetZ
            // 
            displayOffsetZ.Location = new Point(3, 195);
            displayOffsetZ.Name = "displayOffsetZ";
            displayOffsetZ.Size = new Size(179, 25);
            displayOffsetZ.TabIndex = 5;
            displayOffsetZ.Text = "Z Offset";
            displayOffsetZ.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueZ
            // 
            valueZ.Font = new Font("Bahnschrift Light", 14F);
            valueZ.Location = new Point(3, 223);
            valueZ.Name = "valueZ";
            valueZ.Size = new Size(179, 30);
            valueZ.TabIndex = 4;
            // 
            // displayOffsetY
            // 
            displayOffsetY.Location = new Point(3, 134);
            displayOffsetY.Name = "displayOffsetY";
            displayOffsetY.Size = new Size(179, 25);
            displayOffsetY.TabIndex = 3;
            displayOffsetY.Text = "Y Offset";
            displayOffsetY.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueY
            // 
            valueY.Font = new Font("Bahnschrift Light", 14F);
            valueY.Location = new Point(3, 162);
            valueY.Name = "valueY";
            valueY.Size = new Size(179, 30);
            valueY.TabIndex = 2;
            // 
            // displayOffsetX
            // 
            displayOffsetX.Location = new Point(3, 73);
            displayOffsetX.Name = "displayOffsetX";
            displayOffsetX.Size = new Size(179, 25);
            displayOffsetX.TabIndex = 1;
            displayOffsetX.Text = "X Offset";
            displayOffsetX.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueX
            // 
            valueX.Font = new Font("Bahnschrift Light", 14F);
            valueX.Location = new Point(3, 101);
            valueX.Name = "valueX";
            valueX.Size = new Size(179, 30);
            valueX.TabIndex = 0;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 440);
            Controls.Add(mainPanelContent);
            Controls.Add(separator4);
            Controls.Add(btnClearPresetList);
            Controls.Add(btnAddPreset);
            Controls.Add(containerPresets);
            Controls.Add(btnClearWeaponList);
            Controls.Add(btnRemovePreset);
            Controls.Add(btnAddWeapon);
            Controls.Add(containerWeapons);
            Controls.Add(mainSeparator1);
            Controls.Add(topPanel);
            Font = new Font("Bahnschrift Light", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(860, 479);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Presets Configurator";
            Load += mainForm_Load;
            topPanel.ResumeLayout(false);
            topPanelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconBox).EndInit();
            containerWeapons.ResumeLayout(false);
            containerPresets.ResumeLayout(false);
            mainPanelContent.ResumeLayout(false);
            mainPanelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private PictureBox iconBox;
        private Panel separator3;
        private Panel separator1;
        private Panel topPanelContent;
        private Label mainTitle;
        private Label mainVersion;
        private Panel mainSeparator1;
        private Label mainLink;
        private GroupBox containerWeapons;
        private ListBox listWeapons;
        private Button btnAddWeapon;
        private Button btnRemovePreset;
        private Button btnClearWeaponList;
        private GroupBox containerPresets;
        private ListBox listPresets;
        private Button btnRemoveCurrentPreset;
        private Button btnAddPreset;
        private Button btnClearPresetList;
        private Panel separator4;
        private Panel mainPanelContent;
        private TextBox valueX;
        private Label displayOffsetX;
        private Label displayOffsetZ;
        private TextBox valueZ;
        private Label displayOffsetY;
        private TextBox valueY;
        private Button btnSavePresetConfiguration;
        private Label displayPreset;
        private TextBox valuePreset;
    }
}
