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
            btnRemoveWeapon = new Button();
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
            btnRegenWeapons = new Button();
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
            resources.ApplyResources(topPanel, "topPanel");
            topPanel.Controls.Add(topPanelContent);
            topPanel.Controls.Add(separator3);
            topPanel.Controls.Add(separator1);
            topPanel.Controls.Add(iconBox);
            topPanel.Name = "topPanel";
            // 
            // topPanelContent
            // 
            resources.ApplyResources(topPanelContent, "topPanelContent");
            topPanelContent.Controls.Add(mainLink);
            topPanelContent.Controls.Add(mainVersion);
            topPanelContent.Controls.Add(mainTitle);
            topPanelContent.Name = "topPanelContent";
            // 
            // mainLink
            // 
            resources.ApplyResources(mainLink, "mainLink");
            mainLink.ForeColor = SystemColors.ControlText;
            mainLink.Name = "mainLink";
            // 
            // mainVersion
            // 
            resources.ApplyResources(mainVersion, "mainVersion");
            mainVersion.ForeColor = Color.DodgerBlue;
            mainVersion.Name = "mainVersion";
            // 
            // mainTitle
            // 
            resources.ApplyResources(mainTitle, "mainTitle");
            mainTitle.Name = "mainTitle";
            // 
            // separator3
            // 
            resources.ApplyResources(separator3, "separator3");
            separator3.Name = "separator3";
            // 
            // separator1
            // 
            resources.ApplyResources(separator1, "separator1");
            separator1.Name = "separator1";
            // 
            // iconBox
            // 
            iconBox.Image = Properties.Resources._2754_ezgif_com_webp_to_png_converter;
            resources.ApplyResources(iconBox, "iconBox");
            iconBox.Name = "iconBox";
            iconBox.TabStop = false;
            // 
            // mainSeparator1
            // 
            resources.ApplyResources(mainSeparator1, "mainSeparator1");
            mainSeparator1.Name = "mainSeparator1";
            mainSeparator1.Paint += mainSeparator1_Paint;
            // 
            // containerWeapons
            // 
            resources.ApplyResources(containerWeapons, "containerWeapons");
            containerWeapons.Controls.Add(listWeapons);
            containerWeapons.Name = "containerWeapons";
            containerWeapons.TabStop = false;
            // 
            // listWeapons
            // 
            resources.ApplyResources(listWeapons, "listWeapons");
            listWeapons.FormattingEnabled = true;
            listWeapons.Name = "listWeapons";
            // 
            // btnAddWeapon
            // 
            resources.ApplyResources(btnAddWeapon, "btnAddWeapon");
            btnAddWeapon.Cursor = Cursors.Hand;
            btnAddWeapon.Name = "btnAddWeapon";
            btnAddWeapon.UseVisualStyleBackColor = true;
            btnAddWeapon.Click += btnAddWeapon_Click;
            // 
            // btnRemoveWeapon
            // 
            resources.ApplyResources(btnRemoveWeapon, "btnRemoveWeapon");
            btnRemoveWeapon.Cursor = Cursors.Hand;
            btnRemoveWeapon.Name = "btnRemoveWeapon";
            btnRemoveWeapon.UseVisualStyleBackColor = true;
            btnRemoveWeapon.Click += btnRemovePreset_Click;
            // 
            // btnClearWeaponList
            // 
            resources.ApplyResources(btnClearWeaponList, "btnClearWeaponList");
            btnClearWeaponList.Cursor = Cursors.Hand;
            btnClearWeaponList.Name = "btnClearWeaponList";
            btnClearWeaponList.UseVisualStyleBackColor = true;
            btnClearWeaponList.Click += btnClearWeaponList_Click;
            // 
            // containerPresets
            // 
            resources.ApplyResources(containerPresets, "containerPresets");
            containerPresets.Controls.Add(listPresets);
            containerPresets.Name = "containerPresets";
            containerPresets.TabStop = false;
            // 
            // listPresets
            // 
            resources.ApplyResources(listPresets, "listPresets");
            listPresets.FormattingEnabled = true;
            listPresets.Name = "listPresets";
            listPresets.SelectedIndexChanged += listPresets_SelectedIndexChanged;
            // 
            // btnRemoveCurrentPreset
            // 
            resources.ApplyResources(btnRemoveCurrentPreset, "btnRemoveCurrentPreset");
            btnRemoveCurrentPreset.Cursor = Cursors.Hand;
            btnRemoveCurrentPreset.Name = "btnRemoveCurrentPreset";
            btnRemoveCurrentPreset.UseVisualStyleBackColor = true;
            btnRemoveCurrentPreset.Click += btnRemoveCurrentPreset_Click;
            // 
            // btnAddPreset
            // 
            resources.ApplyResources(btnAddPreset, "btnAddPreset");
            btnAddPreset.Cursor = Cursors.Hand;
            btnAddPreset.Name = "btnAddPreset";
            btnAddPreset.UseVisualStyleBackColor = true;
            btnAddPreset.Click += btnAddPreset_Click;
            // 
            // btnClearPresetList
            // 
            resources.ApplyResources(btnClearPresetList, "btnClearPresetList");
            btnClearPresetList.Cursor = Cursors.Hand;
            btnClearPresetList.Name = "btnClearPresetList";
            btnClearPresetList.UseVisualStyleBackColor = true;
            btnClearPresetList.Click += btnClearPresetList_Click;
            // 
            // separator4
            // 
            resources.ApplyResources(separator4, "separator4");
            separator4.Name = "separator4";
            separator4.Paint += separator4_Paint;
            // 
            // mainPanelContent
            // 
            resources.ApplyResources(mainPanelContent, "mainPanelContent");
            mainPanelContent.Controls.Add(btnSavePresetConfiguration);
            mainPanelContent.Controls.Add(displayPreset);
            mainPanelContent.Controls.Add(valuePreset);
            mainPanelContent.Controls.Add(displayOffsetZ);
            mainPanelContent.Controls.Add(valueZ);
            mainPanelContent.Controls.Add(displayOffsetY);
            mainPanelContent.Controls.Add(valueY);
            mainPanelContent.Controls.Add(displayOffsetX);
            mainPanelContent.Controls.Add(valueX);
            mainPanelContent.Name = "mainPanelContent";
            // 
            // btnSavePresetConfiguration
            // 
            resources.ApplyResources(btnSavePresetConfiguration, "btnSavePresetConfiguration");
            btnSavePresetConfiguration.Cursor = Cursors.Hand;
            btnSavePresetConfiguration.Name = "btnSavePresetConfiguration";
            btnSavePresetConfiguration.UseVisualStyleBackColor = true;
            // 
            // displayPreset
            // 
            resources.ApplyResources(displayPreset, "displayPreset");
            displayPreset.Name = "displayPreset";
            // 
            // valuePreset
            // 
            resources.ApplyResources(valuePreset, "valuePreset");
            valuePreset.Name = "valuePreset";
            valuePreset.ReadOnly = true;
            // 
            // displayOffsetZ
            // 
            resources.ApplyResources(displayOffsetZ, "displayOffsetZ");
            displayOffsetZ.Name = "displayOffsetZ";
            // 
            // valueZ
            // 
            resources.ApplyResources(valueZ, "valueZ");
            valueZ.Name = "valueZ";
            // 
            // displayOffsetY
            // 
            resources.ApplyResources(displayOffsetY, "displayOffsetY");
            displayOffsetY.Name = "displayOffsetY";
            // 
            // valueY
            // 
            resources.ApplyResources(valueY, "valueY");
            valueY.Name = "valueY";
            // 
            // displayOffsetX
            // 
            resources.ApplyResources(displayOffsetX, "displayOffsetX");
            displayOffsetX.Name = "displayOffsetX";
            // 
            // valueX
            // 
            resources.ApplyResources(valueX, "valueX");
            valueX.Name = "valueX";
            // 
            // btnRegenWeapons
            // 
            resources.ApplyResources(btnRegenWeapons, "btnRegenWeapons");
            btnRegenWeapons.Cursor = Cursors.Hand;
            btnRegenWeapons.Name = "btnRegenWeapons";
            btnRegenWeapons.UseVisualStyleBackColor = true;
            btnRegenWeapons.Click += btnRegenWeapons_Click;
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRegenWeapons);
            Controls.Add(mainPanelContent);
            Controls.Add(separator4);
            Controls.Add(btnRemoveCurrentPreset);
            Controls.Add(btnClearPresetList);
            Controls.Add(btnAddPreset);
            Controls.Add(containerPresets);
            Controls.Add(btnClearWeaponList);
            Controls.Add(btnRemoveWeapon);
            Controls.Add(btnAddWeapon);
            Controls.Add(containerWeapons);
            Controls.Add(mainSeparator1);
            Controls.Add(topPanel);
            KeyPreview = true;
            Name = "mainForm";
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

        public Panel topPanel;
        public PictureBox iconBox;
        public Panel separator3;
        public Panel separator1;
        public Panel topPanelContent;
        public Label mainTitle;
        public Label mainVersion;
        public Panel mainSeparator1;
        public Label mainLink;
        public GroupBox containerWeapons;
        public ListBox listWeapons;
        public Button btnAddWeapon;
        public Button btnRemoveWeapon;
        public Button btnClearWeaponList;
        public GroupBox containerPresets;
        public ListBox listPresets;
        public Button btnRemoveCurrentPreset;
        public Button btnAddPreset;
        public Button btnClearPresetList;
        public Panel separator4;
        public Panel mainPanelContent;
        public TextBox valueX;
        public Label displayOffsetX;
        public Label displayOffsetZ;
        public TextBox valueZ;
        public Label displayOffsetY;
        public TextBox valueY;
        public Button btnSavePresetConfiguration;
        public Label displayPreset;
        public TextBox valuePreset;
        public Button btnRegenWeapons;
    }
}
