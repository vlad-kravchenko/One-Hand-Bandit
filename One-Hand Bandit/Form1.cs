using System;
using System.Windows.Forms;

namespace One_Hand_Bandit
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dvig1_Tick(object sender, EventArgs e)
        {
            label1.Text = rand.Next(8).ToString();
        }

        private void dvig2_Tick(object sender, EventArgs e)
        {
            label2.Text = rand.Next(8).ToString();
        }

        private void dvig3_Tick(object sender, EventArgs e)
        {
            label3.Text = rand.Next(8).ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            dvig1.Enabled = dvig2.Enabled = dvig3.Enabled = stop1.Enabled = stop2.Enabled = stop3.Enabled = true;
        }

        private void stop1_Tick(object sender, EventArgs e)
        {
            dvig1.Enabled = false;
            stop1.Enabled = false;
        }

        private void stop2_Tick(object sender, EventArgs e)
        {
            dvig2.Enabled = false;
            stop2.Enabled = false;
        }

        private void stop3_Tick(object sender, EventArgs e)
        {
            dvig3.Enabled = false;
            stop3.Enabled = false;

            if (label1.Text == label2.Text || label1.Text == label3.Text || label2.Text == label3.Text)
                MessageBox.Show("Вы выиграли $100!");
            else return;

            if (label1.Text == "1" && label2.Text == "1" && label3.Text == "1") MessageBox.Show("Вы выиграли $1000!");
            if (label1.Text == "2" && label2.Text == "2" && label3.Text == "2") MessageBox.Show("Вы выиграли $2000!");
            if (label1.Text == "3" && label2.Text == "3" && label3.Text == "3") MessageBox.Show("Вы выиграли $3000!");
            if (label1.Text == "4" && label2.Text == "4" && label3.Text == "4") MessageBox.Show("Вы выиграли $4000!");
            if (label1.Text == "5" && label2.Text == "5" && label3.Text == "5") MessageBox.Show("Вы выиграли $5000!");
            if (label1.Text == "6" && label2.Text == "6" && label3.Text == "6") MessageBox.Show("Вы выиграли $6000!");
            if (label1.Text == "7" && label2.Text == "7" && label3.Text == "7") MessageBox.Show("Вы сорвали джек-пот $10 000!");

            if (label2.Text == "0" && label3.Text == "0") MessageBox.Show("Вы выиграли $" + label1.Text + "00!");
        }
    }
}
