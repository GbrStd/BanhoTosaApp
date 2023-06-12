namespace BanhoTosaApp
{
    partial class BanhoTosaForm
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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoltarPrincipal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBanhoTosa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanhoTosa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.AutoSize = true;
            this.btnDeletar.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(748, 246);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(122, 34);
            this.btnDeletar.TabIndex = 38;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AutoSize = true;
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(140, 246);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(122, 34);
            this.btnAtualizar.TabIndex = 37;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.AutoSize = true;
            this.btnAgendar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(12, 246);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(122, 34);
            this.btnAgendar.TabIndex = 36;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(190, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(519, 38);
            this.label8.TabIndex = 35;
            this.label8.Text = "AGENDAMENTO - BANHO E TOSA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltarPrincipal
            // 
            this.btnVoltarPrincipal.AutoSize = true;
            this.btnVoltarPrincipal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVoltarPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVoltarPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarPrincipal.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnVoltarPrincipal.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarPrincipal.Name = "btnVoltarPrincipal";
            this.btnVoltarPrincipal.Size = new System.Drawing.Size(102, 38);
            this.btnVoltarPrincipal.TabIndex = 34;
            this.btnVoltarPrincipal.Text = "<- VOLTAR";
            this.btnVoltarPrincipal.UseVisualStyleBackColor = false;
            this.btnVoltarPrincipal.Click += new System.EventHandler(this.btnVoltarPrincipal_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BanhoTosaApp.Properties.Resources.banhotosa;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(300, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 293);
            this.panel1.TabIndex = 41;
            // 
            // dgvBanhoTosa
            // 
            this.dgvBanhoTosa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBanhoTosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanhoTosa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBanhoTosa.Location = new System.Drawing.Point(12, 286);
            this.dgvBanhoTosa.Name = "dgvBanhoTosa";
            this.dgvBanhoTosa.ReadOnly = true;
            this.dgvBanhoTosa.RowHeadersWidth = 51;
            this.dgvBanhoTosa.RowTemplate.Height = 24;
            this.dgvBanhoTosa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanhoTosa.Size = new System.Drawing.Size(858, 307);
            this.dgvBanhoTosa.TabIndex = 42;
            this.dgvBanhoTosa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanhoTosa_CellContentDoubleClick);
            // 
            // BanhoTosaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 605);
            this.Controls.Add(this.dgvBanhoTosa);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVoltarPrincipal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BanhoTosaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banho e Tosa";
            this.Load += new System.EventHandler(this.BanhoTosaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanhoTosa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltarPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBanhoTosa;
    }
}