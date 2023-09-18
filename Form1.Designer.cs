namespace schap_bai13
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvndtoeur = new System.Windows.Forms.Button();
            this.btnusdtovnd = new System.Windows.Forms.Button();
            this.btneurtovnd = new System.Windows.Forms.Button();
            this.btnvndtousd = new System.Windows.Forms.Button();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquidoi = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(237, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI TIỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiền qui đổi:";
            // 
            // btnvndtoeur
            // 
            this.btnvndtoeur.Location = new System.Drawing.Point(153, 196);
            this.btnvndtoeur.Name = "btnvndtoeur";
            this.btnvndtoeur.Size = new System.Drawing.Size(84, 24);
            this.btnvndtoeur.TabIndex = 1;
            this.btnvndtoeur.Text = "VNDtoEUR";
            this.btnvndtoeur.UseVisualStyleBackColor = true;
            // 
            // btnusdtovnd
            // 
            this.btnusdtovnd.Location = new System.Drawing.Point(268, 196);
            this.btnusdtovnd.Name = "btnusdtovnd";
            this.btnusdtovnd.Size = new System.Drawing.Size(86, 24);
            this.btnusdtovnd.TabIndex = 1;
            this.btnusdtovnd.Text = "USDtoVND";
            this.btnusdtovnd.UseVisualStyleBackColor = true;
            // 
            // btneurtovnd
            // 
            this.btneurtovnd.Location = new System.Drawing.Point(386, 196);
            this.btneurtovnd.Name = "btneurtovnd";
            this.btneurtovnd.Size = new System.Drawing.Size(84, 24);
            this.btneurtovnd.TabIndex = 1;
            this.btneurtovnd.Text = "EURtoVND";
            this.btneurtovnd.UseVisualStyleBackColor = true;
            // 
            // btnvndtousd
            // 
            this.btnvndtousd.Location = new System.Drawing.Point(25, 196);
            this.btnvndtousd.Name = "btnvndtousd";
            this.btnvndtousd.Size = new System.Drawing.Size(90, 25);
            this.btnvndtousd.TabIndex = 1;
            this.btnvndtousd.Text = "VNDtoUSD";
            this.btnvndtousd.UseVisualStyleBackColor = true;
            this.btnvndtousd.Click += new System.EventHandler(this.btnvndtousd_Click);
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(153, 276);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(240, 20);
            this.txtketqua.TabIndex = 2;
            this.txtketqua.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết Quả:";
            // 
            // txtquidoi
            // 
            this.txtquidoi.Location = new System.Drawing.Point(153, 135);
            this.txtquidoi.Name = "txtquidoi";
            this.txtquidoi.Size = new System.Drawing.Size(240, 20);
            this.txtquidoi.TabIndex = 2;
            this.txtquidoi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 372);
            this.Controls.Add(this.txtquidoi);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.btnvndtousd);
            this.Controls.Add(this.btneurtovnd);
            this.Controls.Add(this.btnusdtovnd);
            this.Controls.Add(this.btnvndtoeur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvndtoeur;
        private System.Windows.Forms.Button btnusdtovnd;
        private System.Windows.Forms.Button btneurtovnd;
        private System.Windows.Forms.Button btnvndtousd;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquidoi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

