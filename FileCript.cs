using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES256
{
    internal class FileCript
    {

        public void CreateFileCription(string filename, string saveFilePath) {
            string? fileText;
            string? nameFile;
            using (FileStream fileStream = new FileStream(filename,FileMode.Open)) {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                fileText = Encoding.UTF8.GetString(buffer);
                nameFile = Path.GetFileName(fileStream.Name);
            }
           // Console.WriteLine(fileText);

            string? toCriptionFile=Path.Combine(saveFilePath,"Cription_"+nameFile);
            if (File.Exists(toCriptionFile))
            {
                File.Delete(toCriptionFile);
            }
            using (FileStream fs = File.Create(toCriptionFile))
            {

            }

            using (FileStream fileStream = new FileStream(toCriptionFile, FileMode.Create, FileAccess.Write))
            {
               
                var encription = new EncryptionAndDecryption();
                byte[] buffer = encription.Encrypt(fileText);
                fileStream.Write(buffer, 0, buffer.Length);
            }

        }

        public void CreateEncriptionFile(string filename, string saveFilePath)
        {
            string? fileText;
            string? nameFile;
            using (FileStream fileStream = new FileStream(filename, FileMode.Open))
            {
                var decription = new EncryptionAndDecryption();

                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                fileText= decription.Decrypt(buffer);
                nameFile = Path.GetFileName(fileStream.Name);
            }
        }
    }
}
