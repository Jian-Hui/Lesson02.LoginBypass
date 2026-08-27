using System;
using System.Windows.Forms;

namespace Lesson02.LoginBypass
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = LoginService.Authenticate(
                tbUsername.Text,
                tbPassword.Text);

            if (!authenticated)
            {
                MessageBox.Show(
                    this,
                    "帳號或密碼錯誤",
                    "登入失敗",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Hide();

            using (MainForm mainForm = new MainForm(tbUsername.Text))
            {
                mainForm.ShowDialog(this);
            }

            Close();
        }
    }
}
