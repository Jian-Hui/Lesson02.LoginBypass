using System;
using System.Windows.Forms;

namespace Lesson02.LoginBypass
{
    public partial class MainForm : Form
    {
        private readonly string username;

        public MainForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "登入身分：" + username;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                this,
                "通關成功！你已修改登入驗證的控制流程。\n\n通關碼：LESSON-02-BYPASS",
                "Lesson 02 Completed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
