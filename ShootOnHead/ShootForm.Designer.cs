namespace ShootOnHead
{
    partial class ShootForm
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
            this.Fire = new System.Windows.Forms.Button();
            this.LoadBullet = new System.Windows.Forms.Button();
            this.SpinChamber = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.ShotsLeft = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.ChamberLocation = new System.Windows.Forms.Label();
            this.gun = new System.Windows.Forms.PictureBox();
            this.person = new System.Windows.Forms.PictureBox();
            this.pointAtHead = new System.Windows.Forms.Button();
            this.PointAway = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.person)).BeginInit();
            this.SuspendLayout();
            // 
            // Fire
            // 
            this.Fire.BackColor = System.Drawing.Color.Red;
            this.Fire.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.ForeColor = System.Drawing.Color.Transparent;
            this.Fire.Location = new System.Drawing.Point(397, 478);
            this.Fire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(192, 71);
            this.Fire.TabIndex = 4;
            this.Fire.Text = "Fire";
            this.Fire.UseVisualStyleBackColor = false;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // LoadBullet
            // 
            this.LoadBullet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoadBullet.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBullet.ForeColor = System.Drawing.Color.White;
            this.LoadBullet.Location = new System.Drawing.Point(12, 390);
            this.LoadBullet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadBullet.Name = "LoadBullet";
            this.LoadBullet.Size = new System.Drawing.Size(241, 59);
            this.LoadBullet.TabIndex = 5;
            this.LoadBullet.Text = "Load Bullet";
            this.LoadBullet.UseVisualStyleBackColor = false;
            this.LoadBullet.Click += new System.EventHandler(this.LoadBullet_Click);
            // 
            // SpinChamber
            // 
            this.SpinChamber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SpinChamber.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinChamber.ForeColor = System.Drawing.Color.White;
            this.SpinChamber.Location = new System.Drawing.Point(262, 390);
            this.SpinChamber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpinChamber.Name = "SpinChamber";
            this.SpinChamber.Size = new System.Drawing.Size(238, 59);
            this.SpinChamber.TabIndex = 6;
            this.SpinChamber.Text = "Spin Chamber";
            this.SpinChamber.UseVisualStyleBackColor = false;
            this.SpinChamber.Click += new System.EventHandler(this.SpinChamber_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PlayAgain.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayAgain.Location = new System.Drawing.Point(152, 478);
            this.PlayAgain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(217, 71);
            this.PlayAgain.TabIndex = 7;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Visible = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // ShotsLeft
            // 
            this.ShotsLeft.AutoSize = true;
            this.ShotsLeft.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShotsLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ShotsLeft.Location = new System.Drawing.Point(255, 9);
            this.ShotsLeft.Name = "ShotsLeft";
            this.ShotsLeft.Size = new System.Drawing.Size(213, 41);
            this.ShotsLeft.TabIndex = 9;
            this.ShotsLeft.Text = "Shots left=6";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Status.Location = new System.Drawing.Point(579, 302);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(74, 32);
            this.Status.TabIndex = 10;
            this.Status.Text = "Died";
            this.Status.Visible = false;
            // 
            // ChamberLocation
            // 
            this.ChamberLocation.AutoSize = true;
            this.ChamberLocation.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChamberLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ChamberLocation.Location = new System.Drawing.Point(520, 9);
            this.ChamberLocation.Name = "ChamberLocation";
            this.ChamberLocation.Size = new System.Drawing.Size(361, 41);
            this.ChamberLocation.TabIndex = 11;
            this.ChamberLocation.Text = "Chamber Position=1";
            // 
            // gun
            // 
            this.gun.BackColor = System.Drawing.Color.Transparent;
            this.gun.Image = global::ShootOnHead.Properties.Resources.gun1;
            this.gun.Location = new System.Drawing.Point(726, 131);
            this.gun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gun.MaximumSize = new System.Drawing.Size(235, 142);
            this.gun.MinimumSize = new System.Drawing.Size(235, 142);
            this.gun.Name = "gun";
            this.gun.Size = new System.Drawing.Size(235, 142);
            this.gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gun.TabIndex = 1;
            this.gun.TabStop = false;
            // 
            // person
            // 
            this.person.BackColor = System.Drawing.Color.White;
            this.person.Image = global::ShootOnHead.Properties.Resources.person;
            this.person.Location = new System.Drawing.Point(12, 107);
            this.person.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.person.MaximumSize = new System.Drawing.Size(608, 625);
            this.person.MinimumSize = new System.Drawing.Size(270, 275);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(270, 275);
            this.person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.person.TabIndex = 0;
            this.person.TabStop = false;
            // 
            // pointAtHead
            // 
            this.pointAtHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pointAtHead.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointAtHead.ForeColor = System.Drawing.Color.White;
            this.pointAtHead.Location = new System.Drawing.Point(508, 390);
            this.pointAtHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pointAtHead.Name = "pointAtHead";
            this.pointAtHead.Size = new System.Drawing.Size(238, 59);
            this.pointAtHead.TabIndex = 2;
            this.pointAtHead.Text = "Point At Head";
            this.pointAtHead.UseVisualStyleBackColor = false;
            this.pointAtHead.Click += new System.EventHandler(this.pointAtHead_Click);
            // 
            // PointAway
            // 
            this.PointAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PointAway.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointAway.ForeColor = System.Drawing.Color.White;
            this.PointAway.Location = new System.Drawing.Point(752, 390);
            this.PointAway.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PointAway.Name = "PointAway";
            this.PointAway.Size = new System.Drawing.Size(209, 59);
            this.PointAway.TabIndex = 3;
            this.PointAway.Text = "Point Away";
            this.PointAway.UseVisualStyleBackColor = false;
            this.PointAway.Click += new System.EventHandler(this.PointAway_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Exit_btn.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit_btn.Location = new System.Drawing.Point(611, 478);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(170, 60);
            this.Exit_btn.TabIndex = 12;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // ShootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(973, 672);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.ChamberLocation);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ShotsLeft);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.SpinChamber);
            this.Controls.Add(this.LoadBullet);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.PointAway);
            this.Controls.Add(this.pointAtHead);
            this.Controls.Add(this.gun);
            this.Controls.Add(this.person);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShootForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shooter";
            ((System.ComponentModel.ISupportInitialize)(this.gun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.person)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox person;
        private System.Windows.Forms.PictureBox gun;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button LoadBullet;
        private System.Windows.Forms.Button SpinChamber;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Label ShotsLeft;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label ChamberLocation;
        private System.Windows.Forms.Button pointAtHead;
        private System.Windows.Forms.Button PointAway;
        private System.Windows.Forms.Button Exit_btn;
    }
}

