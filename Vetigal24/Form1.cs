﻿using System;
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

        
        private int points;
        List<object> questions = new List<object>();

        private string player;

        public string Player
        {
            get { return player; }
            set { player = value; }
        }


        public string player
        {
            get { return player; }
            set { player = value; }
        }



        public MainForm()
        {
            InitializeComponent();
        }

        public void play(Form2) {

        }

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
