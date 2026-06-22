namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new Label();
            this.txtId = new TextBox();
            this.txtPassword = new TextBox();
            this.chkShowPassword = new CheckBox();
            this.btnLogin = new Button();
            this.btnClear = new Button();
            this.chkHuman = new CheckBox();
            this.lblAttemptInfo = new Label();
            this.lblError = new Label();
            this.lockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new Font("맑은 고딕", 28F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(120, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(320, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Font = new Font("맑은 고딕", 17F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtId.Location = new Point(120, 125);
            this.txtId.ForeColor = Color.Gray;
            this.txtId.Name = "txtId";
            this.txtId.Size = new Size(320, 45);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "아이디 입력";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("맑은 고딕", 17F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtPassword.Location = new Point(120, 190);
            this.txtPassword.ForeColor = Color.Gray;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(320, 45);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "패스워드 입력";
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.chkShowPassword.Location = new Point(120, 245);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new Size(142, 27);
            this.chkShowPassword.TabIndex = 3;
            this.chkShowPassword.Text = "비밀번호 보기";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // chkHuman
            // 
            this.chkHuman.AutoSize = true;
            this.chkHuman.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.chkHuman.Location = new Point(120, 275);
            this.chkHuman.Name = "chkHuman";
            this.chkHuman.Size = new Size(126, 27);
            this.chkHuman.TabIndex = 4;
            this.chkHuman.Text = "사용자 확인";
            this.chkHuman.UseVisualStyleBackColor = true;
            // 
            // lblAttemptInfo
            // 
            this.lblAttemptInfo.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblAttemptInfo.ForeColor = Color.DimGray;
            this.lblAttemptInfo.Location = new Point(120, 306);
            this.lblAttemptInfo.Name = "lblAttemptInfo";
            this.lblAttemptInfo.Size = new Size(350, 25);
            this.lblAttemptInfo.TabIndex = 5;
            this.lblAttemptInfo.Text = "로그인 시도 가능 횟수: 3회";
            this.lblAttemptInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // 
            // lblError
            // 
            this.lblError.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblError.ForeColor = Color.Red;
            this.lblError.Location = new Point(90, 310);
            this.lblError.Name = "lblError";
            this.lblError.Size = new Size(400, 60);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "아이디 또는 비밀번호가 맞지 않습니다.";
            this.lblError.TextAlign = ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = Color.LightCyan;
            this.btnLogin.FlatAppearance.BorderColor = Color.PowderBlue;
            this.btnLogin.FlatAppearance.BorderSize = 1;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Font = new Font("맑은 고딕", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnLogin.ForeColor = Color.RoyalBlue;
            this.btnLogin.Location = new Point(110, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(135, 52);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = Color.White;
            this.btnClear.FlatAppearance.BorderColor = Color.Silver;
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Font = new Font("맑은 고딕", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnClear.ForeColor = Color.DimGray;
            this.btnClear.Location = new Point(265, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(185, 52);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "전체 지우기";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(560, 510);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblAttemptInfo);
            this.Controls.Add(this.chkHuman);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTitle);
            this.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // lockTimer
            // 
            this.lockTimer.Interval = 1000;
        }

        #endregion

        private Label lblTitle;
        private TextBox txtId;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private CheckBox chkHuman;
        private Label lblAttemptInfo;
        private Button btnLogin;
        private Button btnClear;
        private Label lblError;
        private System.Windows.Forms.Timer lockTimer;
    }
}
