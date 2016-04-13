namespace FolderSync
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
            this.PanelWait = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnalyzing = new System.Windows.Forms.Label();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.PanelMatchingFolders = new System.Windows.Forms.Panel();
            this.lblMatchesLeft = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProgressMatching = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.checkGreen2 = new System.Windows.Forms.PictureBox();
            this.checkGreen1 = new System.Windows.Forms.PictureBox();
            this.lblTotalFolders = new System.Windows.Forms.Label();
            this.lblTargetFolders = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCurrentTarget = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PanelFolderSync = new System.Windows.Forms.Panel();
            this.PanelSync = new System.Windows.Forms.Panel();
            this.lblSyncing = new System.Windows.Forms.Label();
            this.ProgressSync = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LinkSelectAll3 = new System.Windows.Forms.LinkLabel();
            this.LinkSelectAll2 = new System.Windows.Forms.LinkLabel();
            this.LinkSelectAll1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.ListChangedFiles = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListAdd2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListAdd1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelActions = new System.Windows.Forms.Panel();
            this.checkChangedFolders = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.PanelWait.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelMatchingFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkGreen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGreen1)).BeginInit();
            this.PanelFolderSync.SuspendLayout();
            this.PanelSync.SuspendLayout();
            this.PanelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelWait
            // 
            this.PanelWait.Controls.Add(this.panel1);
            this.PanelWait.Controls.Add(this.btnNextStep);
            this.PanelWait.Controls.Add(this.PanelMatchingFolders);
            this.PanelWait.Controls.Add(this.checkGreen1);
            this.PanelWait.Controls.Add(this.lblTotalFolders);
            this.PanelWait.Controls.Add(this.lblTargetFolders);
            this.PanelWait.Controls.Add(this.label13);
            this.PanelWait.Controls.Add(this.lblCurrentTarget);
            this.PanelWait.Controls.Add(this.label12);
            this.PanelWait.Controls.Add(this.label11);
            this.PanelWait.Controls.Add(this.label10);
            this.PanelWait.Controls.Add(this.label9);
            this.PanelWait.Location = new System.Drawing.Point(0, 0);
            this.PanelWait.Name = "PanelWait";
            this.PanelWait.Size = new System.Drawing.Size(1049, 809);
            this.PanelWait.TabIndex = 20;
            this.PanelWait.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lblAnalyzing);
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 350);
            this.panel1.TabIndex = 15;
            // 
            // lblAnalyzing
            // 
            this.lblAnalyzing.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalyzing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAnalyzing.Location = new System.Drawing.Point(15, 16);
            this.lblAnalyzing.Name = "lblAnalyzing";
            this.lblAnalyzing.Size = new System.Drawing.Size(997, 334);
            this.lblAnalyzing.TabIndex = 14;
            this.lblAnalyzing.Text = "7:35:08 > Start Analyzing...";
            // 
            // btnNextStep
            // 
            this.btnNextStep.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStep.ForeColor = System.Drawing.Color.White;
            this.btnNextStep.Location = new System.Drawing.Point(437, 379);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(120, 38);
            this.btnNextStep.TabIndex = 14;
            this.btnNextStep.Text = "Next Step";
            this.btnNextStep.UseVisualStyleBackColor = false;
            this.btnNextStep.Visible = false;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // PanelMatchingFolders
            // 
            this.PanelMatchingFolders.Controls.Add(this.lblMatchesLeft);
            this.PanelMatchingFolders.Controls.Add(this.label8);
            this.PanelMatchingFolders.Controls.Add(this.ProgressMatching);
            this.PanelMatchingFolders.Controls.Add(this.label7);
            this.PanelMatchingFolders.Controls.Add(this.checkGreen2);
            this.PanelMatchingFolders.Location = new System.Drawing.Point(313, 311);
            this.PanelMatchingFolders.Name = "PanelMatchingFolders";
            this.PanelMatchingFolders.Size = new System.Drawing.Size(390, 52);
            this.PanelMatchingFolders.TabIndex = 12;
            this.PanelMatchingFolders.Visible = false;
            // 
            // lblMatchesLeft
            // 
            this.lblMatchesLeft.AutoSize = true;
            this.lblMatchesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchesLeft.Location = new System.Drawing.Point(134, 29);
            this.lblMatchesLeft.Name = "lblMatchesLeft";
            this.lblMatchesLeft.Size = new System.Drawing.Size(16, 17);
            this.lblMatchesLeft.TabIndex = 16;
            this.lblMatchesLeft.Text = "0";
            this.lblMatchesLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Matches Left";
            // 
            // ProgressMatching
            // 
            this.ProgressMatching.Location = new System.Drawing.Point(255, -2);
            this.ProgressMatching.Name = "ProgressMatching";
            this.ProgressMatching.Size = new System.Drawing.Size(130, 23);
            this.ProgressMatching.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Matching Folder Structures";
            // 
            // checkGreen2
            // 
            this.checkGreen2.Image = global::FolderSync.Properties.Resources.check_green;
            this.checkGreen2.Location = new System.Drawing.Point(1, 0);
            this.checkGreen2.Name = "checkGreen2";
            this.checkGreen2.Size = new System.Drawing.Size(33, 29);
            this.checkGreen2.TabIndex = 12;
            this.checkGreen2.TabStop = false;
            // 
            // checkGreen1
            // 
            this.checkGreen1.Image = global::FolderSync.Properties.Resources.check_green;
            this.checkGreen1.Location = new System.Drawing.Point(313, 263);
            this.checkGreen1.Name = "checkGreen1";
            this.checkGreen1.Size = new System.Drawing.Size(33, 29);
            this.checkGreen1.TabIndex = 8;
            this.checkGreen1.TabStop = false;
            // 
            // lblTotalFolders
            // 
            this.lblTotalFolders.AutoSize = true;
            this.lblTotalFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFolders.Location = new System.Drawing.Point(461, 268);
            this.lblTotalFolders.Name = "lblTotalFolders";
            this.lblTotalFolders.Size = new System.Drawing.Size(16, 17);
            this.lblTotalFolders.TabIndex = 7;
            this.lblTotalFolders.Text = "0";
            // 
            // lblTargetFolders
            // 
            this.lblTargetFolders.AutoSize = true;
            this.lblTargetFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetFolders.Location = new System.Drawing.Point(461, 236);
            this.lblTargetFolders.Name = "lblTargetFolders";
            this.lblTargetFolders.Size = new System.Drawing.Size(16, 17);
            this.lblTargetFolders.TabIndex = 6;
            this.lblTargetFolders.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(352, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Folders";
            // 
            // lblCurrentTarget
            // 
            this.lblCurrentTarget.AutoSize = true;
            this.lblCurrentTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTarget.Location = new System.Drawing.Point(461, 206);
            this.lblCurrentTarget.Name = "lblCurrentTarget";
            this.lblCurrentTarget.Size = new System.Drawing.Size(16, 17);
            this.lblCurrentTarget.TabIndex = 4;
            this.lblCurrentTarget.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(352, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Current Target";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(352, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Target Folders";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(348, 31);
            this.label10.TabIndex = 1;
            this.label10.Text = "Analyzing Folder Structures";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Please Wait...";
            // 
            // PanelFolderSync
            // 
            this.PanelFolderSync.Controls.Add(this.PanelSync);
            this.PanelFolderSync.Controls.Add(this.label15);
            this.PanelFolderSync.Controls.Add(this.panel2);
            this.PanelFolderSync.Controls.Add(this.LinkSelectAll3);
            this.PanelFolderSync.Controls.Add(this.LinkSelectAll2);
            this.PanelFolderSync.Controls.Add(this.LinkSelectAll1);
            this.PanelFolderSync.Controls.Add(this.label14);
            this.PanelFolderSync.Controls.Add(this.ListChangedFiles);
            this.PanelFolderSync.Controls.Add(this.button4);
            this.PanelFolderSync.Controls.Add(this.button3);
            this.PanelFolderSync.Controls.Add(this.label5);
            this.PanelFolderSync.Controls.Add(this.label6);
            this.PanelFolderSync.Controls.Add(this.label4);
            this.PanelFolderSync.Controls.Add(this.label3);
            this.PanelFolderSync.Controls.Add(this.ListAdd2);
            this.PanelFolderSync.Controls.Add(this.ListAdd1);
            this.PanelFolderSync.Controls.Add(this.lblTotal2);
            this.PanelFolderSync.Controls.Add(this.lblTotal1);
            this.PanelFolderSync.Controls.Add(this.label2);
            this.PanelFolderSync.Controls.Add(this.label1);
            this.PanelFolderSync.Controls.Add(this.textBox2);
            this.PanelFolderSync.Controls.Add(this.textBox1);
            this.PanelFolderSync.Controls.Add(this.PanelActions);
            this.PanelFolderSync.Location = new System.Drawing.Point(2, 1);
            this.PanelFolderSync.Name = "PanelFolderSync";
            this.PanelFolderSync.Size = new System.Drawing.Size(1049, 806);
            this.PanelFolderSync.TabIndex = 21;
            // 
            // PanelSync
            // 
            this.PanelSync.Controls.Add(this.lblSyncing);
            this.PanelSync.Controls.Add(this.ProgressSync);
            this.PanelSync.Location = new System.Drawing.Point(-2, 732);
            this.PanelSync.Name = "PanelSync";
            this.PanelSync.Size = new System.Drawing.Size(1046, 71);
            this.PanelSync.TabIndex = 30;
            this.PanelSync.Visible = false;
            // 
            // lblSyncing
            // 
            this.lblSyncing.AutoSize = true;
            this.lblSyncing.Location = new System.Drawing.Point(12, 10);
            this.lblSyncing.Name = "lblSyncing";
            this.lblSyncing.Size = new System.Drawing.Size(54, 13);
            this.lblSyncing.TabIndex = 1;
            this.lblSyncing.Text = "Syncing...";
            // 
            // ProgressSync
            // 
            this.ProgressSync.Location = new System.Drawing.Point(12, 28);
            this.ProgressSync.Name = "ProgressSync";
            this.ProgressSync.Size = new System.Drawing.Size(1013, 23);
            this.ProgressSync.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(483, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 22);
            this.label15.TabIndex = 40;
            this.label15.Text = ">>";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(515, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 800);
            this.panel2.TabIndex = 39;
            // 
            // LinkSelectAll3
            // 
            this.LinkSelectAll3.AutoSize = true;
            this.LinkSelectAll3.Location = new System.Drawing.Point(935, 461);
            this.LinkSelectAll3.Name = "LinkSelectAll3";
            this.LinkSelectAll3.Size = new System.Drawing.Size(88, 13);
            this.LinkSelectAll3.TabIndex = 38;
            this.LinkSelectAll3.TabStop = true;
            this.LinkSelectAll3.Text = "Select All / None";
            this.LinkSelectAll3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSelectAll3_LinkClicked);
            // 
            // LinkSelectAll2
            // 
            this.LinkSelectAll2.AutoSize = true;
            this.LinkSelectAll2.Location = new System.Drawing.Point(935, 106);
            this.LinkSelectAll2.Name = "LinkSelectAll2";
            this.LinkSelectAll2.Size = new System.Drawing.Size(88, 13);
            this.LinkSelectAll2.TabIndex = 37;
            this.LinkSelectAll2.TabStop = true;
            this.LinkSelectAll2.Text = "Select All / None";
            this.LinkSelectAll2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSelectAll2_LinkClicked);
            // 
            // LinkSelectAll1
            // 
            this.LinkSelectAll1.AutoSize = true;
            this.LinkSelectAll1.Location = new System.Drawing.Point(398, 104);
            this.LinkSelectAll1.Name = "LinkSelectAll1";
            this.LinkSelectAll1.Size = new System.Drawing.Size(88, 13);
            this.LinkSelectAll1.TabIndex = 36;
            this.LinkSelectAll1.TabStop = true;
            this.LinkSelectAll1.Text = "Select All / None";
            this.LinkSelectAll1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSelectAll1_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(541, 457);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "Add Changed Files";
            // 
            // ListChangedFiles
            // 
            this.ListChangedFiles.CheckBoxes = true;
            this.ListChangedFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.ListChangedFiles.Location = new System.Drawing.Point(547, 480);
            this.ListChangedFiles.Name = "ListChangedFiles";
            this.ListChangedFiles.Size = new System.Drawing.Size(476, 250);
            this.ListChangedFiles.TabIndex = 34;
            this.ListChangedFiles.UseCompatibleStateImageBehavior = false;
            this.ListChangedFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Folder Path";
            this.columnHeader3.Width = 1000;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(970, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Backup Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Live Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Add Missing Folders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Add Missing Folders";
            // 
            // ListAdd2
            // 
            this.ListAdd2.CheckBoxes = true;
            this.ListAdd2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.ListAdd2.Location = new System.Drawing.Point(547, 124);
            this.ListAdd2.Name = "ListAdd2";
            this.ListAdd2.Size = new System.Drawing.Size(476, 322);
            this.ListAdd2.TabIndex = 25;
            this.ListAdd2.UseCompatibleStateImageBehavior = false;
            this.ListAdd2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Folder Path";
            this.columnHeader2.Width = 1000;
            // 
            // ListAdd1
            // 
            this.ListAdd1.CheckBoxes = true;
            this.ListAdd1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListAdd1.Location = new System.Drawing.Point(10, 124);
            this.ListAdd1.Name = "ListAdd1";
            this.ListAdd1.Size = new System.Drawing.Size(476, 606);
            this.ListAdd1.TabIndex = 24;
            this.ListAdd1.UseCompatibleStateImageBehavior = false;
            this.ListAdd1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Folder Path";
            this.columnHeader1.Width = 1000;
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(615, 70);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(13, 13);
            this.lblTotal2.TabIndex = 23;
            this.lblTotal2.Text = "0";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(78, 70);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(13, 13);
            this.lblTotal1.TabIndex = 22;
            this.lblTotal1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total Folders: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Folders: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(547, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(420, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "F:\\";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "D:\\";
            // 
            // PanelActions
            // 
            this.PanelActions.Controls.Add(this.checkChangedFolders);
            this.PanelActions.Controls.Add(this.button1);
            this.PanelActions.Controls.Add(this.button2);
            this.PanelActions.Location = new System.Drawing.Point(-2, 732);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(1050, 70);
            this.PanelActions.TabIndex = 31;
            // 
            // checkChangedFolders
            // 
            this.checkChangedFolders.AutoSize = true;
            this.checkChangedFolders.Location = new System.Drawing.Point(136, 25);
            this.checkChangedFolders.Name = "checkChangedFolders";
            this.checkChangedFolders.Size = new System.Drawing.Size(136, 17);
            this.checkChangedFolders.TabIndex = 20;
            this.checkChangedFolders.Text = "Check for File Changes";
            this.checkChangedFolders.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Analyze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(932, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sync";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 800);
            this.Controls.Add(this.PanelFolderSync);
            this.Controls.Add(this.PanelWait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Folder Sync";
            this.PanelWait.ResumeLayout(false);
            this.PanelWait.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelMatchingFolders.ResumeLayout(false);
            this.PanelMatchingFolders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkGreen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGreen1)).EndInit();
            this.PanelFolderSync.ResumeLayout(false);
            this.PanelFolderSync.PerformLayout();
            this.PanelSync.ResumeLayout(false);
            this.PanelSync.PerformLayout();
            this.PanelActions.ResumeLayout(false);
            this.PanelActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelWait;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalFolders;
        private System.Windows.Forms.Label lblTargetFolders;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCurrentTarget;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel PanelFolderSync;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListAdd2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView ListAdd1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelSync;
        private System.Windows.Forms.Label lblSyncing;
        private System.Windows.Forms.ProgressBar ProgressSync;
        private System.Windows.Forms.PictureBox checkGreen1;
        private System.Windows.Forms.Panel PanelMatchingFolders;
        private System.Windows.Forms.ProgressBar ProgressMatching;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox checkGreen2;
        private System.Windows.Forms.Panel PanelActions;
        private System.Windows.Forms.CheckBox checkChangedFolders;
        private System.Windows.Forms.Label lblMatchesLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAnalyzing;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView ListChangedFiles;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.LinkLabel LinkSelectAll3;
        private System.Windows.Forms.LinkLabel LinkSelectAll2;
        private System.Windows.Forms.LinkLabel LinkSelectAll1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
    }
}

