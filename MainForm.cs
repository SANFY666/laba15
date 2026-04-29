using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace laba15
{
    public partial class MainForm : Form
    {
        private AppSettings _settings = new AppSettings();

        public MainForm()
        {
            InitializeComponent();
            _settings.Load();
        }

        // кнопка Налаштування
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(_settings);
            sf.ShowDialog();
        }

        // кнопка Підключитися
        private void btnConnect_Click(object sender, EventArgs e)
        {
            treeViewFtp.Nodes.Clear();
            TreeNode rootNode = new TreeNode(_settings.Host);
            treeViewFtp.Nodes.Add(rootNode);

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_settings.Host);
                request.Credentials = new NetworkCredential(_settings.Username, _settings.Password);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length >= 9)
                        {
                            string name = string.Join(" ", parts.Skip(8));
                            if (name == "." || name == "..") continue;

                            string displayText = chkDetailedView.Checked ? line : name;

                            TreeNode node = new TreeNode(displayText);
                            rootNode.Nodes.Add(node);
                        }
                    }
                }
                rootNode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення: " + ex.Message);
            }
        }

        // дізнатися розмір файлу
        private void GetFileSize(string fileName)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_settings.Host + fileName);
            request.Credentials = new NetworkCredential(_settings.Username, _settings.Password);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show($"Розмір файлу {fileName}: {response.ContentLength} байт");
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
        }

        // видалити файл
        private void DeleteFile(string fileName)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_settings.Host + fileName);
                request.Credentials = new NetworkCredential(_settings.Username, _settings.Password);
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show($"Файл видалено. Статус: {response.StatusDescription}");
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка видалення: " + ex.Message); }
        }

        // створити або видалити папку 
        private void ManageDirectory(string dirName, string method)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_settings.Host + dirName);
                request.Credentials = new NetworkCredential(_settings.Username, _settings.Password);
                request.Method = method;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show($"Операція успішна: {response.StatusDescription}");
                }
            }
            catch (Exception ex) { MessageBox.Show("Помилка роботи з каталогом: " + ex.Message); }
        }

        // завантаження файлу на сервер
        private void UploadSingleFile(string localFilePath)
        {
            try
            {
                string fileName = Path.GetFileName(localFilePath);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_settings.Host + fileName);
                request.Credentials = new NetworkCredential(_settings.Username, _settings.Password);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] fileContents = File.ReadAllBytes(localFilePath);
                request.ContentLength = fileContents.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }
            }
            catch (Exception ex) { MessageBox.Show($"Помилка завантаження {localFilePath}: " + ex.Message); }
        }

        // завантаження декількох файлів на сервер
        private void btnUploadMultiple_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; 
            ofd.Title = "Вибери файли для завантаження на FTP";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in ofd.FileNames)
                {
                    UploadSingleFile(filePath);
                }
                MessageBox.Show("Усі вибрані файли завантажено");

                btnConnect_Click(sender, e);
            }
        }

        // кнопка дізнатися розмір файлу
        private void btnFileSize_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                GetFileSize(txtFileName.Text);
            }
            else
            {
                MessageBox.Show("Напиши назву файлу", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // кнопка видалити файл
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                DeleteFile(txtFileName.Text);
                btnConnect_Click(sender, e); // Оновлюємо список після видалення
            }
            else
            {
                MessageBox.Show("Напиши назву файлу для видалення", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // кнопка створити папку
        private void btnCreateDir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDirName.Text))
            {
                ManageDirectory(txtDirName.Text, WebRequestMethods.Ftp.MakeDirectory);
                btnConnect_Click(sender, e); // Оновлюємо список
            }
            else
            {
                MessageBox.Show("Напиши назву папки", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // кнопка видалити папку
        private void btnDeleteDir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDirName.Text))
            {
                ManageDirectory(txtDirName.Text, WebRequestMethods.Ftp.RemoveDirectory);
                btnConnect_Click(sender, e); // Оновлюємо список
            }
            else
            {
                MessageBox.Show("Напиши назву папки для видалення", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // скачати файлу з сервера
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text)) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = txtFileName.Text; 
            sfd.Title = "Зберегти файл як...";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_settings.Host + txtFileName.Text);
                    request.Credentials = new NetworkCredential(_settings.Username, _settings.Password);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    using (Stream responseStream = response.GetResponseStream())
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        responseStream.CopyTo(fs);
                    }
                    MessageBox.Show("Файл успішно збережено на пк", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Помилка скачування: " + ex.Message); }
            }
        }

        // перейменування файлу на сервері
        private void btnRename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text) || string.IsNullOrWhiteSpace(txtNewName.Text))
            {
                MessageBox.Show("Напиши стару назву в поле Файл та нову назву в сусіднє поле", "Увага");
                return;
            }

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_settings.Host + txtFileName.Text);
                request.Credentials = new NetworkCredential(_settings.Username, _settings.Password);
                request.Method = WebRequestMethods.Ftp.Rename;
                request.RenameTo = txtNewName.Text;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse()) { }
                MessageBox.Show("Успішно перейменовано!");
                btnConnect_Click(null, null); 
            }
            catch (Exception ex) { MessageBox.Show("Помилка перейменування: " + ex.Message); }
        }

        // завантаження папки з пк на сервер
        private void btnUploadFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Вибери папку для завантаження на сервер";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string folderName = new DirectoryInfo(fbd.SelectedPath).Name;
                        ManageDirectory(folderName, WebRequestMethods.Ftp.MakeDirectory);

                        string[] files = Directory.GetFiles(fbd.SelectedPath);
                        foreach (string filePath in files)
                        {
                            string fileName = Path.GetFileName(filePath);

                            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_settings.Host + folderName + "/" + fileName);
                            request.Credentials = new NetworkCredential(_settings.Username, _settings.Password);
                            request.Method = WebRequestMethods.Ftp.UploadFile;

                            byte[] fileContents = File.ReadAllBytes(filePath);
                            request.ContentLength = fileContents.Length;

                            using (Stream requestStream = request.GetRequestStream())
                            {
                                requestStream.Write(fileContents, 0, fileContents.Length);
                            }
                        }
                        MessageBox.Show($"Папку '{folderName}' та всі її файли успішно завантажено!");
                        btnConnect_Click(null, null); 
                    }
                    catch (Exception ex) { MessageBox.Show("Помилка завантаження папки: " + ex.Message); }
                }
            }
        }

        // перемикання між детальним та простим переглядом
        private void chkDetailedView_CheckedChanged(object sender, EventArgs e)
        {
            btnConnect_Click(sender, e); 
        }

    }
}