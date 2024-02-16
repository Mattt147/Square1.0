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
        // вводим переменную 
        double p = 0;
        // обозначаем текст сообщения об ошибке
        const string msg = "Периметр задаётся целым или вещественным положительным числом , дробная часть отделяется запятой";
        private void button1_Click(object sender, EventArgs e)
        {
            // Делаем проверку вводимого числа, если число введено не правильно выводится сообщение об ошибке
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch(Exception ex) { MessageBox.Show(msg); return; }
            if (p <= 0) {MessageBox.Show(msg); return; }
            // в случае успешного ввода, обрабатываем число через функцию основного кода и выводим в текстовое поле
            textBoxSquare.Text = SquareModel.SquareQudrat(p).ToString();

        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            if (p <= 0) {MessageBox.Show(msg); return; }
            textBoxCircle.Text = SquareModel.SquareCircle(p).ToString();
        }


        private void buttonRectangle2_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            if (p < 0) { MessageBox.Show(msg); return; }
            textBoxRectangle2.Text = SquareModel.SquareRectangle2(p).ToString();
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            if (p <= 0) { MessageBox.Show(msg); return; }
            textBoxHexagon.Text = SquareModel.SquareHexagon(p).ToString();
        }

        private void buttonGoldRectangle_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            if (p <= 0) { MessageBox.Show(msg); return; }
            textBoxGoldRectang.Text = SquareModel.SquareRectangleGold(p).ToString();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            if (p <= 0) { MessageBox.Show(msg); return; }
            textBoxTriangle.Text = SquareModel.SquareTriangle(p).ToString();
        }

        private void buttonRhomb_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            if (p <= 0) { MessageBox.Show(msg); return; }
            textBoxRhomb.Text = SquareModel.SquareRomb(p).ToString();
            
        }

        private void buttonAllForms_Click(object sender, EventArgs e)
        {
            try { p = double.Parse(textBoxPerimetr.Text); }
            catch (Exception ex) { MessageBox.Show(msg); return; }
            if (p <= 0) { MessageBox.Show(msg); return; }
            // обрабатываем все значения и выводим в текстовое поле
            textBoxRhomb.Text = SquareModel.SquareRomb(p).ToString();
            textBoxTriangle.Text = SquareModel.SquareTriangle(p).ToString();
            textBoxGoldRectang.Text = SquareModel.SquareRectangleGold(p).ToString();
            textBoxHexagon.Text = SquareModel.SquareHexagon(p).ToString();
            textBoxRectangle2.Text = SquareModel.SquareRectangle2(p).ToString();
            textBoxCircle.Text = SquareModel.SquareCircle(p).ToString();
            textBoxSquare.Text = SquareModel.SquareQudrat(p).ToString();

        }

        private void buttonDelite_Click(object sender, EventArgs e)
        {
            // удаляем все значения из текстовго поля
            textBoxSquare.Text = string.Empty;
            textBoxCircle.Text = string.Empty;
            textBoxRhomb.Text = string.Empty;
            textBoxTriangle.Text = string.Empty;
            textBoxGoldRectang.Text = string.Empty;
            textBoxHexagon.Text = string.Empty;
            textBoxRectangle2.Text = string.Empty;
            textBoxPerimetr.Text = string.Empty;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
