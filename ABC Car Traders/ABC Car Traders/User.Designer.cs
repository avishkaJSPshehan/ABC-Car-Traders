namespace ABC_Car_Traders
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
            this.dataGridView_car.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView_car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_car.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_car.Location = new System.Drawing.Point(387, 135);
            this.dataGridView_car.Name = "dataGridView_car";
            this.dataGridView_car.RowTemplate.Height = 24;
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
            this.dataGridView_parts.Location = new System.Drawing.Point(387, 134);
            this.dataGridView_parts.Name = "dataGridView_parts";
            this.dataGridView_parts.RowTemplate.Height = 24;
            this.dataGridView_parts.Size = new System.Drawing.Size(1145, 616);
            this.dataGridView_parts.TabIndex = 20;
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_order.Location = new System.Drawing.Point(387, 135);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowTemplate.Height = 24;
            this.dataGridView_order.Size = new System.Drawing.Size(1145, 616);
            this.dataGridView_order.TabIndex = 21;
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
    }
}