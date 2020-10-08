namespace Overwatch_Hero_Clicker
{
    partial class Overwatch_Clicker
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overwatch_Clicker));
            this.BtnStart = new Guna.UI2.WinForms.Guna2Button();
            this.LabPoint = new Guna.UI.WinForms.GunaLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LabSavePoint = new Guna.UI.WinForms.GunaLabel();
            this.click = new System.Windows.Forms.Timer(this.components);
            this.BtnInfo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BorderRadius = 20;
            this.BtnStart.CheckedState.Parent = this.BtnStart;
            this.BtnStart.CustomImages.Parent = this.BtnStart;
            this.BtnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(126)))));
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.HoverState.Parent = this.BtnStart;
            this.BtnStart.Location = new System.Drawing.Point(12, 110);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.ShadowDecoration.Parent = this.BtnStart;
            this.BtnStart.Size = new System.Drawing.Size(180, 45);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "시작";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LabPoint
            // 
            this.LabPoint.AutoSize = true;
            this.LabPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPoint.Location = new System.Drawing.Point(23, 28);
            this.LabPoint.Name = "LabPoint";
            this.LabPoint.Size = new System.Drawing.Size(70, 21);
            this.LabPoint.TabIndex = 1;
            this.LabPoint.Text = "LabPoint";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LabSavePoint
            // 
            this.LabSavePoint.AutoSize = true;
            this.LabSavePoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSavePoint.Location = new System.Drawing.Point(23, 66);
            this.LabSavePoint.Name = "LabSavePoint";
            this.LabSavePoint.Size = new System.Drawing.Size(0, 21);
            this.LabSavePoint.TabIndex = 3;
            // 
            // click
            // 
            this.click.Tick += new System.EventHandler(this.click_Tick);
            // 
            // BtnInfo
            // 
            this.BtnInfo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnInfo.CheckedState.Parent = this.BtnInfo;
            this.BtnInfo.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnInfo.HoverState.Parent = this.BtnInfo;
            this.BtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfo.Image")));
            this.BtnInfo.ImageRotate = 0F;
            this.BtnInfo.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnInfo.Location = new System.Drawing.Point(198, 106);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnInfo.PressedState.Parent = this.BtnInfo;
            this.BtnInfo.Size = new System.Drawing.Size(64, 54);
            this.BtnInfo.TabIndex = 4;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // Overwatch_Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 166);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.LabSavePoint);
            this.Controls.Add(this.LabPoint);
            this.Controls.Add(this.BtnStart);
            this.Name = "Overwatch_Clicker";
            this.Text = "오토마우스";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Overwatch_Clicker_FormClosed);
            this.Load += new System.EventHandler(this.Overwatch_Clicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnStart;
        private Guna.UI.WinForms.GunaLabel LabPoint;
        public System.Windows.Forms.Timer timer;
        private Guna.UI.WinForms.GunaLabel LabSavePoint;
        private System.Windows.Forms.Timer click;
        private Guna.UI2.WinForms.Guna2ImageButton BtnInfo;
    }
}

