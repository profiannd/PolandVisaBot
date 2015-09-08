using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace PolandVisaAuto
{
    public enum Actions
    {
        Delete = 0,
        Restore = 1,
        Create = 2,
        Remove = 3
    }

    public class Message
    {
//        public string Passport { get; set; }
        public Actions Action { get; set; }
        public VisaTask Task { get; set; }

        public static void Serialize(Message task, string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Message));
                xs.Serialize(fs, task);
            }
        }

        public static Message DeSerialize(string filePath)
        {
            Message task = null;
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Message));
                    task = (Message)xs.Deserialize(fs);
                }
            }
            return task;
        }
    }
}
