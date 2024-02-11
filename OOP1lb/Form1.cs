using System.Drawing;
using System.Xml.Linq;

namespace OOP1lb
{
    public partial class Form1 : Form
    {
        List<Zheck> zheckList;
        int selectedNum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Zheck> zheckList1)
        {
            InitializeComponent();
            zheckList = zheckList1;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string region = textReg.Text;
                string name = textNam.Text;
                double numberHabitians = (double)textHab.Value;
                double numberPayments = (double)textServ.Value;
                double numberOfBuildings = (double)textInn.Value;
                string contactEmail = textEmail.Text;
                float serviceArea = float.Parse(textSquare.Text);
                Zheck zheck = new Zheck(region, name, numberHabitians, numberPayments, numberOfBuildings, contactEmail, serviceArea);
                zheckList.Add(zheck);
                count.Text = Zheck.counter.ToString();
                listBox1.Items.Add(zheck.Name1);
            }
            catch (FormatException ex)
            {
                Win32.MessageBox(0, "Неверное значениие поля площадь обслуживания", "Ошибка", 0);
            }
            catch (MyException ex)
            {
                Win32.MessageBox(0, ex.Message, "Ошибка", 0);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNum = listBox1.SelectedIndex + 1;
            Zheck selected = zheckList.Find(item => item.Number1 == selectedNum);
            if (selected != null)
            {
                SelectedZheck(selected);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            try
            {
                selectedIndex = zheckList.FindIndex(item => item.Number1 == selectedNum);
                if (selectedIndex < 0 || selectedIndex > zheckList.Count - 1)
                {
                    throw new ArrayExeption("Элемент не найден", selectedIndex);
                }
                Zheck selected = zheckList[selectedIndex];

                if (selectedIndex < 0)
                {
                    return;
                }
                selected.ContactEmail1 = changingEmail.Text;
                selected.NumberHabitians1 = (double)changingHab.Value;
                selected.NumberOfBuildings1 = (double)changingHous.Value;
                selected.Region1 = changingReg.Text;
                selected.NumberPayments1 = (double)changingServ.Value;
                selected.Name1 = changing_name.Text;
                selected.ServiceArea1 = float.Parse(changingSquare.Text);
            }
            catch (FormatException)
            {
                Win32.MessageBox(0, "Неверное значениие поля площадь обслуживания", "Ошибка", 0);
            }
            catch (MyException ex)
            {
                Win32.MessageBox(0, ex.Message, "Ошибка", 0);
            }
            catch (ArrayExeption ex)
            {
                Win32.MessageBox(0, ex.Message + ex.Index, "Ошибка", 0);
            }
        }


        private void SelectedZheck(Zheck selected)
        {
            changingEmail.Text = selected.ContactEmail1;
            changingHab.Value = (decimal)selected.NumberHabitians1;
            changingHous.Value = (decimal)selected.NumberOfBuildings1;
            changingReg.Text = selected.Region1;
            changingServ.Value = (decimal)selected.NumberPayments1;
            changing_name.Text = selected.Name1;
            changing_number.Text = selected.Number1.ToString();
            changing_number_hex.Text = selected.GetNumberInHex();
            changingSquare.Text = selected.ServiceArea1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               int selectedIndex = zheckList.FindIndex(item => item.Number1 == selectedNum);
                if (selectedIndex < 0 || selectedIndex > zheckList.Count - 1)
                {
                    throw new ArrayExeption("Элемент не найден", (int)search.Value);
                }
                Zheck selected = zheckList[(int)search.Value];
                if (selected != null)
                {
                    SelectedZheck(selected);
                }
            }
            catch (ArrayExeption ex)
            {
                Win32.MessageBox(0, ex.Message + " " + ex.Index, "Ошибка", 0);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string region = textBox2.Text;
                Zheck zheck = new Zheck(region, name);
                zheckList.Add(zheck);
                count.Text = Zheck.counter.ToString();
                listBox1.Items.Add(zheck.Name1);
            }
            catch (MyException ex)
            {
                Win32.MessageBox(0, ex.Message, "Ошибка", 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zheck zheck = new();
            zheckList.Add(zheck);
            count.Text = Zheck.counter.ToString();
            listBox1.Items.Add(zheck.Name1);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}