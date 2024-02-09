using ClassLibrarySquares;
using System;
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

            textBoxSquare.Text = SquareModel.SquareQudrat(p).ToString();

        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }

            textBoxCircle.Text = SquareModel.SquareCircle(p).ToString();
        }


        private void buttonRectangle2_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            textBoxRectangle2.Text = SquareModel.SquareRectangle2(p).ToString();
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }

            buttonHexagon.Text = SquareModel.SquareHexagon(p).ToString();
        }

        private void buttonGoldRectangle_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }

            buttonGoldRectangle.Text = SquareModel.SquareRectangleGold(p).ToString();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            buttonTriangle.Text = SquareModel.SquareTriangle(p).ToString();
        }

        private void buttonRhomb_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            buttonRhomb.Text = SquareModel.SquareRomb(p).ToString();
            
        }

        private void buttonAllForms_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            buttonRhomb.Text = SquareModel.SquareRomb(p).ToString();
            buttonTriangle.Text = SquareModel.SquareTriangle(p).ToString();
            buttonGoldRectangle.Text = SquareModel.SquareRectangleGold(p).ToString();
            buttonHexagon.Text = SquareModel.SquareHexagon(p).ToString();
            textBoxRectangle2.Text = SquareModel.SquareRectangle2(p).ToString();
            textBoxCircle.Text = SquareModel.SquareCircle(p).ToString();
            textBoxSquare.Text = SquareModel.SquareQudrat(p).ToString();

        }

        private void buttonDelite_Click(object sender, EventArgs e)
        {
            textBoxSquare.Text = string.Empty;
            textBoxCircle.Text = string.Empty;
            buttonRhomb.Text = string.Empty;
            buttonTriangle.Text = string.Empty;
            buttonGoldRectangle.Text = string.Empty;
            buttonHexagon.Text = string.Empty;
            textBoxRectangle2.Text = string.Empty;

        }
    }
}
