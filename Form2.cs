using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectX
{
    public partial class RegistForm : Form
    {
        public RegistForm()
        {
            InitializeComponent();
        }

        private async void Registbut_Click(object sender, EventArgs e)
        {
            Registbut.Enabled = false;
            this.UseWaitCursor = true;
            try
            {
                string login = logform.Text.Trim();
                string password = pasform.Text.Trim();
                string paschick = pascheck.Text.Trim();

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(paschick))
                {
                    MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password.Length < 8 || password.Length > 24)
                {
                    MessageBox.Show("Пароль должен быть от 8 до 24 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (login.Length < 3 || login.Length > 50)
                {
                    MessageBox.Show("Имя должно быть от 3 до 50 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != paschick)
                {
                    MessageBox.Show("Пароли не совпадают", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isValid = await DB.registration(login, password);

                if (isValid)
                {
                    MessageBox.Show("✅ Успешная регистрация!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Здесь можно открыть следующее окно или скрыть текущее
                    MainForm mainForm = new MainForm();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("❌ Не удалось зарегистрироваться!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Что-то пошло не так...", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Registbut.Enabled = true;
                this.UseWaitCursor = false;
            }
        }

        private void perehodbut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
            this.Hide();
        }
    }
}
