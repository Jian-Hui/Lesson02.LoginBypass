using System;
using System.Drawing;
using System.IO;
using System.Reflection;
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
            using (Image surpriseImage = LoadSurpriseImage())
            using (Form dialog = new Form())
            {
                dialog.AutoScaleDimensions = new SizeF(8F, 15F);
                dialog.AutoScaleMode = AutoScaleMode.Font;
                dialog.BackColor = Color.FromArgb(248, 250, 253);
                dialog.ClientSize = new Size(600, 520);
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;
                dialog.ShowInTaskbar = false;
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.Text = "Lesson 02 Completed";

                Panel header = new Panel();
                header.BackColor = Color.FromArgb(35, 54, 75);
                header.Dock = DockStyle.Top;
                header.Height = 74;

                Label headerText = new Label();
                headerText.AutoSize = true;
                headerText.Font = new Font(
                    "Microsoft JhengHei UI",
                    17F,
                    FontStyle.Bold);
                headerText.ForeColor = Color.White;
                headerText.Location = new Point(28, 20);
                headerText.Text = "挑戰完成，恭喜過關！";
                header.Controls.Add(headerText);

                Label message = new Label();
                message.Font = new Font(
                    "Microsoft JhengHei UI",
                    11F,
                    FontStyle.Bold);
                message.ForeColor = Color.FromArgb(38, 68, 99);
                message.Location = new Point(40, 99);
                message.Size = new Size(520, 80);
                message.Text =
                    "你成功找出並修改了登入驗證的控制流程！\r\n請向講師出示這個畫面，領取你的神祕小驚喜。(如果有經費的話)";
                message.TextAlign = ContentAlignment.MiddleCenter;

                PictureBox surprisePicture = new PictureBox();
                surprisePicture.Image = surpriseImage;
                surprisePicture.Location = new Point(71, 195);
                surprisePicture.Size = new Size(458, 222);
                surprisePicture.SizeMode = PictureBoxSizeMode.Zoom;

                Label completionCode = new Label();
                completionCode.AutoSize = true;
                completionCode.Font = new Font(
                    "Consolas",
                    10.5F,
                    FontStyle.Bold);
                completionCode.ForeColor = Color.FromArgb(24, 73, 118);
                completionCode.Location = new Point(39, 465);
                completionCode.Text = "通關碼：LESSON-02-BYPASS";

                Button okButton = new Button();
                okButton.BackColor = Color.FromArgb(26, 115, 232);
                okButton.DialogResult = DialogResult.OK;
                okButton.FlatAppearance.BorderSize = 0;
                okButton.FlatStyle = FlatStyle.Flat;
                okButton.Font = new Font(
                    "Microsoft JhengHei UI",
                    10.5F,
                    FontStyle.Bold);
                okButton.ForeColor = Color.White;
                okButton.Location = new Point(415, 450);
                okButton.Size = new Size(145, 44);
                okButton.Text = "OK，收到驚喜！";
                okButton.UseVisualStyleBackColor = false;

                dialog.AcceptButton = okButton;
                dialog.CancelButton = okButton;
                dialog.Controls.Add(header);
                dialog.Controls.Add(message);
                dialog.Controls.Add(surprisePicture);
                dialog.Controls.Add(completionCode);
                dialog.Controls.Add(okButton);

                dialog.ShowDialog(this);
            }
        }

        private static Image LoadSurpriseImage()
        {
            const string resourceName =
                "Lesson02.LoginBypass.Resources.steamCard.png";

            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream stream =
                assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    return SystemIcons.Information.ToBitmap();
                }

                using (Image image = Image.FromStream(stream))
                {
                    return new Bitmap(image);
                }
            }
        }
    }
}
