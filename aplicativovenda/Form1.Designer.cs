
namespace aplicativovenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.cob_produto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cob_preco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_carrinho = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lst_carrinho = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_mens = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_totalpagar = new System.Windows.Forms.Label();
            this.lbl_totalquant = new System.Windows.Forms.Label();
            this.lbl_totalprod = new System.Windows.Forms.Label();
            this.lbl_childlist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // cob_produto
            // 
            this.cob_produto.FormattingEnabled = true;
            this.cob_produto.Items.AddRange(new object[] {
            "mesa",
            "ventilador",
            "bicicleta",
            "liquidificador",
            "cama_de_casal",
            "conjunto_de_facas",
            "max_steel",
            "televisão",
            "xbox_one",
            "fogão"});
            this.cob_produto.Location = new System.Drawing.Point(221, 137);
            this.cob_produto.Name = "cob_produto";
            this.cob_produto.Size = new System.Drawing.Size(121, 21);
            this.cob_produto.TabIndex = 1;
            this.cob_produto.SelectedIndexChanged += new System.EventHandler(this.cob_produto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // cob_preco
            // 
            this.cob_preco.FormattingEnabled = true;
            this.cob_preco.Items.AddRange(new object[] {
            "200,00",
            "140,00",
            "360,00",
            "80,00",
            "400,00",
            "75,00",
            "50,00",
            "1250,00",
            "5000,00",
            "850,00"});
            this.cob_preco.Location = new System.Drawing.Point(455, 137);
            this.cob_preco.Name = "cob_preco";
            this.cob_preco.Size = new System.Drawing.Size(58, 21);
            this.cob_preco.TabIndex = 3;
            this.cob_preco.SelectedIndexChanged += new System.EventHandler(this.cob_preco_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Casas São Paulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "produto escolhido:";
            // 
            // txt_produto
            // 
            this.txt_produto.Enabled = false;
            this.txt_produto.Location = new System.Drawing.Point(314, 330);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(100, 20);
            this.txt_produto.TabIndex = 6;
            // 
            // txt_preco
            // 
            this.txt_preco.Enabled = false;
            this.txt_preco.Location = new System.Drawing.Point(314, 382);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(100, 20);
            this.txt_preco.TabIndex = 8;
            this.txt_preco.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "preco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "valor total:";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(314, 482);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 12;
            this.txt_total.Text = "0";
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(314, 430);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(100, 20);
            this.txt_quant.TabIndex = 11;
            this.txt_quant.Text = "0";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(200, 547);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 13;
            this.btn_calcular.Text = "calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_carrinho
            // 
            this.btn_carrinho.Enabled = false;
            this.btn_carrinho.Location = new System.Drawing.Point(200, 576);
            this.btn_carrinho.Name = "btn_carrinho";
            this.btn_carrinho.Size = new System.Drawing.Size(122, 23);
            this.btn_carrinho.TabIndex = 14;
            this.btn_carrinho.Text = "adiocionar ao carrinho";
            this.btn_carrinho.UseVisualStyleBackColor = true;
            this.btn_carrinho.Click += new System.EventHandler(this.btn_carrinho_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(1023, 627);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(1023, 598);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 16;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lst_carrinho
            // 
            this.lst_carrinho.FormattingEnabled = true;
            this.lst_carrinho.Location = new System.Drawing.Point(661, 101);
            this.lst_carrinho.Name = "lst_carrinho";
            this.lst_carrinho.Size = new System.Drawing.Size(385, 329);
            this.lst_carrinho.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(797, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Carrinho";
            // 
            // lbl_mens
            // 
            this.lbl_mens.AutoSize = true;
            this.lbl_mens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mens.Location = new System.Drawing.Point(506, 613);
            this.lbl_mens.Name = "lbl_mens";
            this.lbl_mens.Size = new System.Drawing.Size(68, 25);
            this.lbl_mens.TabIndex = 19;
            this.lbl_mens.Text = "mens";
            this.lbl_mens.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(658, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total de produtos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(658, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total de quantidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(658, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total a pagar:";
            // 
            // lbl_totalpagar
            // 
            this.lbl_totalpagar.AutoSize = true;
            this.lbl_totalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalpagar.Location = new System.Drawing.Point(799, 538);
            this.lbl_totalpagar.Name = "lbl_totalpagar";
            this.lbl_totalpagar.Size = new System.Drawing.Size(14, 13);
            this.lbl_totalpagar.TabIndex = 25;
            this.lbl_totalpagar.Text = "0";
            // 
            // lbl_totalquant
            // 
            this.lbl_totalquant.AutoSize = true;
            this.lbl_totalquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalquant.Location = new System.Drawing.Point(799, 499);
            this.lbl_totalquant.Name = "lbl_totalquant";
            this.lbl_totalquant.Size = new System.Drawing.Size(14, 13);
            this.lbl_totalquant.TabIndex = 24;
            this.lbl_totalquant.Text = "0";
            // 
            // lbl_totalprod
            // 
            this.lbl_totalprod.AutoSize = true;
            this.lbl_totalprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalprod.Location = new System.Drawing.Point(799, 458);
            this.lbl_totalprod.Name = "lbl_totalprod";
            this.lbl_totalprod.Size = new System.Drawing.Size(14, 13);
            this.lbl_totalprod.TabIndex = 23;
            this.lbl_totalprod.Text = "0";
            // 
            // lbl_childlist
            // 
            this.lbl_childlist.AutoSize = true;
            this.lbl_childlist.Location = new System.Drawing.Point(494, 265);
            this.lbl_childlist.Name = "lbl_childlist";
            this.lbl_childlist.Size = new System.Drawing.Size(41, 13);
            this.lbl_childlist.TabIndex = 26;
            this.lbl_childlist.Text = "label12";
            this.lbl_childlist.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 662);
            this.Controls.Add(this.lbl_childlist);
            this.Controls.Add(this.lbl_totalpagar);
            this.Controls.Add(this.lbl_totalquant);
            this.Controls.Add(this.lbl_totalprod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_mens);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lst_carrinho);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_carrinho);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_quant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cob_preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cob_produto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cob_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cob_preco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_carrinho;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.ListBox lst_carrinho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_mens;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_totalpagar;
        private System.Windows.Forms.Label lbl_totalquant;
        private System.Windows.Forms.Label lbl_totalprod;
        private System.Windows.Forms.Label lbl_childlist;
    }
}

