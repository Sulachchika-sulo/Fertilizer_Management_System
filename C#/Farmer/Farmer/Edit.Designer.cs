namespace Farmer
{
    partial class Edit
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
            this.editfe = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.txtkg = new System.Windows.Forms.TextBox();
            this.rdl = new System.Windows.Forms.RadioButton();
            this.rdkg = new System.Windows.Forms.RadioButton();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.de = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.txtdis = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editfe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editfe
            // 
            this.editfe.BackgroundImage = global::Farmer.Properties.Resources.Untitled_17;
            this.editfe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editfe.Controls.Add(this.dataGridView1);
            this.editfe.Controls.Add(this.groupBox1);
            this.editfe.Controls.Add(this.txtdate);
            this.editfe.Controls.Add(this.label4);
            this.editfe.Controls.Add(this.de);
            this.editfe.Controls.Add(this.clear);
            this.editfe.Controls.Add(this.update);
            this.editfe.Controls.Add(this.txtdis);
            this.editfe.Controls.Add(this.txtname);
            this.editfe.Controls.Add(this.txtsearch);
            this.editfe.Controls.Add(this.txtid);
            this.editfe.Controls.Add(this.label8);
            this.editfe.Controls.Add(this.label3);
            this.editfe.Controls.Add(this.label7);
            this.editfe.Controls.Add(this.label10);
            this.editfe.Controls.Add(this.label2);
            this.editfe.Controls.Add(this.label1);
            this.editfe.Location = new System.Drawing.Point(0, 0);
            this.editfe.Name = "editfe";
            this.editfe.Size = new System.Drawing.Size(769, 523);
            this.editfe.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 162);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtl);
            this.groupBox1.Controls.Add(this.txtkg);
            this.groupBox1.Controls.Add(this.rdl);
            this.groupBox1.Controls.Add(this.rdkg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(76, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 102);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantity";
            // 
            // txtl
            // 
            this.txtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtl.Location = new System.Drawing.Point(114, 59);
            this.txtl.Multiline = true;
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(89, 25);
            this.txtl.TabIndex = 2;
            this.txtl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtl_KeyPress);
            // 
            // txtkg
            // 
            this.txtkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkg.Location = new System.Drawing.Point(114, 23);
            this.txtkg.Multiline = true;
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(89, 25);
            this.txtkg.TabIndex = 2;
            this.txtkg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkg_KeyPress);
            // 
            // rdl
            // 
            this.rdl.AutoSize = true;
            this.rdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdl.Location = new System.Drawing.Point(39, 60);
            this.rdl.Name = "rdl";
            this.rdl.Size = new System.Drawing.Size(56, 20);
            this.rdl.TabIndex = 1;
            this.rdl.TabStop = true;
            this.rdl.Text = "Liter";
            this.rdl.UseVisualStyleBackColor = true;
            this.rdl.CheckedChanged += new System.EventHandler(this.rdl_CheckedChanged);
            // 
            // rdkg
            // 
            this.rdkg.AutoSize = true;
            this.rdkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdkg.Location = new System.Drawing.Point(39, 28);
            this.rdkg.Name = "rdkg";
            this.rdkg.Size = new System.Drawing.Size(44, 20);
            this.rdkg.TabIndex = 0;
            this.rdkg.TabStop = true;
            this.rdkg.Text = "Kg";
            this.rdkg.UseVisualStyleBackColor = true;
            this.rdkg.CheckedChanged += new System.EventHandler(this.rdkg_CheckedChanged);
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.SystemColors.Control;
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(151, 226);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(185, 25);
            this.txtdate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(72, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // de
            // 
            this.de.BackColor = System.Drawing.Color.SeaGreen;
            this.de.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de.ForeColor = System.Drawing.Color.White;
            this.de.Location = new System.Drawing.Point(198, 271);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(81, 30);
            this.de.TabIndex = 4;
            this.de.Text = "Delete";
            this.de.UseVisualStyleBackColor = false;
            this.de.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.SeaGreen;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(285, 271);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(81, 30);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.SeaGreen;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(111, 271);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(81, 30);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtdis
            // 
            this.txtdis.BackColor = System.Drawing.Color.White;
            this.txtdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdis.Location = new System.Drawing.Point(410, 158);
            this.txtdis.Multiline = true;
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(276, 89);
            this.txtdis.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(499, 83);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(185, 25);
            this.txtname.TabIndex = 2;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.White;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(499, 271);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(185, 25);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Control;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(151, 83);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(185, 25);
            this.txtid.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(405, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Discription";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(403, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(660, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(90, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(105, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fertilizer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(428, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 523);
            this.ControlBox = false;
            this.Controls.Add(this.editfe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.editfe.ResumeLayout(false);
            this.editfe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.RadioButton rdl;
        private System.Windows.Forms.RadioButton rdkg;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdis;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button de;
        private System.Windows.Forms.Panel editfe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;

    }
}