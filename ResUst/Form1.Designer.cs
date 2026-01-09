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
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
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
            textBox11 = new TextBox();
            label18 = new Label();
            groupBox3 = new GroupBox();
            label14 = new Label();
            label11 = new Label();
            textBox12 = new TextBox();
            label20 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            textBox8 = new TextBox();
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
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры расчета";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(184, 185);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(52, 27);
            textBox5.TabIndex = 15;
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 188);
            label9.Name = "label9";
            label9.Size = new Size(158, 20);
            label9.TabIndex = 14;
            label9.Text = "Пониж. коэф. K₂ к Fкр";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(184, 152);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(52, 27);
            textBox6.TabIndex = 13;
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 155);
            label10.Name = "label10";
            label10.Size = new Size(159, 20);
            label10.TabIndex = 12;
            label10.Text = "Повыш. коэф. K₁ к Fкр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 122);
            label5.Name = "label5";
            label5.Size = new Size(16, 20);
            label5.TabIndex = 11;
            label5.Text = "c";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(52, 27);
            textBox3.TabIndex = 10;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 122);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 9;
            label6.Text = "Время расчета T";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 89);
            label7.Name = "label7";
            label7.Size = new Size(16, 20);
            label7.TabIndex = 8;
            label7.Text = "с";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(52, 27);
            textBox4.TabIndex = 7;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 89);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 6;
            label8.Text = "Шаг расчета dt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 56);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 5;
            label3.Text = "м";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(52, 27);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 56);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 3;
            label4.Text = "Статический напор Hст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 23);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "м³/с";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(52, 27);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Расход деривации Qд";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SaveData_button, OpenData_button, Execute_button, SaveResults_button, Help_button });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // SaveData_button
            // 
            SaveData_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveData_button.Image = Properties.Resources.save;
            SaveData_button.ImageTransparentColor = Color.Magenta;
            SaveData_button.Name = "SaveData_button";
            SaveData_button.Size = new Size(29, 24);
            SaveData_button.Text = "Сохранить исходные данные";
            // 
            // OpenData_button
            // 
            OpenData_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenData_button.Image = Properties.Resources.open;
            OpenData_button.ImageTransparentColor = Color.Magenta;
            OpenData_button.Name = "OpenData_button";
            OpenData_button.Size = new Size(29, 24);
            OpenData_button.Text = "Открыть исходные данные";
            // 
            // Execute_button
            // 
            Execute_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Execute_button.Image = Properties.Resources.execute;
            Execute_button.ImageTransparentColor = Color.Magenta;
            Execute_button.Name = "Execute_button";
            Execute_button.Size = new Size(29, 24);
            Execute_button.Text = "Выполнить расчет";
            // 
            // SaveResults_button
            // 
            SaveResults_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveResults_button.Image = Properties.Resources.SaveResults;
            SaveResults_button.ImageTransparentColor = Color.Magenta;
            SaveResults_button.Name = "SaveResults_button";
            SaveResults_button.Size = new Size(29, 24);
            SaveResults_button.Text = "Сохранить результат расчета";
            // 
            // Help_button
            // 
            Help_button.Alignment = ToolStripItemAlignment.Right;
            Help_button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Help_button.Image = Properties.Resources.Help;
            Help_button.ImageTransparentColor = Color.Magenta;
            Help_button.Name = "Help_button";
            Help_button.Size = new Size(29, 24);
            Help_button.Text = "ПАМАГИТЕ!!!";
            // 
            // OpenData
            // 
            OpenData.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Fkp);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(textBox11);
            groupBox2.Controls.Add(label18);
            groupBox2.Location = new Point(9, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 176);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Резервуар";
            // 
            // Fkp
            // 
            Fkp.AutoSize = true;
            Fkp.Location = new Point(208, 120);
            Fkp.Name = "Fkp";
            Fkp.Size = new Size(50, 20);
            Fkp.TabIndex = 5;
            Fkp.Text = "= - м²";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fкр;
            pictureBox1.Location = new Point(6, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(190, 56);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(52, 27);
            textBox11.TabIndex = 4;
            textBox11.TextAlign = HorizontalAlignment.Right;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 23);
            label18.Name = "label18";
            label18.Size = new Size(133, 60);
            label18.TabIndex = 3;
            label18.Text = "Коэффициент\r\nдополнительного\r\nсопротивления ζ\r\n";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox12);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(9, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(290, 137);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Деривация";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(248, 56);
            label14.Name = "label14";
            label14.Size = new Size(26, 20);
            label14.TabIndex = 8;
            label14.Text = "м²";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(248, 23);
            label11.Name = "label11";
            label11.Size = new Size(20, 20);
            label11.TabIndex = 7;
            label11.Text = "м";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(190, 98);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(52, 27);
            textBox12.TabIndex = 6;
            textBox12.TextAlign = HorizontalAlignment.Right;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 85);
            label20.Name = "label20";
            label20.Size = new Size(128, 40);
            label20.TabIndex = 5;
            label20.Text = "Коэффициент\r\nшероховатости n";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(190, 53);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(52, 27);
            textBox7.TabIndex = 4;
            textBox7.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 56);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 3;
            label12.Text = "Площадь Fд";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(190, 20);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(52, 27);
            textBox8.TabIndex = 1;
            textBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 23);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 0;
            label13.Text = "Длина Lд";
            // 
            // formsPlot_k1Fkp
            // 
            formsPlot_k1Fkp.DisplayScale = 1.25F;
            formsPlot_k1Fkp.Location = new Point(305, 30);
            formsPlot_k1Fkp.Name = "formsPlot_k1Fkp";
            formsPlot_k1Fkp.Size = new Size(483, 179);
            formsPlot_k1Fkp.TabIndex = 4;
            // 
            // formsPlot_Fkp
            // 
            formsPlot_Fkp.DisplayScale = 1.25F;
            formsPlot_Fkp.Location = new Point(305, 215);
            formsPlot_Fkp.Name = "formsPlot_Fkp";
            formsPlot_Fkp.Size = new Size(483, 179);
            formsPlot_Fkp.TabIndex = 5;
            // 
            // formsPlot_k2Fkp
            // 
            formsPlot_k2Fkp.DisplayScale = 1.25F;
            formsPlot_k2Fkp.Location = new Point(305, 400);
            formsPlot_k2Fkp.Name = "formsPlot_k2Fkp";
            formsPlot_k2Fkp.Size = new Size(483, 179);
            formsPlot_k2Fkp.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(347, 234);
            label15.Name = "label15";
            label15.Size = new Size(58, 20);
            label15.TabIndex = 7;
            label15.Text = "Fр=Fкр";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(347, 48);
            label16.Name = "label16";
            label16.Size = new Size(76, 20);
            label16.TabIndex = 8;
            label16.Text = "Fр=k₁•Fкр";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Location = new Point(347, 420);
            label17.Name = "label17";
            label17.Size = new Size(77, 20);
            label17.TabIndex = 9;
            label17.Text = "Fр=k₂•Fкр";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
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
        private TextBox textBox1;
        private Label label1;
        private ToolStrip toolStrip1;
        private SaveFileDialog SaveData;
        private OpenFileDialog OpenData;
        private SaveFileDialog SaveResults;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox textBox11;
        private Label label18;
        private Label Fkp;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private TextBox textBox12;
        private Label label20;
        private TextBox textBox7;
        private Label label12;
        private TextBox textBox8;
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
