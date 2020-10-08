namespace Overwatch_Hero_Clicker
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabTitle = new Guna.UI.WinForms.GunaLabel();
            this.LabCotent = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // LabTitle
            // 
            this.LabTitle.AutoSize = true;
            this.LabTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTitle.Location = new System.Drawing.Point(12, 9);
            this.LabTitle.Name = "LabTitle";
            this.LabTitle.Size = new System.Drawing.Size(214, 32);
            this.LabTitle.TabIndex = 0;
            this.LabTitle.Text = "오토마우스 사용법";
            // 
            // LabCotent
            // 
            this.LabCotent.AutoSize = true;
            this.LabCotent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabCotent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCotent.Location = new System.Drawing.Point(18, 45);
            this.LabCotent.Name = "LabCotent";
            this.LabCotent.Size = new System.Drawing.Size(313, 80);
            this.LabCotent.TabIndex = 1;
            this.LabCotent.Text = "1. 자신이 클릭하려는 위치에 마우스를 놓는다.\r\n2. Ctrl + Q 를 누른다.\r\n3. 시작 버튼을 눌러 오토 클릭을 시작한다.\r\n4. Ctr" +
    "l + W 로 오토마우스를 정지한다.";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 151);
            this.Controls.Add(this.LabCotent);
            this.Controls.Add(this.LabTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel LabTitle;
        private Guna.UI.WinForms.GunaLabel LabCotent;
    }
}