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
            txtId = new TextBox();
            txtPw = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.FromArgb(255, 128, 0);
            lblAppName.Location = new Point(215, 45);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(394, 166);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            lblAppName.Click += lblAppName_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("한컴 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtId.ForeColor = Color.Silver;
            txtId.Location = new Point(182, 253);
            txtId.Name = "txtId";
            txtId.Size = new Size(485, 91);
            txtId.TabIndex = 2;
            txtId.Text = "아이디";
            txtId.TextChanged += txtId_TextChanged;
            txtId.Enter += txtId_Enter;
            txtId.Leave += txtId_Leave;
            // 
            // txtPw
            // 
            txtPw.Font = new Font("한컴 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtPw.ForeColor = Color.Silver;
            txtPw.Location = new Point(182, 402);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(485, 91);
            txtPw.TabIndex = 3;
            txtPw.Text = "패스워드";
            txtPw.TextChanged += txtPw_TextChanged;
            txtPw.Enter += txtPw_Enter;
            txtPw.Leave += txtPw_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Font = new Font("한컴 고딕", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = Color.FromArgb(192, 255, 255);
            btnLogin.Location = new Point(268, 562);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 130);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 753);
            Controls.Add(btnLogin);
            Controls.Add(txtPw);
            Controls.Add(txtId);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtId;
        private TextBox txtPw;
        private Button btnLogin;
    }
}
