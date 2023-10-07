using System.Text.RegularExpressions;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*\\W).+$");
            //Regex validacion = new Regex("^(?=.* [A - Z])(?=.* [a - z])(?=.*\d)(?=.*\W).+$");

            if (string.IsNullOrEmpty(txtPassword1.Text) && string.IsNullOrEmpty(txtPassword2.Text))
            {
                MessageBox.Show("Los campos está vacíos");
                return;
            }
            if (!txtPassword1.Text.Equals(txtPassword2.Text))
            {
                MessageBox.Show("Las contraseñas no son iguales");
                return;
            }
            if (validacion.IsMatch(txtPassword2.Text))
            {
                MessageBox.Show("La contraseña es válida");
            }
            else
            {
                MessageBox.Show("La contraseña no es válida");
            }
        }
    }
}