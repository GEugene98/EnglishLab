using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup
{
    public partial class ProcessSetup : UserControl
    {
        protected BackgroundWorker bw = new BackgroundWorker();

        protected string rootPath;
        protected string fsPath;
        protected string rsFsPath;
        protected string rsMainPath;
        protected string picsWordSet;

        protected DirectoryInfo FilesDirectory;
        protected DirectoryInfo FirstStartDirectory;
        protected DirectoryInfo FirstStartResourcesDirectory;
        protected DirectoryInfo MainResourcesDirectory;
        protected DirectoryInfo MainPicturesDirectory;

        protected Form ParentShellForm;
        protected bool isError;

        public ProcessSetup(string path, Form form)
        {
            InitializeComponent();
            ParentShellForm = form;

            rootPath = path;
            fsPath = Path.Combine("files", "FirstStart");
            rsFsPath = Path.Combine("files", "Resources");
            rsMainPath = Path.Combine("files", "WordSets");
            picsWordSet = Path.Combine(rsMainPath, "Pictures");

            FilesDirectory = new DirectoryInfo("files");
            FirstStartDirectory = new DirectoryInfo(fsPath);
            FirstStartResourcesDirectory = new DirectoryInfo(rsFsPath);
            MainResourcesDirectory = new DirectoryInfo(rsMainPath);
            MainPicturesDirectory = new DirectoryInfo(picsWordSet);

            progress.Maximum =
                FilesDirectory.GetFiles().Length +
                FirstStartDirectory.GetFiles().Length +
                FirstStartResourcesDirectory.GetFiles().Length +
                MainResourcesDirectory.GetFiles().Length;

            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += Bw_ProgressChanged;

            bw.RunWorkerAsync();
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progress.Value = e.ProgressPercentage;
            }
            catch (Exception)
            {
                progress.Maximum++;
                progress.Value = e.ProgressPercentage;
            }

            logger.Text += e.UserState + Environment.NewLine;
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isError)
            {
                ParentShellForm.Close();
                return;
            }

            logger.Text += "Копирование файлов завершено" + Environment.NewLine;

            var appPath = Path.Combine(rootPath, "EnglishLab", "EnglishLab.exe");

            ShortcutManager.CreateShortcut("EnglishLab", appPath, appPath, ShortcutLocation.DESKTOP, String.Empty);
            ShortcutManager.CreateShortcut("EnglishLab", appPath, appPath, ShortcutLocation.START_MENU, String.Empty);

            logger.Text += "Создан ярлык на рабочем столе и в меню \"Пуск\"" + Environment.NewLine;
            logger.Text += "Нажмите \"Готово\" для выхода из программы установки";

            next.Enabled = true;
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = 0;

            var destinationDir = Path.Combine(rootPath, "EnglishLab");
            try
            {
                Directory.CreateDirectory(destinationDir);
            }
            catch (Exception)
            {
                MessageBox.Show("Запустите установку от имени администратора, если вы хотите установить приложение на диск C или измените путь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isError = true;
                return;
            }

            var files = FilesDirectory.GetFiles();
            foreach (var file in files)
            {
                file.CopyTo(Path.Combine(destinationDir, file.Name));
                bw.ReportProgress(++progress, "Копирование файла " + file.Name);
            }

            files = FirstStartResourcesDirectory.GetFiles();
            Directory.CreateDirectory(Path.Combine(destinationDir, "Resources"));
            foreach (var file in files)
            {
                file.CopyTo(Path.Combine(destinationDir, "Resources", file.Name));
                bw.ReportProgress(++progress, "Копирование файла " + file.Name);
            }

            files = MainResourcesDirectory.GetFiles();
            Directory.CreateDirectory(Path.Combine(destinationDir, "WordSets"));
            foreach (var file in files)
            {
                file.CopyTo(Path.Combine(destinationDir, "WordSets", file.Name));
                bw.ReportProgress(++progress, "Копирование файла " + file.Name);
            }

            files = MainPicturesDirectory.GetFiles();
            Directory.CreateDirectory(Path.Combine(destinationDir, "WordSets", "Pictures"));
            foreach (var file in files)
            {
                file.CopyTo(Path.Combine(destinationDir, "WordSets", "Pictures", file.Name));
                bw.ReportProgress(++progress, "Копирование файла " + file.Name);
            }

            files = FirstStartDirectory.GetFiles();
            Directory.CreateDirectory(Path.Combine(destinationDir, "FirstStart"));
            foreach (var file in files)
            {
                file.CopyTo(Path.Combine(destinationDir, "FirstStart", file.Name));
                bw.ReportProgress(++progress, "Копирование файла " + file.Name);
            }

        }

        private void logger_TextChanged(object sender, EventArgs e)
        {
            logger.SelectionStart = logger.Text.Length;
            logger.ScrollToCaret();
        }

        private void next_Click(object sender, EventArgs e)
        {
            ParentShellForm.Close();
        }
    }
}
