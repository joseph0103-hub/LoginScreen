using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        private const string ValidId = "superman";
        private const string ValidPassword = "1234!";

        private bool isIdPlaceholderActive = true;
        private bool isPasswordPlaceholderActive = true;

        public Form1()
        {
            InitializeComponent();
            WireEvents();
            ApplyIdPlaceholder();
            ApplyPasswordPlaceholder();
        }

        private void WireEvents()
        {
            txtId.Enter += (_, _) => RemoveIdPlaceholderIfNeeded();
            txtId.Leave += (_, _) => ApplyIdPlaceholderIfNeeded();
            txtPassword.Enter += (_, _) => RemovePasswordPlaceholderIfNeeded();
            txtPassword.Leave += (_, _) => ApplyPasswordPlaceholderIfNeeded();
            btnLogin.Click += (_, _) => AttemptLogin();
        }

        private void ApplyIdPlaceholder()
        {
            isIdPlaceholderActive = true;
            txtId.ForeColor = Color.Gray;
            txtId.Text = "아이디 입력";
        }

        private void ApplyPasswordPlaceholder()
        {
            isPasswordPlaceholderActive = true;
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = "패스워드 입력";
        }

        private void RemoveIdPlaceholderIfNeeded()
        {
            if (!isIdPlaceholderActive)
            {
                return;
            }

            isIdPlaceholderActive = false;
            txtId.Text = string.Empty;
            txtId.ForeColor = Color.Black;
        }

        private void RemovePasswordPlaceholderIfNeeded()
        {
            if (!isPasswordPlaceholderActive)
            {
                return;
            }

            isPasswordPlaceholderActive = false;
            txtPassword.Text = string.Empty;
            txtPassword.ForeColor = Color.Black;
            UpdatePasswordMask();
        }

        private void ApplyIdPlaceholderIfNeeded()
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                return;
            }

            ApplyIdPlaceholder();
        }

        private void ApplyPasswordPlaceholderIfNeeded()
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                return;
            }

            ApplyPasswordPlaceholder();
        }

        private void UpdatePasswordMask()
        {
            if (isPasswordPlaceholderActive)
            {
                txtPassword.UseSystemPasswordChar = false;
                return;
            }

            txtPassword.UseSystemPasswordChar = true;
        }

        private string CurrentId => isIdPlaceholderActive ? string.Empty : txtId.Text.Trim();

        private string CurrentPassword => isPasswordPlaceholderActive ? string.Empty : txtPassword.Text;

        private void AttemptLogin()
        {
            if (string.IsNullOrWhiteSpace(CurrentId) || string.IsNullOrWhiteSpace(CurrentPassword))
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해 주세요.", "입력 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CurrentId == ValidId && CurrentPassword == ValidPassword)
            {
                MessageBox.Show("로그인 성공", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
