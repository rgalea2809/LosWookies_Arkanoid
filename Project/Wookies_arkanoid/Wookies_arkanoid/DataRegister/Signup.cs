using System;
using System.Windows.Forms;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.Controlador.DAO;
using Wookies_arkanoid.Exceptions;
using Wookies_arkanoid.Game;

namespace Wookies_arkanoid.Vista
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login FormLogin = new Login();
            FormLogin.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formMainMenu = new Form1();
            formMainMenu.Show();
            this.Close();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserSignup1.Text.Equals(" ") ||
                    txtPasswordSignup2.Text.Equals("") ||
                    txtConfirmSignup3.Text.Equals(""))
                {
                    throw new EmptyFormFieldException("No deje espacios vacíos!");
                }
                else
                {
                    if (txtPasswordSignup2.Text != txtConfirmSignup3.Text)
                    {
                        throw new NonMatchingPasswordValidationException("Error en su contraseña. " +
                                                                         "Escriba la misma contraseña en ambos campos");
                    }
                    else
                    {
                        Player p = new Player();
                        p.nickname = txtUserSignup1.Text;
                        p.password = txtPasswordSignup2.Text;
                        bool added = PlayerDAO.addUser(p);
                        if (added == true)
                        {
                            Play formGame = new Play();
                            formGame.Show();
                            this.Close();
                        }
                    }
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
    }
}