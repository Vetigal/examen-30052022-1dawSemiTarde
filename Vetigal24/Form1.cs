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

     //   public void play(QuestionModel) { }

        public void addQuestion()
        {
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
                player = txt_jugador.Text;
                Form formulario = new Form2();
                formulario.ShowDialog();
        }

        private void btn_anyadir_Click(object sender, EventArgs e)
        {
            Form formPreguntas = new Form2();
            formPreguntas.ShowDialog();
        }
    }
}
