namespace OOP1lb
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Win32.MessageBox(0, "������������ ������ � 1. �����. ����������� �����\r\n������. ��������� ����������", "������ 4: �����, �������", 0);
            Application.Run(new Form1());
        }
    }
}