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
            this.lblError = new Label();
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
            // lblError
            // 
            this.lblError.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblError.ForeColor = Color.Red;
            this.lblError.Location = new Point(120, 275);
            this.lblError.Name = "lblError";
            this.lblError.Size = new Size(350, 25);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "아이디 또는 비밀번호가 맞지 않습니다.";
            this.lblError.TextAlign = ContentAlignment.MiddleLeft;
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
            this.btnLogin.Location = new Point(110, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(135, 52);
            this.btnLogin.TabIndex = 5;
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
            this.btnClear.Location = new Point(265, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(185, 52);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "전체 지우기";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(560, 430);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblError);
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
        }

        #endregion

        private Label lblTitle;
        private TextBox txtId;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnClear;
        private Label lblError;
    }
}
