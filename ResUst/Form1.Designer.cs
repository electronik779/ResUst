namespace ResUst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            k2t = new TextBox();
            label9 = new Label();
            k1t = new TextBox();
            label10 = new Label();
            label5 = new Label();
            Trast = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dtt = new TextBox();
            label8 = new Label();
            label3 = new Label();
            Hctt = new TextBox();
            label4 = new Label();
            label2 = new Label();
            Qdt = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            SaveData_button = new ToolStripButton();
            OpenData_button = new ToolStripButton();
            Execute_button = new ToolStripButton();
            SaveResults_button = new ToolStripButton();
            Help_button = new ToolStripButton();
            SaveData = new SaveFileDialog();
            OpenData = new OpenFileDialog();
            SaveResults = new SaveFileDialog();
            groupBox2 = new GroupBox();
            Fkp = new Label();
            pictureBox1 = new PictureBox();
            krt = new TextBox();
            label18 = new Label();
            groupBox3 = new GroupBox();
            label14 = new Label();
            label11 = new Label();
            knt = new TextBox();
            label20 = new Label();
            Fdt = new TextBox();
            label12 = new Label();
            Ldt = new TextBox();
            label13 = new Label();
            formsPlot_k1Fkp = new ScottPlot.WinForms.FormsPlot();
            formsPlot_Fkp = new ScottPlot.WinForms.FormsPlot();
            formsPlot_k2Fkp = new ScottPlot.WinForms.FormsPlot();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(k2t);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(k1t);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Trast);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtt);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Hctt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Qdt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 265);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(248, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры расчета";
            // 
            // k2t
            // 
            k2t.Location = new Point(161, 139);
            k2t.Margin = new Padding(3, 2, 3, 2);
            k2t.Name = "k2t";
            k2t.Size = new Size(46, 23);
            k2t.TabIndex = 10;
            k2t.TextAlign = HorizontalAlignment.Right;
            k2t.TextChanged += k2t_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 141);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 0;
            label9.Text = "Пониж. коэф. K₂ к Fкр";
            // 
            // k1t
            // 
            k1t.Location = new Point(161, 114);
            k1t.Margin = new Padding(3, 2, 3, 2);
            k1t.Name = "k1t";
            k1t.Size = new Size(46, 23);
            k1t.TabIndex = 9;
            k1t.TextAlign = HorizontalAlignment.Right;
            k1t.TextChanged += k1t_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 116);
            label10.Name = "label10";
            label10.Size = new Size(131, 15);
            label10.TabIndex = 0;
            label10.Text = "Повыш. коэф. K₁ к Fкр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 92);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 11;
            label5.Text = "c";
            // 
            // Trast
            // 
            Trast.Location = new Point(161, 89);
            Trast.Margin = new Padding(3, 2, 3, 2);
            Trast.Name = "Trast";
            Trast.Size = new Size(46, 23);
            Trast.TabIndex = 8;
            Trast.TextAlign = HorizontalAlignment.Right;
            Trast.TextChanged += Trast_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 92);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 0;
            label6.Text = "Время расчета T";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 67);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 8;
            label7.Text = "с";
            // 
            // dtt
            // 
            dtt.Location = new Point(161, 64);
            dtt.Margin = new Padding(3, 2, 3, 2);
            dtt.Name = "dtt";
            dtt.Size = new Size(46, 23);
            dtt.TabIndex = 7;
            dtt.TextAlign = HorizontalAlignment.Right;
            dtt.TextChanged += dtt_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 67);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 0;
            label8.Text = "Шаг расчета dt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 42);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 5;
            label3.Text = "м";
            // 
            // Hctt
            // 
            Hctt.Location = new Point(161, 40);
            Hctt.Margin = new Padding(3, 2, 3, 2);
            Hctt.Name = "Hctt";
            Hctt.Size = new Size(46, 23);
            Hctt.TabIndex = 6;
            Hctt.TextAlign = HorizontalAlignment.Right;
            Hctt.TextChanged += Hctt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 42);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 0;
            label4.Text = "Статический напор Hст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 17);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "м³/с";
            // 
            // Qdt
            // 
            Qdt.Location = new Point(161, 15);
            Qdt.Margin = new Padding(3, 2, 3, 2);
            Qdt.Name = "Qdt";
            Qdt.Size = new Size(46, 23);
            Qdt.TabIndex = 5;
            Qdt.TextAlign = HorizontalAlignment.Right;
            Qdt.TextChanged += Qdt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 17);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Расход деривации Qд";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SaveData_button, OpenData_button, Execute_button, SaveResults_button, Help_button });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(700, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // SaveData_button
            // 
            SaveData_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveData_button.Image = Properties.Resources.save;
            SaveData_button.ImageTransparentColor = Color.Magenta;
            SaveData_button.Name = "SaveData_button";
            SaveData_button.Size = new Size(24, 24);
            SaveData_button.Text = "Сохранить исходные данные";
            SaveData_button.Click += SaveData_button_Click;
            // 
            // OpenData_button
            // 
            OpenData_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenData_button.Image = Properties.Resources.open;
            OpenData_button.ImageTransparentColor = Color.Magenta;
            OpenData_button.Name = "OpenData_button";
            OpenData_button.Size = new Size(24, 24);
            OpenData_button.Text = "Открыть исходные данные";
            OpenData_button.Click += OpenData_button_Click;
            // 
            // Execute_button
            // 
            Execute_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Execute_button.Image = Properties.Resources.execute;
            Execute_button.ImageTransparentColor = Color.Magenta;
            Execute_button.Name = "Execute_button";
            Execute_button.Size = new Size(24, 24);
            Execute_button.Text = "Выполнить расчет";
            Execute_button.Click += Execute_button_Click;
            // 
            // SaveResults_button
            // 
            SaveResults_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveResults_button.Image = Properties.Resources.SaveResults;
            SaveResults_button.ImageTransparentColor = Color.Magenta;
            SaveResults_button.Name = "SaveResults_button";
            SaveResults_button.Size = new Size(24, 24);
            SaveResults_button.Text = "Сохранить результат расчета";
            SaveResults_button.Click += SaveResults_button_Click;
            // 
            // Help_button
            // 
            Help_button.Alignment = ToolStripItemAlignment.Right;
            Help_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Help_button.Image = Properties.Resources.Help;
            Help_button.ImageTransparentColor = Color.Magenta;
            Help_button.Name = "Help_button";
            Help_button.Size = new Size(24, 24);
            Help_button.Text = "ПАМАГИТЕ!!!";
            Help_button.Click += Help_button_Click;
            // 
            // OpenData
            // 
            OpenData.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Fkp);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(krt);
            groupBox2.Controls.Add(label18);
            groupBox2.Location = new Point(8, 128);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(254, 132);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Резервуар";
            // 
            // Fkp
            // 
            Fkp.AutoSize = true;
            Fkp.Location = new Point(182, 90);
            Fkp.Name = "Fkp";
            Fkp.Size = new Size(39, 15);
            Fkp.TabIndex = 5;
            Fkp.Text = "= - м²";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fкр;
            pictureBox1.Location = new Point(5, 76);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // krt
            // 
            krt.Location = new Point(166, 42);
            krt.Margin = new Padding(3, 2, 3, 2);
            krt.Name = "krt";
            krt.Size = new Size(46, 23);
            krt.TabIndex = 4;
            krt.TextAlign = HorizontalAlignment.Right;
            krt.TextChanged += krt_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(5, 17);
            label18.Name = "label18";
            label18.Size = new Size(105, 45);
            label18.TabIndex = 0;
            label18.Text = "Коэффициент\r\nдополнительного\r\nсопротивления ζ\r\n";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(knt);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(Fdt);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(Ldt);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(8, 21);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(254, 103);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Деривация";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(217, 42);
            label14.Name = "label14";
            label14.Size = new Size(20, 15);
            label14.TabIndex = 8;
            label14.Text = "м²";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(217, 17);
            label11.Name = "label11";
            label11.Size = new Size(16, 15);
            label11.TabIndex = 7;
            label11.Text = "м";
            // 
            // knt
            // 
            knt.Location = new Point(166, 74);
            knt.Margin = new Padding(3, 2, 3, 2);
            knt.Name = "knt";
            knt.Size = new Size(46, 23);
            knt.TabIndex = 3;
            knt.TextAlign = HorizontalAlignment.Right;
            knt.TextChanged += knt_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(5, 64);
            label20.Name = "label20";
            label20.Size = new Size(103, 30);
            label20.TabIndex = 0;
            label20.Text = "Коэффициент\r\nшероховатости n";
            // 
            // Fdt
            // 
            Fdt.Location = new Point(166, 40);
            Fdt.Margin = new Padding(3, 2, 3, 2);
            Fdt.Name = "Fdt";
            Fdt.Size = new Size(46, 23);
            Fdt.TabIndex = 2;
            Fdt.TextAlign = HorizontalAlignment.Right;
            Fdt.TextChanged += Fdt_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 42);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 0;
            label12.Text = "Площадь Fд";
            // 
            // Ldt
            // 
            Ldt.Location = new Point(166, 15);
            Ldt.Margin = new Padding(3, 2, 3, 2);
            Ldt.Name = "Ldt";
            Ldt.Size = new Size(46, 23);
            Ldt.TabIndex = 1;
            Ldt.TextAlign = HorizontalAlignment.Right;
            Ldt.TextChanged += Ldt_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 17);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 0;
            label13.Text = "Длина Lд";
            // 
            // formsPlot_k1Fkp
            // 
            formsPlot_k1Fkp.DisplayScale = 1.25F;
            formsPlot_k1Fkp.Location = new Point(267, 22);
            formsPlot_k1Fkp.Margin = new Padding(3, 2, 3, 2);
            formsPlot_k1Fkp.Name = "formsPlot_k1Fkp";
            formsPlot_k1Fkp.Size = new Size(423, 134);
            formsPlot_k1Fkp.TabIndex = 0;
            // 
            // formsPlot_Fkp
            // 
            formsPlot_Fkp.DisplayScale = 1.25F;
            formsPlot_Fkp.Location = new Point(267, 161);
            formsPlot_Fkp.Margin = new Padding(3, 2, 3, 2);
            formsPlot_Fkp.Name = "formsPlot_Fkp";
            formsPlot_Fkp.Size = new Size(423, 134);
            formsPlot_Fkp.TabIndex = 0;
            // 
            // formsPlot_k2Fkp
            // 
            formsPlot_k2Fkp.DisplayScale = 1.25F;
            formsPlot_k2Fkp.Location = new Point(267, 300);
            formsPlot_k2Fkp.Margin = new Padding(3, 2, 3, 2);
            formsPlot_k2Fkp.Name = "formsPlot_k2Fkp";
            formsPlot_k2Fkp.Size = new Size(423, 134);
            formsPlot_k2Fkp.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(464, 176);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 0;
            label15.Text = "Fр=Fкр";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(456, 36);
            label16.Name = "label16";
            label16.Size = new Size(62, 15);
            label16.TabIndex = 0;
            label16.Text = "Fр=k₁•Fкр";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Location = new Point(456, 315);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 0;
            label17.Text = "Fр=k₂•Fкр";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 438);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(formsPlot_k2Fkp);
            Controls.Add(formsPlot_Fkp);
            Controls.Add(formsPlot_k1Fkp);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Устойчивость системы 'деривация - уравнительный резервуар'";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox Qdt;
        private Label label1;
        private ToolStrip toolStrip1;
        private SaveFileDialog SaveData;
        private OpenFileDialog OpenData;
        private SaveFileDialog SaveResults;
        private TextBox k2t;
        private Label label9;
        private TextBox k1t;
        private Label label10;
        private Label label5;
        private TextBox Trast;
        private Label label6;
        private Label label7;
        private TextBox dtt;
        private Label label8;
        private Label label3;
        private TextBox Hctt;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox krt;
        private Label label18;
        private Label Fkp;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private TextBox knt;
        private Label label20;
        private TextBox Fdt;
        private Label label12;
        private TextBox Ldt;
        private Label label13;
        private ToolStripButton SaveData_button;
        private ToolStripButton OpenData_button;
        private ToolStripButton Execute_button;
        private ToolStripButton SaveResults_button;
        private ToolStripButton Help_button;
        private ScottPlot.WinForms.FormsPlot formsPlot_k1Fkp;
        private ScottPlot.WinForms.FormsPlot formsPlot_Fkp;
        private Label label14;
        private Label label11;
        private ScottPlot.WinForms.FormsPlot formsPlot_k2Fkp;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}
