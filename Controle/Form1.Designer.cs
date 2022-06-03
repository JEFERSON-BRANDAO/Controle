namespace Controle
{
    partial class FormEtrega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.dataGridViewFunc = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCesta = new System.Windows.Forms.DataGridView();
            this.status_cesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHora_cesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFrio = new System.Windows.Forms.DataGridView();
            this.status_frio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHora_frio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbFrio = new System.Windows.Forms.RadioButton();
            this.rdbCesta = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbAviso = new System.Windows.Forms.Label();
            this.lbRodape = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(16, 40);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 20);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatricula_KeyDown);
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lbMatricula.Location = new System.Drawing.Point(13, 24);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(52, 13);
            this.lbMatricula.TabIndex = 1;
            this.lbMatricula.Text = "Matrícula";
            // 
            // dataGridViewFunc
            // 
            this.dataGridViewFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFunc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewFunc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nome,
            this.c_custo});
            this.dataGridViewFunc.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewFunc.Location = new System.Drawing.Point(16, 111);
            this.dataGridViewFunc.Name = "dataGridViewFunc";
            this.dataGridViewFunc.ReadOnly = true;
            this.dataGridViewFunc.RowHeadersVisible = false;
            this.dataGridViewFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFunc.Size = new System.Drawing.Size(627, 75);
            this.dataGridViewFunc.TabIndex = 2;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matrícula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // c_custo
            // 
            this.c_custo.HeaderText = "C. Custo";
            this.c_custo.Name = "c_custo";
            this.c_custo.ReadOnly = true;
            // 
            // dataGridViewCesta
            // 
            this.dataGridViewCesta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCesta.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCesta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCesta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCesta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCesta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status_cesta,
            this.dataHora_cesta});
            this.dataGridViewCesta.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewCesta.Location = new System.Drawing.Point(16, 30);
            this.dataGridViewCesta.Name = "dataGridViewCesta";
            this.dataGridViewCesta.ReadOnly = true;
            this.dataGridViewCesta.RowHeadersVisible = false;
            this.dataGridViewCesta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCesta.Size = new System.Drawing.Size(272, 80);
            this.dataGridViewCesta.TabIndex = 3;
            // 
            // status_cesta
            // 
            this.status_cesta.FillWeight = 50F;
            this.status_cesta.HeaderText = "Entregue";
            this.status_cesta.Name = "status_cesta";
            this.status_cesta.ReadOnly = true;
            // 
            // dataHora_cesta
            // 
            this.dataHora_cesta.HeaderText = "Data/Hora";
            this.dataHora_cesta.Name = "dataHora_cesta";
            this.dataHora_cesta.ReadOnly = true;
            // 
            // dataGridViewFrio
            // 
            this.dataGridViewFrio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFrio.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFrio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFrio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewFrio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFrio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status_frio,
            this.dataHora_frio});
            this.dataGridViewFrio.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewFrio.Location = new System.Drawing.Point(16, 30);
            this.dataGridViewFrio.Name = "dataGridViewFrio";
            this.dataGridViewFrio.ReadOnly = true;
            this.dataGridViewFrio.RowHeadersVisible = false;
            this.dataGridViewFrio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFrio.Size = new System.Drawing.Size(272, 80);
            this.dataGridViewFrio.TabIndex = 4;
            // 
            // status_frio
            // 
            this.status_frio.FillWeight = 50F;
            this.status_frio.HeaderText = "Entregue";
            this.status_frio.Name = "status_frio";
            this.status_frio.ReadOnly = true;
            // 
            // dataHora_frio
            // 
            this.dataHora_frio.HeaderText = "Data/Hora";
            this.dataHora_frio.Name = "dataHora_frio";
            this.dataHora_frio.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.BackgroundImage = global::Controle.Properties.Resources.natal2;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dataGridViewFunc);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.lbMatricula);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 206);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FUNCIONÁRIO";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rdbFrio);
            this.groupBox4.Controls.Add(this.rdbCesta);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(351, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 81);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ENTREGA";
            // 
            // rdbFrio
            // 
            this.rdbFrio.AutoSize = true;
            this.rdbFrio.Location = new System.Drawing.Point(105, 30);
            this.rdbFrio.Name = "rdbFrio";
            this.rdbFrio.Size = new System.Drawing.Size(42, 17);
            this.rdbFrio.TabIndex = 1;
            this.rdbFrio.TabStop = true;
            this.rdbFrio.Text = "Frio";
            this.rdbFrio.UseVisualStyleBackColor = true;
            // 
            // rdbCesta
            // 
            this.rdbCesta.AutoSize = true;
            this.rdbCesta.Location = new System.Drawing.Point(16, 30);
            this.rdbCesta.Name = "rdbCesta";
            this.rdbCesta.Size = new System.Drawing.Size(52, 17);
            this.rdbCesta.TabIndex = 0;
            this.rdbCesta.TabStop = true;
            this.rdbCesta.Text = "Cesta";
            this.rdbCesta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridViewCesta);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 136);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CESTA";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridViewFrio);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 136);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FRIO";
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.BackColor = System.Drawing.Color.Transparent;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Red;
            this.lbAviso.Location = new System.Drawing.Point(329, 365);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(148, 25);
            this.lbAviso.TabIndex = 8;
            this.lbAviso.Text = "mensagem erro";
            this.lbAviso.Visible = false;
            // 
            // lbRodape
            // 
            this.lbRodape.AutoSize = true;
            this.lbRodape.BackColor = System.Drawing.Color.Transparent;
            this.lbRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRodape.ForeColor = System.Drawing.Color.White;
            this.lbRodape.Location = new System.Drawing.Point(8, 649);
            this.lbRodape.Name = "lbRodape";
            this.lbRodape.Size = new System.Drawing.Size(70, 24);
            this.lbRodape.TabIndex = 9;
            this.lbRodape.Text = "rodapé";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Controle.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.Transparent;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.Transparent;
            this.lbData.Location = new System.Drawing.Point(314, 11);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(77, 20);
            this.lbData.TabIndex = 11;
            this.lbData.Text = "data hora";
            // 
            // FormEtrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Controle.Properties.Resources.natal2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1351, 736);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbRodape);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormEtrega";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Entrega  CESTAS/FRIOS   V1.0.0.3";
            this.Load += new System.EventHandler(this.FormEtrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.DataGridView dataGridViewFunc;
        private System.Windows.Forms.DataGridView dataGridViewCesta;
        private System.Windows.Forms.DataGridView dataGridViewFrio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbFrio;
        private System.Windows.Forms.RadioButton rdbCesta;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Label lbRodape;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_cesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHora_cesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_frio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHora_frio;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_custo;
    }
}

