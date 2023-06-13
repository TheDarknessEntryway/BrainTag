namespace Form1
{
    partial class Buscar_Professores
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.txtdtNascimento = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labFechar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(142, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(250, 97);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(62, 22);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(191, 263);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(66, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(20, 263);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(66, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.Location = new System.Drawing.Point(20, 165);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(66, 20);
            this.txtTipoUsuario.TabIndex = 5;
            // 
            // txtdtNascimento
            // 
            this.txtdtNascimento.Location = new System.Drawing.Point(191, 218);
            this.txtdtNascimento.Name = "txtdtNascimento";
            this.txtdtNascimento.Size = new System.Drawing.Size(66, 20);
            this.txtdtNascimento.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(51, 99);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(32, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(20, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(66, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(191, 165);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(66, 20);
            this.txtNome.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "dtNascimento ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cpf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email    ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Senha   ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID";
            // 
            // labFechar
            // 
            this.labFechar.AutoSize = true;
            this.labFechar.BackColor = System.Drawing.Color.White;
            this.labFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFechar.ForeColor = System.Drawing.Color.Red;
            this.labFechar.Location = new System.Drawing.Point(316, 12);
            this.labFechar.Name = "labFechar";
            this.labFechar.Padding = new System.Windows.Forms.Padding(2);
            this.labFechar.Size = new System.Drawing.Size(21, 19);
            this.labFechar.TabIndex = 17;
            this.labFechar.Text = "X";
            this.labFechar.Click += new System.EventHandler(this.labFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labFechar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 81);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alteração do Professor";
            // 
            // Buscar_Professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 305);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtdtNascimento);
            this.Controls.Add(this.txtTipoUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscar_Professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Professores";
            this.Load += new System.EventHandler(this.Buscar_Professores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.TextBox txtdtNascimento;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}