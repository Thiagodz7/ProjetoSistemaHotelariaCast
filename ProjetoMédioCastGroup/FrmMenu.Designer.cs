
namespace ProjetoMédioCastGroup
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarServiços = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAlterarFuncionário = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LawnGreen;
            this.panel2.Controls.Add(this.btnModificarServiços);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnAlterarFuncionário);
            this.panel2.Controls.Add(this.btnCadastrarFuncionario);
            this.panel2.Controls.Add(this.btnCadastroCliente);
            this.panel2.Controls.Add(this.btnInicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 414);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 40);
            this.panel1.TabIndex = 2;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMenu.Location = new System.Drawing.Point(35, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(70, 17);
            this.lblMenu.TabIndex = 18;
            this.lblMenu.Text = "Hotelaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(802, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoMédioCastGroup.Properties.Resources.hotel;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnModificarServiços
            // 
            this.btnModificarServiços.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarServiços.BackgroundImage = global::ProjetoMédioCastGroup.Properties.Resources.agenda;
            this.btnModificarServiços.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarServiços.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarServiços.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnModificarServiços.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnModificarServiços.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnModificarServiços.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnModificarServiços.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarServiços.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificarServiços.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnModificarServiços.Location = new System.Drawing.Point(-128, 73);
            this.btnModificarServiços.Name = "btnModificarServiços";
            this.btnModificarServiços.Size = new System.Drawing.Size(325, 61);
            this.btnModificarServiços.TabIndex = 0;
            this.btnModificarServiços.Text = "                           Agendamento";
            this.btnModificarServiços.UseVisualStyleBackColor = false;
            this.btnModificarServiços.Click += new System.EventHandler(this.btnModificarServiços_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImage = global::ProjetoMédioCastGroup.Properties.Resources.troca;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAlterar.Location = new System.Drawing.Point(-128, 207);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(325, 61);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "                       Alterar \r\n                             Clientes       ";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnAlterarFuncionário
            // 
            this.btnAlterarFuncionário.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarFuncionário.BackgroundImage = global::ProjetoMédioCastGroup.Properties.Resources.troca;
            this.btnAlterarFuncionário.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterarFuncionário.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarFuncionário.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnAlterarFuncionário.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAlterarFuncionário.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAlterarFuncionário.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnAlterarFuncionário.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarFuncionário.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAlterarFuncionário.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAlterarFuncionário.Location = new System.Drawing.Point(-113, 346);
            this.btnAlterarFuncionário.Name = "btnAlterarFuncionário";
            this.btnAlterarFuncionário.Size = new System.Drawing.Size(310, 61);
            this.btnAlterarFuncionário.TabIndex = 0;
            this.btnAlterarFuncionário.Text = "                          Alterar Sócios              ";
            this.btnAlterarFuncionário.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarFuncionario.BackgroundImage = global::ProjetoMédioCastGroup.Properties.Resources.cadastro;
            this.btnCadastrarFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnCadastrarFuncionario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCadastrarFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(-113, 279);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(310, 61);
            this.btnCadastrarFuncionario.TabIndex = 0;
            this.btnCadastrarFuncionario.Text = "                         Cadastrar Sócios";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroCliente.BackgroundImage = global::ProjetoMédioCastGroup.Properties.Resources.cadastro;
            this.btnCadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroCliente.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnCadastroCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCadastroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCadastroCliente.Location = new System.Drawing.Point(-113, 140);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(310, 61);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.Text = "                       Cadastrar \r\n                        Clientes  ";
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImage = global::ProjetoMédioCastGroup.Properties.Resources.Inicio;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnInicio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnInicio.Location = new System.Drawing.Point(-128, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(325, 61);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "                       Início";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModificarServiços;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAlterarFuncionário;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}