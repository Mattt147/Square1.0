﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        double p = 0;
        const string msg = "Периметр задаётся целым числом или вещественным, дробная часть отделяется запятой";
        private void button1_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch(Exception ex) { MessageBox.Show(msg); return; }
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
        }

        private void buttonRectangle2_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
        }

        private void buttonGoldRectangle_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
        }

        private void buttonRhomb_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
        }
    }
}
