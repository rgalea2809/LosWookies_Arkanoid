using System;
using System.Windows.Forms;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.Controlador.DAO;
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
            if (comboBox1.SelectedValue.Equals(textBox2.Text))
            {
                Player p = (Player) comboBox1.SelectedItem;
                Play formGame = new Play();
                formGame.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
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