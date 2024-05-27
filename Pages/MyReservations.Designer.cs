namespace TAMS.Pages
{
    partial class MyReservations
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
            this.Reserve_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reserve_btn
            // 
            this.Reserve_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Reserve_btn.Location = new System.Drawing.Point(12, 627);
            this.Reserve_btn.Name = "Reserve_btn";
            this.Reserve_btn.Size = new System.Drawing.Size(240, 40);
            this.Reserve_btn.TabIndex = 6;
            this.Reserve_btn.Text = "Make a Reservation";
            this.Reserve_btn.UseVisualStyleBackColor = true;
            this.Reserve_btn.Click += new System.EventHandler(this.My_reservations_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Logout_btn.Location = new System.Drawing.Point(919, 12);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(130, 40);
            this.Logout_btn.TabIndex = 7;
            this.Logout_btn.Text = "Log out";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(295, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "My Reservations";
            // 
            // MyReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Reserve_btn);
            this.Name = "MyReservations";
            this.Text = "MyReservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reserve_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label label1;
    }
}