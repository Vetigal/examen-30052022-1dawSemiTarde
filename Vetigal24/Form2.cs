using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetigal24
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cad1 = "esta es tu primera cadena";
            cad2 = "esta es tu segundacadena";
            bl1 = true;
            bl2 = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
