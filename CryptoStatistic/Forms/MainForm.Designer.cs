using CryptoStatistic.Components;

namespace CryptoStatistic.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UpdateButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BasePlot = new IncomePlot();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Label_Week_Expected = new System.Windows.Forms.Label();
            this.Label_Week_Aver = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Label_Day_Expected = new System.Windows.Forms.Label();
            this.Label_Day_Aver = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Label_All_Trend = new System.Windows.Forms.Label();
            this.Label_All_Income = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Label_Week_Trend = new System.Windows.Forms.Label();
            this.Label_Week_Income = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_Day_Trend = new System.Windows.Forms.Label();
            this.Label_Day_Income = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.Label_Hour_Month_Median = new System.Windows.Forms.Label();
            this.Label_Hour_Month_Average = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.Label_Hour_Week_Median = new System.Windows.Forms.Label();
            this.Label_Hour_Week_Average = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.Label_Full_Month_Median = new System.Windows.Forms.Label();
            this.Label_Full_Month_Average = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.Label_Full_Week_Median = new System.Windows.Forms.Label();
            this.Label_Full_Week_Average = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.Label_Hour_Day_Median = new System.Windows.Forms.Label();
            this.Label_Hour_Day_Average = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.Label_Full_Day_Median = new System.Windows.Forms.Label();
            this.Label_Full_Day_Average = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(492, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(90, 23);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 302);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Controls.Add(this.BasePlot);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(578, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "График";
            // 
            // BasePlot
            // 
            this.BasePlot.BackColor = System.Drawing.SystemColors.Control;
            this.BasePlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePlot.Location = new System.Drawing.Point(3, 3);
            this.BasePlot.Name = "BasePlot";
            this.BasePlot.Size = new System.Drawing.Size(572, 270);
            this.BasePlot.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel10);
            this.tabPage2.Controls.Add(this.panel11);
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(578, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика";
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.Label_Week_Expected);
            this.panel10.Controls.Add(this.Label_Week_Aver);
            this.panel10.Controls.Add(this.label21);
            this.panel10.Location = new System.Drawing.Point(212, 109);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(135, 64);
            this.panel10.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Медианный доход:";
            // 
            // Label_Week_Expected
            // 
            this.Label_Week_Expected.AutoSize = true;
            this.Label_Week_Expected.ForeColor = System.Drawing.Color.Green;
            this.Label_Week_Expected.Location = new System.Drawing.Point(3, 20);
            this.Label_Week_Expected.Name = "Label_Week_Expected";
            this.Label_Week_Expected.Size = new System.Drawing.Size(13, 13);
            this.Label_Week_Expected.TabIndex = 20;
            this.Label_Week_Expected.Text = "0";
            // 
            // Label_Week_Aver
            // 
            this.Label_Week_Aver.AutoSize = true;
            this.Label_Week_Aver.ForeColor = System.Drawing.Color.Green;
            this.Label_Week_Aver.Location = new System.Drawing.Point(3, 46);
            this.Label_Week_Aver.Name = "Label_Week_Aver";
            this.Label_Week_Aver.Size = new System.Drawing.Size(13, 13);
            this.Label_Week_Aver.TabIndex = 22;
            this.Label_Week_Aver.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Средний доход:";
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label22);
            this.panel11.Location = new System.Drawing.Point(212, 89);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(135, 22);
            this.panel11.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Прогноз(1н):";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.Label_Day_Expected);
            this.panel9.Controls.Add(this.Label_Day_Aver);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(8, 109);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(135, 64);
            this.panel9.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Медианный доход:";
            // 
            // Label_Day_Expected
            // 
            this.Label_Day_Expected.AutoSize = true;
            this.Label_Day_Expected.ForeColor = System.Drawing.Color.Green;
            this.Label_Day_Expected.Location = new System.Drawing.Point(3, 20);
            this.Label_Day_Expected.Name = "Label_Day_Expected";
            this.Label_Day_Expected.Size = new System.Drawing.Size(13, 13);
            this.Label_Day_Expected.TabIndex = 20;
            this.Label_Day_Expected.Text = "0";
            // 
            // Label_Day_Aver
            // 
            this.Label_Day_Aver.AutoSize = true;
            this.Label_Day_Aver.ForeColor = System.Drawing.Color.Green;
            this.Label_Day_Aver.Location = new System.Drawing.Point(3, 46);
            this.Label_Day_Aver.Name = "Label_Day_Aver";
            this.Label_Day_Aver.Size = new System.Drawing.Size(13, 13);
            this.Label_Day_Aver.TabIndex = 22;
            this.Label_Day_Aver.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Средний доход:";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(8, 88);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(135, 22);
            this.panel8.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Прогноз(24ч):";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(425, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 22);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Весь период:";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Label_All_Trend);
            this.panel7.Controls.Add(this.Label_All_Income);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(425, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(135, 146);
            this.panel7.TabIndex = 20;
            // 
            // Label_All_Trend
            // 
            this.Label_All_Trend.AutoSize = true;
            this.Label_All_Trend.ForeColor = System.Drawing.Color.Green;
            this.Label_All_Trend.Location = new System.Drawing.Point(3, 44);
            this.Label_All_Trend.Name = "Label_All_Trend";
            this.Label_All_Trend.Size = new System.Drawing.Size(13, 13);
            this.Label_All_Trend.TabIndex = 17;
            this.Label_All_Trend.Text = "0";
            // 
            // Label_All_Income
            // 
            this.Label_All_Income.AutoSize = true;
            this.Label_All_Income.ForeColor = System.Drawing.Color.Green;
            this.Label_All_Income.Location = new System.Drawing.Point(3, 18);
            this.Label_All_Income.Name = "Label_All_Income";
            this.Label_All_Income.Size = new System.Drawing.Size(13, 13);
            this.Label_All_Income.TabIndex = 16;
            this.Label_All_Income.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Заработано:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Тренд:";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(212, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 22);
            this.panel5.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Неделя:";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Label_Week_Trend);
            this.panel6.Controls.Add(this.Label_Week_Income);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(212, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(135, 63);
            this.panel6.TabIndex = 14;
            // 
            // Label_Week_Trend
            // 
            this.Label_Week_Trend.AutoSize = true;
            this.Label_Week_Trend.ForeColor = System.Drawing.Color.Green;
            this.Label_Week_Trend.Location = new System.Drawing.Point(3, 45);
            this.Label_Week_Trend.Name = "Label_Week_Trend";
            this.Label_Week_Trend.Size = new System.Drawing.Size(13, 13);
            this.Label_Week_Trend.TabIndex = 19;
            this.Label_Week_Trend.Text = "0";
            // 
            // Label_Week_Income
            // 
            this.Label_Week_Income.AutoSize = true;
            this.Label_Week_Income.ForeColor = System.Drawing.Color.Green;
            this.Label_Week_Income.Location = new System.Drawing.Point(3, 19);
            this.Label_Week_Income.Name = "Label_Week_Income";
            this.Label_Week_Income.Size = new System.Drawing.Size(13, 13);
            this.Label_Week_Income.TabIndex = 18;
            this.Label_Week_Income.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Заработано:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Падение/рост:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(8, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 22);
            this.panel4.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "День:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Label_Day_Trend);
            this.panel3.Controls.Add(this.Label_Day_Income);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(8, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 63);
            this.panel3.TabIndex = 11;
            // 
            // Label_Day_Trend
            // 
            this.Label_Day_Trend.AutoSize = true;
            this.Label_Day_Trend.ForeColor = System.Drawing.Color.Green;
            this.Label_Day_Trend.Location = new System.Drawing.Point(3, 43);
            this.Label_Day_Trend.Name = "Label_Day_Trend";
            this.Label_Day_Trend.Size = new System.Drawing.Size(13, 13);
            this.Label_Day_Trend.TabIndex = 19;
            this.Label_Day_Trend.Text = "0";
            // 
            // Label_Day_Income
            // 
            this.Label_Day_Income.AutoSize = true;
            this.Label_Day_Income.ForeColor = System.Drawing.Color.Green;
            this.Label_Day_Income.Location = new System.Drawing.Point(3, 17);
            this.Label_Day_Income.Name = "Label_Day_Income";
            this.Label_Day_Income.Size = new System.Drawing.Size(13, 13);
            this.Label_Day_Income.TabIndex = 18;
            this.Label_Day_Income.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Заработано:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Падение/рост:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.panel21);
            this.tabPage3.Controls.Add(this.panel17);
            this.tabPage3.Controls.Add(this.panel15);
            this.tabPage3.Controls.Add(this.panel23);
            this.tabPage3.Controls.Add(this.panel22);
            this.tabPage3.Controls.Add(this.panel18);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(578, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Прогноз";
            // 
            // panel21
            // 
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Controls.Add(this.label41);
            this.panel21.Controls.Add(this.Label_Hour_Month_Median);
            this.panel21.Controls.Add(this.Label_Hour_Month_Average);
            this.panel21.Controls.Add(this.label48);
            this.panel21.Location = new System.Drawing.Point(356, 109);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(127, 70);
            this.panel21.TabIndex = 35;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 7);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(101, 13);
            this.label41.TabIndex = 16;
            this.label41.Text = "Медианный доход:";
            // 
            // Label_Hour_Month_Median
            // 
            this.Label_Hour_Month_Median.AutoSize = true;
            this.Label_Hour_Month_Median.ForeColor = System.Drawing.Color.Green;
            this.Label_Hour_Month_Median.Location = new System.Drawing.Point(3, 20);
            this.Label_Hour_Month_Median.Name = "Label_Hour_Month_Median";
            this.Label_Hour_Month_Median.Size = new System.Drawing.Size(13, 13);
            this.Label_Hour_Month_Median.TabIndex = 20;
            this.Label_Hour_Month_Median.Text = "0";
            // 
            // Label_Hour_Month_Average
            // 
            this.Label_Hour_Month_Average.AutoSize = true;
            this.Label_Hour_Month_Average.ForeColor = System.Drawing.Color.Green;
            this.Label_Hour_Month_Average.Location = new System.Drawing.Point(3, 46);
            this.Label_Hour_Month_Average.Name = "Label_Hour_Month_Average";
            this.Label_Hour_Month_Average.Size = new System.Drawing.Size(13, 13);
            this.Label_Hour_Month_Average.TabIndex = 22;
            this.Label_Hour_Month_Average.Text = "0";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(3, 33);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(85, 13);
            this.label48.TabIndex = 21;
            this.label48.Text = "Средний доход:";
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.label29);
            this.panel17.Controls.Add(this.Label_Hour_Week_Median);
            this.panel17.Controls.Add(this.Label_Hour_Week_Average);
            this.panel17.Controls.Add(this.label38);
            this.panel17.Location = new System.Drawing.Point(230, 109);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(127, 70);
            this.panel17.TabIndex = 34;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 7);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 13);
            this.label29.TabIndex = 16;
            this.label29.Text = "Медианный доход:";
            // 
            // Label_Hour_Week_Median
            // 
            this.Label_Hour_Week_Median.AutoSize = true;
            this.Label_Hour_Week_Median.ForeColor = System.Drawing.Color.Green;
            this.Label_Hour_Week_Median.Location = new System.Drawing.Point(3, 20);
            this.Label_Hour_Week_Median.Name = "Label_Hour_Week_Median";
            this.Label_Hour_Week_Median.Size = new System.Drawing.Size(13, 13);
            this.Label_Hour_Week_Median.TabIndex = 20;
            this.Label_Hour_Week_Median.Text = "0";
            // 
            // Label_Hour_Week_Average
            // 
            this.Label_Hour_Week_Average.AutoSize = true;
            this.Label_Hour_Week_Average.ForeColor = System.Drawing.Color.Green;
            this.Label_Hour_Week_Average.Location = new System.Drawing.Point(3, 46);
            this.Label_Hour_Week_Average.Name = "Label_Hour_Week_Average";
            this.Label_Hour_Week_Average.Size = new System.Drawing.Size(13, 13);
            this.Label_Hour_Week_Average.TabIndex = 22;
            this.Label_Hour_Week_Average.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 33);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(85, 13);
            this.label38.TabIndex = 21;
            this.label38.Text = "Средний доход:";
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.panel30);
            this.panel15.Controls.Add(this.label60);
            this.panel15.Location = new System.Drawing.Point(355, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(128, 176);
            this.panel15.TabIndex = 33;
            // 
            // panel30
            // 
            this.panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel30.Controls.Add(this.label33);
            this.panel30.Controls.Add(this.Label_Full_Month_Median);
            this.panel30.Controls.Add(this.Label_Full_Month_Average);
            this.panel30.Controls.Add(this.label59);
            this.panel30.Location = new System.Drawing.Point(-1, 36);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(128, 70);
            this.panel30.TabIndex = 33;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 7);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(101, 13);
            this.label33.TabIndex = 16;
            this.label33.Text = "Медианный доход:";
            // 
            // Label_Full_Month_Median
            // 
            this.Label_Full_Month_Median.AutoSize = true;
            this.Label_Full_Month_Median.ForeColor = System.Drawing.Color.Green;
            this.Label_Full_Month_Median.Location = new System.Drawing.Point(3, 20);
            this.Label_Full_Month_Median.Name = "Label_Full_Month_Median";
            this.Label_Full_Month_Median.Size = new System.Drawing.Size(13, 13);
            this.Label_Full_Month_Median.TabIndex = 20;
            this.Label_Full_Month_Median.Text = "0";
            // 
            // Label_Full_Month_Average
            // 
            this.Label_Full_Month_Average.AutoSize = true;
            this.Label_Full_Month_Average.ForeColor = System.Drawing.Color.Green;
            this.Label_Full_Month_Average.Location = new System.Drawing.Point(3, 46);
            this.Label_Full_Month_Average.Name = "Label_Full_Month_Average";
            this.Label_Full_Month_Average.Size = new System.Drawing.Size(13, 13);
            this.Label_Full_Month_Average.TabIndex = 22;
            this.Label_Full_Month_Average.Text = "0";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(3, 33);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(85, 13);
            this.label59.TabIndex = 21;
            this.label59.Text = "Средний доход:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(4, 9);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(43, 13);
            this.label60.TabIndex = 10;
            this.label60.Text = "Месяц:";
            // 
            // panel23
            // 
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Controls.Add(this.panel27);
            this.panel23.Controls.Add(this.label36);
            this.panel23.Location = new System.Drawing.Point(230, 3);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(126, 176);
            this.panel23.TabIndex = 32;
            // 
            // panel27
            // 
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel27.Controls.Add(this.label51);
            this.panel27.Controls.Add(this.Label_Full_Week_Median);
            this.panel27.Controls.Add(this.Label_Full_Week_Average);
            this.panel27.Controls.Add(this.label54);
            this.panel27.Location = new System.Drawing.Point(-1, 36);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(155, 70);
            this.panel27.TabIndex = 33;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(3, 7);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(101, 13);
            this.label51.TabIndex = 16;
            this.label51.Text = "Медианный доход:";
            // 
            // Label_Full_Week_Median
            // 
            this.Label_Full_Week_Median.AutoSize = true;
            this.Label_Full_Week_Median.ForeColor = System.Drawing.Color.Green;
            this.Label_Full_Week_Median.Location = new System.Drawing.Point(3, 20);
            this.Label_Full_Week_Median.Name = "Label_Full_Week_Median";
            this.Label_Full_Week_Median.Size = new System.Drawing.Size(13, 13);
            this.Label_Full_Week_Median.TabIndex = 20;
            this.Label_Full_Week_Median.Text = "0";
            // 
            // Label_Full_Week_Average
            // 
            this.Label_Full_Week_Average.AutoSize = true;
            this.Label_Full_Week_Average.ForeColor = System.Drawing.Color.Green;
            this.Label_Full_Week_Average.Location = new System.Drawing.Point(3, 46);
            this.Label_Full_Week_Average.Name = "Label_Full_Week_Average";
            this.Label_Full_Week_Average.Size = new System.Drawing.Size(13, 13);
            this.Label_Full_Week_Average.TabIndex = 22;
            this.Label_Full_Week_Average.Text = "0";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(3, 33);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(85, 13);
            this.label54.TabIndex = 21;
            this.label54.Text = "Средний доход:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(4, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(48, 13);
            this.label36.TabIndex = 10;
            this.label36.Text = "Неделя:";
            // 
            // panel22
            // 
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel22.Controls.Add(this.panel16);
            this.panel22.Controls.Add(this.label35);
            this.panel22.Controls.Add(this.panel25);
            this.panel22.Location = new System.Drawing.Point(104, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(127, 176);
            this.panel22.TabIndex = 31;
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.label25);
            this.panel16.Controls.Add(this.Label_Hour_Day_Median);
            this.panel16.Controls.Add(this.Label_Hour_Day_Average);
            this.panel16.Controls.Add(this.label28);
            this.panel16.Location = new System.Drawing.Point(-1, 105);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(127, 70);
            this.panel16.TabIndex = 34;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 7);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "Медианный доход:";
            // 
            // Label_Hour_Day_Median
            // 
            this.Label_Hour_Day_Median.AutoSize = true;
            this.Label_Hour_Day_Median.ForeColor = System.Drawing.Color.Green;
            this.Label_Hour_Day_Median.Location = new System.Drawing.Point(3, 20);
            this.Label_Hour_Day_Median.Name = "Label_Hour_Day_Median";
            this.Label_Hour_Day_Median.Size = new System.Drawing.Size(13, 13);
            this.Label_Hour_Day_Median.TabIndex = 20;
            this.Label_Hour_Day_Median.Text = "0";
            // 
            // Label_Hour_Day_Average
            // 
            this.Label_Hour_Day_Average.AutoSize = true;
            this.Label_Hour_Day_Average.ForeColor = System.Drawing.Color.Green;
            this.Label_Hour_Day_Average.Location = new System.Drawing.Point(3, 46);
            this.Label_Hour_Day_Average.Name = "Label_Hour_Day_Average";
            this.Label_Hour_Day_Average.Size = new System.Drawing.Size(13, 13);
            this.Label_Hour_Day_Average.TabIndex = 22;
            this.Label_Hour_Day_Average.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 33);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 13);
            this.label28.TabIndex = 21;
            this.label28.Text = "Средний доход:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(4, 9);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(37, 13);
            this.label35.TabIndex = 10;
            this.label35.Text = "День:";
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Controls.Add(this.label43);
            this.panel25.Controls.Add(this.Label_Full_Day_Median);
            this.panel25.Controls.Add(this.Label_Full_Day_Average);
            this.panel25.Controls.Add(this.label46);
            this.panel25.Location = new System.Drawing.Point(-1, 36);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(127, 70);
            this.panel25.TabIndex = 33;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 7);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(101, 13);
            this.label43.TabIndex = 16;
            this.label43.Text = "Медианный доход:";
            // 
            // Label_Full_Day_Median
            // 
            this.Label_Full_Day_Median.AutoSize = true;
            this.Label_Full_Day_Median.ForeColor = System.Drawing.Color.Green;
            this.Label_Full_Day_Median.Location = new System.Drawing.Point(3, 20);
            this.Label_Full_Day_Median.Name = "Label_Full_Day_Median";
            this.Label_Full_Day_Median.Size = new System.Drawing.Size(13, 13);
            this.Label_Full_Day_Median.TabIndex = 20;
            this.Label_Full_Day_Median.Text = "0";
            // 
            // Label_Full_Day_Average
            // 
            this.Label_Full_Day_Average.AutoSize = true;
            this.Label_Full_Day_Average.ForeColor = System.Drawing.Color.Green;
            this.Label_Full_Day_Average.Location = new System.Drawing.Point(3, 46);
            this.Label_Full_Day_Average.Name = "Label_Full_Day_Average";
            this.Label_Full_Day_Average.Size = new System.Drawing.Size(13, 13);
            this.Label_Full_Day_Average.TabIndex = 22;
            this.Label_Full_Day_Average.Text = "0";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(3, 33);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(85, 13);
            this.label46.TabIndex = 21;
            this.label46.Text = "Средний доход:";
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.label30);
            this.panel18.Controls.Add(this.panel20);
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(102, 176);
            this.panel18.TabIndex = 28;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(4, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 13);
            this.label30.TabIndex = 10;
            this.label30.Text = "Выборка:";
            // 
            // panel20
            // 
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Controls.Add(this.label32);
            this.panel20.Location = new System.Drawing.Point(-1, 105);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(102, 70);
            this.panel20.TabIndex = 30;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(4, 9);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 13);
            this.label32.TabIndex = 10;
            this.label32.Text = "Один час:";
            // 
            // panel19
            // 
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Controls.Add(this.label31);
            this.panel19.Location = new System.Drawing.Point(-1, 36);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(102, 70);
            this.panel19.TabIndex = 29;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(4, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 13);
            this.label31.TabIndex = 10;
            this.label31.Text = "Полная:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.StatusLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 30);
            this.panel2.TabIndex = 11;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(43, 8);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(13, 13);
            this.StatusLabel.TabIndex = 13;
            this.StatusLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Статус:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem1, this.debugToolStripMenuItem, this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuItem1.Text = "Настройки";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.loadJsonToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.debugToolStripMenuItem.Text = "Отладка";
            // 
            // loadJsonToolStripMenuItem
            // 
            this.loadJsonToolStripMenuItem.Name = "loadJsonToolStripMenuItem";
            this.loadJsonToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.loadJsonToolStripMenuItem.Text = "Load json";
            this.loadJsonToolStripMenuItem.Click += new System.EventHandler(this.loadJsonToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem2.Text = "Помощь";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 200;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(587, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My Crypto Statistic";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Label_All_Trend;
        private System.Windows.Forms.Label Label_All_Income;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Week_Expected;
        private System.Windows.Forms.Label Label_Week_Trend;
        private System.Windows.Forms.Label Label_Week_Income;
        private System.Windows.Forms.Label Label_Day_Expected;
        private System.Windows.Forms.Label Label_Day_Trend;
        private System.Windows.Forms.Label Label_Day_Income;
        private IncomePlot BasePlot;
        private System.Windows.Forms.Label Label_Day_Aver;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Label_Week_Aver;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label Label_Hour_Month_Median;
        private System.Windows.Forms.Label Label_Hour_Month_Average;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label Label_Hour_Week_Median;
        private System.Windows.Forms.Label Label_Hour_Week_Average;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label Label_Full_Month_Median;
        private System.Windows.Forms.Label Label_Full_Month_Average;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label Label_Full_Week_Median;
        private System.Windows.Forms.Label Label_Full_Week_Average;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label Label_Hour_Day_Median;
        private System.Windows.Forms.Label Label_Hour_Day_Average;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label Label_Full_Day_Median;
        private System.Windows.Forms.Label Label_Full_Day_Average;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label31;
    }
}

