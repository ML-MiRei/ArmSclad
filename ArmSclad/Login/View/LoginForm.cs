using ArmSclad.UI.Modules.Login.View;

namespace ArmSclad
{
    public partial class LoginForm : Form
    {
        private static SignupForm _signupForm;
        private static SigninForm _signinForm;

        public LoginForm(SigninForm signinForm, SignupForm signupForm)
        {
            InitializeComponent();

            signinForm.TopLevel = false;
            signupForm.TopLevel = false;

            _signinForm = signinForm;
            _signupForm = signupForm;

            PageContainer.Controls.Add(_signinForm);
            PageContainer.Controls.Add(_signupForm);

            signinForm.Show();

            ToRegistrationButton.Click += ToRegistrationButton_Click;
            ToSigninButton.Click += ToSigninButton_Click;
        }

        private void ToRegistrationButton_Click(object? sender, EventArgs e)
        {
            _signinForm.Visible = false;
            _signupForm.Visible  = true;
            ToRegistrationButton.Visible = false;
            ToSigninButton.Visible = true;
            TitleForm.Text = "Регистрация";
        }


        private void ToSigninButton_Click(object? sender, EventArgs e)
        {
            _signupForm.Visible = false;
            _signinForm.Visible = true;
            ToRegistrationButton.Visible = true;
            ToSigninButton.Visible = false;
            TitleForm.Text = "Вход";
        }


        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
