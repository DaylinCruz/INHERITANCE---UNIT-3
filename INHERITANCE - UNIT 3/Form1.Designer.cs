namespace INHERITANCE___UNIT_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.txtartist = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.SONG = new System.Windows.Forms.ListBox();
            this.btnaccept = new System.Windows.Forms.Button();
            this.txtnumsongs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "SONG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(83, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "DURATION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(110, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "ARTIST:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(189, 189);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(249, 23);
            this.txtname.TabIndex = 4;
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(189, 259);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(249, 23);
            this.txtduration.TabIndex = 5;
            // 
            // txtartist
            // 
            this.txtartist.Location = new System.Drawing.Point(189, 328);
            this.txtartist.Name = "txtartist";
            this.txtartist.Size = new System.Drawing.Size(249, 23);
            this.txtartist.TabIndex = 6;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Crimson;
            this.btnexit.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(765, 338);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(99, 39);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnshow.Location = new System.Drawing.Point(632, 43);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(111, 38);
            this.btnshow.TabIndex = 8;
            this.btnshow.Text = "SHOW";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // SONG
            // 
            this.SONG.FormattingEnabled = true;
            this.SONG.ItemHeight = 15;
            this.SONG.Location = new System.Drawing.Point(486, 121);
            this.SONG.Name = "SONG";
            this.SONG.Size = new System.Drawing.Size(378, 169);
            this.SONG.TabIndex = 9;
            // 
            // btnaccept
            // 
            this.btnaccept.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnaccept.Location = new System.Drawing.Point(353, 121);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(85, 35);
            this.btnaccept.TabIndex = 10;
            this.btnaccept.Text = "ACCEPT";
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // txtnumsongs
            // 
            this.txtnumsongs.Location = new System.Drawing.Point(189, 130);
            this.txtnumsongs.Name = "txtnumsongs";
            this.txtnumsongs.Size = new System.Drawing.Size(158, 23);
            this.txtnumsongs.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of songs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnumsongs);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.SONG);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtartist);
            this.Controls.Add(this.txtduration);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtname;
        private TextBox txtduration;
        private TextBox txtartist;
        private Button btnexit;
        private Button btnshow;
        private ListBox SONG;
        private Button btnaccept;
        private TextBox txtnumsongs;
        private Label label5;
    }
}