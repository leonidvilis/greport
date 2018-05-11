
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace GetReport.BL
{
    class XmlFileService<T> : IFileService<T>
    {
        public ObservableCollection<T> Open(string filename)
        {
            ObservableCollection<T> list = new ObservableCollection<T>();
            if (filename != null)
            {
                
                XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<T>));
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    list = formatter.Deserialize(fs) as ObservableCollection<T>;
                }
                return list;
            }
            else
            {
                return list;
            }
            
        }

        public void Save(string filename, ObservableCollection<T> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<T>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
    }
}
