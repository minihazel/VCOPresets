using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCOPresets
{
    public partial class AddWeapon : Form
    {
        private readonly string[] _existingWeapons;
        public string WeaponName
        {
            get { return valueName.Text.Trim(); }
        }

        public AddWeapon(string[] existingWeapons)
        {
            InitializeComponent();
            _existingWeapons = existingWeapons;
        }

        private void AddWeapon_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(550, 83); // 100 is the minimum width you want
            this.MaximumSize = new Size(int.MaxValue, 83); // int.MaxValue allows any width
        }

        private void valueName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.SuppressKeyPress || e.Handled)
                return;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                if (!string.IsNullOrWhiteSpace(valueName.Text))
                {
                    foreach (var weapon in _existingWeapons)
                    {
                        if (string.Equals(weapon, valueName.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(weapon + " already exists in the weapons list", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid weapon name", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AddWeapon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
