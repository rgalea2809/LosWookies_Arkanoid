using System;
using System.Windows.Forms;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.Controlador.DAO;
using Wookies_arkanoid.Exceptions;
using Wookies_arkanoid.Game;

namespace Wookies_arkanoid.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loadObjects();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Signin formSignup = new Signin();
            formSignup.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePassword formChangepwd = new ChangePassword();
            formChangepwd.Show();
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cmbUserLogin1.SelectedValue.Equals(txtPasswordLogin1.Text))
                {
                    throw new IncorrectPasswordException("Invalid Password, try again!");
                }
                else
                {
                    Player p = (Player) cmbUserLogin1.SelectedItem;
                    Play formGame = new Play(p);
                    formGame.Show();
                    this.Close();
                }
            }
            catch (IncorrectPasswordException exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
        }
        
        private void loadObjects()
        {
            //Login User combobox options
            cmbUserLogin1.DataSource = null;
            cmbUserLogin1.ValueMember = "password"; 
            cmbUserLogin1.DisplayMember = "nickname";
            cmbUserLogin1.DataSource = PlayerDAO.getPlayers();
        }
    }
}