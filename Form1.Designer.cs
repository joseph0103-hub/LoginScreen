namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            btnLogin = new Button();
            txtPW = new TextBox();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(253, 26);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(218, 70);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "  Login";
            lblAppName.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(117, 121);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(500, 62);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.TextChanged += txtID_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 255);
            btnLogin.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = Color.Purple;
            btnLogin.Location = new Point(253, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(221, 79);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(117, 204);
            txtPW.Multiline = true;
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(500, 62);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(txtPW);
            Controls.Add(btnLogin);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private Button btnLogin;
        private TextBox txtPW;
    }
}
