namespace BuscaNomePorCPF
{
    partial class MainForm
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSituacaoCPF = new System.Windows.Forms.Label();
            this.lblSituacaoCPFEncontrado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 38);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(102, 13);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "Digite o Nome/CPF:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(471, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(15, 54);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(427, 20);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyUp);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome encontrado:";
            // 
            // lblNomeResultado
            // 
            this.lblNomeResultado.AutoSize = true;
            this.lblNomeResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeResultado.Location = new System.Drawing.Point(12, 123);
            this.lblNomeResultado.Name = "lblNomeResultado";
            this.lblNomeResultado.Size = new System.Drawing.Size(24, 20);
            this.lblNomeResultado.TabIndex = 4;
            this.lblNomeResultado.Text = "...";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Control;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResultado.Location = new System.Drawing.Point(16, 225);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultado.Size = new System.Drawing.Size(530, 176);
            this.txtResultado.TabIndex = 5;
            // 
            // lblSituacaoCPF
            // 
            this.lblSituacaoCPF.AutoSize = true;
            this.lblSituacaoCPF.Location = new System.Drawing.Point(13, 157);
            this.lblSituacaoCPF.Name = "lblSituacaoCPF";
            this.lblSituacaoCPF.Size = new System.Drawing.Size(90, 13);
            this.lblSituacaoCPF.TabIndex = 6;
            this.lblSituacaoCPF.Text = "Situação do CPF:";
            // 
            // lblSituacaoCPFEncontrado
            // 
            this.lblSituacaoCPFEncontrado.AutoSize = true;
            this.lblSituacaoCPFEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacaoCPFEncontrado.Location = new System.Drawing.Point(13, 180);
            this.lblSituacaoCPFEncontrado.Name = "lblSituacaoCPFEncontrado";
            this.lblSituacaoCPFEncontrado.Size = new System.Drawing.Size(24, 20);
            this.lblSituacaoCPFEncontrado.TabIndex = 7;
            this.lblSituacaoCPFEncontrado.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 413);
            this.Controls.Add(this.lblSituacaoCPFEncontrado);
            this.Controls.Add(this.lblSituacaoCPF);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblNomeResultado);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Nome por CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSituacaoCPF;
        private System.Windows.Forms.Label lblSituacaoCPFEncontrado;
    }
}

