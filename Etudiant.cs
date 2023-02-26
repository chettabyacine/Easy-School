using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Etudiant
    {
        public static int id = 0;
        public String nom { get; set; }
        public String prenom { get; set; }
        public int telephone { get; set; }
        public Classe classe { get; set; }
        public List<String> matieres { get; set; }

        public Etudiant(String nom, String prenom, int telephone, Classe classe, List<String> matieres)
        {
            id++;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.classe = classe;
            this.matieres = matieres;
        }

        public static Dictionary<int, Etudiant> Etudiant_data = new Dictionary<int, Etudiant>();



    }
}
