namespace PraktikumADO
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnDosen = new System.Windows.Forms.Button();
            this.btnUpdateMK = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LightPink;
            this.btnConnect.Location = new System.Drawing.Point(81, 380);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(143, 39);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.BackColor = System.Drawing.Color.LightPink;
            this.btnHitungMhs.Location = new System.Drawing.Point(271, 380);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(143, 39);
            this.btnHitungMhs.TabIndex = 1;
            this.btnHitungMhs.Text = "Hitung Mahasiswa";
            this.btnHitungMhs.UseVisualStyleBackColor = false;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.BackColor = System.Drawing.Color.LightPink;
            this.btnHitungMK.Location = new System.Drawing.Point(443, 380);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(143, 39);
            this.btnHitungMK.TabIndex = 2;
            this.btnHitungMK.Text = "Hitung Matakuliah";
            this.btnHitungMK.UseVisualStyleBackColor = false;
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightPink;
            this.btnUpdate.Location = new System.Drawing.Point(607, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 39);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HASIL";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(257, 212);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(368, 20);
            this.txtHasil.TabIndex = 5;
            // 
            // btnDosen
            // 
            this.btnDosen.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDosen.Location = new System.Drawing.Point(645, 132);
            this.btnDosen.Name = "btnDosen";
            this.btnDosen.Size = new System.Drawing.Size(96, 35);
            this.btnDosen.TabIndex = 6;
            this.btnDosen.Text = "Hitung Dosen";
            this.btnDosen.UseVisualStyleBackColor = false;
            this.btnDosen.Click += new System.EventHandler(this.btnDosen_Click);
            // 
            // btnUpdateMK
            // 
            this.btnUpdateMK.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateMK.Location = new System.Drawing.Point(645, 186);
            this.btnUpdateMK.Name = "btnUpdateMK";
            this.btnUpdateMK.Size = new System.Drawing.Size(96, 35);
            this.btnUpdateMK.TabIndex = 7;
            this.btnUpdateMK.Text = "UpdateMK";
            this.btnUpdateMK.UseVisualStyleBackColor = false;
            this.btnUpdateMK.Click += new System.EventHandler(this.btnUpdateMK_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnInsert.Location = new System.Drawing.Point(645, 241);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 33);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdateMK);
            this.Controls.Add(this.btnDosen);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnDosen;
        private System.Windows.Forms.Button btnUpdateMK;
        private System.Windows.Forms.Button btnInsert;
    }
}

