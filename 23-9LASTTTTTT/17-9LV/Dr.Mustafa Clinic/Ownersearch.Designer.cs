namespace Dr.Mustafa_Clinic
{
    partial class Ownersearch
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
            this.OwnSearchDatagrid = new System.Windows.Forms.DataGridView();
            this.Close = new System.Windows.Forms.Button();
            this.owner_filter = new System.Windows.Forms.TextBox();
            this.mob_filter = new System.Windows.Forms.TextBox();
            this.unpaid = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Choose = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OwnSearchDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OwnSearchDatagrid
            // 
            this.OwnSearchDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OwnSearchDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OwnSearchDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Choose});
            this.OwnSearchDatagrid.Location = new System.Drawing.Point(12, 48);
            this.OwnSearchDatagrid.Name = "OwnSearchDatagrid";
            this.OwnSearchDatagrid.Size = new System.Drawing.Size(539, 443);
            this.OwnSearchDatagrid.TabIndex = 0;
            this.OwnSearchDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(12, 497);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(539, 29);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // owner_filter
            // 
            this.owner_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.owner_filter.Location = new System.Drawing.Point(173, 21);
            this.owner_filter.Name = "owner_filter";
            this.owner_filter.Size = new System.Drawing.Size(120, 20);
            this.owner_filter.TabIndex = 2;
            // 
            // mob_filter
            // 
            this.mob_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mob_filter.Location = new System.Drawing.Point(292, 21);
            this.mob_filter.Name = "mob_filter";
            this.mob_filter.Size = new System.Drawing.Size(120, 20);
            this.mob_filter.TabIndex = 3;
            // 
            // unpaid
            // 
            this.unpaid.AutoSize = true;
            this.unpaid.Location = new System.Drawing.Point(414, 23);
            this.unpaid.Name = "unpaid";
            this.unpaid.Size = new System.Drawing.Size(104, 17);
            this.unpaid.TabIndex = 8;
            this.unpaid.Text = "Unpaid Amounts";
            this.unpaid.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dr.Mustafa_Clinic.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Choose
            // 
            this.Choose.HeaderText = "Choose";
            this.Choose.Name = "Choose";
            this.Choose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Choose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Choose.Text = "Select";
            this.Choose.UseColumnTextForButtonValue = true;
            // 
            // Ownersearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(563, 538);
            this.Controls.Add(this.unpaid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mob_filter);
            this.Controls.Add(this.owner_filter);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.OwnSearchDatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ownersearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ownersearch";
            ((System.ComponentModel.ISupportInitialize)(this.OwnSearchDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OwnSearchDatagrid;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox owner_filter;
        private System.Windows.Forms.TextBox mob_filter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox unpaid;
        private System.Windows.Forms.DataGridViewButtonColumn Choose;

    }
}