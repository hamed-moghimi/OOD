using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OOD.EMS.Management;

namespace OOD.EMS.UI
{
    public partial class AttachmentPanel : UserControl
    {
        private Dictionary<String, Attachment> _attachments = new Dictionary<String, Attachment>();
        public Dictionary<String, Attachment> newlyAdded = new Dictionary<string, Attachment>();
        public bool Changed { get; set; }

        bool viewMode = false;
        public bool ViewMode { 
            set 
            { 
                this.viewMode = value; 
                removeButon.Visible = add.Visible = !value;
                if (viewMode)
                {
                    int X = attachmentGrid.Location.X + 50;
                    int Y = attachmentGrid.Location.Y;
                    attachmentGrid.Location = new System.Drawing.Point(X, Y);
                }
                   
            } 

            get { return this.viewMode; } 
        }

        public AttachmentPanel()
        {
            InitializeComponent();
            attachmentGrid.CellDoubleClick += new DataGridViewCellEventHandler(download_click);
            Changed = false;
        }

        public void populate(List<Attachment> attachments)
        {
            //TODO: fix this
            if (attachments == null)
                return;
            foreach (Attachment attach in attachments)
            {
                _attachments.Add(attach.Title, attach);
                attachmentGrid.Rows.Add(new Object[] { attach.Filename, attach.Title });
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                //Set File dialog properties
                fileDialog.CheckFileExists = true;
                fileDialog.CheckPathExists = true;
                fileDialog.Filter = "All Files|*.*";
                fileDialog.Title = "انتخاب فایل";
                fileDialog.Multiselect = false;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(fileDialog.FileName);
                    byte[] binaryData = File.ReadAllBytes(fileDialog.FileName);
                    Attachment attach = new Attachment(fileDialog.SafeFileName);
                    try
                    {
                        // Open file for reading
                        System.IO.FileStream _FileStream =
                           new System.IO.FileStream(attach.path + @"\" + attach.Title, System.IO.FileMode.Create,
                                                    System.IO.FileAccess.Write);
                        // Writes a block of bytes to this stream using data from
                        // a byte array.
                        _FileStream.Write(binaryData, 0, binaryData.Length);

                        // close file stream
                        _FileStream.Close();
                        attachmentGrid.Rows.Add(new Object[] { attach.Filename, attach.Title });
                        _attachments.Add(attach.Title, attach);
                        newlyAdded.Add(attach.Title, attach);
                        Changed = true;
                    }
                    catch (Exception _Exception)
                    {
                        // Error
                        MessageBox.Show(_Exception.ToString());
                        MessageBox.Show("در حین اضافه کردن ضمیمه خطا رخ داده است");
                    }

                }
            }
        }

        private void removeButon_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in attachmentGrid.SelectedRows)
            {
                String key = (String)row.Cells[1].Value;
                if (key == null) continue;
                Attachment attach = _attachments[key];
                if (attach == null) continue;
                attach.delete();
                attachmentGrid.Rows.RemoveAt(row.Index);
                _attachments.Remove(key);
                newlyAdded.Remove(key);
                Changed = true;
            }
        }

        private void download_click(object sender, EventArgs e)
        {
            String key = (String)attachmentGrid.Rows[attachmentGrid.SelectedRows[0].Index].Cells[1].Value;
            if (key == null) return;
            Attachment attach = _attachments[key];
            if (attach == null) return;
            FileInfo fileInfo = new FileInfo(attach.path + @"\" + attach.Title);
            string fileExtension = fileInfo.Extension;
            byte[] binaryData = File.ReadAllBytes(attach.path + @"\" + attach.Title);

            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                //Set Save dialog properties
                saveFileDialog1.Filter = "Files (*" + fileExtension + ")|*" + fileExtension;
                saveFileDialog1.Title = "ذخیره‌ی فایل";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.FileName = attach.Filename;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, binaryData);
                }
            }
        }

        public List<Attachment> getAttachments()
        {
            return _attachments.Values.ToList<Attachment>();
        }

        public List<Attachment> getNewlyAdded()
        {
            return newlyAdded.Values.ToList<Attachment>();
        }
       
    }
}
