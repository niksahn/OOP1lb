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
            Win32.MessageBox(0, "Лабораторная работа № 1. Класс. Статические члены\r\nкласса. Обработка исключений", "Группа 4: Сахно, Никитов", 0);
            Application.Run(new Form1());
        }
    }
}