using GestionEtudiants.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionEtudiants.Database
{
    class EtudiantsDbAccess
    {
        private static EtudiantsDbAccess _instance;
        private readonly SqlConnection _connection;

        /// <summary>
        /// Constructeur
        /// </summary>
        private EtudiantsDbAccess()
        {
            const string connectionString = @"data source=(LocalDB)\v11.0;attachdbfilename=|DataDirectory|\Database\Etudiants.mdf;integrated security=True";
            _connection = new SqlConnection(connectionString);
        }

        public static EtudiantsDbAccess Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EtudiantsDbAccess();
                }

                return _instance;
            }
        }

        public Etudiant Get(int code)
        {
            _connection.Open();

            // Requête SQL
            const string sql = "SELECT Id, Nom, Prenom, Classe, DateDeNaissance FROM Etudiant WHERE Id = @Id";

            // Initialisation de la commande SQL
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@Id", code);

            // Initialisation du reader de la table
            SqlDataReader reader = command.ExecuteReader();

            Etudiant etudiant = null;

            if (reader.Read())
            {
                // Récupération des champs
                int id = (int)reader["Id"];
                string nom = reader["Nom"].ToString();
                string prenom = reader["Prenom"].ToString();
                int codeClasse = (int)reader["Classe"];
                Classe classe = (Classe)codeClasse;
                DateTime dateDeNaissance = DateTime.Parse(reader["DateDeNaissance"].ToString());

                etudiant = new Etudiant(id, nom, prenom, classe, dateDeNaissance);
            }

            // Libération des ressources
            reader.Dispose();
            command.Dispose();
            _connection.Close();

            return etudiant;
        }

        public IList<Etudiant> Get()
        {
            _connection.Open();

            // Requête SQL
            const string sql = "SELECT Id, Nom, Prenom, Classe, DateDeNaissance FROM Etudiant";

            // Initialisation de la commande SQL
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = sql;

            // Initialisation du reader de la table
            SqlDataReader reader = command.ExecuteReader();

            IList<Etudiant> etudiants = new List<Etudiant>();

            while (reader.Read())
            {
                // Récupération des champs
                int id = (int)reader["Id"];
                string nom = reader["Nom"].ToString();
                string prenom = reader["Prenom"].ToString();

                int codeClasse = (short)reader["Classe"];
                Classe classe = (Classe)codeClasse;

                DateTime dateDeNaissance = DateTime.Parse(reader["DateDeNaissance"].ToString());

                Etudiant etudiant = new Etudiant(id, nom, prenom, classe, dateDeNaissance);
                etudiants.Add(etudiant);
            }

            // Libération des ressources
            reader.Dispose();
            command.Dispose();
            _connection.Close();

            return etudiants;
        }

        public void Ajouter(Etudiant element)
        {
            // TODO: Ajouter un étudiant dans la base de données
        }

        public void Modifier(Etudiant element)
        {
            // TODO: Modifier un étudiant contenu dans la base de données
        }

        public void Supprimer(Etudiant element)
        {
            // TODO: Supprimer un étudiant existant de la base de données
        }
    }
}