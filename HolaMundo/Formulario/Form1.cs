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
                MessageBox.Show("Los campos est� vac�os");
                return;
            }
            if (!txtPassword1.Text.Equals(txtPassword2.Text))
            {
                MessageBox.Show("Las contrase�as no son iguales");
                return;
            }
            if (validacion.IsMatch(txtPassword2.Text))
            {
                MessageBox.Show("La contrase�a es v�lida");
            }
            else
            {
                MessageBox.Show("La contrase�a no es v�lida");
            }
        }
    }
}