using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using modele;

namespace dal
{
    public class sqlreq
    {
        private static string connectionstring = "server=localhost;userid=responsable;password=Admin123!;database=MediaTek86";
        private static MySqlConnection sql = new MySqlConnection(connectionstring);

        /// <summary>
        /// Vérifie dans la bdd si les identifiants/mots de passe sont correctes
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public bool checkLogin(string login, string pwd)
        {
            sql.Open();
            var cmd = new MySqlCommand("SELECT COUNT(login) AS valid FROM responsable WHERE login = ?login AND pwd = SHA2(?pwd,256)", sql);
            cmd.Parameters.AddWithValue("login", login);
            cmd.Parameters.AddWithValue("pwd", pwd);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(0) == "1")
                {
                    sql.Close();
                    return true;
                }
            }

            sql.Close();
            return false;
        }

        /// <summary>
        /// Get les données des services dans la bdd afin de valoriser les classes dans une liste
        /// </summary>
        public List<service> GetServices()
        {
            List<service> toreturn = new List<service>();
            sql.Open();
            var cmd = new MySqlCommand("SELECT * FROM service ORDER BY NOM ASC", sql);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                toreturn.Add(new service(reader.GetInt32(0), reader.GetString(1)));
            }

            sql.Close();
            return toreturn;
        }

        /// <summary>
        /// Get les données des motifs dans la bdd afin de valoriser les classes dans une liste
        /// </summary>
        public List<motif> GetMotifs()
        {
            List<motif> toreturn = new List<motif>();
            sql.Open();
            var cmd = new MySqlCommand("SELECT * FROM motif ORDER BY LIBELLE ASC", sql);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                toreturn.Add(new motif(reader.GetInt32(0), reader.GetString(1)));
            }

            sql.Close();
            return toreturn;
        }

        /// <summary>
        /// Get le personnel et tout ce qui en découle
        /// </summary>
        public List<Personnel> GetPersonnel()
        {
            List<Personnel> toreturn = new List<Personnel>();
            sql.Open();
            var cmd = new MySqlCommand("SELECT * FROM personnel ORDER BY IDPERSONNEL ASC", sql);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                toreturn.Add(new Personnel(
                    reader.GetInt32(0), 
                    reader.GetInt32(1), 
                    reader.GetString(2), 
                    reader.GetString(3), 
                    reader.GetString(4), 
                    reader.GetString(5), 
                    new List<absence>()));
            }
            sql.Close();
            sql.Open();
            var cmd2 = new MySqlCommand("SELECT * FROM absence ORDER BY DATEDEBUT ASC", sql);
            var reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                foreach(Personnel element in toreturn)
                {
                    List<string> infos = element.Getinfos();
                    if (reader2.GetInt32(0).ToString() == infos[0])
                    {
                        element.ajoutAbsence(new absence(element, reader2.GetInt32(2), reader2.GetDateTime(1), reader2.GetDateTime(3)));
                    }
                }
            }
            sql.Close();
            return toreturn;
        }

        /// <summary>
        /// Ajoute des données dans la table Personnel de la BDD
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <returns>le nombre de lignes affectées par la requete (normalement 1 ici)</returns>
        public int AjoutPersonnel(int idservice , string nom, string prenom , string tel, string mail)
        {
            sql.Open();
            var cmd = new MySqlCommand("INSERT INTO personnel(`IDSERVICE`,`NOM`,`PRENOM`,`TEL`,`MAIL`) VALUES(@idservice, @nom, @prenom, @tel, @mail)", sql);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idservice", idservice);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@mail", mail);
            int success = cmd.ExecuteNonQuery();

            sql.Close();
            return success;
        }

        /// <summary>
        /// Modifie les données d'une ligne de la table Personnel de la BDD
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <returns>le nombre de lignes affectées par la requete (normalement 1 ici)</returns>
        public int EditPersonnel(int id, int idservice, string nom, string prenom, string tel, string mail)
        {
            sql.Open();
            var cmd = new MySqlCommand("UPDATE personnel SET `IDSERVICE` = @idservice, `NOM` = @nom, `PRENOM` = @prenom, `TEL` = @tel, `MAIL` = @mail WHERE `IDPERSONNEL` = @id", sql);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idservice", idservice);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@id", id);
            int success = cmd.ExecuteNonQuery();

            sql.Close();
            return success;
        }

        /// <summary>
        /// Supprime une ligne de la table Personnel de la BDD
        /// </summary>
        /// <param name="id"></param>
        /// <returns>le nombre de lignes affectées par la requete (normalement 1 ici)</returns>
        public int SuppPersonnel(int id)
        {
            sql.Open();
            var cmd = new MySqlCommand("DELETE FROM personnel WHERE `IDPERSONNEL` = @id", sql);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            int success = cmd.ExecuteNonQuery();

            sql.Close();

            sql.Open();
            var cmd2 = new MySqlCommand("DELETE FROM absence WHERE `IDPERSONNEL` = @id", sql);
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@id", id);
            cmd2.ExecuteNonQuery();

            sql.Close();
            return success;
        }

        /// <summary>
        /// Ajoute des données dans la table absence de la BDD 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <param name="motif"></param>
        /// <returns>le nombre de lignes affectées par la requete (normalement 1 ici)</returns>
        public int AjoutAbsence(int id, DateTime debut, DateTime fin, int motif)
        {
            sql.Open();
            var cmd = new MySqlCommand("INSERT IGNORE INTO absence(`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES(@id, @debut, @motif, @fin)", sql);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@debut", debut);
            cmd.Parameters.AddWithValue("@motif", motif);
            cmd.Parameters.AddWithValue("@fin", fin);
            int success = cmd.ExecuteNonQuery();

            sql.Close();
            return success;
        }

        /// <summary>
        /// Modifie les données d'une ligne de la table absence de la BDD
        /// </summary>
        /// <param name="id"></param>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <param name="motif"></param>
        /// <param name="oldDebut"></param>
        /// <returns>le nombre de lignes affectées par la requete (normalement 1 ici)</returns>
        public int EditAbsence(int id, DateTime debut, DateTime fin, int motif, DateTime oldDebut)
        {
            Console.WriteLine(id);
            Console.WriteLine(oldDebut.ToString("yyyy-MM-dd HH:mm:ss"));
            sql.Open();
            var cmd = new MySqlCommand("UPDATE absence SET `DATEDEBUT` = @debut, `IDMOTIF` = @motif, `DATEFIN` = @fin WHERE `IDPERSONNEL` = @id AND `DATEDEBUT` = @oldDebut", sql);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@debut", debut);
            cmd.Parameters.AddWithValue("@oldDebut", oldDebut.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@motif", motif);
            cmd.Parameters.AddWithValue("@fin", fin);
            int success = cmd.ExecuteNonQuery();
            Console.WriteLine(success);

            sql.Close();
            return success;
        }

        /// <summary>
        /// Supprime une ligne de la table absence de la BDD
        /// </summary>
        /// <param name="id"></param>
        /// <param name="debut"></param>
        /// <returns>le nombre de lignes affectées par la requete (normalement 1 ici)</returns>
        public int SuppAbsence(int id, DateTime debut)
        {
            sql.Open();
            var cmd = new MySqlCommand("DELETE FROM absence WHERE `IDPERSONNEL` = @id AND `DATEDEBUT` = @debut", sql);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@debut", debut);
            int success = cmd.ExecuteNonQuery();

            sql.Close();
            return success;
        }

    }
}
