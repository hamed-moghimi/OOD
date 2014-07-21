using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Globalization;
using System.Windows.Forms;
using System.IO;

namespace OOD.EMS.Management
{
    [Serializable()]
    public class Attachment
    {
        public String Filename { get; set; }
        public String Title { get; set; }
        public String path { get; set; }
        private DateTime creationTime;


        public Attachment(String filename)
        {
            Filename = filename;
            SHA1 sha = new SHA1CryptoServiceProvider();
            creationTime = DateTime.Now;
            byte[] res = sha.ComputeHash(GetBytes(filename + creationTime.ToString("yyyy-MM-dd HH:mm:ss.fff",
                                            CultureInfo.InvariantCulture)));
            Title = standardize(Convert.ToBase64String(res));
            DirectoryInfo mainDir = new DirectoryInfo(@Application.StartupPath);
            DirectoryInfo twoLevelsUp = mainDir.Parent.Parent;
            path = twoLevelsUp.FullName + @"\data";
            
        }

        public void save(byte[] binaryData)
        {
            // Open file for reading
            System.IO.FileStream _FileStream =
               new System.IO.FileStream(path + @"\" + Title, System.IO.FileMode.Create,
                                        System.IO.FileAccess.Write);
            // Writes a block of bytes to this stream using data from
            // a byte array.
            _FileStream.Write(binaryData, 0, binaryData.Length);

            // close file stream
            _FileStream.Close();
                        
        }

        public void download(String dlPath)
        {
            if (path != null)
            {
                byte[] binaryData = File.ReadAllBytes(path + @"\" + Title);
                File.WriteAllBytes(dlPath, binaryData);
            }
        }

        public void delete()
        {
            File.Delete(path + @"\" + Title);
        }

        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private String standardize(String str)
        {
            String res = str;
            char[][] numbers = new char[][]
            {
                "<>:\"/\\|?*".ToCharArray(),"123456789".ToCharArray()
            };
            for (int x = 0; x <= 8; x++)
            {
                res = res.Replace(numbers[0][x], numbers[1][x]);
            }
            return res;
        }

    }
}
