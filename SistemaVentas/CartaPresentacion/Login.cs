using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();

            form.Show();
            this.Hide(); //para ocultar el form login

            form.FormClosing += form_closing;
        }

        //Metodo para volver a mostar el form de login cuando se cierra el de inicio
        private void form_closing(object sender,FormClosingEventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";

            this.Show(); // para mostrar el form login que se encuentra oculto
        }
    }
}
