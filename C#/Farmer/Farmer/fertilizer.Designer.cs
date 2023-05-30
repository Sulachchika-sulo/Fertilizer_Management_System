namespace Farmer
{
    partial class fertilizer
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
            this.panfe = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.txtkg = new System.Windows.Forms.TextBox();
            this.rdl = new System.Windows.Forms.RadioButton();
            this.rdkg = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdis = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.main2 = new System.Windows.Forms.Panel();
            this.panfe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panfe
            // 
            this.panfe.BackgroundImage = global::Farmer.Properties.Resources.Untitled_1;
            this.panfe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panfe.Controls.Add(this.groupBox1);
            this.panfe.Controls.Add(this.button2);
            this.panfe.Controls.Add(this.button1);
            this.panfe.Controls.Add(this.txtdis);
            this.panfe.Controls.Add(this.txtname);
            this.panfe.Controls.Add(this.txtdate);
            this.panfe.Controls.Add(this.txtid);
            this.panfe.Controls.Add(this.label8);
            this.panfe.Controls.Add(this.label7);
            this.panfe.Controls.Add(this.label4);
            this.panfe.Controls.Add(this.label2);
            this.panfe.Controls.Add(this.label1);
            this.panfe.Location = new System.Drawing.Point(12, 12);
            this.panfe.Name = "panfe";
            this.panfe.Size = new System.Drawing.Size(742, 496);
            this.panfe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtl);
            this.groupBox1.Controls.Add(this.txtkg);
            this.groupBox1.Controls.Add(this.rdl);
            this.groupBox1.Controls.Add(this.rdkg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(88, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantity";
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(114, 59);
            this.txtl.Multiline = true;
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(89, 30);
            this.txtl.TabIndex = 2;
            this.txtl.TextChanged += new System.EventHandler(this.txtl_TextChanged);
            this.txtl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtl_KeyPress);
            // 
            // txtkg
            // 
            this.txtkg.Location = new System.Drawing.Point(114, 23);
            this.txtkg.Multiline = true;
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(89, 30);
            this.txtkg.TabIndex = 2;
            this.txtkg.TextChanged += new System.EventHandler(this.txtkg_TextChanged);
            this.txtkg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkg_KeyPress);
            // 
            // rdl
            // 
            this.rdl.AutoSize = true;
            this.rdl.Location = new System.Drawing.Point(39, 64);
            this.rdl.Name = "rdl";
            this.rdl.Size = new System.Drawing.Size(59, 22);
            this.rdl.TabIndex = 1;
            this.rdl.TabStop = true;
            this.rdl.Text = "Liter";
            this.rdl.UseVisualStyleBackColor = true;
            this.rdl.CheckedChanged += new System.EventHandler(this.rdl_CheckedChanged);
            // 
            // rdkg
            // 
            this.rdkg.AutoSize = true;
            this.rdkg.Location = new System.Drawing.Point(39, 28);
            this.rdkg.Name = "rdkg";
            this.rdkg.Size = new System.Drawing.Size(46, 22);
            this.rdkg.TabIndex = 0;
            this.rdkg.TabStop = true;
            this.rdkg.Text = "Kg";
            this.rdkg.UseVisualStyleBackColor = true;
            this.rdkg.CheckedChanged += new System.EventHandler(this.rdkg_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(572, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(482, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdis
            // 
            this.txtdis.BackColor = System.Drawing.Color.White;
            this.txtdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdis.Location = new System.Drawing.Point(402, 202);
            this.txtdis.Multiline = true;
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(276, 111);
            this.txtdis.TabIndex = 2;
            this.txtdis.TextChanged += new System.EventHandler(this.txtdis_TextChanged);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(493, 115);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(185, 29);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(157, 312);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(185, 35);
            this.txtdate.TabIndex = 2;
            this.txtdate.TextChanged += new System.EventHandler(this.txtdate_TextChanged);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(157, 119);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(185, 29);
            this.txtid.TabIndex = 2;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(397, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Discription";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(397, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(78, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(83, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(303, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fertilizer";
            // 
            // main2
            // 
            this.main2.Location = new System.Drawing.Point(11, 10);
            this.main2.Name = "main2";
            this.main2.Size = new System.Drawing.Size(742, 496);
            this.main2.TabIndex = 5;
            // 
            // fertilizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 523);
            this.ControlBox = false;
            this.Controls.Add(this.panfe);
            this.Controls.Add(this.main2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fertilizer";
            this.Load += new System.EventHandler(this.fertilizer_Load);
            this.panfe.ResumeLayout(false);
            this.panfe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panfe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdis;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Panel main2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.RadioButton rdl;
        private System.Windows.Forms.RadioButton rdkg;
    }
}