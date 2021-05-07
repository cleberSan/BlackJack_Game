
namespace BlackJack
{
    partial class Form_jogo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_jogo));
            this.btn_jogar_1 = new System.Windows.Forms.Button();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Pontos_A = new System.Windows.Forms.Label();
            this.lbl_legenda = new System.Windows.Forms.Label();
            this.btn_parar_1 = new System.Windows.Forms.Button();
            this.btn_parar_2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_jogar_2 = new System.Windows.Forms.Button();
            this.lbl_Pontos_B = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_jogar_1
            // 
            this.btn_jogar_1.BackColor = System.Drawing.Color.Gray;
            this.btn_jogar_1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_jogar_1.Location = new System.Drawing.Point(30, 603);
            this.btn_jogar_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_jogar_1.Name = "btn_jogar_1";
            this.btn_jogar_1.Size = new System.Drawing.Size(126, 39);
            this.btn_jogar_1.TabIndex = 0;
            this.btn_jogar_1.Text = "Jogar";
            this.btn_jogar_1.UseVisualStyleBackColor = false;
            this.btn_jogar_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.BackColor = System.Drawing.Color.Gray;
            this.btn_reiniciar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reiniciar.Location = new System.Drawing.Point(381, 16);
            this.btn_reiniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(137, 37);
            this.btn_reiniciar.TabIndex = 1;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = false;
            this.btn_reiniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(30, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Pontos_A
            // 
            this.lbl_Pontos_A.AutoSize = true;
            this.lbl_Pontos_A.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pontos_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pontos_A.ForeColor = System.Drawing.Color.White;
            this.lbl_Pontos_A.Location = new System.Drawing.Point(381, 240);
            this.lbl_Pontos_A.Name = "lbl_Pontos_A";
            this.lbl_Pontos_A.Size = new System.Drawing.Size(30, 31);
            this.lbl_Pontos_A.TabIndex = 3;
            this.lbl_Pontos_A.Text = "0";
            this.lbl_Pontos_A.Click += new System.EventHandler(this.lbl_Pontos_A_Click);
            // 
            // lbl_legenda
            // 
            this.lbl_legenda.AutoSize = true;
            this.lbl_legenda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_legenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_legenda.ForeColor = System.Drawing.Color.White;
            this.lbl_legenda.Location = new System.Drawing.Point(410, 216);
            this.lbl_legenda.Name = "lbl_legenda";
            this.lbl_legenda.Size = new System.Drawing.Size(84, 24);
            this.lbl_legenda.TabIndex = 4;
            this.lbl_legenda.Text = "Pontos:";
            // 
            // btn_parar_1
            // 
            this.btn_parar_1.BackColor = System.Drawing.Color.Gray;
            this.btn_parar_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_parar_1.FlatAppearance.BorderSize = 0;
            this.btn_parar_1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_parar_1.Location = new System.Drawing.Point(185, 603);
            this.btn_parar_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_parar_1.Name = "btn_parar_1";
            this.btn_parar_1.Size = new System.Drawing.Size(126, 39);
            this.btn_parar_1.TabIndex = 5;
            this.btn_parar_1.Text = "Parar";
            this.btn_parar_1.UseVisualStyleBackColor = false;
            this.btn_parar_1.Click += new System.EventHandler(this.btn_parar_1_Click);
            // 
            // btn_parar_2
            // 
            this.btn_parar_2.BackColor = System.Drawing.Color.Gray;
            this.btn_parar_2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_parar_2.Location = new System.Drawing.Point(750, 603);
            this.btn_parar_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_parar_2.Name = "btn_parar_2";
            this.btn_parar_2.Size = new System.Drawing.Size(126, 39);
            this.btn_parar_2.TabIndex = 8;
            this.btn_parar_2.Text = "Parar";
            this.btn_parar_2.UseVisualStyleBackColor = false;
            this.btn_parar_2.Click += new System.EventHandler(this.btn_parar_2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BlackJack.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(594, 111);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 471);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btn_jogar_2
            // 
            this.btn_jogar_2.BackColor = System.Drawing.Color.Gray;
            this.btn_jogar_2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_jogar_2.Location = new System.Drawing.Point(594, 603);
            this.btn_jogar_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_jogar_2.Name = "btn_jogar_2";
            this.btn_jogar_2.Size = new System.Drawing.Size(126, 39);
            this.btn_jogar_2.TabIndex = 6;
            this.btn_jogar_2.Text = "Jogar";
            this.btn_jogar_2.UseVisualStyleBackColor = false;
            this.btn_jogar_2.Click += new System.EventHandler(this.btn_jogar_2_Click);
            // 
            // lbl_Pontos_B
            // 
            this.lbl_Pontos_B.AutoSize = true;
            this.lbl_Pontos_B.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pontos_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pontos_B.ForeColor = System.Drawing.Color.White;
            this.lbl_Pontos_B.Location = new System.Drawing.Point(479, 240);
            this.lbl_Pontos_B.Name = "lbl_Pontos_B";
            this.lbl_Pontos_B.Size = new System.Drawing.Size(30, 31);
            this.lbl_Pontos_B.TabIndex = 9;
            this.lbl_Pontos_B.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(438, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Resultado.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resultado.ForeColor = System.Drawing.Color.White;
            this.lbl_Resultado.Location = new System.Drawing.Point(352, 424);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 27);
            this.lbl_Resultado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jogador 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(675, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Jogador 2";
            // 
            // Form_jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = global::BlackJack.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(902, 669);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Pontos_B);
            this.Controls.Add(this.btn_parar_2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_jogar_2);
            this.Controls.Add(this.btn_parar_1);
            this.Controls.Add(this.lbl_legenda);
            this.Controls.Add(this.lbl_Pontos_A);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.btn_jogar_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_jogo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Black Jack (Versão1.0)";
            this.Load += new System.EventHandler(this.Form_jogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jogar_1;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Pontos_A;
        private System.Windows.Forms.Label lbl_legenda;
        private System.Windows.Forms.Button btn_parar_1;
        private System.Windows.Forms.Button btn_parar_2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_jogar_2;
        private System.Windows.Forms.Label lbl_Pontos_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

