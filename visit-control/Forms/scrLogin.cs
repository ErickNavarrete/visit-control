using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using visit_control.Connection;
using visit_control.Models;

namespace visit_control
{
    public partial class scrLogin : MaterialForm

    {
        public scrLogin()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red900, //Color dialog 
                Primary.Red900, //Color control buttons
                Primary.Blue400,
                Accent.LightBlue200,
                TextShade.WHITE

            );
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //VALIDAMOS QUE EL CAMPO tbPassword NO ESTE VACÍO
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Campo obligatorio", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return;
            }
            var db = new ConnectionDB();

            //COMPROBAMOS QUE EL USUARIO EXISTA EN BASE DE DATOS
            var users = db.Users.Where(x => x.password == tbPassword.Text).FirstOrDefault();
            if (users == null)
            {
                MessageBox.Show("El usuario no existe", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Focus();
                return;
            }

            var scrDashBoard = new scrDashBoard();
            scrDashBoard.Show();
            scrDashBoard.BringToFront();
            Hide();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    btLogin.Focus();
                    break;
            }
        }
    }
}
