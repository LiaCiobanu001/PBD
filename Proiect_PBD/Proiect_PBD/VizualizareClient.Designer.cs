namespace Proiect_PBD
{
    partial class Vizualizare_Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdaugareBT = new System.Windows.Forms.Button();
            this.StergeBT = new System.Windows.Forms.Button();
            this.MeniuBT = new System.Windows.Forms.Button();
            this.CautareTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CautareBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vizualizare Clienti";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(799, 271);
            this.dataGridView1.TabIndex = 1;
            // 
            // AdaugareBT
            // 
            this.AdaugareBT.Location = new System.Drawing.Point(47, 474);
            this.AdaugareBT.Name = "AdaugareBT";
            this.AdaugareBT.Size = new System.Drawing.Size(138, 61);
            this.AdaugareBT.TabIndex = 2;
            this.AdaugareBT.Text = "Adaugare Client";
            this.AdaugareBT.UseVisualStyleBackColor = true;
            this.AdaugareBT.Click += new System.EventHandler(this.AdaugareBT_Click);
            // 
            // StergeBT
            // 
            this.StergeBT.Location = new System.Drawing.Point(318, 474);
            this.StergeBT.Name = "StergeBT";
            this.StergeBT.Size = new System.Drawing.Size(138, 61);
            this.StergeBT.TabIndex = 3;
            this.StergeBT.Text = "Sterge Client";
            this.StergeBT.UseVisualStyleBackColor = true;
            this.StergeBT.Click += new System.EventHandler(this.StergeBT_Click);
            // 
            // MeniuBT
            // 
            this.MeniuBT.Location = new System.Drawing.Point(598, 474);
            this.MeniuBT.Name = "MeniuBT";
            this.MeniuBT.Size = new System.Drawing.Size(138, 61);
            this.MeniuBT.TabIndex = 4;
            this.MeniuBT.Text = "Meniu";
            this.MeniuBT.UseVisualStyleBackColor = true;
            this.MeniuBT.Click += new System.EventHandler(this.MeniuBT_Click);
            // 
            // CautareTB
            // 
            this.CautareTB.Location = new System.Drawing.Point(243, 75);
            this.CautareTB.Name = "CautareTB";
            this.CautareTB.Size = new System.Drawing.Size(407, 27);
            this.CautareTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Introduceti numele clientului";
            // 
            // CautareBT
            // 
            this.CautareBT.Location = new System.Drawing.Point(656, 74);
            this.CautareBT.Name = "CautareBT";
            this.CautareBT.Size = new System.Drawing.Size(94, 29);
            this.CautareBT.TabIndex = 7;
            this.CautareBT.Text = "Cautare";
            this.CautareBT.UseVisualStyleBackColor = true;
            this.CautareBT.Click += new System.EventHandler(this.CautareBT_Click);
            // 
            // Vizualizare_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.CautareBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CautareTB);
            this.Controls.Add(this.MeniuBT);
            this.Controls.Add(this.StergeBT);
            this.Controls.Add(this.AdaugareBT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Vizualizare_Client";
            this.Text = "Vizualizare_Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button AdaugareBT;
        private Button StergeBT;
        private Button MeniuBT;
        private TextBox CautareTB;
        private Label label2;
        private Button CautareBT;
    }
}