using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void loginBtn_Click(object sender, EventArgs e)
        {
            //username.Text = "Hello";

            string usernameInput = username.Text;
            string passwordInput = password.Text;
            

            heading.Text = "Hello " + usernameInput;


            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 100;
            prompt.Text = "Thank you for loging in " + username.Text;
            prompt.ShowDialog();
        }

    }
}
