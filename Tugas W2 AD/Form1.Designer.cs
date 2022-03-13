namespace Tugas_W2_AD
{
    partial class F1PengaturanWarna
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
            this.Txt_Inputan = new System.Windows.Forms.TextBox();
            this.LblData = new System.Windows.Forms.Label();
            this.Btn_Proses = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Inputan
            // 
            this.Txt_Inputan.Location = new System.Drawing.Point(37, 80);
            this.Txt_Inputan.Name = "Txt_Inputan";
            this.Txt_Inputan.Size = new System.Drawing.Size(332, 27);
            this.Txt_Inputan.TabIndex = 0;
            this.Txt_Inputan.TextChanged += new System.EventHandler(this.Txt_Inputan_TextChanged);
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(37, 52);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(85, 25);
            this.LblData.TabIndex = 1;
            this.LblData.Text = "Input Data :";
            this.LblData.UseCompatibleTextRendering = true;
            this.LblData.UseMnemonic = false;
            this.LblData.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Proses
            // 
            this.Btn_Proses.Location = new System.Drawing.Point(37, 159);
            this.Btn_Proses.Name = "Btn_Proses";
            this.Btn_Proses.Size = new System.Drawing.Size(108, 29);
            this.Btn_Proses.TabIndex = 2;
            this.Btn_Proses.Text = "Proses";
            this.Btn_Proses.UseVisualStyleBackColor = true;
            this.Btn_Proses.Click += new System.EventHandler(this.Btn_Proses_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOutput.Location = new System.Drawing.Point(37, 257);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(180, 57);
            this.LblOutput.TabIndex = 3;
            this.LblOutput.Text = "[EMPTY]";
            this.LblOutput.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // F1PengaturanWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.Btn_Proses);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.Txt_Inputan);
            this.Name = "F1PengaturanWarna";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Txt_Inputan;
        private Label LblData;
        private Button Btn_Proses;
        private Label LblOutput;
        private Label label1;
    }
}