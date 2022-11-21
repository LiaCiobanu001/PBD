namespace Proiect_PBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AdaugareAchizitieBT = new System.Windows.Forms.Button();
            this.VizualizareAchizitiiBT = new System.Windows.Forms.Button();
            this.AdaugareClientBT = new System.Windows.Forms.Button();
            this.VizualizareClient_BT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AdaugareAchizitieBT);
            this.panel1.Controls.Add(this.VizualizareAchizitiiBT);
            this.panel1.Controls.Add(this.AdaugareClientBT);
            this.panel1.Controls.Add(this.VizualizareClient_BT);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 435);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Meniu";
            // 
            // AdaugareAchizitieBT
            // 
            this.AdaugareAchizitieBT.Location = new System.Drawing.Point(0, 348);
            this.AdaugareAchizitieBT.Name = "AdaugareAchizitieBT";
            this.AdaugareAchizitieBT.Size = new System.Drawing.Size(262, 87);
            this.AdaugareAchizitieBT.TabIndex = 3;
            this.AdaugareAchizitieBT.Text = "Adaugare Achizitie";
            this.AdaugareAchizitieBT.UseVisualStyleBackColor = true;
            this.AdaugareAchizitieBT.Click += new System.EventHandler(this.AdaugareAchizitieBT_Click);
            // 
            // VizualizareAchizitiiBT
            // 
            this.VizualizareAchizitiiBT.Location = new System.Drawing.Point(0, 262);
            this.VizualizareAchizitiiBT.Name = "VizualizareAchizitiiBT";
            this.VizualizareAchizitiiBT.Size = new System.Drawing.Size(262, 87);
            this.VizualizareAchizitiiBT.TabIndex = 2;
            this.VizualizareAchizitiiBT.Text = "Vizualizare Achzitii";
            this.VizualizareAchizitiiBT.UseVisualStyleBackColor = true;
            this.VizualizareAchizitiiBT.Click += new System.EventHandler(this.VizualizareAchizitiiBT_Click);
            // 
            // AdaugareClientBT
            // 
            this.AdaugareClientBT.Location = new System.Drawing.Point(0, 177);
            this.AdaugareClientBT.Name = "AdaugareClientBT";
            this.AdaugareClientBT.Size = new System.Drawing.Size(262, 87);
            this.AdaugareClientBT.TabIndex = 1;
            this.AdaugareClientBT.Text = "Adaugare Client";
            this.AdaugareClientBT.UseVisualStyleBackColor = true;
            this.AdaugareClientBT.Click += new System.EventHandler(this.AdaugareClientBT_Click);
            // 
            // VizualizareClient_BT
            // 
            this.VizualizareClient_BT.Location = new System.Drawing.Point(0, 93);
            this.VizualizareClient_BT.Name = "VizualizareClient_BT";
            this.VizualizareClient_BT.Size = new System.Drawing.Size(262, 87);
            this.VizualizareClient_BT.TabIndex = 0;
            this.VizualizareClient_BT.Text = "Vizualizare Clienti";
            this.VizualizareClient_BT.UseVisualStyleBackColor = true;
            this.VizualizareClient_BT.Click += new System.EventHandler(this.VizualizareClient_BT_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(262, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 435);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button AdaugareAchizitieBT;
        private Button VizualizareAchizitiiBT;
        private Button AdaugareClientBT;
        private Button VizualizareClient_BT;
        private PictureBox pictureBox1;
    }
}