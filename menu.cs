using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workers Win = new workers();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orders Win = new orders();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            positions Win = new positions();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list Win = new list();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            men Win = new men();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            types Win = new types();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
    }
}
