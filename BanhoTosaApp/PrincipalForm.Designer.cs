namespace BanhoTosaApp
{
    partial class PrincipalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTelaPets = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTelaClientes = new System.Windows.Forms.Button();
            this.btnTelaTipoPets = new System.Windows.Forms.Button();
            this.btnTelaBanhoTosa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cacau Banho e Tosa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTelaPets
            // 
            this.btnTelaPets.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTelaPets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTelaPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaPets.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaPets.ForeColor = System.Drawing.Color.White;
            this.btnTelaPets.Location = new System.Drawing.Point(169, 13);
            this.btnTelaPets.Name = "btnTelaPets";
            this.btnTelaPets.Size = new System.Drawing.Size(150, 63);
            this.btnTelaPets.TabIndex = 2;
            this.btnTelaPets.Text = "Pets";
            this.btnTelaPets.UseVisualStyleBackColor = false;
            this.btnTelaPets.Click += new System.EventHandler(this.btnTelaPets_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TELAS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTelaClientes);
            this.flowLayoutPanel1.Controls.Add(this.btnTelaPets);
            this.flowLayoutPanel1.Controls.Add(this.btnTelaTipoPets);
            this.flowLayoutPanel1.Controls.Add(this.btnTelaBanhoTosa);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 243);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnTelaClientes
            // 
            this.btnTelaClientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTelaClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTelaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaClientes.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaClientes.ForeColor = System.Drawing.Color.White;
            this.btnTelaClientes.Location = new System.Drawing.Point(13, 13);
            this.btnTelaClientes.Name = "btnTelaClientes";
            this.btnTelaClientes.Size = new System.Drawing.Size(150, 63);
            this.btnTelaClientes.TabIndex = 1;
            this.btnTelaClientes.Text = "Clientes";
            this.btnTelaClientes.UseVisualStyleBackColor = false;
            this.btnTelaClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnTelaTipoPets
            // 
            this.btnTelaTipoPets.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTelaTipoPets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTelaTipoPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaTipoPets.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaTipoPets.ForeColor = System.Drawing.Color.White;
            this.btnTelaTipoPets.Location = new System.Drawing.Point(325, 13);
            this.btnTelaTipoPets.Name = "btnTelaTipoPets";
            this.btnTelaTipoPets.Size = new System.Drawing.Size(150, 63);
            this.btnTelaTipoPets.TabIndex = 3;
            this.btnTelaTipoPets.Text = "Tipo Pets";
            this.btnTelaTipoPets.UseVisualStyleBackColor = false;
            this.btnTelaTipoPets.Click += new System.EventHandler(this.btnTelaTipoPets_Click);
            // 
            // btnTelaBanhoTosa
            // 
            this.btnTelaBanhoTosa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTelaBanhoTosa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTelaBanhoTosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaBanhoTosa.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaBanhoTosa.ForeColor = System.Drawing.Color.White;
            this.btnTelaBanhoTosa.Location = new System.Drawing.Point(481, 13);
            this.btnTelaBanhoTosa.Name = "btnTelaBanhoTosa";
            this.btnTelaBanhoTosa.Size = new System.Drawing.Size(150, 63);
            this.btnTelaBanhoTosa.TabIndex = 4;
            this.btnTelaBanhoTosa.Text = "Banho e Tosa";
            this.btnTelaBanhoTosa.UseVisualStyleBackColor = false;
            this.btnTelaBanhoTosa.Click += new System.EventHandler(this.btnTelaBanhoTosa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Araraquara - SP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BanhoTosaApp.Properties.Resources.estetica;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(516, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 226);
            this.panel1.TabIndex = 3;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banho&Tosa";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTelaPets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTelaClientes;
        private System.Windows.Forms.Button btnTelaTipoPets;
        private System.Windows.Forms.Button btnTelaBanhoTosa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

