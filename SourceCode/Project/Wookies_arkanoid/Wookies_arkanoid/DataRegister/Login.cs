using System;
using System.Windows.Forms;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.Controlador.DAO;
using Wookies_arkanoid.Events;
using Wookies_arkanoid.Exceptions;

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
            SignUpEventArgs signUpEvent = new SignUpEventArgs();
            signUpEvent.Event(sender, e, null);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePasswordEventArgs changePasswordevent = new ChangePasswordEventArgs();
            changePasswordevent.Event(sender, e, null);
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
                    StartEventArgs start = new StartEventArgs();
                    start.Event(sender, e, p);
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