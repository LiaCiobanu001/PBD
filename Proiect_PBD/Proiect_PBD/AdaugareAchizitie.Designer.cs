namespace Proiect_PBD
{
    partial class AdaugareAchizitie
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
            this.label2 = new System.Windows.Forms.Label();
            this.ProdusTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PretTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SumaTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdaugareBT = new System.Windows.Forms.Button();
            this.MeniuBT = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugare Achizitie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produs";
            // 
            // ProdusTB
            // 
            this.ProdusTB.Location = new System.Drawing.Point(135, 103);
            this.ProdusTB.Name = "ProdusTB";
            this.ProdusTB.Size = new System.Drawing.Size(263, 27);
            this.ProdusTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data achizitie";
            // 
            // PretTB
            // 
            this.PretTB.Location = new System.Drawing.Point(135, 226);
            this.PretTB.Name = "PretTB";
            this.PretTB.Size = new System.Drawing.Size(263, 27);
            this.PretTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pret";
            // 
            // SumaTB
            // 
            this.SumaTB.Location = new System.Drawing.Point(135, 287);
            this.SumaTB.Name = "SumaTB";
            this.SumaTB.Size = new System.Drawing.Size(263, 27);
            this.SumaTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Suma incasata";
            // 
            // AdaugareBT
            // 
            this.AdaugareBT.Location = new System.Drawing.Point(32, 367);
            this.AdaugareBT.Name = "AdaugareBT";
            this.AdaugareBT.Size = new System.Drawing.Size(121, 68);
            this.AdaugareBT.TabIndex = 9;
            this.AdaugareBT.Text = "Adaugare Achizitie";
            this.AdaugareBT.UseVisualStyleBackColor = true;
            this.AdaugareBT.Click += new System.EventHandler(this.AdaugareBT_Click);
            // 
            // MeniuBT
            // 
            this.MeniuBT.Location = new System.Drawing.Point(267, 367);
            this.MeniuBT.Name = "MeniuBT";
            this.MeniuBT.Size = new System.Drawing.Size(121, 68);
            this.MeniuBT.TabIndex = 10;
            this.MeniuBT.Text = "Meniu";
            this.MeniuBT.UseVisualStyleBackColor = true;
            this.MeniuBT.Click += new System.EventHandler(this.MeniuBT_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // AdaugareAchizitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 468);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MeniuBT);
            this.Controls.Add(this.AdaugareBT);
            this.Controls.Add(this.SumaTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PretTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProdusTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugareAchizitie";
            this.Text = "AdaugareAchizitie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ProdusTB;
        private Label label3;
        private TextBox PretTB;
        private Label label4;
        private TextBox SumaTB;
        private Label label5;
        private Button AdaugareBT;
        private Button MeniuBT;
        private DateTimePicker dateTimePicker1;
    }
}