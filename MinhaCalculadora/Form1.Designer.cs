
namespace MinhaCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Operacao = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Adicao = new System.Windows.Forms.Button();
            this.btn_Subtracao = new System.Windows.Forms.Button();
            this.btn_Multiplicacao = new System.Windows.Forms.Button();
            this.btn_Divisao = new System.Windows.Forms.Button();
            this.btn_Resultado = new System.Windows.Forms.Button();
            this.btn_virgulaPonto = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.Location = new System.Drawing.Point(13, 25);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(415, 78);
            this.txt_Resultado.TabIndex = 0;
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Operacao
            // 
            this.lbl_Operacao.AutoSize = true;
            this.lbl_Operacao.Location = new System.Drawing.Point(25, 55);
            this.lbl_Operacao.Name = "lbl_Operacao";
            this.lbl_Operacao.Size = new System.Drawing.Size(0, 17);
            this.lbl_Operacao.TabIndex = 1;
            // 
            // btn_1
            // 
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1.Location = new System.Drawing.Point(13, 139);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 77);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2.Location = new System.Drawing.Point(94, 139);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 77);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3.Location = new System.Drawing.Point(175, 139);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 77);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_6
            // 
            this.btn_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_6.Location = new System.Drawing.Point(175, 222);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 77);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_5.Location = new System.Drawing.Point(94, 222);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 77);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4.Location = new System.Drawing.Point(13, 222);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 77);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_9
            // 
            this.btn_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_9.Location = new System.Drawing.Point(175, 305);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 77);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_8.Location = new System.Drawing.Point(94, 305);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 77);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_7.Location = new System.Drawing.Point(13, 305);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 77);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_0
            // 
            this.btn_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_0.Location = new System.Drawing.Point(13, 388);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(156, 77);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_Adicao
            // 
            this.btn_Adicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Adicao.Location = new System.Drawing.Point(272, 139);
            this.btn_Adicao.Name = "btn_Adicao";
            this.btn_Adicao.Size = new System.Drawing.Size(75, 77);
            this.btn_Adicao.TabIndex = 12;
            this.btn_Adicao.Text = "+";
            this.btn_Adicao.UseVisualStyleBackColor = true;
            this.btn_Adicao.Click += new System.EventHandler(this.btn_Adicao_Click);
            // 
            // btn_Subtracao
            // 
            this.btn_Subtracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Subtracao.Location = new System.Drawing.Point(272, 222);
            this.btn_Subtracao.Name = "btn_Subtracao";
            this.btn_Subtracao.Size = new System.Drawing.Size(75, 77);
            this.btn_Subtracao.TabIndex = 13;
            this.btn_Subtracao.Text = "-";
            this.btn_Subtracao.UseVisualStyleBackColor = true;
            this.btn_Subtracao.Click += new System.EventHandler(this.btn_Subtracao_Click);
            // 
            // btn_Multiplicacao
            // 
            this.btn_Multiplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Multiplicacao.Location = new System.Drawing.Point(272, 305);
            this.btn_Multiplicacao.Name = "btn_Multiplicacao";
            this.btn_Multiplicacao.Size = new System.Drawing.Size(75, 77);
            this.btn_Multiplicacao.TabIndex = 14;
            this.btn_Multiplicacao.Text = "x";
            this.btn_Multiplicacao.UseVisualStyleBackColor = true;
            this.btn_Multiplicacao.Click += new System.EventHandler(this.btn_Multiplicacao_Click);
            // 
            // btn_Divisao
            // 
            this.btn_Divisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Divisao.Location = new System.Drawing.Point(272, 388);
            this.btn_Divisao.Name = "btn_Divisao";
            this.btn_Divisao.Size = new System.Drawing.Size(75, 77);
            this.btn_Divisao.TabIndex = 15;
            this.btn_Divisao.Text = "/";
            this.btn_Divisao.UseVisualStyleBackColor = true;
            this.btn_Divisao.Click += new System.EventHandler(this.btn_Divisao_Click);
            // 
            // btn_Resultado
            // 
            this.btn_Resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Resultado.Location = new System.Drawing.Point(353, 305);
            this.btn_Resultado.Name = "btn_Resultado";
            this.btn_Resultado.Size = new System.Drawing.Size(75, 160);
            this.btn_Resultado.TabIndex = 16;
            this.btn_Resultado.Text = "=";
            this.btn_Resultado.UseVisualStyleBackColor = true;
            this.btn_Resultado.Click += new System.EventHandler(this.btn_Resultado_Click);
            // 
            // btn_virgulaPonto
            // 
            this.btn_virgulaPonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_virgulaPonto.Location = new System.Drawing.Point(175, 388);
            this.btn_virgulaPonto.Name = "btn_virgulaPonto";
            this.btn_virgulaPonto.Size = new System.Drawing.Size(75, 77);
            this.btn_virgulaPonto.TabIndex = 17;
            this.btn_virgulaPonto.Text = ".";
            this.btn_virgulaPonto.UseVisualStyleBackColor = true;
            this.btn_virgulaPonto.Click += new System.EventHandler(this.btn_virgulaPonto_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CE.Location = new System.Drawing.Point(353, 139);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(75, 77);
            this.btn_CE.TabIndex = 18;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_C
            // 
            this.btn_C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_C.Location = new System.Drawing.Point(353, 222);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(75, 77);
            this.btn_C.TabIndex = 19;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 507);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_virgulaPonto);
            this.Controls.Add(this.btn_Resultado);
            this.Controls.Add(this.btn_Divisao);
            this.Controls.Add(this.btn_Multiplicacao);
            this.Controls.Add(this.btn_Subtracao);
            this.Controls.Add(this.btn_Adicao);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lbl_Operacao);
            this.Controls.Add(this.txt_Resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_Operacao;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Adicao;
        private System.Windows.Forms.Button btn_Subtracao;
        private System.Windows.Forms.Button btn_Multiplicacao;
        private System.Windows.Forms.Button btn_Divisao;
        private System.Windows.Forms.Button btn_Resultado;
        private System.Windows.Forms.Button btn_virgulaPonto;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_C;
    }
}

