namespace OOP1lb
{
    internal static class Program
    {
        static List<Zheck> zheckList = new();
        /// <summary>
        ///  ������� ����� � ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Win32.MessageBox(0, "������������ ������ � 1. �����. ����������� �����\r\n������. ��������� ����������", "������ 4: �����, �������", 0);
            
            Application.Run(new Form1(zheckList));
        }
    }
}