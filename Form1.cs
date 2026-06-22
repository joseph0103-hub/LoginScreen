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
        private const int MaxLoginAttempts = 3;
        private const int LockSeconds = 30;

        private bool isIdPlaceholderActive = true;
        private bool isPasswordPlaceholderActive = true;
        private int failedLoginAttempts = 0;
        private int remainingLockSeconds = 0;
        private bool isLocked = false;

        public Form1()
        {
            InitializeComponent();
            WireEvents();
            ApplyIdPlaceholder();
            ApplyPasswordPlaceholder();
            UpdateAttemptInfo();
            txtId.Focus();
        }

        private void WireEvents()
        {
            txtId.Enter += (_, _) => RemoveIdPlaceholderIfNeeded();
            txtId.Leave += (_, _) => ApplyIdPlaceholderIfNeeded();
            txtId.TextChanged += (_, _) => HideErrorMessage();
            txtId.KeyDown += TxtId_KeyDown;

            txtPassword.Enter += (_, _) => RemovePasswordPlaceholderIfNeeded();
            txtPassword.Leave += (_, _) => ApplyPasswordPlaceholderIfNeeded();
            txtPassword.TextChanged += (_, _) => HideErrorMessage();
            txtPassword.KeyDown += TxtPassword_KeyDown;

            btnLogin.Click += (_, _) => AttemptLogin();
            btnClear.Click += (_, _) => ClearAllInputs();
            chkShowPassword.CheckedChanged += (_, _) => UpdatePasswordMask();
            chkHuman.CheckedChanged += (_, _) => HideErrorMessage();
            lockTimer.Tick += LockTimer_Tick;
        }

        private void TxtId_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.SuppressKeyPress = true;
            RemovePasswordPlaceholderIfNeeded();
            txtPassword.Focus();
        }

        private void TxtPassword_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.SuppressKeyPress = true;
            AttemptLogin();
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

            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private string CurrentId => isIdPlaceholderActive ? string.Empty : txtId.Text.Trim();

        private string CurrentPassword => isPasswordPlaceholderActive ? string.Empty : txtPassword.Text;

        private void AttemptLogin()
        {
            HideErrorMessage();

            if (isLocked)
            {
                ShowErrorMessage($"로그인이 잠겼습니다. {remainingLockSeconds}초 후 다시 시도하세요.");
                return;
            }

            string validationMessage;
            if (!ValidateInputs(out validationMessage))
            {
                RegisterLoginFailure(validationMessage);
                return;
            }

            if (CurrentId == ValidId && CurrentPassword == ValidPassword)
            {
                failedLoginAttempts = 0;
                UpdateAttemptInfo();
                MessageBox.Show("로그인 성공", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RegisterLoginFailure("아이디 또는 비밀번호가 맞지 않습니다.");
        }

        private void RegisterLoginFailure(string message)
        {
            failedLoginAttempts++;

            if (failedLoginAttempts >= MaxLoginAttempts)
            {
                StartLoginLock();
                return;
            }

            int remainingAttempts = MaxLoginAttempts - failedLoginAttempts;
            ShowErrorMessage($"{message} 남은 시도: {remainingAttempts}회");
            UpdateAttemptInfo();
        }

        private bool ValidateInputs(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrWhiteSpace(CurrentId) || string.IsNullOrWhiteSpace(CurrentPassword))
            {
                message = "아이디와 비밀번호를 모두 입력해 주세요.";
                return false;
            }

            if (!IsValidId(CurrentId))
            {
                message = "아이디는 영문자와 숫자만 입력할 수 있습니다.";
                txtId.Focus();
                return false;
            }

            if (!IsValidPassword(CurrentPassword))
            {
                message = "비밀번호는 공백없이 숫자와 특수문자 !를 포함해야 합니다.";
                txtPassword.Focus();
                return false;
            }

            if (!chkHuman.Checked)
            {
                message = "사용자 확인 항목을 체크해 주세요.";
                chkHuman.Focus();
                return false;
            }

            return true;
        }

        private static bool IsValidId(string id)
        {
            return Regex.IsMatch(id, "^[a-zA-Z0-9]+$");
        }

        private static bool IsValidPassword(string password)
        {
            bool hasNumber = Regex.IsMatch(password, "[0-9]");
            bool hasRequiredSpecialChar = password.Contains('!');
            bool hasSpace = Regex.IsMatch(password, "\\s");
            bool hasInvalidKorean = Regex.IsMatch(password, "[가-힣]");

            return password.Length >= 4 && hasNumber && hasRequiredSpecialChar && !hasSpace && !hasInvalidKorean;
        }

        private void StartLoginLock()
        {
            isLocked = true;
            remainingLockSeconds = LockSeconds;
            SetInputEnabled(false);
            ShowErrorMessage($"로그인 3회 실패로 잠겼습니다. {remainingLockSeconds}초 후 다시 시도하세요.");
            UpdateAttemptInfo();
            lockTimer.Start();
        }

        private void LockTimer_Tick(object? sender, EventArgs e)
        {
            remainingLockSeconds--;

            if (remainingLockSeconds > 0)
            {
                ShowErrorMessage($"로그인 3회 실패로 잠겼습니다. {remainingLockSeconds}초 후 다시 시도하세요.");
                UpdateAttemptInfo();
                return;
            }

            lockTimer.Stop();
            isLocked = false;
            failedLoginAttempts = 0;
            remainingLockSeconds = 0;
            SetInputEnabled(true);
            HideErrorMessage();
            UpdateAttemptInfo();
            txtId.Focus();
        }

        private void SetInputEnabled(bool enabled)
        {
            txtId.Enabled = enabled;
            txtPassword.Enabled = enabled;
            chkShowPassword.Enabled = enabled;
            chkHuman.Enabled = enabled;
            btnLogin.Enabled = enabled;
            btnClear.Enabled = enabled;
        }

        private void UpdateAttemptInfo()
        {
            if (isLocked)
            {
                lblAttemptInfo.Text = $"로그인 잠김: {remainingLockSeconds}초 남음";
                return;
            }

            int remainingAttempts = MaxLoginAttempts - failedLoginAttempts;
            lblAttemptInfo.Text = $"로그인 시도 가능 횟수: {remainingAttempts}회";
        }

        private void ClearAllInputs()
        {
            HideErrorMessage();
            chkShowPassword.Checked = false;
            chkHuman.Checked = false;
            ApplyIdPlaceholder();
            ApplyPasswordPlaceholder();
            txtId.Focus();
        }

        private void ShowErrorMessage(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        private void HideErrorMessage()
        {
            lblError.Visible = false;
        }
    }
}
