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
            
            if (inputID == myID && inputPW == myPW) { 
                MessageBox.Show("로그인성공!"); 
            } 
            else { 
                MessageBox.Show("로그인실패~"); 
            }
        }
    }
}
