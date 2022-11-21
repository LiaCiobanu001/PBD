namespace Proiect_PBD
{
    partial class VizualizareAchizitii
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
            this.CautareBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CautareTB = new System.Windows.Forms.TextBox();
            this.MeniuBT = new System.Windows.Forms.Button();
            this.StergeBT = new System.Windows.Forms.Button();
            this.AdaugareBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CautareBT
            // 
            this.CautareBT.Location = new System.Drawing.Point(655, 74);
            this.CautareBT.Name = "CautareBT";
            this.CautareBT.Size = new System.Drawing.Size(94, 29);
            this.CautareBT.TabIndex = 15;
            this.CautareBT.Text = "Cautare";
            this.CautareBT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Introduceti produs";
            // 
            // CautareTB
            // 
            this.CautareTB.Location = new System.Drawing.Point(179, 75);
            this.CautareTB.Name = "CautareTB";
            this.CautareTB.Size = new System.Drawing.Size(470, 27);
            this.CautareTB.TabIndex = 13;
            // 
            // MeniuBT
            // 
            this.MeniuBT.Location = new System.Drawing.Point(597, 474);
            this.MeniuBT.Name = "MeniuBT";
            this.MeniuBT.Size = new System.Drawing.Size(138, 61);
            this.MeniuBT.TabIndex = 12;
            this.MeniuBT.Text = "Meniu";
            this.MeniuBT.UseVisualStyleBackColor = true;
            this.MeniuBT.Click += new System.EventHandler(this.MeniuBT_Click);
            // 
            // StergeBT
            // 
            this.StergeBT.Location = new System.Drawing.Point(317, 474);
            this.StergeBT.Name = "StergeBT";
            this.StergeBT.Size = new System.Drawing.Size(138, 61);
            this.StergeBT.TabIndex = 11;
            this.StergeBT.Text = "Sterge Achizite";
            this.StergeBT.UseVisualStyleBackColor = true;
            this.StergeBT.Click += new System.EventHandler(this.StergeBT_Click);
            // 
            // AdaugareBT
            // 
            this.AdaugareBT.Location = new System.Drawing.Point(46, 474);
            this.AdaugareBT.Name = "AdaugareBT";
            this.AdaugareBT.Size = new System.Drawing.Size(138, 61);
            this.AdaugareBT.TabIndex = 10;
            this.AdaugareBT.Text = "Adaugare achizitie";
            this.AdaugareBT.UseVisualStyleBackColor = true;
            this.AdaugareBT.Click += new System.EventHandler(this.AdaugareBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(799, 271);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vizualizare Achizitii";
            // 
            // VizualizareAchizitii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.CautareBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CautareTB);
            this.Controls.Add(this.MeniuBT);
            this.Controls.Add(this.StergeBT);
            this.Controls.Add(this.AdaugareBT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "VizualizareAchizitii";
            this.Text = "VizualizareAchizitii";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CautareBT;
        private Label label2;
        private TextBox CautareTB;
        private Button MeniuBT;
        private Button StergeBT;
        private Button AdaugareBT;
        private DataGridView dataGridView1;
        private Label label1;
    }
}