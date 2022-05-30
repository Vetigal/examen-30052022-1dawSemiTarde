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
    public partial class Form2 : Form
    {
        private string question;
        private string[]  answer;
        private int value;

        public Form2(string question, string[] answer, int value) {
            this.question = question;
            this.answer = answer;
            this.value = value;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

         private void button1_Click(object sender, EventArgs e)
          {
             
              this.DialogResult = DialogResult.OK;
              this.Close();
          }


    }
}
