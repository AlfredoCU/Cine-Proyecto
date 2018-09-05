namespace Cine.Capa_de_Presentación
{
    partial class VerCartelera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCartelera));
            this.dgvListaCartelera = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbMartes2x1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCartelera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMartes2x1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCartelera
            // 
            this.dgvListaCartelera.AllowUserToAddRows = false;
            this.dgvListaCartelera.AllowUserToDeleteRows = false;
            this.dgvListaCartelera.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListaCartelera.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaCartelera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCartelera.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvListaCartelera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCartelera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaCartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCartelera.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCartelera.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaCartelera.Location = new System.Drawing.Point(13, 76);
            this.dgvListaCartelera.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaCartelera.MultiSelect = false;
            this.dgvListaCartelera.Name = "dgvListaCartelera";
            this.dgvListaCartelera.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListaCartelera.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaCartelera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCartelera.ShowEditingIcon = false;
            this.dgvListaCartelera.Size = new System.Drawing.Size(462, 320);
            this.dgvListaCartelera.TabIndex = 83;
            this.dgvListaCartelera.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvListaCartelera_ColumnAdded);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(626, 76);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 36);
            this.btnSalir.TabIndex = 84;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbMartes2x1
            // 
            this.pbMartes2x1.Image = ((System.Drawing.Image)(resources.GetObject("pbMartes2x1.Image")));
            this.pbMartes2x1.Location = new System.Drawing.Point(513, 140);
            this.pbMartes2x1.Name = "pbMartes2x1";
            this.pbMartes2x1.Size = new System.Drawing.Size(251, 256);
            this.pbMartes2x1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMartes2x1.TabIndex = 85;
            this.pbMartes2x1.TabStop = false;
            // 
            // VerCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 409);
            this.Controls.Add(this.pbMartes2x1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvListaCartelera);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VerCartelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Cartelera";
            this.Load += new System.EventHandler(this.VerCartelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCartelera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMartes2x1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCartelera;
        internal System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbMartes2x1;
    }
}