using System;

namespace GestionEtudiants.Entities
{
    class Etudiant
    {
        public int Id { get; private set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public Classe Classe { get; set; }

        public DateTime DateDeNaissance { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Etudiant(int id, string nom, string prenom, Classe classe, DateTime dateDeNaissance)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Classe = classe;
            this.DateDeNaissance = dateDeNaissance;
        }

        /// <summary>
        /// Permet d'afficher l'étudiant sous forme de chaîne de caractère dans la liste
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", this.Nom, this.Prenom, this.Classe);
        }
    }
}