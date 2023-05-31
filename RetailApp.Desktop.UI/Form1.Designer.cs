namespace RetailApp.Desktop.UI
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.TitleNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberNFe = new System.Windows.Forms.Label();
            this.TitleChave = new System.Windows.Forms.TextBox();
            this.Chave = new System.Windows.Forms.Label();
            this.TitleDate = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.id,
            this.descricao,
            this.qtde,
            this.unitario,
            this.valor});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 232);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // item
            // 
            this.item.Text = "Item";
            this.item.Width = 40;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 61;
            // 
            // descricao
            // 
            this.descricao.Text = "descrição do produto";
            this.descricao.Width = 270;
            // 
            // qtde
            // 
            this.qtde.Text = "Quantidade";
            this.qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qtde.Width = 100;
            // 
            // unitario
            // 
            this.unitario.Text = "unitario";
            this.unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitario.Width = 100;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor.Width = 120;
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Location = new System.Drawing.Point(347, 415);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 2;
            this.Button.Text = "Abrir";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Title
            // 
            this.Title.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(181, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(428, 55);
            this.Title.TabIndex = 3;
            this.Title.Text = "Importação de XML";
            // 
            // TitleNumber
            // 
            this.TitleNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.TitleNumber.BackColor = System.Drawing.SystemColors.Control;
            this.TitleNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleNumber.Location = new System.Drawing.Point(12, 73);
            this.TitleNumber.Name = "TitleNumber";
            this.TitleNumber.Size = new System.Drawing.Size(94, 19);
            this.TitleNumber.TabIndex = 4;
            this.TitleNumber.Text = "Numero NFe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // NumberNFe
            // 
            this.NumberNFe.BackColor = System.Drawing.Color.Transparent;
            this.NumberNFe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberNFe.Cursor = System.Windows.Forms.Cursors.Default;
            this.NumberNFe.Location = new System.Drawing.Point(112, 73);
            this.NumberNFe.Name = "NumberNFe";
            this.NumberNFe.Size = new System.Drawing.Size(96, 19);
            this.NumberNFe.TabIndex = 6;
            this.NumberNFe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumberNFe.Click += new System.EventHandler(this.NumberNFe_Click);
            // 
            // TitleChave
            // 
            this.TitleChave.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.TitleChave.BackColor = System.Drawing.SystemColors.Control;
            this.TitleChave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleChave.Location = new System.Drawing.Point(12, 98);
            this.TitleChave.Name = "TitleChave";
            this.TitleChave.Size = new System.Drawing.Size(127, 19);
            this.TitleChave.TabIndex = 7;
            this.TitleChave.Text = "Chave de acesso";
            this.TitleChave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Chave
            // 
            this.Chave.BackColor = System.Drawing.Color.Transparent;
            this.Chave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chave.Cursor = System.Windows.Forms.Cursors.Default;
            this.Chave.Location = new System.Drawing.Point(145, 98);
            this.Chave.Name = "Chave";
            this.Chave.Size = new System.Drawing.Size(630, 19);
            this.Chave.TabIndex = 8;
            this.Chave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Chave.Click += new System.EventHandler(this.C_Click);
            // 
            // TitleDate
            // 
            this.TitleDate.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.TitleDate.BackColor = System.Drawing.SystemColors.Control;
            this.TitleDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleDate.Location = new System.Drawing.Point(456, 67);
            this.TitleDate.Name = "TitleDate";
            this.TitleDate.Size = new System.Drawing.Size(104, 19);
            this.TitleDate.TabIndex = 9;
            this.TitleDate.Text = "Data Emissão";
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date.Cursor = System.Windows.Forms.Cursors.Default;
            this.Date.Location = new System.Drawing.Point(566, 67);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(96, 19);
            this.Date.TabIndex = 10;
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.TitleDate);
            this.Controls.Add(this.Chave);
            this.Controls.Add(this.TitleChave);
            this.Controls.Add(this.NumberNFe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleNumber);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox TitleNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberNFe;
        private System.Windows.Forms.TextBox TitleChave;
        private System.Windows.Forms.Label Chave;
        private System.Windows.Forms.TextBox TitleDate;
        private System.Windows.Forms.Label Date;
    }
}

