using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Cls_Cat
    {
        GestionMagasinEntities db = new GestionMagasinEntities();
        Categorie cat = new Categorie();
        public void modifier(string code,string lib)
        {
            cat = db.Categories.SingleOrDefault(s => s.CODE == code);
            if (cat != null)
            {
                cat.LIBELLE = lib;
                db.SaveChanges();

            }

        }
        public void Supprimer_Cat(string code)
        {
            cat = db.Categories.SingleOrDefault(s => s.CODE == code);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();

            }

        }
    }
}
