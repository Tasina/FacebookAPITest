namespace FacebookTest
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
            this.components = new System.ComponentModel.Container();
            this.lbPosts = new System.Windows.Forms.ListBox();
            this.lblTotalLikes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSad1 = new System.Windows.Forms.Label();
            this.lblLikes1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAngry1 = new System.Windows.Forms.Label();
            this.lblLove1 = new System.Windows.Forms.Label();
            this.lblHaha1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblWow1 = new System.Windows.Forms.Label();
            this.lblThankf1 = new System.Windows.Forms.Label();
            this.lblTotalPosts = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalThanks = new System.Windows.Forms.Label();
            this.lblTotalAngry = new System.Windows.Forms.Label();
            this.lblTotalSad = new System.Windows.Forms.Label();
            this.lblTotalHaha = new System.Windows.Forms.Label();
            this.lblTotalWow = new System.Windows.Forms.Label();
            this.lblTotalLove = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbAppId = new System.Windows.Forms.TextBox();
            this.tbAppSecret = new System.Windows.Forms.TextBox();
            this.lblAppId1 = new System.Windows.Forms.Label();
            this.lblAppSecret1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPosts
            // 
            this.lbPosts.FormattingEnabled = true;
            this.lbPosts.Location = new System.Drawing.Point(310, 114);
            this.lbPosts.Name = "lbPosts";
            this.lbPosts.Size = new System.Drawing.Size(576, 368);
            this.lbPosts.TabIndex = 4;
            this.lbPosts.SelectedIndexChanged += new System.EventHandler(this.lbPosts_SelectedIndexChanged);
            // 
            // lblTotalLikes
            // 
            this.lblTotalLikes.AutoSize = true;
            this.lblTotalLikes.Location = new System.Drawing.Point(172, 112);
            this.lblTotalLikes.Name = "lblTotalLikes";
            this.lblTotalLikes.Size = new System.Drawing.Size(0, 13);
            this.lblTotalLikes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Like:";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1129, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblSad1);
            this.panel1.Controls.Add(this.lblLikes1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lblAngry1);
            this.panel1.Controls.Add(this.lblLove1);
            this.panel1.Controls.Add(this.lblHaha1);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.lblWow1);
            this.panel1.Controls.Add(this.lblThankf1);
            this.panel1.Location = new System.Drawing.Point(15, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 425);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(19, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 5);
            this.panel5.TabIndex = 22;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(16, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(253, 124);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Message";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Angry:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Sad:";
            // 
            // lblSad1
            // 
            this.lblSad1.AutoSize = true;
            this.lblSad1.Location = new System.Drawing.Point(191, 301);
            this.lblSad1.Name = "lblSad1";
            this.lblSad1.Size = new System.Drawing.Size(0, 13);
            this.lblSad1.TabIndex = 17;
            // 
            // lblLikes1
            // 
            this.lblLikes1.AutoSize = true;
            this.lblLikes1.Location = new System.Drawing.Point(191, 161);
            this.lblLikes1.Name = "lblLikes1";
            this.lblLikes1.Size = new System.Drawing.Size(0, 13);
            this.lblLikes1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(59, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Thankful:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(59, 159);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 16);
            this.label24.TabIndex = 6;
            this.label24.Text = "Like:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(59, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Haha:";
            // 
            // lblAngry1
            // 
            this.lblAngry1.AutoSize = true;
            this.lblAngry1.Location = new System.Drawing.Point(191, 336);
            this.lblAngry1.Name = "lblAngry1";
            this.lblAngry1.Size = new System.Drawing.Size(0, 13);
            this.lblAngry1.TabIndex = 18;
            // 
            // lblLove1
            // 
            this.lblLove1.AutoSize = true;
            this.lblLove1.Location = new System.Drawing.Point(191, 196);
            this.lblLove1.Name = "lblLove1";
            this.lblLove1.Size = new System.Drawing.Size(0, 13);
            this.lblLove1.TabIndex = 14;
            // 
            // lblHaha1
            // 
            this.lblHaha1.AutoSize = true;
            this.lblHaha1.Location = new System.Drawing.Point(191, 266);
            this.lblHaha1.Name = "lblHaha1";
            this.lblHaha1.Size = new System.Drawing.Size(0, 13);
            this.lblHaha1.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(59, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "Wow:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(59, 194);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 16);
            this.label21.TabIndex = 8;
            this.label21.Text = "Love:";
            // 
            // lblWow1
            // 
            this.lblWow1.AutoSize = true;
            this.lblWow1.Location = new System.Drawing.Point(191, 231);
            this.lblWow1.Name = "lblWow1";
            this.lblWow1.Size = new System.Drawing.Size(0, 13);
            this.lblWow1.TabIndex = 15;
            // 
            // lblThankf1
            // 
            this.lblThankf1.AutoSize = true;
            this.lblThankf1.Location = new System.Drawing.Point(191, 371);
            this.lblThankf1.Name = "lblThankf1";
            this.lblThankf1.Size = new System.Drawing.Size(0, 13);
            this.lblThankf1.TabIndex = 19;
            // 
            // lblTotalPosts
            // 
            this.lblTotalPosts.AutoSize = true;
            this.lblTotalPosts.Location = new System.Drawing.Point(172, 77);
            this.lblTotalPosts.Name = "lblTotalPosts";
            this.lblTotalPosts.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPosts.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Total posts:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(42, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 5);
            this.panel3.TabIndex = 21;
            // 
            // lblTotalThanks
            // 
            this.lblTotalThanks.AutoSize = true;
            this.lblTotalThanks.Location = new System.Drawing.Point(172, 322);
            this.lblTotalThanks.Name = "lblTotalThanks";
            this.lblTotalThanks.Size = new System.Drawing.Size(0, 13);
            this.lblTotalThanks.TabIndex = 19;
            // 
            // lblTotalAngry
            // 
            this.lblTotalAngry.AutoSize = true;
            this.lblTotalAngry.Location = new System.Drawing.Point(172, 287);
            this.lblTotalAngry.Name = "lblTotalAngry";
            this.lblTotalAngry.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAngry.TabIndex = 18;
            // 
            // lblTotalSad
            // 
            this.lblTotalSad.AutoSize = true;
            this.lblTotalSad.Location = new System.Drawing.Point(172, 252);
            this.lblTotalSad.Name = "lblTotalSad";
            this.lblTotalSad.Size = new System.Drawing.Size(0, 13);
            this.lblTotalSad.TabIndex = 17;
            // 
            // lblTotalHaha
            // 
            this.lblTotalHaha.AutoSize = true;
            this.lblTotalHaha.Location = new System.Drawing.Point(172, 217);
            this.lblTotalHaha.Name = "lblTotalHaha";
            this.lblTotalHaha.Size = new System.Drawing.Size(0, 13);
            this.lblTotalHaha.TabIndex = 16;
            // 
            // lblTotalWow
            // 
            this.lblTotalWow.AutoSize = true;
            this.lblTotalWow.Location = new System.Drawing.Point(172, 182);
            this.lblTotalWow.Name = "lblTotalWow";
            this.lblTotalWow.Size = new System.Drawing.Size(0, 13);
            this.lblTotalWow.TabIndex = 15;
            // 
            // lblTotalLove
            // 
            this.lblTotalLove.AutoSize = true;
            this.lblTotalLove.Location = new System.Drawing.Point(172, 147);
            this.lblTotalLove.Name = "lblTotalLove";
            this.lblTotalLove.Size = new System.Drawing.Size(0, 13);
            this.lblTotalLove.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thankful:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Angry:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Haha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wow:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Love:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblCount);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.lblTotalPosts);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblTotalLove);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblTotalWow);
            this.panel4.Controls.Add(this.lblTotalThanks);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblTotalHaha);
            this.panel4.Controls.Add(this.lblTotalAngry);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblTotalLikes);
            this.panel4.Controls.Add(this.lblTotalSad);
            this.panel4.Location = new System.Drawing.Point(893, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 368);
            this.panel4.TabIndex = 10;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCount.Location = new System.Drawing.Point(233, 51);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(21, 13);
            this.lblCount.TabIndex = 26;
            this.lblCount.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Updating in:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // tbAppId
            // 
            this.tbAppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAppId.Location = new System.Drawing.Point(505, 35);
            this.tbAppId.Name = "tbAppId";
            this.tbAppId.Size = new System.Drawing.Size(235, 26);
            this.tbAppId.TabIndex = 11;
            // 
            // tbAppSecret
            // 
            this.tbAppSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAppSecret.Location = new System.Drawing.Point(505, 67);
            this.tbAppSecret.Name = "tbAppSecret";
            this.tbAppSecret.Size = new System.Drawing.Size(235, 26);
            this.tbAppSecret.TabIndex = 12;
            // 
            // lblAppId1
            // 
            this.lblAppId1.AutoSize = true;
            this.lblAppId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppId1.Location = new System.Drawing.Point(417, 38);
            this.lblAppId1.Name = "lblAppId1";
            this.lblAppId1.Size = new System.Drawing.Size(70, 20);
            this.lblAppId1.TabIndex = 13;
            this.lblAppId1.Text = "App ID:";
            // 
            // lblAppSecret1
            // 
            this.lblAppSecret1.AutoSize = true;
            this.lblAppSecret1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppSecret1.Location = new System.Drawing.Point(383, 70);
            this.lblAppSecret1.Name = "lblAppSecret1";
            this.lblAppSecret1.Size = new System.Drawing.Size(104, 20);
            this.lblAppSecret1.TabIndex = 14;
            this.lblAppSecret1.Text = "App Secret:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(762, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 58);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 500);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAppSecret1);
            this.Controls.Add(this.lblAppId1);
            this.Controls.Add(this.tbAppSecret);
            this.Controls.Add(this.tbAppId);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbPosts;
        private System.Windows.Forms.Label lblTotalLikes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalThanks;
        private System.Windows.Forms.Label lblTotalAngry;
        private System.Windows.Forms.Label lblTotalSad;
        private System.Windows.Forms.Label lblTotalHaha;
        private System.Windows.Forms.Label lblTotalWow;
        private System.Windows.Forms.Label lblTotalLove;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalPosts;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLove1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblWow1;
        private System.Windows.Forms.Label lblThankf1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblHaha1;
        private System.Windows.Forms.Label lblAngry1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblLikes1;
        private System.Windows.Forms.Label lblSad1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbAppId;
        private System.Windows.Forms.TextBox tbAppSecret;
        private System.Windows.Forms.Label lblAppId1;
        private System.Windows.Forms.Label lblAppSecret1;
        private System.Windows.Forms.Button btnAdd;
    }
}

