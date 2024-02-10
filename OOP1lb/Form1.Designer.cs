namespace OOP1lb
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
            textBox8 = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            textReg = new TextBox();
            textEmail = new TextBox();
            textSquare = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            textInn = new NumericUpDown();
            textServ = new NumericUpDown();
            textHab = new NumericUpDown();
            label8 = new Label();
            textNam = new TextBox();
            panel3 = new Panel();
            changingHous = new NumericUpDown();
            changingHab = new NumericUpDown();
            changingServ = new NumericUpDown();
            label20 = new Label();
            button4 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label19 = new Label();
            changing_number_hex = new Label();
            label18 = new Label();
            changing_number = new Label();
            label17 = new Label();
            changing_name = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            changingSquare = new TextBox();
            changingEmail = new TextBox();
            changingReg = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textInn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textServ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textHab).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)changingHous).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changingHab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changingServ).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 27);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 9);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 1;
            label9.Text = "Поиск по номеру";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox8);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 596);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(133, 27);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 3;
            button2.Text = "Найти";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 529);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.Location = new Point(8, 375);
            button1.Name = "button1";
            button1.Size = new Size(214, 26);
            button1.TabIndex = 0;
            button1.Text = "Зарегистрировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.Location = new Point(54, 25);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 1;
            label1.Text = "Зарегистрировать ЖЭК";
            // 
            // textReg
            // 
            textReg.Location = new Point(124, 88);
            textReg.Name = "textReg";
            textReg.Size = new Size(100, 23);
            textReg.TabIndex = 2;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(124, 266);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 23);
            textEmail.TabIndex = 6;
            // 
            // textSquare
            // 
            textSquare.Location = new Point(124, 313);
            textSquare.Name = "textSquare";
            textSquare.Size = new Size(100, 23);
            textSquare.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 93);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 9;
            label2.Text = "Регион";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 128);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 10;
            label3.Text = "Число жителей";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 178);
            label4.Name = "label4";
            label4.Size = new Size(114, 30);
            label4.TabIndex = 11;
            label4.Text = "Число оплативших\r\n услуги";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 224);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 12;
            label5.Text = "Число домов";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 266);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 13;
            label6.Text = "email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 302);
            label7.Name = "label7";
            label7.Size = new Size(97, 45);
            label7.TabIndex = 14;
            label7.Text = "Площадь \r\nобслуживаемой\r\nтерритории";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuBar;
            panel2.Controls.Add(textInn);
            panel2.Controls.Add(textServ);
            panel2.Controls.Add(textHab);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textNam);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textSquare);
            panel2.Controls.Add(textEmail);
            panel2.Controls.Add(textReg);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(373, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 412);
            panel2.TabIndex = 1;
            // 
            // textInn
            // 
            textInn.Location = new Point(124, 216);
            textInn.Name = "textInn";
            textInn.Size = new Size(100, 23);
            textInn.TabIndex = 19;
            // 
            // textServ
            // 
            textServ.Location = new Point(124, 176);
            textServ.Name = "textServ";
            textServ.Size = new Size(100, 23);
            textServ.TabIndex = 18;
            // 
            // textHab
            // 
            textHab.Location = new Point(124, 128);
            textHab.Name = "textHab";
            textHab.Size = new Size(100, 23);
            textHab.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 54);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 16;
            label8.Text = "Название";
            // 
            // textNam
            // 
            textNam.Location = new Point(124, 49);
            textNam.Name = "textNam";
            textNam.Size = new Size(100, 23);
            textNam.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(changingHous);
            panel3.Controls.Add(changingHab);
            panel3.Controls.Add(changingServ);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(changing_number_hex);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(changing_number);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(changing_name);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(changingSquare);
            panel3.Controls.Add(changingEmail);
            panel3.Controls.Add(changingReg);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(241, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 593);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // changingHous
            // 
            changingHous.Location = new Point(155, 270);
            changingHous.Name = "changingHous";
            changingHous.Size = new Size(100, 23);
            changingHous.TabIndex = 37;
            // 
            // changingHab
            // 
            changingHab.Location = new Point(155, 168);
            changingHab.Name = "changingHab";
            changingHab.Size = new Size(100, 23);
            changingHab.TabIndex = 36;
            // 
            // changingServ
            // 
            changingServ.Location = new Point(159, 216);
            changingServ.Name = "changingServ";
            changingServ.Size = new Size(100, 23);
            changingServ.TabIndex = 35;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(39, 272);
            label20.Name = "label20";
            label20.Size = new Size(80, 15);
            label20.TabIndex = 34;
            label20.Text = "Число домов";
            // 
            // button4
            // 
            button4.Location = new Point(99, 445);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 33;
            button4.Text = "Изменить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label19);
            panel4.Location = new Point(373, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 174);
            panel4.TabIndex = 32;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.Location = new Point(5, 143);
            button3.Name = "button3";
            button3.Size = new Size(214, 26);
            button3.TabIndex = 7;
            button3.Text = "Зарегистрировать";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(14, 87);
            label22.Name = "label22";
            label22.Size = new Size(59, 15);
            label22.TabIndex = 4;
            label22.Text = "Название";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(14, 46);
            label21.Name = "label21";
            label21.Size = new Size(46, 15);
            label21.TabIndex = 3;
            label21.Text = "Регион";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Linen;
            label19.Location = new Point(53, 10);
            label19.Name = "label19";
            label19.Size = new Size(135, 15);
            label19.TabIndex = 2;
            label19.Text = "Зарегистрировать ЖЭК";
            // 
            // changing_number_hex
            // 
            changing_number_hex.AutoSize = true;
            changing_number_hex.Location = new Point(230, 90);
            changing_number_hex.Name = "changing_number_hex";
            changing_number_hex.Size = new Size(44, 15);
            changing_number_hex.TabIndex = 31;
            changing_number_hex.Text = "label18";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(39, 90);
            label18.Name = "label18";
            label18.Size = new Size(164, 15);
            label18.TabIndex = 30;
            label18.Text = "Номер в 16-ричной системе";
            // 
            // changing_number
            // 
            changing_number.AutoSize = true;
            changing_number.Location = new Point(159, 59);
            changing_number.Name = "changing_number";
            changing_number.Size = new Size(44, 15);
            changing_number.TabIndex = 29;
            changing_number.Text = "label18";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(41, 59);
            label17.Name = "label17";
            label17.Size = new Size(45, 15);
            label17.TabIndex = 28;
            label17.Text = "Номер";
            // 
            // changing_name
            // 
            changing_name.AutoSize = true;
            changing_name.Location = new Point(159, 35);
            changing_name.Name = "changing_name";
            changing_name.Size = new Size(44, 15);
            changing_name.TabIndex = 27;
            changing_name.Text = "label17";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 168);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 22;
            label11.Text = "Число жителей";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 342);
            label12.Name = "label12";
            label12.Size = new Size(97, 45);
            label12.TabIndex = 26;
            label12.Text = "Площадь \r\nобслуживаемой\r\nтерритории";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 306);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 25;
            label13.Text = "email";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(34, 218);
            label15.Name = "label15";
            label15.Size = new Size(114, 30);
            label15.TabIndex = 23;
            label15.Text = "Число оплативших\r\n услуги";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(41, 130);
            label16.Name = "label16";
            label16.Size = new Size(46, 15);
            label16.TabIndex = 21;
            label16.Text = "Регион";
            // 
            // changingSquare
            // 
            changingSquare.Location = new Point(155, 353);
            changingSquare.Name = "changingSquare";
            changingSquare.Size = new Size(100, 23);
            changingSquare.TabIndex = 20;
            // 
            // changingEmail
            // 
            changingEmail.Location = new Point(155, 306);
            changingEmail.Name = "changingEmail";
            changingEmail.Size = new Size(100, 23);
            changingEmail.TabIndex = 19;
            // 
            // changingReg
            // 
            changingReg.Location = new Point(155, 128);
            changingReg.Name = "changingReg";
            changingReg.Size = new Size(100, 23);
            changingReg.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 32);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 2;
            label10.Text = "Информация о ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(839, 595);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textInn).EndInit();
            ((System.ComponentModel.ISupportInitialize)textServ).EndInit();
            ((System.ComponentModel.ISupportInitialize)textHab).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)changingHous).EndInit();
            ((System.ComponentModel.ISupportInitialize)changingHab).EndInit();
            ((System.ComponentModel.ISupportInitialize)changingServ).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox8;
        private Label label9;
        private Panel panel1;
        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private TextBox textReg;
        private TextBox textEmail;
        private TextBox textSquare;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Button button2;
        private Panel panel3;
        private Label label10;
        private Label changing_name;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private TextBox changingEmail;
        private TextBox changingReg;
        private Label changing_number_hex;
        private Label label18;
        private Label changing_number;
        private Label label17;
        private Panel panel4;
        private Label label19;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label22;
        private Label label21;
        private NumericUpDown textInn;
        private NumericUpDown textServ;
        private NumericUpDown textHab;
        private Label label8;
        private TextBox textNam;
        private Button button4;
        private NumericUpDown changingHous;
        private NumericUpDown changingHab;
        private NumericUpDown changingServ;
        private Label label20;
        private TextBox changingSquare;
    }
}