using System.Diagnostics;

namespace projectX
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Logbut_Click(object sender, EventArgs e)
        {
            Logbut.Enabled = false;
            this.UseWaitCursor = true;
            try
            {
                string login = logform.Text.Trim();
                string password = pasform.Text.Trim();

                // Проверка на пустые поля
                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Вызываем нашу функцию из класса DB
                bool isValid = await DB.login(login, password);

                if (isValid)
                {
                    MessageBox.Show("✅ Успешный вход!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Здесь можно открыть следующее окно или скрыть текущее
                    MainForm mainForm = new MainForm();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("❌ Неверный логин или пароль!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Что-то пошло не так...", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                // Разблокируем кнопку в любом случае
                Logbut.Enabled = true;
                this.UseWaitCursor = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistForm registForm = new RegistForm();
            registForm.FormClosed += (s, args) => this.Close();
            registForm.Show();
            this.Hide();
        }
    }
}
