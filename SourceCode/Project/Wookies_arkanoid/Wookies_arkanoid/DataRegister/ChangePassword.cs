using System;
using System.Windows.Forms;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.Controlador.DAO;
using Wookies_arkanoid.Exceptions;
using Wookies_arkanoid.Game;

namespace Wookies_arkanoid.Vista
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            loadObjects();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login FormLogin = new Login();
            FormLogin.Show();
            this.Close();
        }

        private void changepwdBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUser1.SelectedValue.Equals(txtOldPassword1.Text))
                {
                    Player p = (Player) cmbUser1.SelectedItem;
                    if (txtNewPassword2.Text.Equals("") ||
                        txtCNewPassword3.Text.Equals(""))
                    {
                        throw new EmptyFormFieldException("Don't leave blank spaces, fill out the form!");
                    }
                    else
                    {
                        if (txtNewPassword2.Text != txtCNewPassword3.Text)
                        {
                            throw new NonMatchingPasswordValidationException("Error en su nueva contraseña. " +
                                                                             "Escriba la misma contraseña en " +
                                                                             "ambos campos");
                        }
                        else
                        {
                            PlayerDAO.changePassword(p, txtNewPassword2.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (EmptyFormFieldException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (NonMatchingPasswordValidationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        private void loadObjects()
        {
            //Login User combobox options
            cmbUser1.DataSource = null;
            cmbUser1.ValueMember = "password"; 
            cmbUser1.DisplayMember = "nickname";
            cmbUser1.DataSource = PlayerDAO.getPlayers();
        }
    }
}