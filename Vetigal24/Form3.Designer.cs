namespace Vetigal24
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_pregunta = new System.Windows.Forms.ComboBox();
            this.btn_niIdea = new System.Windows.Forms.Button();
            this.btn_estoySeguro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la opcion correcta de la pregunta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pregunta";
            // 
            // comboBox_pregunta
            // 
            this.comboBox_pregunta.FormattingEnabled = true;
            this.comboBox_pregunta.Items.AddRange(new object[] {
            "Respuesta A",
            "Respuesta B",
            "Respuesta C",
            "Valor"});
            this.comboBox_pregunta.Location = new System.Drawing.Point(51, 179);
            this.comboBox_pregunta.Name = "comboBox_pregunta";
            this.comboBox_pregunta.Size = new System.Drawing.Size(337, 24);
            this.comboBox_pregunta.TabIndex = 2;
            this.comboBox_pregunta.SelectedIndexChanged += new System.EventHandler(this.comboBox_pregunta_SelectedIndexChanged);
            // 
            // btn_niIdea
            // 
            this.btn_niIdea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_niIdea.Location = new System.Drawing.Point(51, 271);
            this.btn_niIdea.Name = "btn_niIdea";
            this.btn_niIdea.Size = new System.Drawing.Size(139, 79);
            this.btn_niIdea.TabIndex = 3;
            this.btn_niIdea.Text = "Ni idea";
            this.btn_niIdea.UseVisualStyleBackColor = true;
            // 
            // btn_estoySeguro
            // 
            this.btn_estoySeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estoySeguro.Location = new System.Drawing.Point(253, 271);
            this.btn_estoySeguro.Name = "btn_estoySeguro";
            this.btn_estoySeguro.Size = new System.Drawing.Size(135, 79);
            this.btn_estoySeguro.TabIndex = 4;
            this.btn_estoySeguro.Text = "Estoy seguro";
            this.btn_estoySeguro.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 406);
            this.Controls.Add(this.btn_estoySeguro);
            this.Controls.Add(this.btn_niIdea);
            this.Controls.Add(this.comboBox_pregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GameForm";
            this.Text = "Hola soy Mister question";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_pregunta;
        private System.Windows.Forms.Button btn_niIdea;
        private System.Windows.Forms.Button btn_estoySeguro;
    }
}