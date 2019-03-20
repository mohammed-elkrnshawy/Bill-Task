namespace Bill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_MaterialTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_BillNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الكمية = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 729);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-8, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 680);
            this.panel2.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 505);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1386, 175);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.txt_MaterialTotal);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(-1, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1386, 175);
            this.panel7.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(189)))), ((int)(((byte)(212)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(84)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(19, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 35;
            this.button1.Text = "حفظ و طباعة";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_MaterialTotal
            // 
            this.txt_MaterialTotal.Enabled = false;
            this.txt_MaterialTotal.Location = new System.Drawing.Point(1081, 20);
            this.txt_MaterialTotal.Name = "txt_MaterialTotal";
            this.txt_MaterialTotal.ReadOnly = true;
            this.txt_MaterialTotal.Size = new System.Drawing.Size(125, 20);
            this.txt_MaterialTotal.TabIndex = 18;
            this.txt_MaterialTotal.Text = "0";
            this.txt_MaterialTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(1212, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "اجمالى الفاتورة";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(0, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1386, 394);
            this.panel5.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1378, 97);
            this.panel9.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Location = new System.Drawing.Point(0, 106);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1382, 283);
            this.panel8.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.الكمية,
            this.Column3,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(189)))), ((int)(((byte)(212)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1382, 283);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1386, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_BillNumber);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(736, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 100);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(506, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "البائع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_BillNumber
            // 
            this.txt_BillNumber.Enabled = false;
            this.txt_BillNumber.Location = new System.Drawing.Point(211, 14);
            this.txt_BillNumber.Name = "txt_BillNumber";
            this.txt_BillNumber.ReadOnly = true;
            this.txt_BillNumber.Size = new System.Drawing.Size(285, 20);
            this.txt_BillNumber.TabIndex = 8;
            this.txt_BillNumber.Text = "0";
            this.txt_BillNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(502, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "رقم البيان";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtProduct);
            this.panel10.Controls.Add(this.pictureBox1);
            this.panel10.Controls.Add(this.txtQuantity);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.txtPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(650, 100);
            this.panel10.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(60, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(345, 55);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(106, 20);
            this.txtQuantity.TabIndex = 16;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(457, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "الكمية";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(115, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(106, 20);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(216, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "السعر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(457, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "اسم الصنف";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(211, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 20);
            this.txtName.TabIndex = 17;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(166, 14);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(285, 20);
            this.txtProduct.TabIndex = 42;
            this.txtProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            this.Column1.Width = 81;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "الوصف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // الكمية
            // 
            this.الكمية.HeaderText = "الكمية";
            this.الكمية.Name = "الكمية";
            this.الكمية.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "سعر المنتج ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الاجمالى";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_MaterialTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_BillNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn الكمية;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

