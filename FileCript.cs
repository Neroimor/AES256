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

        public void CreateDecriptionFile(string filename, string saveFilePath)
        {
            string? fileText;
            byte[] fileBuffer;
            string? nameFile;
            using (FileStream fileStream = new FileStream(filename, FileMode.Open))
            {
                var decription = new EncryptionAndDecryption();
                byte[] buffer = new byte[fileStream.Length];
                fileBuffer = buffer;
                fileStream.Read(buffer, 0, buffer.Length);
                fileText= decription.Decrypt(buffer);
                nameFile = Path.GetFileName(fileStream.Name);
            }


            string? toCriptionFile = Path.Combine(saveFilePath, "Decription_" + nameFile);
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
                string text = encription.Decrypt(fileBuffer);
                byte[] buffer = Encoding.UTF8.GetBytes(text);
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
