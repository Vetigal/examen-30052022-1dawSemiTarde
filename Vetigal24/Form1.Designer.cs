﻿namespace Vetigal24
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.txt_jugador = new System.Windows.Forms.TextBox();
            this.lbl_puntuacion = new System.Windows.Forms.Label();
            this.btn_anyadir = new System.Windows.Forms.Button();
            this.btn_jugar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugador";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(589, 128);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(92, 20);
            this.label0.TabIndex = 1;
            this.label0.Text = "Puntuación";
            // 
            // txt_jugador
            // 
            this.txt_jugador.Location = new System.Drawing.Point(720, 48);
            this.txt_jugador.Name = "txt_jugador";
            this.txt_jugador.Size = new System.Drawing.Size(100, 22);
            this.txt_jugador.TabIndex = 2;
            // 
            // lbl_puntuacion
            // 
            this.lbl_puntuacion.AutoSize = true;
            this.lbl_puntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puntuacion.Location = new System.Drawing.Point(728, 128);
            this.lbl_puntuacion.Name = "lbl_puntuacion";
            this.lbl_puntuacion.Size = new System.Drawing.Size(0, 20);
            this.lbl_puntuacion.TabIndex = 3;
            // 
            // btn_anyadir
            // 
            this.btn_anyadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anyadir.Location = new System.Drawing.Point(120, 383);
            this.btn_anyadir.Name = "btn_anyadir";
            this.btn_anyadir.Size = new System.Drawing.Size(394, 49);
            this.btn_anyadir.TabIndex = 4;
            this.btn_anyadir.Text = "Añadir preguntas y respuestas";
            this.btn_anyadir.UseVisualStyleBackColor = true;
            this.btn_anyadir.Click += new System.EventHandler(this.btn_anyadir_Click);
            // 
            // btn_jugar
            // 
            this.btn_jugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jugar.Location = new System.Drawing.Point(120, 471);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(394, 38);
            this.btn_jugar.TabIndex = 5;
            this.btn_jugar.Text = "Jugar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vetigal24.Properties.Resources.gatos_al_flautista;
            this.pictureBox1.Location = new System.Drawing.Point(51, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 323);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_jugar);
            this.Controls.Add(this.btn_anyadir);
            this.Controls.Add(this.lbl_puntuacion);
            this.Controls.Add(this.txt_jugador);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Hola soy Mister question";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.TextBox txt_jugador;
        private System.Windows.Forms.Label lbl_puntuacion;
        private System.Windows.Forms.Button btn_anyadir;
        private System.Windows.Forms.Button btn_jugar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

