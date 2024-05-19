namespace TAMS.Pages
{
    partial class Reserve
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
            this.Departure_city_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Arrival_city_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.My_reservations_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Departure_city_txt
            // 
            this.Departure_city_txt.AutoCompleteCustomSource.AddRange(new string[] {
            "Paris",
            "London",
            "Barcelona",
            "Rome",
            "Prague",
            "Amsterdam",
            "Berlin",
            "Vienna",
            "Madrid",
            "Istanbul",
            "Florence",
            "Athens",
            "Dublin",
            "Lisbon",
            "Munich",
            "Venice",
            "Budapest",
            "Copenhagen",
            "Edinburgh",
            "Stockholm",
            "Brussels",
            "Dubrovnik",
            "Zurich",
            "Helsinki",
            "Salzburg",
            "Reykjavik",
            "Nice",
            "Krakow"});
            this.Departure_city_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Departure_city_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Departure_city_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Departure_city_txt.Location = new System.Drawing.Point(18, 137);
            this.Departure_city_txt.Name = "Departure_city_txt";
            this.Departure_city_txt.Size = new System.Drawing.Size(132, 26);
            this.Departure_city_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departure City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arrival City";
            // 
            // Arrival_city_txt
            // 
            this.Arrival_city_txt.AutoCompleteCustomSource.AddRange(new string[] {
            "Paris",
            "London",
            "Barcelona",
            "Rome",
            "Prague",
            "Amsterdam",
            "Berlin",
            "Vienna",
            "Madrid",
            "Istanbul",
            "Florence",
            "Athens",
            "Dublin",
            "Lisbon",
            "Munich",
            "Venice",
            "Budapest",
            "Copenhagen",
            "Edinburgh",
            "Stockholm",
            "Brussels",
            "Dubrovnik",
            "Zurich",
            "Helsinki",
            "Salzburg",
            "Reykjavik",
            "Nice",
            "Krakow"});
            this.Arrival_city_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Arrival_city_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Arrival_city_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Arrival_city_txt.Location = new System.Drawing.Point(18, 258);
            this.Arrival_city_txt.Name = "Arrival_city_txt";
            this.Arrival_city_txt.Size = new System.Drawing.Size(132, 26);
            this.Arrival_city_txt.TabIndex = 2;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search_btn.Location = new System.Drawing.Point(18, 320);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(132, 40);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // My_reservations_btn
            // 
            this.My_reservations_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.My_reservations_btn.Location = new System.Drawing.Point(12, 559);
            this.My_reservations_btn.Name = "My_reservations_btn";
            this.My_reservations_btn.Size = new System.Drawing.Size(182, 40);
            this.My_reservations_btn.TabIndex = 5;
            this.My_reservations_btn.Text = "My Reservations";
            this.My_reservations_btn.UseVisualStyleBackColor = true;
            this.My_reservations_btn.Click += new System.EventHandler(this.My_reservations_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Logout_btn.Location = new System.Drawing.Point(818, 12);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(130, 40);
            this.Logout_btn.TabIndex = 8;
            this.Logout_btn.Text = "Log out";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Make a Reservation";
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 611);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.My_reservations_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Arrival_city_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Departure_city_txt);
            this.Name = "Reserve";
            this.Text = "Reserve";
            this.Load += new System.EventHandler(this.Reserve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Departure_city_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Arrival_city_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button My_reservations_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label label3;
    }
}