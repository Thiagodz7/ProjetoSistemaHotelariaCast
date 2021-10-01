
namespace ProjetoMédioCastGroup
{
    partial class FrmAgendamento
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
            this.txtNumeroQuarto = new System.Windows.Forms.TextBox();
            this.txtNumeroHospedes = new System.Windows.Forms.TextBox();
            this.rdBasico = new System.Windows.Forms.RadioButton();
            this.rdPremium = new System.Windows.Forms.RadioButton();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCheckIn = new System.Windows.Forms.MaskedTextBox();
            this.mskCheckOut = new System.Windows.Forms.MaskedTextBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txtValorEstadia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAgendamentos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Location = new System.Drawing.Point(527, 70);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(36, 20);
            this.txtNumeroQuarto.TabIndex = 0;
            this.txtNumeroQuarto.Validated += new System.EventHandler(this.txtNumeroQuarto_Validated);
            // 
            // txtNumeroHospedes
            // 
            this.txtNumeroHospedes.Location = new System.Drawing.Point(547, 180);
            this.txtNumeroHospedes.Name = "txtNumeroHospedes";
            this.txtNumeroHospedes.Size = new System.Drawing.Size(39, 20);
            this.txtNumeroHospedes.TabIndex = 3;
            // 
            // rdBasico
            // 
            this.rdBasico.AutoSize = true;
            this.rdBasico.Location = new System.Drawing.Point(333, 319);
            this.rdBasico.Name = "rdBasico";
            this.rdBasico.Size = new System.Drawing.Size(96, 17);
            this.rdBasico.TabIndex = 6;
            this.rdBasico.TabStop = true;
            this.rdBasico.Text = "Serviço Básico";
            this.rdBasico.UseVisualStyleBackColor = true;
            // 
            // rdPremium
            // 
            this.rdPremium.AutoSize = true;
            this.rdPremium.Location = new System.Drawing.Point(468, 319);
            this.rdPremium.Name = "rdPremium";
            this.rdPremium.Size = new System.Drawing.Size(104, 17);
            this.rdPremium.TabIndex = 7;
            this.rdPremium.TabStop = true;
            this.rdPremium.Text = "Serviço Premium";
            this.rdPremium.UseVisualStyleBackColor = true;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(468, 217);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 4;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMenu.Location = new System.Drawing.Point(306, 62);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(215, 28);
            this.lblMenu.TabIndex = 19;
            this.lblMenu.Text = "Número do Quarto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(306, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Check In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(306, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Check Out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(306, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID do Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(306, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Número de Hóspedes";
            // 
            // mskCheckIn
            // 
            this.mskCheckIn.Location = new System.Drawing.Point(441, 106);
            this.mskCheckIn.Mask = "00/00/0000 90:00";
            this.mskCheckIn.Name = "mskCheckIn";
            this.mskCheckIn.Size = new System.Drawing.Size(100, 20);
            this.mskCheckIn.TabIndex = 1;
            this.mskCheckIn.ValidatingType = typeof(System.DateTime);
            // 
            // mskCheckOut
            // 
            this.mskCheckOut.Location = new System.Drawing.Point(441, 142);
            this.mskCheckOut.Mask = "00/00/0000 90:00";
            this.mskCheckOut.Name = "mskCheckOut";
            this.mskCheckOut.Size = new System.Drawing.Size(100, 20);
            this.mskCheckOut.TabIndex = 2;
            this.mskCheckOut.ValidatingType = typeof(System.DateTime);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(325, 356);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(261, 37);
            this.btnAgendar.TabIndex = 8;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txtValorEstadia
            // 
            this.txtValorEstadia.Location = new System.Drawing.Point(499, 274);
            this.txtValorEstadia.Name = "txtValorEstadia";
            this.txtValorEstadia.Size = new System.Drawing.Size(87, 20);
            this.txtValorEstadia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(306, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor da Estadia";
            // 
            // dgvAgendamentos
            // 
            this.dgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamentos.Location = new System.Drawing.Point(0, 98);
            this.dgvAgendamentos.Name = "dgvAgendamentos";
            this.dgvAgendamentos.Size = new System.Drawing.Size(300, 220);
            this.dgvAgendamentos.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoMédioCastGroup.Properties.Resources.Agendamenotp;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(633, 405);
            this.Controls.Add(this.dgvAgendamentos);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mskCheckOut);
            this.Controls.Add(this.mskCheckIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.rdPremium);
            this.Controls.Add(this.txtValorEstadia);
            this.Controls.Add(this.rdBasico);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtNumeroHospedes);
            this.Controls.Add(this.txtNumeroQuarto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Agendamentos";
            this.Load += new System.EventHandler(this.FrmAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroQuarto;
        private System.Windows.Forms.TextBox txtNumeroHospedes;
        private System.Windows.Forms.RadioButton rdBasico;
        private System.Windows.Forms.RadioButton rdPremium;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCheckIn;
        private System.Windows.Forms.MaskedTextBox mskCheckOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.TextBox txtValorEstadia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAgendamentos;
    }
}