using System;
using System.Collections.Generic;

namespace modele
{
    public class absence
    {
        private Personnel personnel;
        private int idMotif;
        private string dateDebut;
        private string dateFin;

        /// <summary>
        /// Constructeur : valorise les propriétés privées
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="idMotif"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        public absence(Personnel personnel, int idMotif, DateTime dateDebut, DateTime dateFin)
        {
            string dateDebSansHeure = dateDebut.ToString().Split(' ')[0];
            string dateFinSansHeure = dateFin.ToString().Split(' ')[0];
            this.personnel = personnel;
            this.idMotif = idMotif;
            this.dateDebut = dateDebSansHeure;
            this.dateFin = dateFinSansHeure;
        }

        /// <summary>
        /// Permet de Getter les propritétés privées: idMotif, dateDebut, DateTime d'une absence
        /// </summary>
        /// <returns>List<string></returns>
        public List<string> GetAbsInfo()
        {
            List<string> toreturn = new List<string>();
            toreturn.Add(idMotif.ToString());
            toreturn.Add(dateDebut.ToString());
            toreturn.Add(dateFin.ToString());

            return toreturn;
        }
    }

    public class Personnel
    {
        private int idPersonnel;
        private int idService;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private List<absence> absences;

        /// <summary>
        /// Constructeur : valorise les propriétés privées
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="absences"></param>
        public Personnel(int idPersonnel, int idService, string nom, string prenom, string tel, string mail, List<absence> absences)
        {
            this.idPersonnel = idPersonnel;
            this.idService = idService;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.absences = absences;
        }

        /// <summary>
        /// Permet de Getter les propritétés privées: idPersonnel, idService, nom, prenom, tel, mail d'un personnel
        /// </summary>
        /// <returns>List<string></returns>
        public List<string> Getinfos()
        {
            List<string> toreturn = new List<string>();
            toreturn.Add(this.idPersonnel.ToString());
            toreturn.Add(this.idService.ToString());
            toreturn.Add(this.nom);
            toreturn.Add(this.prenom);
            toreturn.Add(this.tel);
            toreturn.Add(this.mail);

            return toreturn;
        }

        /// <summary>
        /// Permet d'ajouter un object de class absence a la list d'absence d'un personnel
        /// </summary>
        public void ajoutAbsence(absence absence)
        {
            this.absences.Add(absence);
        }

        /// <summary>
        /// Permet de Getter la propritété privée: absences d'un personnel
        /// </summary>
        /// <returns>List<absence></returns>
        public List<absence> GetAbsences()
        {
            return absences;
        }
    }

    public class motif
    {
        private int idMotif;
        private string libelle;

        /// <summary>
        /// Constructeur : valorise les propriétés privées
        /// </summary>
        /// <param name="idMotif"></param>
        /// <param name="libelle"></param>
        public motif(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Getter sur la propriété libelle
        /// </summary>
        /// <returns>libelle</returns>
        public string getLibelle()
        {
            return this.libelle;
        }

        /// <summary>
        /// Getter sur la propriété idMotif
        /// </summary>
        /// <returns>idMotif</returns>
        public int getId()
        {
            return this.idMotif;
        }
    }

    public class service
    {
        private int idService;
        private string nom;

        /// <summary>
        /// Constructeur : valorise les propriétés privées
        /// </summary>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        public service(int idService, string nom)
        {
            this.idService = idService;
            this.nom = nom;
        }

        /// <summary>
        /// Getter sur la propriété idService
        /// </summary>
        /// <returns>idService</returns>
        public int getId()
        {
            return this.idService;
        }

        /// <summary>
        /// Getter sur la propriété nom
        /// </summary>
        /// <returns>nom</returns>
        public string getNom()
        {
            return this.nom;
        }
    }
}