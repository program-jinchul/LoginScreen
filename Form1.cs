namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "아이디")
            {
                txtId.Text = "";

                txtId.ForeColor = Color.Black;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {

                txtId.Text = "아이디";

                txtId.ForeColor = Color.Silver;
            }
        }

        private void txtPw_Enter(object sender, EventArgs e)
        {
            if (txtPw.Text == "패스워드")
            {
                txtPw.Text = "";
                txtPw.ForeColor = Color.Black;
                txtPw.UseSystemPasswordChar = true;
            }
        }

        private void txtPw_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPw.Text))
            {
                txtPw.UseSystemPasswordChar = false;
                txtPw.Text = "패스워드";
                txtPw.ForeColor = Color.Silver;
            }
        }

        string myID = "admin";
        string myPW = "superman";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtId.Text;
            string inputPW = txtPw.Text;

            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인성공!", "로그인", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("로그인실패~", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                txtPw.Focus(); // 패스워드입력창이포커스를갖게끔
            }
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                btnLogin.PerformClick(); // 버튼이눌린것처럼만들기
            }
        }
    }
}
