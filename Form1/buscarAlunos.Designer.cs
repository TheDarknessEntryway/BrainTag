namespace Form1
{
    partial class buscarAlunos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.gridBuscarAlunos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirAlunos = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscarAlunos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExcluirAlunos);
            this.panel2.Controls.Add(this.btnBuscarId);
            this.panel2.Controls.Add(this.txtNomeAluno);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 64);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mulish", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Alunos";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(337, 22);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(162, 20);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Font = new System.Drawing.Font("Mulish", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarId.Location = new System.Drawing.Point(505, 20);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarId.TabIndex = 2;
            this.btnBuscarId.Text = "Buscar ID";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridBuscarAlunos
            // 
            this.gridBuscarAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuscarAlunos.Location = new System.Drawing.Point(9, 3);
            this.gridBuscarAlunos.Name = "gridBuscarAlunos";
            this.gridBuscarAlunos.Size = new System.Drawing.Size(737, 258);
            this.gridBuscarAlunos.TabIndex = 1;
            this.gridBuscarAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBuscarAlunos_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridBuscarAlunos);
            this.panel1.Location = new System.Drawing.Point(3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 271);
            this.panel1.TabIndex = 0;
            // 
            // btnExcluirAlunos
            // 
            this.btnExcluirAlunos.Font = new System.Drawing.Font("Mulish", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAlunos.Location = new System.Drawing.Point(612, 20);
            this.btnExcluirAlunos.Name = "btnExcluirAlunos";
            this.btnExcluirAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAlunos.TabIndex = 3;
            this.btnExcluirAlunos.Text = "Excluir";
            this.btnExcluirAlunos.UseVisualStyleBackColor = true;
            this.btnExcluirAlunos.Click += new System.EventHandler(this.btnExcluirAlunos_Click);
            // 
            // buscarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "buscarAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buscarAlunos";
            this.Load += new System.EventHandler(this.buscarAlunos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscarAlunos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Button btnExcluirAlunos;
        private System.Windows.Forms.DataGridView gridBuscarAlunos;
        private System.Windows.Forms.Panel panel1;
    }
}