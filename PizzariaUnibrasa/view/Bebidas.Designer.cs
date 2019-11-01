namespace PizzariaUnibrasa.view
{
    partial class Bebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bebidas));
            this.txtInicio = new System.Windows.Forms.Label();
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.IbITotal = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.IblCod = new System.Windows.Forms.Label();
            this.picProd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnFechaCli = new System.Windows.Forms.Button();
            this.BtnexcluiCli = new System.Windows.Forms.Button();
            this.BtnAlteraCli = new System.Windows.Forms.Button();
            this.BtnIncluirCli = new System.Windows.Forms.Button();
            this.BtnPesquisarCli = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInicio
            // 
            this.txtInicio.AutoSize = true;
            this.txtInicio.BackColor = System.Drawing.Color.Transparent;
            this.txtInicio.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold);
            this.txtInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInicio.Location = new System.Drawing.Point(668, 20);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(420, 41);
            this.txtInicio.TabIndex = 32;
            this.txtInicio.Text = "CADASTRO de BEBIDAS ";
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.Location = new System.Drawing.Point(986, 140);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(285, 238);
            this.listProdutos.TabIndex = 29;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1121, 441);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 40);
            this.txtTotal.TabIndex = 28;
            // 
            // IbITotal
            // 
            this.IbITotal.AutoSize = true;
            this.IbITotal.BackColor = System.Drawing.Color.Transparent;
            this.IbITotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbITotal.Location = new System.Drawing.Point(979, 444);
            this.IbITotal.Name = "IbITotal";
            this.IbITotal.Size = new System.Drawing.Size(114, 37);
            this.IbITotal.TabIndex = 27;
            this.IbITotal.Text = "Total :\r\n";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(844, 140);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 26);
            this.txtCod.TabIndex = 26;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // IblCod
            // 
            this.IblCod.AutoSize = true;
            this.IblCod.BackColor = System.Drawing.Color.Transparent;
            this.IblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IblCod.Location = new System.Drawing.Point(671, 140);
            this.IblCod.Name = "IblCod";
            this.IblCod.Size = new System.Drawing.Size(157, 20);
            this.IblCod.TabIndex = 25;
            this.IblCod.Text = "Código do produto";
            // 
            // picProd
            // 
            this.picProd.Location = new System.Drawing.Point(674, 179);
            this.picProd.Name = "picProd";
            this.picProd.Size = new System.Drawing.Size(270, 313);
            this.picProd.TabIndex = 24;
            this.picProd.TabStop = false;
            this.picProd.Click += new System.EventHandler(this.picProd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // BtnFechaCli
            // 
            this.BtnFechaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechaCli.ForeColor = System.Drawing.Color.Red;
            this.BtnFechaCli.Location = new System.Drawing.Point(530, 463);
            this.BtnFechaCli.Name = "BtnFechaCli";
            this.BtnFechaCli.Size = new System.Drawing.Size(112, 29);
            this.BtnFechaCli.TabIndex = 76;
            this.BtnFechaCli.Text = "Fechar";
            this.BtnFechaCli.UseVisualStyleBackColor = true;
            // 
            // BtnexcluiCli
            // 
            this.BtnexcluiCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnexcluiCli.Location = new System.Drawing.Point(530, 416);
            this.BtnexcluiCli.Name = "BtnexcluiCli";
            this.BtnexcluiCli.Size = new System.Drawing.Size(112, 29);
            this.BtnexcluiCli.TabIndex = 75;
            this.BtnexcluiCli.Text = "Excluir";
            this.BtnexcluiCli.UseVisualStyleBackColor = true;
            // 
            // BtnAlteraCli
            // 
            this.BtnAlteraCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlteraCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnAlteraCli.Location = new System.Drawing.Point(530, 320);
            this.BtnAlteraCli.Name = "BtnAlteraCli";
            this.BtnAlteraCli.Size = new System.Drawing.Size(112, 29);
            this.BtnAlteraCli.TabIndex = 74;
            this.BtnAlteraCli.Text = "Alterar";
            this.BtnAlteraCli.UseVisualStyleBackColor = true;
            // 
            // BtnIncluirCli
            // 
            this.BtnIncluirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluirCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnIncluirCli.Location = new System.Drawing.Point(530, 265);
            this.BtnIncluirCli.Name = "BtnIncluirCli";
            this.BtnIncluirCli.Size = new System.Drawing.Size(112, 29);
            this.BtnIncluirCli.TabIndex = 73;
            this.BtnIncluirCli.Text = "Incluir";
            this.BtnIncluirCli.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisarCli
            // 
            this.BtnPesquisarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisarCli.ForeColor = System.Drawing.Color.Fuchsia;
            this.BtnPesquisarCli.Location = new System.Drawing.Point(530, 370);
            this.BtnPesquisarCli.Name = "BtnPesquisarCli";
            this.BtnPesquisarCli.Size = new System.Drawing.Size(112, 29);
            this.BtnPesquisarCli.TabIndex = 77;
            this.BtnPesquisarCli.Text = "Pesquisar";
            this.BtnPesquisarCli.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PizzariaUnibrasa.Properties.Resources.logotipo_pizzazriaunuibrasa;
            this.pictureBox2.Location = new System.Drawing.Point(18, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(459, 397);
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzariaUnibrasa.Properties.Resources.pizza3__2__1;
            this.ClientSize = new System.Drawing.Size(1276, 538);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnPesquisarCli);
            this.Controls.Add(this.BtnFechaCli);
            this.Controls.Add(this.BtnexcluiCli);
            this.Controls.Add(this.BtnAlteraCli);
            this.Controls.Add(this.BtnIncluirCli);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.listProdutos);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.IbITotal);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.IblCod);
            this.Controls.Add(this.picProd);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bebidas";
            this.Text = "Bebidas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtInicio;
        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label IbITotal;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label IblCod;
        private System.Windows.Forms.PictureBox picProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnFechaCli;
        private System.Windows.Forms.Button BtnexcluiCli;
        private System.Windows.Forms.Button BtnAlteraCli;
        private System.Windows.Forms.Button BtnIncluirCli;
        private System.Windows.Forms.Button BtnPesquisarCli;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}