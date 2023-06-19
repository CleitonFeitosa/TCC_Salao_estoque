namespace TCC_Salao_estoque
{
    partial class Estoque
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
            this.bt_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bto_cadastrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tb_validade = new System.Windows.Forms.MaskedTextBox();
            this.tb_produto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.bt_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.bt_buscar.FlatAppearance.BorderSize = 0;
            this.bt_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscar.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.bt_buscar.ForeColor = System.Drawing.Color.White;
            this.bt_buscar.Location = new System.Drawing.Point(320, 185);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(103, 37);
            this.bt_buscar.TabIndex = 0;
            this.bt_buscar.Text = "buscar";
            this.bt_buscar.UseVisualStyleBackColor = false;
            this.bt_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(89, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "produto";
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tb_quantidade.Location = new System.Drawing.Point(454, 149);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(262, 29);
            this.tb_quantidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(449, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(82, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 71);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(89, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "validade";
            // 
            // tb_marca
            // 
            this.tb_marca.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tb_marca.Location = new System.Drawing.Point(235, 252);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(215, 29);
            this.tb_marca.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(230, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "marca";
            // 
            // tb_obs
            // 
            this.tb_obs.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tb_obs.Location = new System.Drawing.Point(485, 252);
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(231, 29);
            this.tb_obs.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.label6.Location = new System.Drawing.Point(480, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "observação";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(661, 57);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(55, 29);
            this.tb_id.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(685, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID";
            // 
            // bto_cadastrar
            // 
            this.bto_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.bto_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.bto_cadastrar.FlatAppearance.BorderSize = 0;
            this.bto_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bto_cadastrar.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.bto_cadastrar.ForeColor = System.Drawing.Color.White;
            this.bto_cadastrar.Location = new System.Drawing.Point(94, 381);
            this.bto_cadastrar.Name = "bto_cadastrar";
            this.bto_cadastrar.Size = new System.Drawing.Size(127, 37);
            this.bto_cadastrar.TabIndex = 17;
            this.bto_cadastrar.Text = "cadastrar";
            this.bto_cadastrar.UseVisualStyleBackColor = false;
            this.bto_cadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(251, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 37);
            this.button3.TabIndex = 18;
            this.button3.Text = "alterar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(385, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 37);
            this.button4.TabIndex = 19;
            this.button4.Text = "excluir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(117)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(518, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 37);
            this.button5.TabIndex = 20;
            this.button5.Text = "limpar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb_validade
            // 
            this.tb_validade.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tb_validade.Location = new System.Drawing.Point(94, 252);
            this.tb_validade.Mask = "00/00/0000";
            this.tb_validade.Name = "tb_validade";
            this.tb_validade.Size = new System.Drawing.Size(110, 29);
            this.tb_validade.TabIndex = 21;
            this.tb_validade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_validade.ValidatingType = typeof(System.DateTime);
            // 
            // tb_produto
            // 
            this.tb_produto.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tb_produto.FormattingEnabled = true;
            this.tb_produto.Location = new System.Drawing.Point(94, 149);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(329, 29);
            this.tb_produto.TabIndex = 22;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.tb_validade);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bto_cadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_buscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bto_cadastrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox tb_validade;
        private System.Windows.Forms.ComboBox tb_produto;
    }
}

