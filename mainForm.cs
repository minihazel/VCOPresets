using Newtonsoft.Json;
using System;

namespace VCOPresets
{
    public partial class mainForm : Form
    {
        // D:\SPT Iterations\SPT 3.11\BepInEx\plugins\hazelify.VCO
        // Environment.CurrentDirectory
        public string currentEnv = "D:\\SPT Iterations\\SPT 3.11\\BepInEx\\plugins\\hazelify.VCO";
        public string? weaponsPath = null;
        public string? presetsJSON = null;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            weaponsPath = Path.Join(currentEnv, "weapons.cfg");
            presetsJSON = Path.Join(currentEnv, "presets.json");
            initConfigs();
        }

        private void initConfigs()
        {
            checkWeaponsConfig();
            checkPresetsConfig();

            loadConfigs();
        }

        private void loadConfigs()
        {
            loadWeaponsList();
            loadPresets();
        }

        private void checkWeaponsConfig()
        {
            if (!File.Exists(weaponsPath))
            {
                try
                {
                    File.WriteAllText(weaponsPath,
                        "HK MP7A1 4.6x30 submachine gun" + Environment.NewLine +
                        "HK MP7A2 4.6x30 submachine gun" + Environment.NewLine +
                        "FN SCAR-L 5.56x45 assault rifle" + Environment.NewLine +
                        "FN SCAR-L 5.56x45 assault rifle (FDE)" + Environment.NewLine +
                        "FN SCAR-H X-17 7.62x51 assault rifle" + Environment.NewLine +
                        "FN SCAR-H X-17 7.62x51 assault rifle (FDE)" + Environment.NewLine +
                        "SIG MCX-SPEAR 6.8x51 assault rifle" + Environment.NewLine +
                        "SIG MPX 9x19 submachine gun");
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void checkPresetsConfig()
        {
            if (!File.Exists(presetsJSON))
            {
                var presets = new PresetsRoot
                {
                    Presets = new List<Preset>
                    {
                        new Preset { Name = "Default",
                            X = -0.01,
                            Y = 0.06,
                            Z = 0.05
                        },
                        new Preset { Name = "CSGO",
                            X = -0.02,
                            Y = 0.065,
                            Z = 0.04
                        },
                    }
                };

                try
                {
                    string json = JsonConvert.SerializeObject(presets, Formatting.Indented);
                    File.WriteAllText(presetsJSON, json);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void loadWeaponsList()
        {
            bool doesExist = File.Exists(weaponsPath);
            if (doesExist)
            {
                listWeapons.Items.Clear();

                string[] weapons = File.ReadAllLines(weaponsPath);
                if (weapons != null && weapons.Length > 0)
                {
                    foreach (string weapon in weapons)
                    {
                        if (!string.IsNullOrWhiteSpace(weapon))
                        {
                            listWeapons.Items.Add(weapon.Trim());
                        }
                    }
                }
            }
        }

        private void loadPresets()
        {
            bool doesExist = File.Exists(presetsJSON);
            if (doesExist)
            {
                listPresets.Items.Clear();

                try
                {
                    string json = File.ReadAllText(presetsJSON);
                    var presetsObj = JsonConvert.DeserializeObject<PresetsRoot>(json);

                    if (presetsObj?.Presets != null)
                    {
                        foreach (var preset in presetsObj.Presets)
                        {
                            if (!string.IsNullOrWhiteSpace(preset.Name))
                            {
                                listPresets.Items.Add(preset.Name);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void mainSeparator1_Paint(object sender, PaintEventArgs e)
        {
            int y = mainSeparator1.Height / 2;
            using (var pen = new Pen(Color.FromArgb(100, 100, 100), 1))
            {
                e.Graphics.DrawLine(pen, 0, y, mainSeparator1.Width, y);
            }
        }

        private void separator4_Paint(object sender, PaintEventArgs e)
        {
            int x = separator4.Width / 2;
            using (var pen = new Pen(Color.FromArgb(220, 220, 220), 1))
            {
                e.Graphics.DrawLine(pen, x, 0, x, separator4.Height);
            }
        }

        private void listPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPresets.Items.Count < 0)
            {
                return;
            }

            if (listPresets.SelectedIndex < 0)
            {
                return;
            }

            if (listPresets.SelectedItem == null)
            {
                return;
            }

            string? selectedPreset = listPresets.SelectedItem.ToString();

            if (!string.IsNullOrWhiteSpace(selectedPreset))
            {
                valuePreset.Clear();
                valueX.Clear();
                valueY.Clear();
                valueZ.Clear();

                var preset = PresetManager.GetPresetByName(selectedPreset, currentEnv);
                if (preset != null)
                {
                    valuePreset.Text = preset.Name;
                    valueX.Text = preset.X.ToString("F2");
                    valueY.Text = preset.Y.ToString("F2");
                    valueZ.Text = preset.Z.ToString("F2");
                }
            }
        }

        private void btnClearWeaponList_Click(object sender, EventArgs e)
        {
            string? content = "Clear " + listWeapons.Items.Count + " items?";
            if (MessageBox.Show(content, "Clear weapons list", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listWeapons.Items.Clear();

                try
                {
                    File.WriteAllText(weaponsPath, string.Empty);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnClearPresetList_Click(object sender, EventArgs e)
        {
            string? content = "Clear " + listPresets.Items.Count + " presets?";
            if (MessageBox.Show(content, "Clear presets", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listPresets.Items.Clear();

                try
                {
                    File.WriteAllText(presetsJSON, "{}");
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnRegenWeapons_Click(object sender, EventArgs e)
        {
            string? content = "Regenerate weapons list?";
            if (MessageBox.Show(content, "Regeneration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listWeapons.Items.Clear();

                try
                {
                    File.Delete(weaponsPath);
                }
                catch (Exception ex)
                {
                }

                checkWeaponsConfig();
                loadWeaponsList();
            }
        }

        private void btnAddWeapon_Click(object sender, EventArgs e)
        {
            string[] weapons = listWeapons.Items.Cast<string>().ToArray();
            using (var newForm = new secondForm(weapons))
            {
                newForm.Text = "Add new weapon";
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    string weaponName = newForm.providedName;
                    if (!string.IsNullOrWhiteSpace(weaponName))
                    {
                        listWeapons.Items.Add(weaponName);
                        File.AppendAllText(weaponsPath, weaponName + Environment.NewLine);
                    }
                }
            }
        }

        private void btnRemovePreset_Click(object sender, EventArgs e)
        {
            if (listWeapons.SelectedIndex < 0)
            {
                return;
            }

            if (listWeapons.SelectedItem == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(listWeapons.SelectedItem.ToString()))
            {
                return;
            }

            string? content = "Remove " + listWeapons.SelectedItem?.ToString() + "?";
            if (MessageBox.Show(content, "Item removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (listWeapons.SelectedItem == null)
                {
                    return;
                }

                try
                {
                    listWeapons.Items.Remove(listWeapons.SelectedItem);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnAddPreset_Click(object sender, EventArgs e)
        {
            string[] presets = listPresets.Items.Cast<string>().ToArray();

            using (var newForm = new secondForm(presets))
            {
                newForm.Text = "Add new preset";

                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    string presetName = newForm.providedName;
                    if (!string.IsNullOrWhiteSpace(presetName))
                    {
                        listPresets.Items.Clear();

                        var newPreset = new Preset
                        {
                            Name = presetName,
                            X = 0.4,
                            Y = 0.4,
                            Z = 0.4
                        };

                        if (PresetManager.SavePreset(newPreset, currentEnv))
                        {
                            checkPresetsConfig();
                            loadPresets();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save " + presetName + " to file, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnRemoveCurrentPreset_Click(object sender, EventArgs e)
        {
            if (listPresets.SelectedIndex < 0)
            {
                return;
            }

            if (listPresets.SelectedItem == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(listPresets.SelectedItem.ToString()))
            {
                return;
            }

            string? presetName = listPresets.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(presetName))
            {
                return;
            }

            if (MessageBox.Show($"Remove " + presetName + "?", "Preset management", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (PresetManager.RemovePreset(presetName, currentEnv))
                {
                    checkPresetsConfig();
                    loadPresets();
                }
                else
                {
                    MessageBox.Show("Failed to remove preset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
