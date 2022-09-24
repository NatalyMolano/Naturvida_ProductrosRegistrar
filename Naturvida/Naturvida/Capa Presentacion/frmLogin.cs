namespace Naturvida
{
    public partial class frmLogin : Form
    {
        String _usuario = "nataly";
        String _contraseña = "123";
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == _usuario && txtcontraseña.Text == _contraseña)
            {
                lblerror.Visible = false;
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
            }
            else
            {
                lblerror.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}