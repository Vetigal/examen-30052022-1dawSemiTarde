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
    public partial class MainForm : Form
    {

        private string player;
        private int points;
        List<object> questions = new List<object>();


        public MainForm()
        {
            InitializeComponent();
        }

        public void play(QuestionModel) { }

        public void addQuestion()
        {
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            QuestionForm formQuestion = new QuestionForm();
            if (formQuestion.ShowDialog() == DialogResult.OK)
            {
                string cadena1 = formQuestion.cad1;
                string cadena2 = formQuestion.cad2;
                bool boleano1 = formQuestion.bl1;
                bool boleano2 = formQuestion.bl2;

            }
        }
    }
}
