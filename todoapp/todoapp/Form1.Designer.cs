
namespace todoapp
{
    partial class Form1
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
            this.lblLista = new System.Windows.Forms.Label();
            this.lblInserir = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbTarefa = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.tbPrazo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLista.Location = new System.Drawing.Point(238, 9);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(379, 20);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Lista de afazeres, HOW3 (danilo, João, Paulo)";
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Location = new System.Drawing.Point(56, 44);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(99, 18);
            this.lblInserir.TabIndex = 1;
            this.lblInserir.Text = "inserir tarefa:";
            this.lblInserir.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(56, 71);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 18);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "tipo:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(210, 71);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 18);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "data:";
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Location = new System.Drawing.Point(300, 71);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(55, 18);
            this.lblTarefa.TabIndex = 4;
            this.lblTarefa.Text = "Tarefa:";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(56, 92);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(155, 26);
            this.tbTipo.TabIndex = 6;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(210, 92);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(93, 26);
            this.tbData.TabIndex = 7;
            // 
            // tbTarefa
            // 
            this.tbTarefa.Location = new System.Drawing.Point(300, 92);
            this.tbTarefa.Name = "tbTarefa";
            this.tbTarefa.Size = new System.Drawing.Size(350, 26);
            this.tbTarefa.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionar.Location = new System.Drawing.Point(751, 92);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(83, 27);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.data,
            this.tarefa,
            this.prazo});
            this.dgv.Location = new System.Drawing.Point(18, 188);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(724, 169);
            this.dgv.TabIndex = 11;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 150;
            // 
            // data
            // 
            this.data.HeaderText = "data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 90;
            // 
            // tarefa
            // 
            this.tarefa.HeaderText = "tarefa";
            this.tarefa.Name = "tarefa";
            this.tarefa.ReadOnly = true;
            this.tarefa.Width = 350;
            // 
            // prazo
            // 
            this.prazo.HeaderText = "prazo";
            this.prazo.Name = "prazo";
            this.prazo.ReadOnly = true;
            this.prazo.Width = 90;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditar.Location = new System.Drawing.Point(751, 125);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 27);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletar.Location = new System.Drawing.Point(751, 188);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(83, 27);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Location = new System.Drawing.Point(648, 71);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(51, 18);
            this.lblPrazo.TabIndex = 5;
            this.lblPrazo.Text = "prazo:";
            // 
            // tbPrazo
            // 
            this.tbPrazo.Location = new System.Drawing.Point(648, 92);
            this.tbPrazo.Name = "tbPrazo";
            this.tbPrazo.Size = new System.Drawing.Size(94, 26);
            this.tbPrazo.TabIndex = 9;
            this.tbPrazo.Tag = "prazo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(857, 369);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbPrazo);
            this.Controls.Add(this.tbTarefa);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblInserir);
            this.Controls.Add(this.lblLista);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "todoapp";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbTarefa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazo;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.TextBox tbPrazo;
    }
}

