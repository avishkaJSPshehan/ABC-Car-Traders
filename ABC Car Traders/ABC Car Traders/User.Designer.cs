﻿namespace ABC_Car_Traders
{
    partial class User_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.car_details_btn = new System.Windows.Forms.Button();
            this.parts_details_btn = new System.Windows.Forms.Button();
            this.order_status_btn = new System.Windows.Forms.Button();
            this.search_car = new System.Windows.Forms.Button();
            this.car_search_box = new System.Windows.Forms.TextBox();
            this.dataGridView_car = new System.Windows.Forms.DataGridView();
            this.search_parts = new System.Windows.Forms.Button();
            this.parts_search_box = new System.Windows.Forms.TextBox();
            this.dataGridView_parts = new System.Windows.Forms.DataGridView();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.SuspendLayout();
            // 
            // car_details_btn
            // 
            this.car_details_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.car_details_btn.FlatAppearance.BorderSize = 0;
            this.car_details_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car_details_btn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_details_btn.ForeColor = System.Drawing.Color.White;
            this.car_details_btn.Location = new System.Drawing.Point(12, 204);
            this.car_details_btn.Name = "car_details_btn";
            this.car_details_btn.Size = new System.Drawing.Size(330, 37);
            this.car_details_btn.TabIndex = 9;
            this.car_details_btn.Text = "Explore  Car";
            this.car_details_btn.UseVisualStyleBackColor = false;
            this.car_details_btn.Click += new System.EventHandler(this.car_details_btn_Click);
            // 
            // parts_details_btn
            // 
            this.parts_details_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.parts_details_btn.FlatAppearance.BorderSize = 0;
            this.parts_details_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parts_details_btn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parts_details_btn.ForeColor = System.Drawing.Color.White;
            this.parts_details_btn.Location = new System.Drawing.Point(12, 261);
            this.parts_details_btn.Name = "parts_details_btn";
            this.parts_details_btn.Size = new System.Drawing.Size(330, 37);
            this.parts_details_btn.TabIndex = 10;
            this.parts_details_btn.Text = "Explore  Car Parts";
            this.parts_details_btn.UseVisualStyleBackColor = false;
            this.parts_details_btn.Click += new System.EventHandler(this.parts_details_btn_Click);
            // 
            // order_status_btn
            // 
            this.order_status_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.order_status_btn.FlatAppearance.BorderSize = 0;
            this.order_status_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_status_btn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_status_btn.ForeColor = System.Drawing.Color.White;
            this.order_status_btn.Location = new System.Drawing.Point(12, 322);
            this.order_status_btn.Name = "order_status_btn";
            this.order_status_btn.Size = new System.Drawing.Size(330, 37);
            this.order_status_btn.TabIndex = 11;
            this.order_status_btn.Text = "View Order Status";
            this.order_status_btn.UseVisualStyleBackColor = false;
            this.order_status_btn.Click += new System.EventHandler(this.order_status_btn_Click);
            // 
            // search_car
            // 
            this.search_car.BackColor = System.Drawing.Color.Crimson;
            this.search_car.FlatAppearance.BorderSize = 0;
            this.search_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_car.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_car.Location = new System.Drawing.Point(1269, 75);
            this.search_car.Name = "search_car";
            this.search_car.Size = new System.Drawing.Size(264, 31);
            this.search_car.TabIndex = 16;
            this.search_car.Text = "Search Car";
            this.search_car.UseVisualStyleBackColor = false;
            // 
            // car_search_box
            // 
            this.car_search_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.car_search_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.car_search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_search_box.Location = new System.Drawing.Point(388, 75);
            this.car_search_box.Multiline = true;
            this.car_search_box.Name = "car_search_box";
            this.car_search_box.Size = new System.Drawing.Size(874, 30);
            this.car_search_box.TabIndex = 15;
            // 
            // dataGridView_car
            // 
            this.dataGridView_car.AllowUserToAddRows = false;
            this.dataGridView_car.AllowUserToDeleteRows = false;
            this.dataGridView_car.AllowUserToResizeColumns = false;
            this.dataGridView_car.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_car.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_car.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView_car.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_car.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_car.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_car.ColumnHeadersHeight = 30;
            this.dataGridView_car.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_car.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_car.EnableHeadersVisualStyles = false;
            this.dataGridView_car.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_car.Location = new System.Drawing.Point(387, 135);
            this.dataGridView_car.Name = "dataGridView_car";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_car.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_car.RowHeadersVisible = false;
            this.dataGridView_car.RowTemplate.Height = 24;
            this.dataGridView_car.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_car.Size = new System.Drawing.Size(1145, 616);
            this.dataGridView_car.TabIndex = 17;
            // 
            // search_parts
            // 
            this.search_parts.BackColor = System.Drawing.Color.Crimson;
            this.search_parts.FlatAppearance.BorderSize = 0;
            this.search_parts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_parts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_parts.Location = new System.Drawing.Point(1269, 74);
            this.search_parts.Name = "search_parts";
            this.search_parts.Size = new System.Drawing.Size(264, 31);
            this.search_parts.TabIndex = 19;
            this.search_parts.Text = "Search Parts";
            this.search_parts.UseVisualStyleBackColor = false;
            // 
            // parts_search_box
            // 
            this.parts_search_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.parts_search_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parts_search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parts_search_box.Location = new System.Drawing.Point(388, 74);
            this.parts_search_box.Multiline = true;
            this.parts_search_box.Name = "parts_search_box";
            this.parts_search_box.Size = new System.Drawing.Size(874, 30);
            this.parts_search_box.TabIndex = 18;
            // 
            // dataGridView_parts
            // 
            this.dataGridView_parts.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parts.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_parts.Location = new System.Drawing.Point(387, 204);
            this.dataGridView_parts.Name = "dataGridView_parts";
            this.dataGridView_parts.RowTemplate.Height = 24;
            this.dataGridView_parts.Size = new System.Drawing.Size(1145, 546);
            this.dataGridView_parts.TabIndex = 20;
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_order.Location = new System.Drawing.Point(387, 261);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowTemplate.Height = 24;
            this.dataGridView_order.Size = new System.Drawing.Size(1145, 490);
            this.dataGridView_order.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Company";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Modele";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Product Year";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Salling Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Mileage";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Engine Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Transmission";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Color";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Condition";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Status";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // User_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.user_home_bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1573, 826);
            this.Controls.Add(this.dataGridView_order);
            this.Controls.Add(this.search_parts);
            this.Controls.Add(this.parts_search_box);
            this.Controls.Add(this.dataGridView_parts);
            this.Controls.Add(this.search_car);
            this.Controls.Add(this.car_search_box);
            this.Controls.Add(this.dataGridView_car);
            this.Controls.Add(this.order_status_btn);
            this.Controls.Add(this.parts_details_btn);
            this.Controls.Add(this.car_details_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button car_details_btn;
        private System.Windows.Forms.Button parts_details_btn;
        private System.Windows.Forms.Button order_status_btn;
        private System.Windows.Forms.Button search_car;
        private System.Windows.Forms.TextBox car_search_box;
        private System.Windows.Forms.DataGridView dataGridView_car;
        private System.Windows.Forms.Button search_parts;
        private System.Windows.Forms.TextBox parts_search_box;
        private System.Windows.Forms.DataGridView dataGridView_parts;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}