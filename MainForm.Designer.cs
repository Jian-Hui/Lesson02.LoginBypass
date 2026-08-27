namespace Lesson02.LoginBypass
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblControlPanel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gbProduction;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblMachines;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Button btnComplete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblControlPanel = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbProduction = new System.Windows.Forms.GroupBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblMachines = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbProduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(35, 54, 75);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblControlPanel);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(624, 94);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(205, 218, 230);
            this.lblWelcome.Location = new System.Drawing.Point(35, 59);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(99, 19);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "登入身分：---";
            // 
            // lblControlPanel
            // 
            this.lblControlPanel.AutoSize = true;
            this.lblControlPanel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblControlPanel.ForeColor = System.Drawing.Color.White;
            this.lblControlPanel.Location = new System.Drawing.Point(32, 18);
            this.lblControlPanel.Name = "lblControlPanel";
            this.lblControlPanel.Size = new System.Drawing.Size(257, 38);
            this.lblControlPanel.TabIndex = 0;
            this.lblControlPanel.Text = "生產作業監控中心";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.Location = new System.Drawing.Point(35, 122);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(95, 22);
            this.lblStatusTitle.TabIndex = 1;
            this.lblStatusTitle.Text = "系統連線狀態";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblStatus.Location = new System.Drawing.Point(151, 122);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 22);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "● 運作中";
            // 
            // gbProduction
            // 
            this.gbProduction.Controls.Add(this.lblQuality);
            this.gbProduction.Controls.Add(this.lblMachines);
            this.gbProduction.Controls.Add(this.lblOrders);
            this.gbProduction.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbProduction.Location = new System.Drawing.Point(39, 165);
            this.gbProduction.Name = "gbProduction";
            this.gbProduction.Size = new System.Drawing.Size(546, 145);
            this.gbProduction.TabIndex = 3;
            this.gbProduction.TabStop = false;
            this.gbProduction.Text = "今日生產摘要";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblQuality.Location = new System.Drawing.Point(27, 101);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(196, 22);
            this.lblQuality.TabIndex = 2;
            this.lblQuality.Text = "品質抽檢：98.7% 合格";
            // 
            // lblMachines
            // 
            this.lblMachines.AutoSize = true;
            this.lblMachines.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblMachines.Location = new System.Drawing.Point(27, 68);
            this.lblMachines.Name = "lblMachines";
            this.lblMachines.Size = new System.Drawing.Size(178, 22);
            this.lblMachines.TabIndex = 1;
            this.lblMachines.Text = "運轉設備：8 / 8 台";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblOrders.Location = new System.Drawing.Point(27, 35);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(180, 22);
            this.lblOrders.TabIndex = 0;
            this.lblOrders.Text = "待處理訂單：24 筆";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(39, 335);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(546, 48);
            this.btnComplete.TabIndex = 4;
            this.btnComplete.Text = "確認 Lesson 02 通關";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(624, 415);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.gbProduction);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusTitle);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帽子工廠生產作業監控中心";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbProduction.ResumeLayout(false);
            this.gbProduction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
