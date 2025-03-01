using System;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace PCHUB
{
    public partial class TextFileCreator : Form
    {
        public TextFileCreator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
            string fileName = txtFileName.Text;
            string filePath = txtFilePath.Text;
            string fileContent = txtFileContent.Text;


            {
                // Проверяем, содержит ли имя файла кавычки
                bool isHidden = fileName.StartsWith("\"") && fileName.EndsWith("\"");

                // Убираем кавычки из имени файла для создания файла
                string sanitizedFileName = isHidden ? fileName.Trim('"') : fileName;

                // Полный путь к файлу
                string fullPath = Path.Combine(filePath, sanitizedFileName + ".txt");

                try
                {
                    // Создание файла и запись в него содержимого
                    File.WriteAllText(fullPath, fileContent);

                    // Уведомление о успешном создании файла
                    lblStatus.Text = "Файл успешно создан: " + fullPath;

                    // Если имя файла было указано в кавычках, делаем файл скрытым
                    if (isHidden)
                    {
                        // Устанавливаем атрибут "Скрытый" для файла
                        File.SetAttributes(fullPath, File.GetAttributes(fullPath) | FileAttributes.Hidden);
                        Console.WriteLine($"Файл '{fullPath}' теперь скрыт.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании файла: " + ex.Message);
                }
            }
        }

        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 
        private void backToHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAIN hub = new MAIN();
            hub.Show();
            this.Close();
        }
        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 

        private void TextFileCreator_Load(object sender, EventArgs e)
        {

        }

        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 

        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 
        private void purpleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;
        }
        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 

        //ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About(); // Создаем новый экземпляр Form2
            about.Show(); // Открываем Form2 как независимую форму
        }
        //ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU 

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
