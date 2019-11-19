using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClassManagement
    {
        public Class[] GetClasses()
        {
            var db = new OOPCSEntities();
            return db.Classes.ToArray();
        }
        public void AddClass(string name, string description)
        {
            var newClass = new Class();
            newClass.Name = name;
            newClass.Description = description;

            var db = new OOPCSEntities();
            db.Classes.Add(newClass);
            db.SaveChanges();
        }
        public void EditClass(int id, string name, string description)
        {
            var db = new OOPCSEntities();
            var oldClass = db.Classes.Find(id);

            oldClass.Name = name;
            oldClass.Description = description;
            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteClass(int id)
        {
            var db = new OOPCSEntities();
            var @class = db.Classes.Find(id);
            db.Classes.Remove(@class);
            db.SaveChanges();
        }
        public Class GetClass(int id)
        {
            var db = new OOPCSEntities();
            return db.Classes.Find(id);
        }
    }
}
