
namespace GPS_Calculator_Net_Framework
{
    partial class FormCalc
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDLat = new System.Windows.Forms.TextBox();
            this.textBoxDDLat = new System.Windows.Forms.TextBox();
            this.textBoxDDLong = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxDLong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUTM = new System.Windows.Forms.TextBox();
            this.textBoxMLat = new System.Windows.Forms.TextBox();
            this.textBoxSLat = new System.Windows.Forms.TextBox();
            this.textBoxMLong = new System.Windows.Forms.TextBox();
            this.textBoxSLong = new System.Windows.Forms.TextBox();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.radioButtonS = new System.Windows.Forms.RadioButton();
            this.radioButtonW = new System.Windows.Forms.RadioButton();
            this.radioButtonE = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonDDM = new System.Windows.Forms.RadioButton();
            this.radioButtonUTM = new System.Windows.Forms.RadioButton();
            this.radioButtonDD = new System.Windows.Forms.RadioButton();
            this.radioButtonDMS = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMGRS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDDMLongM = new System.Windows.Forms.TextBox();
            this.textBoxDDMLatM = new System.Windows.Forms.TextBox();
            this.textBoxDDMLongD = new System.Windows.Forms.TextBox();
            this.textBoxDDMLatD = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButtonDDME = new System.Windows.Forms.RadioButton();
            this.radioButtonDDMW = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButtonDDMN = new System.Windows.Forms.RadioButton();
            this.radioButtonDDMS = new System.Windows.Forms.RadioButton();
            this.buttonCopyDMSLat = new System.Windows.Forms.Button();
            this.buttonCopyDMSLong = new System.Windows.Forms.Button();
            this.buttonCopyDDMLat = new System.Windows.Forms.Button();
            this.buttonCopyDDMLong = new System.Windows.Forms.Button();
            this.buttonCopyDDLat = new System.Windows.Forms.Button();
            this.buttonCopyDDLong = new System.Windows.Forms.Button();
            this.buttonCopyUTM = new System.Windows.Forms.Button();
            this.buttonCopyMGRS = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDLat
            // 
            this.textBoxDLat.Location = new System.Drawing.Point(54, 12);
            this.textBoxDLat.Name = "textBoxDLat";
            this.textBoxDLat.ReadOnly = true;
            this.textBoxDLat.Size = new System.Drawing.Size(91, 20);
            this.textBoxDLat.TabIndex = 0;
            this.textBoxDLat.Text = "DD";
            // 
            // textBoxDDLat
            // 
            this.textBoxDDLat.Location = new System.Drawing.Point(54, 162);
            this.textBoxDDLat.Name = "textBoxDDLat";
            this.textBoxDDLat.ReadOnly = true;
            this.textBoxDDLat.Size = new System.Drawing.Size(281, 20);
            this.textBoxDDLat.TabIndex = 10;
            this.textBoxDDLat.Text = "DD.DDDDDD  ";
            // 
            // textBoxDDLong
            // 
            this.textBoxDDLong.Location = new System.Drawing.Point(54, 187);
            this.textBoxDDLong.Name = "textBoxDDLong";
            this.textBoxDDLong.ReadOnly = true;
            this.textBoxDDLong.Size = new System.Drawing.Size(281, 20);
            this.textBoxDDLong.TabIndex = 11;
            this.textBoxDDLong.Text = "DD.DDDDDD  ";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(12, 359);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(90, 39);
            this.buttonCalc.TabIndex = 14;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxDLong
            // 
            this.textBoxDLong.Location = new System.Drawing.Point(54, 37);
            this.textBoxDLong.Name = "textBoxDLong";
            this.textBoxDLong.ReadOnly = true;
            this.textBoxDLong.Size = new System.Drawing.Size(91, 20);
            this.textBoxDLong.TabIndex = 5;
            this.textBoxDLong.Text = "DD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DMS Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DMS Longitude";
            // 
            // textBoxUTM
            // 
            this.textBoxUTM.Location = new System.Drawing.Point(54, 242);
            this.textBoxUTM.Name = "textBoxUTM";
            this.textBoxUTM.ReadOnly = true;
            this.textBoxUTM.Size = new System.Drawing.Size(281, 20);
            this.textBoxUTM.TabIndex = 12;
            this.textBoxUTM.Text = "ZZZ EEEEEE NNNNNN";
            // 
            // textBoxMLat
            // 
            this.textBoxMLat.Location = new System.Drawing.Point(149, 11);
            this.textBoxMLat.Name = "textBoxMLat";
            this.textBoxMLat.ReadOnly = true;
            this.textBoxMLat.Size = new System.Drawing.Size(91, 20);
            this.textBoxMLat.TabIndex = 1;
            this.textBoxMLat.Text = "MM";
            // 
            // textBoxSLat
            // 
            this.textBoxSLat.Location = new System.Drawing.Point(245, 11);
            this.textBoxSLat.Name = "textBoxSLat";
            this.textBoxSLat.ReadOnly = true;
            this.textBoxSLat.Size = new System.Drawing.Size(91, 20);
            this.textBoxSLat.TabIndex = 2;
            this.textBoxSLat.Text = "SS.SSSS";
            // 
            // textBoxMLong
            // 
            this.textBoxMLong.Location = new System.Drawing.Point(149, 37);
            this.textBoxMLong.Name = "textBoxMLong";
            this.textBoxMLong.ReadOnly = true;
            this.textBoxMLong.Size = new System.Drawing.Size(91, 20);
            this.textBoxMLong.TabIndex = 6;
            this.textBoxMLong.Text = "MM";
            // 
            // textBoxSLong
            // 
            this.textBoxSLong.Location = new System.Drawing.Point(245, 37);
            this.textBoxSLong.Name = "textBoxSLong";
            this.textBoxSLong.ReadOnly = true;
            this.textBoxSLong.Size = new System.Drawing.Size(91, 20);
            this.textBoxSLong.TabIndex = 7;
            this.textBoxSLong.Text = "SS.SSSS";
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.Checked = true;
            this.radioButtonN.Location = new System.Drawing.Point(3, 1);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.Size = new System.Drawing.Size(33, 17);
            this.radioButtonN.TabIndex = 3;
            this.radioButtonN.TabStop = true;
            this.radioButtonN.Text = "N";
            this.radioButtonN.UseVisualStyleBackColor = true;
            // 
            // radioButtonS
            // 
            this.radioButtonS.AutoSize = true;
            this.radioButtonS.Location = new System.Drawing.Point(38, 1);
            this.radioButtonS.Name = "radioButtonS";
            this.radioButtonS.Size = new System.Drawing.Size(32, 17);
            this.radioButtonS.TabIndex = 4;
            this.radioButtonS.Text = "S";
            this.radioButtonS.UseVisualStyleBackColor = true;
            // 
            // radioButtonW
            // 
            this.radioButtonW.AutoSize = true;
            this.radioButtonW.Checked = true;
            this.radioButtonW.Location = new System.Drawing.Point(38, 1);
            this.radioButtonW.Name = "radioButtonW";
            this.radioButtonW.Size = new System.Drawing.Size(36, 17);
            this.radioButtonW.TabIndex = 9;
            this.radioButtonW.TabStop = true;
            this.radioButtonW.Text = "W";
            this.radioButtonW.UseVisualStyleBackColor = true;
            // 
            // radioButtonE
            // 
            this.radioButtonE.AutoSize = true;
            this.radioButtonE.Location = new System.Drawing.Point(3, 1);
            this.radioButtonE.Name = "radioButtonE";
            this.radioButtonE.Size = new System.Drawing.Size(32, 17);
            this.radioButtonE.TabIndex = 8;
            this.radioButtonE.Text = "E";
            this.radioButtonE.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DD Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "DD Latitude";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonN);
            this.panel1.Controls.Add(this.radioButtonS);
            this.panel1.Location = new System.Drawing.Point(340, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 21);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonE);
            this.panel2.Controls.Add(this.radioButtonW);
            this.panel2.Location = new System.Drawing.Point(340, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 19);
            this.panel2.TabIndex = 21;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(44, 1);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 19);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "S";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonDDM);
            this.panel3.Controls.Add(this.radioButtonUTM);
            this.panel3.Controls.Add(this.radioButtonDD);
            this.panel3.Controls.Add(this.radioButtonDMS);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 341);
            this.panel3.TabIndex = 22;
            // 
            // radioButtonDDM
            // 
            this.radioButtonDDM.AutoSize = true;
            this.radioButtonDDM.Location = new System.Drawing.Point(11, 76);
            this.radioButtonDDM.Name = "radioButtonDDM";
            this.radioButtonDDM.Size = new System.Drawing.Size(14, 13);
            this.radioButtonDDM.TabIndex = 4;
            this.radioButtonDDM.UseVisualStyleBackColor = true;
            this.radioButtonDDM.CheckedChanged += new System.EventHandler(this.radioButtonDDM_CheckedChanged);
            // 
            // radioButtonUTM
            // 
            this.radioButtonUTM.AutoSize = true;
            this.radioButtonUTM.Location = new System.Drawing.Point(11, 232);
            this.radioButtonUTM.Name = "radioButtonUTM";
            this.radioButtonUTM.Size = new System.Drawing.Size(14, 13);
            this.radioButtonUTM.TabIndex = 2;
            this.radioButtonUTM.UseVisualStyleBackColor = true;
            this.radioButtonUTM.CheckedChanged += new System.EventHandler(this.radioButtonUTM_CheckedChanged);
            // 
            // radioButtonDD
            // 
            this.radioButtonDD.AutoSize = true;
            this.radioButtonDD.Location = new System.Drawing.Point(11, 157);
            this.radioButtonDD.Name = "radioButtonDD";
            this.radioButtonDD.Size = new System.Drawing.Size(14, 13);
            this.radioButtonDD.TabIndex = 1;
            this.radioButtonDD.UseVisualStyleBackColor = true;
            this.radioButtonDD.CheckedChanged += new System.EventHandler(this.radioButtonDD_CheckedChanged);
            // 
            // radioButtonDMS
            // 
            this.radioButtonDMS.AutoSize = true;
            this.radioButtonDMS.Location = new System.Drawing.Point(11, 2);
            this.radioButtonDMS.Name = "radioButtonDMS";
            this.radioButtonDMS.Size = new System.Drawing.Size(14, 13);
            this.radioButtonDMS.TabIndex = 0;
            this.radioButtonDMS.UseVisualStyleBackColor = true;
            this.radioButtonDMS.CheckedChanged += new System.EventHandler(this.radioButtonDMS_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "UTM";
            // 
            // textBoxMGRS
            // 
            this.textBoxMGRS.Location = new System.Drawing.Point(54, 294);
            this.textBoxMGRS.Name = "textBoxMGRS";
            this.textBoxMGRS.ReadOnly = true;
            this.textBoxMGRS.Size = new System.Drawing.Size(281, 20);
            this.textBoxMGRS.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "MGRS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "DDM Longitude";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "DDM Latitude";
            // 
            // textBoxDDMLongM
            // 
            this.textBoxDDMLongM.Location = new System.Drawing.Point(149, 110);
            this.textBoxDDMLongM.Name = "textBoxDDMLongM";
            this.textBoxDDMLongM.ReadOnly = true;
            this.textBoxDDMLongM.Size = new System.Drawing.Size(91, 20);
            this.textBoxDDMLongM.TabIndex = 33;
            this.textBoxDDMLongM.Text = "MM.MMMM";
            // 
            // textBoxDDMLatM
            // 
            this.textBoxDDMLatM.Location = new System.Drawing.Point(149, 84);
            this.textBoxDDMLatM.Name = "textBoxDDMLatM";
            this.textBoxDDMLatM.ReadOnly = true;
            this.textBoxDDMLatM.Size = new System.Drawing.Size(91, 20);
            this.textBoxDDMLatM.TabIndex = 31;
            this.textBoxDDMLatM.Text = "MM.MMMM";
            // 
            // textBoxDDMLongD
            // 
            this.textBoxDDMLongD.Location = new System.Drawing.Point(54, 110);
            this.textBoxDDMLongD.Name = "textBoxDDMLongD";
            this.textBoxDDMLongD.ReadOnly = true;
            this.textBoxDDMLongD.Size = new System.Drawing.Size(91, 20);
            this.textBoxDDMLongD.TabIndex = 32;
            this.textBoxDDMLongD.Text = "DD";
            // 
            // textBoxDDMLatD
            // 
            this.textBoxDDMLatD.Location = new System.Drawing.Point(54, 85);
            this.textBoxDDMLatD.Name = "textBoxDDMLatD";
            this.textBoxDDMLatD.ReadOnly = true;
            this.textBoxDDMLatD.Size = new System.Drawing.Size(91, 20);
            this.textBoxDDMLatD.TabIndex = 30;
            this.textBoxDDMLatD.Text = "DD";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButtonDDME);
            this.panel4.Controls.Add(this.radioButtonDDMW);
            this.panel4.Location = new System.Drawing.Point(338, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(76, 19);
            this.panel4.TabIndex = 23;
            // 
            // radioButtonDDME
            // 
            this.radioButtonDDME.AutoSize = true;
            this.radioButtonDDME.Location = new System.Drawing.Point(3, 1);
            this.radioButtonDDME.Name = "radioButtonDDME";
            this.radioButtonDDME.Size = new System.Drawing.Size(32, 17);
            this.radioButtonDDME.TabIndex = 8;
            this.radioButtonDDME.Text = "E";
            this.radioButtonDDME.UseVisualStyleBackColor = true;
            // 
            // radioButtonDDMW
            // 
            this.radioButtonDDMW.AutoSize = true;
            this.radioButtonDDMW.Checked = true;
            this.radioButtonDDMW.Location = new System.Drawing.Point(38, 1);
            this.radioButtonDDMW.Name = "radioButtonDDMW";
            this.radioButtonDDMW.Size = new System.Drawing.Size(36, 17);
            this.radioButtonDDMW.TabIndex = 9;
            this.radioButtonDDMW.TabStop = true;
            this.radioButtonDDMW.Text = "W";
            this.radioButtonDDMW.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButtonDDMN);
            this.panel5.Controls.Add(this.radioButtonDDMS);
            this.panel5.Location = new System.Drawing.Point(338, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(76, 21);
            this.panel5.TabIndex = 22;
            // 
            // radioButtonDDMN
            // 
            this.radioButtonDDMN.AutoSize = true;
            this.radioButtonDDMN.Checked = true;
            this.radioButtonDDMN.Location = new System.Drawing.Point(3, 1);
            this.radioButtonDDMN.Name = "radioButtonDDMN";
            this.radioButtonDDMN.Size = new System.Drawing.Size(33, 17);
            this.radioButtonDDMN.TabIndex = 3;
            this.radioButtonDDMN.TabStop = true;
            this.radioButtonDDMN.Text = "N";
            this.radioButtonDDMN.UseVisualStyleBackColor = true;
            // 
            // radioButtonDDMS
            // 
            this.radioButtonDDMS.AutoSize = true;
            this.radioButtonDDMS.Location = new System.Drawing.Point(38, 1);
            this.radioButtonDDMS.Name = "radioButtonDDMS";
            this.radioButtonDDMS.Size = new System.Drawing.Size(32, 17);
            this.radioButtonDDMS.TabIndex = 4;
            this.radioButtonDDMS.Text = "S";
            this.radioButtonDDMS.UseVisualStyleBackColor = true;
            // 
            // buttonCopyDMSLat
            // 
            this.buttonCopyDMSLat.Location = new System.Drawing.Point(518, 9);
            this.buttonCopyDMSLat.Name = "buttonCopyDMSLat";
            this.buttonCopyDMSLat.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyDMSLat.TabIndex = 34;
            this.buttonCopyDMSLat.Text = "Copy";
            this.buttonCopyDMSLat.UseVisualStyleBackColor = true;
            this.buttonCopyDMSLat.Click += new System.EventHandler(this.buttonCopyDMSLat_Click);
            // 
            // buttonCopyDMSLong
            // 
            this.buttonCopyDMSLong.Location = new System.Drawing.Point(518, 35);
            this.buttonCopyDMSLong.Name = "buttonCopyDMSLong";
            this.buttonCopyDMSLong.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyDMSLong.TabIndex = 35;
            this.buttonCopyDMSLong.Text = "Copy";
            this.buttonCopyDMSLong.UseVisualStyleBackColor = true;
            this.buttonCopyDMSLong.Click += new System.EventHandler(this.buttonCopyDMSLong_Click);
            // 
            // buttonCopyDDMLat
            // 
            this.buttonCopyDDMLat.Location = new System.Drawing.Point(518, 80);
            this.buttonCopyDDMLat.Name = "buttonCopyDDMLat";
            this.buttonCopyDDMLat.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyDDMLat.TabIndex = 36;
            this.buttonCopyDDMLat.Text = "Copy";
            this.buttonCopyDDMLat.UseVisualStyleBackColor = true;
            this.buttonCopyDDMLat.Click += new System.EventHandler(this.buttonCopyDDMLat_Click);
            // 
            // buttonCopyDDMLong
            // 
            this.buttonCopyDDMLong.Location = new System.Drawing.Point(518, 105);
            this.buttonCopyDDMLong.Name = "buttonCopyDDMLong";
            this.buttonCopyDDMLong.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyDDMLong.TabIndex = 37;
            this.buttonCopyDDMLong.Text = "Copy";
            this.buttonCopyDDMLong.UseVisualStyleBackColor = true;
            this.buttonCopyDDMLong.Click += new System.EventHandler(this.buttonCopyDDMLong_Click);
            // 
            // buttonCopyDDLat
            // 
            this.buttonCopyDDLat.Location = new System.Drawing.Point(518, 159);
            this.buttonCopyDDLat.Name = "buttonCopyDDLat";
            this.buttonCopyDDLat.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyDDLat.TabIndex = 38;
            this.buttonCopyDDLat.Text = "Copy";
            this.buttonCopyDDLat.UseVisualStyleBackColor = true;
            this.buttonCopyDDLat.Click += new System.EventHandler(this.buttonCopyDDLat_Click);
            // 
            // buttonCopyDDLong
            // 
            this.buttonCopyDDLong.Location = new System.Drawing.Point(518, 184);
            this.buttonCopyDDLong.Name = "buttonCopyDDLong";
            this.buttonCopyDDLong.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyDDLong.TabIndex = 39;
            this.buttonCopyDDLong.Text = "Copy";
            this.buttonCopyDDLong.UseVisualStyleBackColor = true;
            this.buttonCopyDDLong.Click += new System.EventHandler(this.buttonCopyDDLong_Click);
            // 
            // buttonCopyUTM
            // 
            this.buttonCopyUTM.Location = new System.Drawing.Point(518, 239);
            this.buttonCopyUTM.Name = "buttonCopyUTM";
            this.buttonCopyUTM.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyUTM.TabIndex = 40;
            this.buttonCopyUTM.Text = "Copy";
            this.buttonCopyUTM.UseVisualStyleBackColor = true;
            this.buttonCopyUTM.Click += new System.EventHandler(this.buttonCopyUTM_Click);
            // 
            // buttonCopyMGRS
            // 
            this.buttonCopyMGRS.Location = new System.Drawing.Point(518, 292);
            this.buttonCopyMGRS.Name = "buttonCopyMGRS";
            this.buttonCopyMGRS.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyMGRS.TabIndex = 41;
            this.buttonCopyMGRS.Text = "Copy";
            this.buttonCopyMGRS.UseVisualStyleBackColor = true;
            this.buttonCopyMGRS.Click += new System.EventHandler(this.buttonCopyMGRS_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(503, 359);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 39);
            this.buttonClear.TabIndex = 42;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 422);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCopyMGRS);
            this.Controls.Add(this.buttonCopyUTM);
            this.Controls.Add(this.buttonCopyDDLong);
            this.Controls.Add(this.buttonCopyDDLat);
            this.Controls.Add(this.buttonCopyDDMLong);
            this.Controls.Add(this.buttonCopyDDMLat);
            this.Controls.Add(this.buttonCopyDMSLong);
            this.Controls.Add(this.buttonCopyDMSLat);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxDDMLongM);
            this.Controls.Add(this.textBoxDDMLatM);
            this.Controls.Add(this.textBoxDDMLongD);
            this.Controls.Add(this.textBoxDDMLatD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMGRS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSLong);
            this.Controls.Add(this.textBoxMLong);
            this.Controls.Add(this.textBoxSLat);
            this.Controls.Add(this.textBoxMLat);
            this.Controls.Add(this.textBoxUTM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDLong);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxDDLong);
            this.Controls.Add(this.textBoxDDLat);
            this.Controls.Add(this.textBoxDLat);
            this.Name = "FormCalc";
            this.Text = "GPS Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDLat;
        private System.Windows.Forms.TextBox textBoxDDLat;
        private System.Windows.Forms.TextBox textBoxDDLong;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxDLong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMLat;
        private System.Windows.Forms.TextBox textBoxSLat;
        private System.Windows.Forms.TextBox textBoxMLong;
        private System.Windows.Forms.TextBox textBoxSLong;
        private System.Windows.Forms.RadioButton radioButtonN;
        private System.Windows.Forms.RadioButton radioButtonS;
        private System.Windows.Forms.RadioButton radioButtonW;
        private System.Windows.Forms.RadioButton radioButtonE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonUTM;
        private System.Windows.Forms.RadioButton radioButtonDD;
        private System.Windows.Forms.RadioButton radioButtonDMS;
        private System.Windows.Forms.TextBox textBoxUTM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMGRS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonDDM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDDMLongM;
        private System.Windows.Forms.TextBox textBoxDDMLatM;
        private System.Windows.Forms.TextBox textBoxDDMLongD;
        private System.Windows.Forms.TextBox textBoxDDMLatD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButtonDDME;
        private System.Windows.Forms.RadioButton radioButtonDDMW;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButtonDDMN;
        private System.Windows.Forms.RadioButton radioButtonDDMS;
        private System.Windows.Forms.Button buttonCopyDMSLat;
        private System.Windows.Forms.Button buttonCopyDMSLong;
        private System.Windows.Forms.Button buttonCopyDDMLat;
        private System.Windows.Forms.Button buttonCopyDDMLong;
        private System.Windows.Forms.Button buttonCopyDDLat;
        private System.Windows.Forms.Button buttonCopyDDLong;
        private System.Windows.Forms.Button buttonCopyUTM;
        private System.Windows.Forms.Button buttonCopyMGRS;
        private System.Windows.Forms.Button buttonClear;
    }
}
