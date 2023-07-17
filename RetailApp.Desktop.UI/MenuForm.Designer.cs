using RetailApp.Utility;

namespace RetailApp.Desktop.UI
{
    partial class Menu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.item = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.descricao = new System.Windows.Forms.ColumnHeader();
            this.qtde = new System.Windows.Forms.ColumnHeader();
            this.unitario = new System.Windows.Forms.ColumnHeader();
            this.Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.regimeTrib = new System.Windows.Forms.ComboBox();
            this.Recalc = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Frete = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Seguro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Despesa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.id,
            this.descricao,
            this.qtde,
            this.unitario});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(13, 265);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1033, 398);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // item
            // 
            this.item.Text = "Item";
            this.item.Width = 45;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 170;
            // 
            // descricao
            // 
            this.descricao.Text = "descrição do produto";
            this.descricao.Width = 440;
            // 
            // qtde
            // 
            this.qtde.Text = "Quantidade";
            this.qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qtde.Width = 140;
            // 
            // unitario
            // 
            this.unitario.Text = "Valor de custo produto";
            this.unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitario.Width = 240;
            // 
            // Button
            // 
            this.Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button.Location = new System.Drawing.Point(417, 14);
            this.Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(250, 76);
            this.Button.TabIndex = 1;
            this.Button.Text = "Importar XML";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(13, 162);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 28);
            this.textBox1.TabIndex = 33;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Regime Tributario";
            // 
            // regimeTrib
            // 
            this.regimeTrib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regimeTrib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regimeTrib.FormattingEnabled = true;
            this.regimeTrib.Items.AddRange(new object[] {
            "1. Simples Nacional",
            "2. Simples Nacional - Excesso de sublimite da receita bruta",
            "3. Regime Normal - Lucro presumido",
            "4. Regime Normal - Lucro Real"});
            this.regimeTrib.Location = new System.Drawing.Point(195, 162);
            this.regimeTrib.Name = "regimeTrib";
            this.regimeTrib.Size = new System.Drawing.Size(370, 28);
            this.regimeTrib.Sorted = true;
            this.regimeTrib.TabIndex = 5;
            // 
            // Recalc
            // 
            this.Recalc.Enabled = false;
            this.Recalc.Location = new System.Drawing.Point(594, 160);
            this.Recalc.Name = "Recalc";
            this.Recalc.Size = new System.Drawing.Size(103, 30);
            this.Recalc.TabIndex = 6;
            this.Recalc.Text = "Recalcular";
            this.Recalc.UseVisualStyleBackColor = true;
            this.Recalc.Click += new System.EventHandler(this.Recalc_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(195, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(702, 32);
            this.textBox2.TabIndex = 33;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Clique no produto abaixo para mais detalhes";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frete
            // 
            this.Frete.Enabled = false;
            this.Frete.Location = new System.Drawing.Point(82, 104);
            this.Frete.Name = "Frete";
            this.Frete.Size = new System.Drawing.Size(125, 27);
            this.Frete.TabIndex = 2;
            this.Frete.Text = "0.00";
            this.Frete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerico_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(16, 104);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(59, 28);
            this.textBox4.TabIndex = 16;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Frete";
            // 
            // textBox5
            // 
            this.textBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(718, 104);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(196, 28);
            this.textBox5.TabIndex = 19;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Despesas acessorias";
            // 
            // Seguro
            // 
            this.Seguro.Enabled = false;
            this.Seguro.Location = new System.Drawing.Point(495, 104);
            this.Seguro.Name = "Seguro";
            this.Seguro.Size = new System.Drawing.Size(125, 27);
            this.Seguro.TabIndex = 3;
            this.Seguro.Text = "0.00";
            this.Seguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerico_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(410, 104);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(78, 28);
            this.textBox7.TabIndex = 20;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Seguro";
            // 
            // Despesa
            // 
            this.Despesa.Enabled = false;
            this.Despesa.Location = new System.Drawing.Point(921, 103);
            this.Despesa.Name = "Despesa";
            this.Despesa.Size = new System.Drawing.Size(125, 27);
            this.Despesa.TabIndex = 4;
            this.Despesa.Text = "0.00";
            this.Despesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerico_KeyPress);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.Despesa);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Seguro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Frete);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Recalc);
            this.Controls.Add(this.regimeTrib);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader qtde;
        private System.Windows.Forms.ColumnHeader unitario;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label label1;
        private TextBox textBox1;
        private ComboBox regimeTrib;
        private Button Recalc;
        private TextBox textBox2;
        private TextBox Frete;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox Seguro;
        private Label label2;
        private TextBox textBox7;
        private TextBox Despesa;
    }
}

