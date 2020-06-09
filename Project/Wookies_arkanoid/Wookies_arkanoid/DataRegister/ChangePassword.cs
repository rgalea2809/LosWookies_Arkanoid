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
                if (comboBox1.SelectedValue.Equals(textBox1.Text))
                {
                    Player p = (Player) comboBox1.SelectedItem;
                    if (textBox2.Text.Equals("") ||
                        textBox3.Text.Equals(""))
                    {
                        throw new EmptyFormFieldException("Don't leave blank spaces, fill out the form!");
                    }
                    else
                    {
                        if (textBox2.Text != textBox3.Text)
                        {
                            throw new NonMatchingPasswordValidationException("Error en su nueva contraseña. " +
                                                                             "Escriba la misma contraseña en " +
                                                                             "ambos campos");
                        }
                        else
                        {
                            PlayerDAO.changePassword(p, textBox2.Text);
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
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "password"; 
            comboBox1.DisplayMember = "nickname";
            comboBox1.DataSource = PlayerDAO.getPlayers();
        }
    }
}