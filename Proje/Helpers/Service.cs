using Newtonsoft.Json;
using Proje.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Helpers
{
    public static class Service<T>
    {
        public static Guid AddOrUpdate(T Entity)
        {
            string Id = Entity.GetType().GetProperties().FirstOrDefault(p => p.Name == "Id").GetValue(Entity).ToString();
            if (Id == "00000000-0000-0000-0000-000000000000")
            {
                var list = SelectAll();
                Guid GivenId = Guid.NewGuid();
                Entity.GetType().GetProperties().FirstOrDefault(p => p.Name == "Id").SetValue(Entity, GivenId);
                if (Convert.ToDateTime(Entity.GetType().GetProperty("DateCreated").GetValue(Entity)).Year < 2000)
                    Entity.GetType().GetProperties().FirstOrDefault(p => p.Name == "DateCreated").SetValue(Entity, DateTime.Now);
                list.Add(Entity);
                Save(list);
                return GivenId;
            }
            else
            {
                var list = SelectAll();
                foreach (var EntProp in Entity.GetType().GetProperties())
                {
                    var obj = list.FirstOrDefault(s => s.GetType().GetProperty("Id").GetValue(s).ToString() == Id);
                    foreach (var DataProp in obj.GetType().GetProperties())
                    {
                        if (DataProp.Name == EntProp.Name && DataProp.Name != "StringValue")
                        {
                            var value = EntProp.GetValue(Entity);
                            DataProp.SetValue(list.FirstOrDefault(s => s.GetType().GetProperty("Id").GetValue(s).ToString() == Id), value);
                        }
                    }
                }
                Save(list);

                return Guid.Parse(Id);
            }
        }
        public static void Delete(string Id)
        {
            try
            {
                var list = SelectAll();
                list.Remove(list.First(s => s.GetType().GetProperties().FirstOrDefault(p => p.Name == "Id").GetValue(s).ToString() == Id));
                Save(list);
            }
            catch (System.Exception ex)
            {
                Logger.Add(ex);
            }
        }
        public static void Delete(T Entity)
        {
            try
            {
                var list = SelectAll();
                Delete(Entity.GetType().GetProperties().FirstOrDefault(p => p.Name == "Id").GetValue(Entity).ToString());
            }
            catch (System.Exception ex)
            {
                Logger.Add(ex);
            }
        }

        public static T Select(string Id)
        {
            return SelectAll().FirstOrDefault(s => s.GetType().GetProperties().FirstOrDefault(p => p.Name == "Id").GetValue(s).ToString() == Id);
        }

        public static List<T> SelectAll()
        {
            string fileName = GetFilePath();
            string json = File.ReadAllText(fileName);
            try
            {
                return JsonConvert.DeserializeObject<List<T>>(json).ToList();
            }
            catch (System.Exception ex)
            {
                Logger.Add(ex);
                return new List<T>();
            }
        }

        public static BindingList<T> toBindingList
        {
            get
            {
                try
                {
                    BindingList<T> entities = new BindingList<T>();
                    foreach (T t in SelectAll())
                    {
                        entities.Add(t);
                    }
                    return entities;
                }
                catch (System.Exception ex)
                {
                    Logger.Add(ex);
                    return null;
                }
            }
        }
        public static void Save(List<T> List)
        {
            try
            {
                string json = JsonConvert.SerializeObject(List);
                string fileName = GetFilePath(); 
                File.WriteAllText(fileName, json);
            }
            catch (System.Exception ex)
            {
                Logger.Add(ex);
            }

        }
        public static void Clear()
        {
            try
            {
                bool isOK = MessageBox.Show("Tüm " + Utilities.getTranslated(typeof(T).Name) + " kayıtları silinecek. Bu işlem geri alınamaz.", "Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
                if (isOK)
                    File.WriteAllText(GetFilePath(), "[]");
            }
            catch (System.Exception ex)
            {
                Logger.Add(ex);
            }
        }

        private static string GetFilePath()
        {
            TableAttribute attribute =
                           typeof(T)
                              .GetCustomAttributes(typeof(TableAttribute), false).First() as TableAttribute;
            string tableFileName = attribute.Name + ".json";
            var filename = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                Settings.Default.DBFolder,
                tableFileName);
            return filename;
        }

    }
}
