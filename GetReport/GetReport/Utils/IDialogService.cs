namespace GetReport.Utils
{
    interface IDialogService
    {
        void ShowMessage(string message);   // показ сообщения
        string FilePath { get; set; }   // путь к выбранному файлу
        bool OpenFileDialog();  // открытие файла
        bool OpenPath(); //открытие папки
        bool SaveFileDialog();  // сохранение файла
    }
}
