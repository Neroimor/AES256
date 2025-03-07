using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES256
{
    internal class FileCript
    {

        public void CreateFileCription(string filename) {
            string? fileText;
            using (FileStream fileStream = new FileStream(filename,FileMode.Open)) {
                byte[] buffer = new byte[filename.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                fileText = Encoding.UTF8.GetString(buffer);
            }

            Console.WriteLine(fileText);
        }
    }
}
