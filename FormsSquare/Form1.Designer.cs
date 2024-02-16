namespace FormsSquare
{
    partial class Form1
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPerimetr = new System.Windows.Forms.TextBox();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonRectangle2 = new System.Windows.Forms.Button();
            this.buttonHexagon = new System.Windows.Forms.Button();
            this.buttonGoldRectangle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonRhomb = new System.Windows.Forms.Button();
            this.textBoxCircle = new System.Windows.Forms.TextBox();
            this.textBoxRectangle2 = new System.Windows.Forms.TextBox();
            this.textBoxHexagon = new System.Windows.Forms.TextBox();
            this.textBoxGoldRectang = new System.Windows.Forms.TextBox();
            this.textBoxTriangle = new System.Windows.Forms.TextBox();
            this.textBoxRhomb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAllForms = new System.Windows.Forms.Button();
            this.buttonDelite = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 562);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Location = new System.Drawing.Point(165, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 99);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Location = new System.Drawing.Point(143, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 101);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OliveDrab;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(144, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(583, 101);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ограда для фермера";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPerimetr
            // 
            this.textBoxPerimetr.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerimetr.Location = new System.Drawing.Point(351, 125);
            this.textBoxPerimetr.Multiline = true;
            this.textBoxPerimetr.Name = "textBoxPerimetr";
            this.textBoxPerimetr.Size = new System.Drawing.Size(198, 46);
            this.textBoxPerimetr.TabIndex = 3;
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonSquare.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSquare.Location = new System.Drawing.Point(558, 183);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(228, 44);
            this.buttonSquare.TabIndex = 4;
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSquare.Location = new System.Drawing.Point(351, 183);
            this.textBoxSquare.Multiline = true;
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(198, 44);
            this.textBoxSquare.TabIndex = 5;
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonCircle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCircle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCircle.Location = new System.Drawing.Point(555, 233);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(227, 40);
            this.buttonCircle.TabIndex = 6;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonRectangle2
            // 
            this.buttonRectangle2.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonRectangle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRectangle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRectangle2.Location = new System.Drawing.Point(556, 279);
            this.buttonRectangle2.Name = "buttonRectangle2";
            this.buttonRectangle2.Size = new System.Drawing.Size(227, 44);
            this.buttonRectangle2.TabIndex = 7;
            this.buttonRectangle2.Text = "Прямоугольник с отношением сторон равном 2";
            this.buttonRectangle2.UseVisualStyleBackColor = false;
            this.buttonRectangle2.Click += new System.EventHandler(this.buttonRectangle2_Click);
            // 
            // buttonHexagon
            // 
            this.buttonHexagon.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonHexagon.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHexagon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHexagon.Location = new System.Drawing.Point(556, 329);
            this.buttonHexagon.Name = "buttonHexagon";
            this.buttonHexagon.Size = new System.Drawing.Size(225, 46);
            this.buttonHexagon.TabIndex = 8;
            this.buttonHexagon.Text = "Правильный шестиугольник";
            this.buttonHexagon.UseVisualStyleBackColor = false;
            this.buttonHexagon.Click += new System.EventHandler(this.buttonHexagon_Click);
            // 
            // buttonGoldRectangle
            // 
            this.buttonGoldRectangle.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonGoldRectangle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoldRectangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoldRectangle.Location = new System.Drawing.Point(555, 381);
            this.buttonGoldRectangle.Name = "buttonGoldRectangle";
            this.buttonGoldRectangle.Size = new System.Drawing.Size(224, 46);
            this.buttonGoldRectangle.TabIndex = 9;
            this.buttonGoldRectangle.Text = "Прямоугольник с золотым сечением";
            this.buttonGoldRectangle.UseVisualStyleBackColor = false;
            this.buttonGoldRectangle.Click += new System.EventHandler(this.buttonGoldRectangle_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonTriangle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTriangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTriangle.Location = new System.Drawing.Point(556, 433);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(222, 41);
            this.buttonTriangle.TabIndex = 10;
            this.buttonTriangle.Text = "Равносторонний треугольник";
            this.buttonTriangle.UseVisualStyleBackColor = false;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonRhomb
            // 
            this.buttonRhomb.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonRhomb.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRhomb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRhomb.Location = new System.Drawing.Point(558, 480);
            this.buttonRhomb.Name = "buttonRhomb";
            this.buttonRhomb.Size = new System.Drawing.Size(221, 43);
            this.buttonRhomb.TabIndex = 11;
            this.buttonRhomb.Text = "Ромб с углом в 60 градусов";
            this.buttonRhomb.UseVisualStyleBackColor = false;
            this.buttonRhomb.Click += new System.EventHandler(this.buttonRhomb_Click);
            // 
            // textBoxCircle
            // 
            this.textBoxCircle.Location = new System.Drawing.Point(351, 233);
            this.textBoxCircle.Multiline = true;
            this.textBoxCircle.Name = "textBoxCircle";
            this.textBoxCircle.Size = new System.Drawing.Size(197, 40);
            this.textBoxCircle.TabIndex = 12;
            // 
            // textBoxRectangle2
            // 
            this.textBoxRectangle2.Location = new System.Drawing.Point(351, 279);
            this.textBoxRectangle2.Multiline = true;
            this.textBoxRectangle2.Name = "textBoxRectangle2";
            this.textBoxRectangle2.Size = new System.Drawing.Size(197, 44);
            this.textBoxRectangle2.TabIndex = 13;
            // 
            // textBoxHexagon
            // 
            this.textBoxHexagon.Location = new System.Drawing.Point(351, 329);
            this.textBoxHexagon.Multiline = true;
            this.textBoxHexagon.Name = "textBoxHexagon";
            this.textBoxHexagon.Size = new System.Drawing.Size(197, 46);
            this.textBoxHexagon.TabIndex = 14;
            // 
            // textBoxGoldRectang
            // 
            this.textBoxGoldRectang.Location = new System.Drawing.Point(351, 381);
            this.textBoxGoldRectang.Multiline = true;
            this.textBoxGoldRectang.Name = "textBoxGoldRectang";
            this.textBoxGoldRectang.Size = new System.Drawing.Size(196, 45);
            this.textBoxGoldRectang.TabIndex = 15;
            // 
            // textBoxTriangle
            // 
            this.textBoxTriangle.Location = new System.Drawing.Point(351, 432);
            this.textBoxTriangle.Multiline = true;
            this.textBoxTriangle.Name = "textBoxTriangle";
            this.textBoxTriangle.Size = new System.Drawing.Size(195, 41);
            this.textBoxTriangle.TabIndex = 16;
            // 
            // textBoxRhomb
            // 
            this.textBoxRhomb.Location = new System.Drawing.Point(351, 480);
            this.textBoxRhomb.Multiline = true;
            this.textBoxRhomb.Name = "textBoxRhomb";
            this.textBoxRhomb.Size = new System.Drawing.Size(194, 43);
            this.textBoxRhomb.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(158, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Введите периметр :";
            // 
            // buttonAllForms
            // 
            this.buttonAllForms.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAllForms.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllForms.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonAllForms.Location = new System.Drawing.Point(152, 415);
            this.buttonAllForms.Name = "buttonAllForms";
            this.buttonAllForms.Size = new System.Drawing.Size(183, 49);
            this.buttonAllForms.TabIndex = 20;
            this.buttonAllForms.Text = "Все формы";
            this.buttonAllForms.UseVisualStyleBackColor = false;
            this.buttonAllForms.Click += new System.EventHandler(this.buttonAllForms_Click);
            // 
            // buttonDelite
            // 
            this.buttonDelite.BackColor = System.Drawing.Color.Brown;
            this.buttonDelite.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelite.Location = new System.Drawing.Point(154, 470);
            this.buttonDelite.Name = "buttonDelite";
            this.buttonDelite.Size = new System.Drawing.Size(182, 53);
            this.buttonDelite.TabIndex = 21;
            this.buttonDelite.Text = "Очистить ";
            this.buttonDelite.UseVisualStyleBackColor = false;
            this.buttonDelite.Click += new System.EventHandler(this.buttonDelite_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(162, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Выберите площадь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(831, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDelite);
            this.Controls.Add(this.buttonAllForms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRhomb);
            this.Controls.Add(this.textBoxTriangle);
            this.Controls.Add(this.textBoxGoldRectang);
            this.Controls.Add(this.textBoxHexagon);
            this.Controls.Add(this.textBoxRectangle2);
            this.Controls.Add(this.textBoxCircle);
            this.Controls.Add(this.buttonRhomb);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.buttonGoldRectangle);
            this.Controls.Add(this.buttonHexagon);
            this.Controls.Add(this.buttonRectangle2);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.textBoxSquare);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.textBoxPerimetr);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPerimetr;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonRectangle2;
        private System.Windows.Forms.Button buttonHexagon;
        private System.Windows.Forms.Button buttonGoldRectangle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonRhomb;
        private System.Windows.Forms.TextBox textBoxCircle;
        private System.Windows.Forms.TextBox textBoxRectangle2;
        private System.Windows.Forms.TextBox textBoxHexagon;
        private System.Windows.Forms.TextBox textBoxGoldRectang;
        private System.Windows.Forms.TextBox textBoxTriangle;
        private System.Windows.Forms.TextBox textBoxRhomb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAllForms;
        private System.Windows.Forms.Button buttonDelite;
        private System.Windows.Forms.Label label3;
    }
}

