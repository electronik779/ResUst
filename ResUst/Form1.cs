using OpenTK.Windowing.Common.Input;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace ResUst
{
    public partial class Form1 : Form
    {
        decimal[,,] Table = new decimal[3, 32768, 8];
        int[] count = new int[3] { 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();

            OpenData.Filter = "CSV файлы (*.csv)|*.csv";
            SaveData.Filter = "CSV файлы (*.csv)|*.csv";
            SaveData.DefaultExt = "csv";
            SaveData.AddExtension = true;
            SaveResults.Filter = "CSV файлы (*.csv)|*.csv";
            SaveResults.DefaultExt = "csv";
            SaveResults.AddExtension = true;
            this.FormClosing += (sender, e) => { TryDeleteFile(tempFilePath); };
        }

        // Генерация уникального имени файла
        string tempFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".pdf");

        private void Execute_button_Click(object sender, EventArgs e)
        {
            Array.Fill(count, 0);

            formsPlot_k1Fkp.Plot.Clear();
            formsPlot_Fkp.Plot.Clear();
            formsPlot_k2Fkp.Plot.Clear();

            decimal Ld = 0;
            decimal Fd = 0;
            decimal Fr = 0;
            decimal kn = 0;
            decimal kr = 0;
            decimal Hct = 0;
            decimal dt = 0;
            decimal Tras = 0;
            decimal k1 = 1;
            decimal k2 = 1;
            decimal kwd;
            decimal kwr;
            decimal Dd;
            decimal R;
            decimal Qst;
            decimal Qd = 0;
            decimal Qr;
            decimal Hwd;
            decimal Hwr;
            decimal Z;
            decimal Hd;
            decimal Shesi;
            decimal DZDT;
            decimal DQdDt;
            decimal Hsk;
            decimal Hr;
            decimal Fro;
            decimal Qst0;
            decimal Z0;
            decimal T = 0;

            try { Ld = GetDecimal(Ldt.Text, 0m); }
            catch { ErrorMsg(Ldt, "длину деривации"); }
            try { Fd = GetDecimal(Fdt.Text, 0m); }
            catch { ErrorMsg(Fdt, "площадь деривации"); }
            try { kn = GetDecimal(knt.Text, 0m); }
            catch { ErrorMsg(knt, "коэффициент шероховатости"); }
            try { kr = GetDecimal(krt.Text, 0m); }
            catch { ErrorMsg(krt, "коэффициент дополнительного сопротивления"); }
            try { Qd = GetDecimal(Qdt.Text, 0m); }
            catch { ErrorMsg(Qdt, "расход деривации"); }
            try { Hct = GetDecimal(Hctt.Text, 0m); }
            catch { ErrorMsg(Hctt, "статический напор"); }
            try { dt = GetDecimal(dtt.Text, 0m); }
            catch { ErrorMsg(dtt, "шаг расчета"); }
            try { Tras = GetDecimal(Trast.Text, 0m); }
            catch { ErrorMsg(Trast, "время расчета"); }
            try { k1 = GetDecimal(k1t.Text, 0m); }
            catch { ErrorMsg(k1t, "повышающий коэффициент"); }
            try { k2 = GetDecimal(k2t.Text, 0m); }
            catch { ErrorMsg(k2t, "понижающий коэффициент"); }

            if (k1 <= 1)
            {
                MessageBox.Show("Коэффициент k1 должен быть больше 1.", "Внимание!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                k1t.BackColor = Color.Red;
                return;
            }
            if (k2 >= 1)
            {
                MessageBox.Show("Коэффициент k2 должен быть меньше 1.", "Внимание!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                k1t.BackColor = Color.Red;
                return;
            }

            try
            {
                Qst = Qd;
                Qst0 = Qd;

                Dd = (decimal)Math.Pow(4 * (double)Fd / 3.1415, 0.5);
                R = Dd / 4;

                if (kn > 0)
                {
                    Shesi = 1 / kn * (decimal)Math.Pow((double)R, 1 / 6);
                    kwd = Ld / ((decimal)Math.Pow((double)Shesi, 2) * R * (decimal)Math.Pow((double)Fd, 2));
                }
                else { kwd = 0; }
                Hwd = kwd * Qst * Math.Abs(Qst);

                Hsk = (decimal)Math.Pow((double)Qst, 2) / 19.62m / (decimal)Math.Pow((double)Fd, 2);

                Hr = Hct - Hwd;

                Fro = (Ld * (decimal)Math.Pow((double)Qst, 2)) / ((Hwd + Hsk) * 19.62m * Fd * Hr);
                Fkp.Text = "= " + Math.Round(Fro, 1) + " м²";
                Fr = Fro;

                if (kn < 0) kn = 0;

                if (dt > 10)
                {
                    dtt.BackColor = Color.Red;
                    MessageBox.Show("Шаг расчета не должен превышать 10 с", "Внимание!",
                        MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    return;
                }

                for (int i = 0; i < 3; i++)
                {
                    T = 0;

                    switch (i)
                    {
                        case 0:
                            Fr = k1 * Fro;
                            break;
                        case 1:
                            Fr = Fro;
                            break;
                        case 2:
                            Fr = k2 * Fro;
                            break;
                        default:
                            Fr = Fro;
                            break;
                    }
                    //Debug.WriteLine("S: i= {0}, Fr= {1}", i, Fr);
                    Dd = (decimal)Math.Pow(4 * (double)Fd / 3.1415, 0.5);
                    R = Dd / 4;
                    if (kn > 0)
                    {
                        Shesi = 1 / kn * (decimal)Math.Pow((double)R, 1 / 6);
                        kwd = Ld / ((decimal)Math.Pow((double)Shesi, 2) * R * (decimal)Math.Pow((double)Fd, 2));
                    }
                    else { kwd = 0; }

                    kwr = kr / (19.62m * (decimal)Math.Pow((double)Fd, 2));

                    Qr = 0;
                    Hwd = kwd * Qd * Math.Abs(Qd);
                    Hwr = 0;
                    Z = -Hwd - Hwr - (decimal)Math.Pow((double)Qd, 2) / (19.62m * (decimal)Math.Pow((double)Fd, 2));
                    Z0 = Z;
                    Z = Z0 + 1;
                    Hd = Z;

                    Table[i, 0, 0] = T;
                    Table[i, 0, 1] = Qst0;
                    Table[i, 0, 2] = Qd;
                    Table[i, 0, 3] = Qr;
                    Table[i, 0, 4] = Hwd;
                    Table[i, 0, 5] = Hwr;
                    Table[i, 0, 6] = Z;
                    Table[i, 0, 7] = Hd;

                    //Debug.WriteLine("i={0},  {1} {2} {3} {4} {5} {6} {7} {8}",
                    //    i, Table[i, 0, 0], Table[i, 0, 1], Table[i, 0, 2], Table[i, 0, 3],
                    //    Table[i, 0, 4], Table[i, 0, 5], Table[i, 0, 6], Table[i, 0, 7]);

                    while (T <= Tras)
                    {
                        T += dt;
                        count[i]++;
                        if (count[i] >= 32768)
                        {
                            MessageBox.Show("Слишком много значений. Увеличьте шаг расчета", "Внимание!",
                            MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                            break;
                        }

                        Qst = Qst0 * (Hct + Z0) / (Hct + Z);
                        DZDT = (Qd - Qst) / Fr;
                        Z += DZDT * dt;
                        DQdDt = -(Z + Hwd + Hwr) * Fd * 9.81m / Ld;
                        Qd += DQdDt * dt;
                        Hwd = kwd * Qd * Math.Abs(Qd);
                        Qr = Qd - Qst;
                        Hwr = kwr * Qr * Math.Abs(Qr) + (decimal)Math.Pow((double)Qd, 2) / (19.62m * (decimal)Math.Pow((double)Fd, 2));
                        Hd = Z + Hwr;
                        Table[i, count[i], 0] = T;
                        Table[i, count[i], 1] = Qst;
                        Table[i, count[i], 2] = Qd;
                        Table[i, count[i], 3] = Qr;
                        Table[i, count[i], 4] = Hwd;
                        Table[i, count[i], 5] = Hwr;
                        Table[i, count[i], 6] = Z;
                        Table[i, count[i], 7] = Hd;

                        //Debug.WriteLine("i={0},  {1} {2} {3} {4} {5} {6} {7} {8}",
                        //i, Table[i, count[i], 0], Table[i, count[i], 1], Table[i, count[i], 2], Table[i, count[i], 3],
                        //Table[i, count[i], 4], Table[i, count[i], 5], Table[i, count[i], 6], Table[i, count[i], 7]);

                        if (Z > 100 || Z < -100)
                        {
                            MessageBox.Show("Ошибка расчета.\nСлишком большой диапазон колебаний." +
                                " Попробуйте задать К1 и / или К2 ближе к 1.",
                            "Внимание!",
                            MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка расчета. Проверьте корректность введенных данных",
                    "Внимание!",
                    MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

            // Строим графики
            int max1 = -1000000, max2 = -1000000, max3 = -1000000;
            int min1 = 1000000, min2 = 1000000, min3 = 1000000;
            int markerSize = 0;
            int lineWidth = 2;

            double[] dataX = new double[count[0]];
            double[] dataY1 = new double[count[0]];
            double[] dataY2 = new double[count[0]];
            double[] dataY3 = new double[count[0]];

            for (int i = 0; i < count[0]; i++)
            {
                if (max1 < (int)Table[0, i, 6]) max1 = (int)Table[0, i, 6];
                if (min1 > (int)Table[0, i, 6]) min1 = (int)Table[0, i, 6];
                dataX[i] = (double)Table[0, i, 0];
                dataY1[i] = (double)Table[0, i, 6];
                //Debug.WriteLine("i= {0}, t= {1}, Z= {2}", i, dataX[i], dataY1[i]);
            }
            for (int i = 0; i < count[1]; i++)
            {
                if (max2 < (int)Table[1, i, 6]) max2 = (int)Table[1, i, 6];
                if (min2 > (int)Table[1, i, 6]) min2 = (int)Table[1, i, 6];
                dataY2[i] = (double)Table[1, i, 6];
                //Debug.WriteLine("i= {0}, t= {1}, Z= {2}", i, dataX[i], dataY2[i]);
            }
            for (int i = 0; i < count[2]; i++)
            {
                if (max3 < (int)Table[2, i, 6]) max3 = (int)Table[2, i, 6];
                if (min3 > (int)Table[2, i, 6]) min3 = (int)Table[2, i, 6];
                dataY3[i] = (double)Table[2, i, 6];
                //Debug.WriteLine("i= {0}, t= {1}, Z= {2}", i, dataX[i], dataY3[i]);
            }
            max1++;
            max2++;
            max3++;
            min1--;
            min2--;
            min3--;

            var z1 = formsPlot_k1Fkp.Plot.Add.Scatter(dataX, dataY1);
            z1.MarkerSize = markerSize;
            z1.LineWidth = lineWidth;
            formsPlot_k1Fkp.Plot.Axes.SetLimitsX(0, (double)Tras);
            formsPlot_k1Fkp.Plot.Axes.SetLimitsY(min1, max1);
            formsPlot_k1Fkp.Plot.Axes.Left.Label.Text = "Уровень в УР, м";
            formsPlot_k1Fkp.Plot.Axes.Left.Label.Bold = false;
            formsPlot_k1Fkp.Plot.Axes.Bottom.Label.Text = "Время, с";
            formsPlot_k1Fkp.Plot.Axes.Bottom.Label.Bold = false;
            formsPlot_k1Fkp.Refresh();

            var z2 = formsPlot_Fkp.Plot.Add.Scatter(dataX, dataY2);
            z2.MarkerSize = markerSize;
            z2.LineWidth = lineWidth;
            formsPlot_Fkp.Plot.Axes.SetLimitsX(0, (double)Tras);
            formsPlot_Fkp.Plot.Axes.SetLimitsY(min2, max2);
            formsPlot_Fkp.Plot.Axes.Left.Label.Text = "Уровень в УР, м";
            formsPlot_Fkp.Plot.Axes.Left.Label.Bold = false;
            formsPlot_Fkp.Plot.Axes.Bottom.Label.Text = "Время, с";
            formsPlot_Fkp.Plot.Axes.Bottom.Label.Bold = false;
            formsPlot_Fkp.Refresh();

            var z3 = formsPlot_k2Fkp.Plot.Add.Scatter(dataX, dataY3);
            z3.MarkerSize = markerSize;
            z3.LineWidth = lineWidth;
            formsPlot_k2Fkp.Plot.Axes.SetLimitsX(0, (double)Tras);
            formsPlot_k2Fkp.Plot.Axes.SetLimitsY(min3, max3);
            formsPlot_k2Fkp.Plot.Axes.Left.Label.Text = "Уровень в УР, м";
            formsPlot_k2Fkp.Plot.Axes.Left.Label.Bold = false;
            formsPlot_k2Fkp.Plot.Axes.Bottom.Label.Text = "Время, с";
            formsPlot_k2Fkp.Plot.Axes.Bottom.Label.Bold = false;
            formsPlot_k2Fkp.Refresh();
        }

        private decimal GetDecimal(string str, decimal defaultValue)
        {
            decimal result;
            //Try parsing in the current culture
            if (!decimal.TryParse(str, NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                //Then try in US english
                !decimal.TryParse(str, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                //Then in neutral language
                !decimal.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                result = defaultValue;
                throw new ArgumentNullException();
            }

            return result;
        }

        private void ErrorMsg(TextBox textBox, string str)
        {
            textBox.BackColor = Color.Red;
            MessageBox.Show("Необходимо ввести " + str + ".", "Внимание!",
                    MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            return;
        }

        private static void TryDeleteFile(string path)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
            catch { /* Игнорируем ошибки удаления */ }
        }

        private void SaveData_button_Click(object sender, EventArgs e)
        {
            if (SaveData.ShowDialog() == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = SaveData.FileName;

                //если существует - удаляем
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }

                List<string> block1 = new List<string>();
                List<string> block2 = new List<string>();
                List<string> block3 = new List<string>();

                block1.Add(Ldt.Text);
                block1.Add(Fdt.Text);
                block1.Add(knt.Text);
                block2.Add(krt.Text);
                block3.Add(Qdt.Text);
                block3.Add(Hctt.Text);
                block3.Add(dtt.Text);
                block3.Add(Trast.Text);
                block3.Add(k1t.Text);
                block3.Add(k2t.Text);

                using (StreamWriter writer = new StreamWriter(filename, true, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(string.Join(";", block1));
                    writer.WriteLine(string.Join(";", block2));
                    writer.WriteLine(string.Join(";", block3));
                }
            }
        }

        private void OpenData_button_Click(object sender, EventArgs e)
        {
            if (OpenData.ShowDialog() == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = OpenData.FileName;

                List<List<string>> blocks = new List<List<string>>();

                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        List<string> row = line.Split(';').ToList();
                        blocks.Add(row);
                    }
                }

                List<string>? block1 = blocks.ElementAtOrDefault(0);
                List<string>? block2 = blocks.ElementAtOrDefault(1);
                List<string>? block3 = blocks.ElementAtOrDefault(2);

                try
                {
                    Ldt.Text = block1?.ElementAtOrDefault(0) ?? string.Empty;
                    Fdt.Text = block1?.ElementAtOrDefault(1) ?? string.Empty;
                    knt.Text = block1?.ElementAtOrDefault(2) ?? string.Empty;
                    krt.Text = block2?.ElementAtOrDefault(0) ?? string.Empty;
                    Qdt.Text = block3?.ElementAtOrDefault(0) ?? string.Empty;
                    Hctt.Text = block3?.ElementAtOrDefault(1) ?? string.Empty;
                    dtt.Text = block3?.ElementAtOrDefault(2) ?? string.Empty;
                    Trast.Text = block3?.ElementAtOrDefault(3) ?? string.Empty;
                    k1t.Text = block3?.ElementAtOrDefault(4) ?? string.Empty;
                    k2t.Text = block3?.ElementAtOrDefault(5) ?? string.Empty;
                }
                catch
                {
                    MessageBox.Show("Неверный формат файла исходных данных " +
                        "/ файл исходных данных повреждён.", "Внимание!",
                    MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
        }

        private void SaveResults_button_Click(object sender, EventArgs e)
        {
            if (SaveResults.ShowDialog() == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = SaveResults.FileName;

                //если существует - удаляем
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }

                using (StreamWriter writer = new StreamWriter(filename, true, System.Text.Encoding.UTF8))
                {
                    List<string> cases = new List<string>()
                        { "Fр = К1 * Fкр", "Fр = Fкр", "Fр = К2 * Fкр" };

                    List<string> columnsNames = new List<string>()
                        { "Время, с", "Расход турбинного водовода, м3/с", "Расход деривации, м3/с",
                        "Расход резервуара, м3/с", "Потери в деривации, м",
                        "Потери в резервуаре, м", "Уровень в резервуаре, м",
                        "Давление в деривации, м"};

                    for (int i = 0; i < 3; i++)
                    {
                        writer.WriteLine(string.Join(";", cases[i]));
                        writer.WriteLine(string.Join(";", columnsNames));

                        for (int j = 0; j < count[i]; j++)
                        {
                            List<string> list = new List<string>();
                            for (int k = 0; k < 8; k++)
                            {
                                decimal tmp;
                                tmp = Table[i, j, k];
                                //Debug.WriteLine("{0}, {1}, {2}", j, i, tmp);
                                list.Add(tmp.ToString());
                            }
                            writer.WriteLine(string.Join(";", list));
                        }
                    }
                }
            }
        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            byte[] fileData = Properties.Resources.ResUst_help;

            try
            {
                // Сохранение ресурса во временный файл
                File.WriteAllBytes(tempFilePath, fileData);

                // Запуск приложения по умолчанию
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = tempFilePath,
                    UseShellExecute = true // Ключевой параметр для использования ассоциаций ОС
                };
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                // Удаление файла в случае ошибки
                TryDeleteFile(tempFilePath);
            }
        }

        private void Ldt_TextChanged(object sender, EventArgs e)
        {
            if (Ldt.BackColor == Color.Red) { Ldt.BackColor = SystemColors.Window; }
        }

        private void Fdt_TextChanged(object sender, EventArgs e)
        {
            if (Fdt.BackColor == Color.Red) { Fdt.BackColor = SystemColors.Window; }
        }

        private void knt_TextChanged(object sender, EventArgs e)
        {
            if (knt.BackColor == Color.Red) { knt.BackColor = SystemColors.Window; }
        }

        private void krt_TextChanged(object sender, EventArgs e)
        {
            if (krt.BackColor == Color.Red) { krt.BackColor = SystemColors.Window; }
        }

        private void Qdt_TextChanged(object sender, EventArgs e)
        {
            if (Qdt.BackColor == Color.Red) { Qdt.BackColor = SystemColors.Window; }
        }

        private void Hctt_TextChanged(object sender, EventArgs e)
        {
            if (Hctt.BackColor == Color.Red) { Hctt.BackColor = SystemColors.Window; }
        }

        private void dtt_TextChanged(object sender, EventArgs e)
        {
            if (dtt.BackColor == Color.Red) { dtt.BackColor = SystemColors.Window; }
        }

        private void Trast_TextChanged(object sender, EventArgs e)
        {
            if (Trast.BackColor == Color.Red) { Trast.BackColor = SystemColors.Window; }
        }

        private void k1t_TextChanged(object sender, EventArgs e)
        {
            if (k1t.BackColor == Color.Red) { k1t.BackColor = SystemColors.Window; }
        }

        private void k2t_TextChanged(object sender, EventArgs e)
        {
            if (k2t.BackColor == Color.Red) { k2t.BackColor = SystemColors.Window; }
        }
    }
}
