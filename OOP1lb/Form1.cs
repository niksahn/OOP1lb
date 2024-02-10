namespace OOP1lb
{
    public partial class Form1 : Form
    {
        static List<Zheck> zheckList = new List<Zheck>();
        int selectedNum = 0;
        public Form1()
        {
            InitializeComponent();
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
                listBox1.Items.Add(zheck.Name1);
            }
            catch (ArgumentNullException ex)
            {
                Win32.MessageBox(0, "Пустое значениие поля", "Ошибка", 0);
            }
            catch (FormatException ex)
            {
                Win32.MessageBox(0, "Неверное значениие поля", "Ошибка", 0);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNum = listBox1.SelectedIndex;
            Zheck selected = zheckList.Find(item => item.Number1 == selectedNum);
            try
            {
                if (selected != null)
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
            }
            catch (ArgumentNullException ex)
            {
                Win32.MessageBox(0, "Пустое значениие поля", "Ошибка", 0);
            }
            catch (FormatException ex)
            {
                Win32.MessageBox(0, "Неверное значениие поля", "Ошибка", 0);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedIndex = zheckList.FindIndex(item => item.Number1 == selectedNum);
            Zheck selected = zheckList[selectedIndex];
            if (selectedIndex < 0)
            {
                return;
            }
            selected.ContactEmail1=changingEmail.Text;
            selected.NumberHabitians1 =(double) changingHab.Value;
            selected.NumberOfBuildings1 =(double) changingHous.Value;
            selected.Region1 =changingReg.Text;
            selected.NumberPayments1=(double)changingServ.Value;
            selected.Name1=changing_name.Text;
             selected.ServiceArea1 = float.Parse(changingSquare.Text);
        }
    }
}