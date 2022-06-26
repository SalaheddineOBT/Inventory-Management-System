using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Cls_Four
    {
        private GestionMagasinEntities db = new GestionMagasinEntities();
        private Fornisseur f;


        public bool Ajout_Four(int id,string Nom,string Adresse,string Tel,string Email,string ville,string fax,string Rs)
        {
            f = new Fornisseur();
            f.NomComplet = Nom;
            f.RaisonSocial = Rs;
            f.Tele = Tel;
            f.Fax = fax;
            f.Adress = Adresse;
            f.Email = Email;
            f.Ville = ville;
            if(db.Fornisseurs.SingleOrDefault(S=>S.IdFornisseur == id) == null)
            {
                db.Fornisseurs.Add(f);
                db.SaveChanges();
                return true;

            }
            else
            {
                return false;
            }
        }
        public void Modifier_Four(int id, string Nom, string Adresse, string Tel, string Email, string ville, string fax, string Rs)
        {
            f = new Fornisseur();
            f = db.Fornisseurs.SingleOrDefault(S => S.IdFornisseur == id);
            if (f != null)
            {
                f.NomComplet = Nom;
                f.RaisonSocial = Rs;
                f.Adress = Adresse;
                f.Tele = Tel;
                f.Email = Email;
                f.Ville = ville;
                f.Fax = fax;
                db.SaveChanges();
            }
        }

        public void supprimer_Four(int id)
        {
            f = db.Fornisseurs.SingleOrDefault(s => s.IdFornisseur == id);
            if(f!=null){
                db.Fornisseurs.Remove(f);
                db.SaveChanges();
            }
        }
    }
}
