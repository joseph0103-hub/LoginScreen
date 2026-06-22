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
            this.btnLogin = new Button();
            this.lblError = new Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new Font("맑은 고딕", 28F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(120, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(320, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Font = new Font("맑은 고딕", 17F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtId.Location = new Point(120, 135);
            this.txtId.ForeColor = Color.Gray;
            this.txtId.Name = "txtId";
            this.txtId.Size = new Size(320, 45);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "아이디 입력";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("맑은 고딕", 17F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtPassword.Location = new Point(120, 205);
            this.txtPassword.ForeColor = Color.Gray;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(320, 45);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "패스워드 입력";
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // lblError
            // 
            this.lblError.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblError.ForeColor = Color.Red;
            this.lblError.Location = new Point(120, 255);
            //this.lblError.Location = new Point(95, 255);
            this.lblError.Name = "lblError";
            this.lblError.Size = new Size(350, 25);
            //this.lblError.Size = new Size(280, 25);
            this.lblError.TabIndex = 3;
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
            this.btnLogin.Location = new Point(210, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(140, 52);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(560, 430);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblError);
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
        private Button btnLogin;
        private Label lblError;
    }
}
