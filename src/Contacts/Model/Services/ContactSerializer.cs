using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using View.ViewModel;

namespace View.Model.Services
{
    /// <summary>
    /// Представляет реализацию сериалайзера./> 
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь сохранения файла (Мои документы).
        /// </summary>
        public static string Path { get; set; }
            = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\contacts.json";

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="contacts">Коллекция контактов.</param>
        /// <param name="path">Путь сериализации.</param>
        public static void Serialize(ObservableCollection<ContactVM> contacts)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }

            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <param name="path">Путь десериализации.</param>
        /// <returns>Список контактов.</returns>
        public static ObservableCollection<ContactVM> Deserialize()
        {
            ObservableCollection<ContactVM> contacts = new ObservableCollection<ContactVM>();

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contacts = JsonConvert.DeserializeObject
                    <ObservableCollection<ContactVM>>(sr.ReadToEnd());
                }
            }
            else
            {
                File.Create(Path).Close();
            }

            return contacts;
        }
    }
}
