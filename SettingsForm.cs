using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba15
{
    public partial class SettingsForm : Form
    {
        private AppSettings _settings;

        public SettingsForm(AppSettings settings)
        {
            InitializeComponent();
            _settings = settings;
        }

        // завантаження налаштувань при відкритті форм
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtHost.Text = _settings.Host;
            txtUsername.Text = _settings.Username;
            txtPassword.Text = _settings.Password;
        }

        // збереження налаштувань при натисканні кнопки Зберегти
        private void btnSave_Click(object sender, EventArgs e)
        {
            _settings.Host = txtHost.Text;
            _settings.Username = txtUsername.Text;
            _settings.Password = txtPassword.Text;
            _settings.Save();

            MessageBox.Show("Налаштування збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
