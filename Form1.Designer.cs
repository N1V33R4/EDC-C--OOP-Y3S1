namespace EDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.meterNumTb = new System.Windows.Forms.TextBox();
            this.oldReadTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.consumeTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newReadTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rateTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.calcConsumeBtn = new System.Windows.Forms.Button();
            this.calcTotalBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.receiptBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meter Number";
            // 
            // meterNumTb
            // 
            this.meterNumTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meterNumTb.Location = new System.Drawing.Point(487, 53);
            this.meterNumTb.Name = "meterNumTb";
            this.meterNumTb.Size = new System.Drawing.Size(417, 30);
            this.meterNumTb.TabIndex = 5;
            this.meterNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.meterNumTb.TextChanged += new System.EventHandler(this.meterNumTb_TextChanged);
            // 
            // oldReadTb
            // 
            this.oldReadTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldReadTb.Location = new System.Drawing.Point(487, 114);
            this.oldReadTb.Name = "oldReadTb";
            this.oldReadTb.Size = new System.Drawing.Size(417, 30);
            this.oldReadTb.TabIndex = 7;
            this.oldReadTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldReadTb.TextChanged += new System.EventHandler(this.oldReadTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Old Reading";
            // 
            // consumeTb
            // 
            this.consumeTb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.consumeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consumeTb.Location = new System.Drawing.Point(487, 236);
            this.consumeTb.Name = "consumeTb";
            this.consumeTb.ReadOnly = true;
            this.consumeTb.Size = new System.Drawing.Size(417, 30);
            this.consumeTb.TabIndex = 11;
            this.consumeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Consuming Wat";
            // 
            // newReadTb
            // 
            this.newReadTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newReadTb.Location = new System.Drawing.Point(487, 175);
            this.newReadTb.Name = "newReadTb";
            this.newReadTb.Size = new System.Drawing.Size(417, 30);
            this.newReadTb.TabIndex = 9;
            this.newReadTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newReadTb.TextChanged += new System.EventHandler(this.newReadTb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "New Reading";
            // 
            // totalTb
            // 
            this.totalTb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTb.Location = new System.Drawing.Point(487, 358);
            this.totalTb.Name = "totalTb";
            this.totalTb.ReadOnly = true;
            this.totalTb.Size = new System.Drawing.Size(417, 30);
            this.totalTb.TabIndex = 15;
            this.totalTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Amount";
            // 
            // rateTb
            // 
            this.rateTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rateTb.Location = new System.Drawing.Point(487, 297);
            this.rateTb.Name = "rateTb";
            this.rateTb.Size = new System.Drawing.Size(417, 30);
            this.rateTb.TabIndex = 13;
            this.rateTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rateTb.TextChanged += new System.EventHandler(this.rateTb_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(677, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Rate";
            // 
            // calcConsumeBtn
            // 
            this.calcConsumeBtn.Location = new System.Drawing.Point(490, 404);
            this.calcConsumeBtn.Name = "calcConsumeBtn";
            this.calcConsumeBtn.Size = new System.Drawing.Size(203, 46);
            this.calcConsumeBtn.TabIndex = 16;
            this.calcConsumeBtn.Text = "Cal. Con&suming";
            this.calcConsumeBtn.UseVisualStyleBackColor = true;
            this.calcConsumeBtn.Click += new System.EventHandler(this.calcConsumeBtn_Click);
            // 
            // calcTotalBtn
            // 
            this.calcTotalBtn.Location = new System.Drawing.Point(701, 404);
            this.calcTotalBtn.Name = "calcTotalBtn";
            this.calcTotalBtn.Size = new System.Drawing.Size(203, 46);
            this.calcTotalBtn.TabIndex = 17;
            this.calcTotalBtn.Text = "Cal. &Amount";
            this.calcTotalBtn.UseVisualStyleBackColor = true;
            this.calcTotalBtn.Click += new System.EventHandler(this.calcTotalBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(701, 456);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(203, 46);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "&Clear All";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // receiptBtn
            // 
            this.receiptBtn.Location = new System.Drawing.Point(490, 456);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Size = new System.Drawing.Size(203, 46);
            this.receiptBtn.TabIndex = 18;
            this.receiptBtn.Text = "&Print Receipt";
            this.receiptBtn.UseVisualStyleBackColor = true;
            this.receiptBtn.Click += new System.EventHandler(this.receiptBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(24, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 477);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ang TaPich", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(119)))));
            this.label2.Location = new System.Drawing.Point(7, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "នាយកដ្ឋានបច្ចេកវិទ្យាព័ត៍មាន";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ang TaPich", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(122, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "អគ្គិសនីកម្ពុជា";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.receiptBtn);
            this.Controls.Add(this.calcTotalBtn);
            this.Controls.Add(this.calcConsumeBtn);
            this.Controls.Add(this.totalTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rateTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.consumeTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newReadTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.oldReadTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.meterNumTb);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "EDC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox meterNumTb;
        private System.Windows.Forms.TextBox oldReadTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox consumeTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newReadTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rateTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calcConsumeBtn;
        private System.Windows.Forms.Button calcTotalBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button receiptBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

