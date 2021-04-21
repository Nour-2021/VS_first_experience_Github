using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_des_notes_des_etudiants
{
    public class Etudiant
    {

        //Definir les proprietes
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NumeroInscription { get; set; }

        public string Adresse { get; set; }

        public string Groupe { get; set; }

        public int Niveau { get; set; }

        public string AnneeScolaire { get; set; }
        
        //liste qui va contenir toutes les etudiants saisie
        public static List<Etudiant> Classe { get; set; } = new List<Etudiant>();

       
     //Definir le constructeur qui prens toutes les attribus
        public Etudiant(string nom,string prenom,int numeroEtudiant,string adresse, string groupe,int niveau,string annee)
        {
            this.NumeroInscription = numeroEtudiant;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.Groupe = groupe;
            this.Niveau = niveau;
            this.AnneeScolaire = annee;
            
        }
       
        //Ajouter les etudiant on rempliant la liste classe des etudiants
        public static void AjouEtudiant(Etudiant e)
        {
            Classe.Add(e);
            
        }
        //Recuperer l'objet etudiant qui prend le numero etudiant comme parametre
        public static Etudiant getEtudiant(int numEtudiant)
        {
            Etudiant E = null;
            foreach (Etudiant e in Classe)
            {
                if (e.NumeroInscription == numEtudiant)
                {
                    return e;
                }
            }
            return E;
        }
        // Afficher les information d'un etudiant
        public override string ToString()
        {
            return "Nom :" + this.Nom + "\nPrenom : " + this.Prenom + "\nNumeroEtudiant : " + this.NumeroInscription
                +"\n***************************************************************************";
        }
        //Afficher toutes les etudiants saisie dans la liste
        public void AfficherEtudiant()
        {
            foreach (Etudiant e in Classe)
            {
                Console.WriteLine(e.ToString());
            }

        }

        //Affichet l'entête du buletin qui contient les information d'un etudiant
        public string Buletin()
        {
            return "*****************************Relevé de Notes*************************************\n\n\n" +
                   "\nNumero d'inscription   " + this.NumeroInscription + "                        Groupe " + this.Groupe + "" +
                   "\nNom                    " + this.Nom + "                       Niveau " + this.Niveau + "" +
                   "\nPrénom                 " + this.Prenom + "                      Année Scolaire " + this.AnneeScolaire +
                   "\nAdresse              " + this.Adresse + "\n\n\n" +
                   "\n------------------------------------------------------------------------------" + "\n" +
                   "|" + "  Matière                |        Coefficient      |      Note              |" + "\n" +
                   "------------------------------------------------------------------------------";

        }

        //Afficher Buletin d'un etudiant : cette methode 
           //* recupere l'etudiant selon son numero 
           //* Afficher l'entete d'etudiant
           //*Afficher les cours et ses notes d'etudiant on utilisant des methodes dans la classe Grade 
        public static void AfficherBuletinEtudiant( int numEtudiant)
        {
            Etudiant e = getEtudiant( numEtudiant);
            Console.WriteLine(e.Buletin());
            int c = 0;
            string s = "";
            foreach (Cours F in Grade.CoursEtudiant(numEtudiant))
            {
                int n = 25-( F.getTitre(F.NumeroCours).Length);
                string S = " ";
                S= String.Concat(Enumerable.Repeat(" ", n));
          
                
                Console.WriteLine("|" + F.getTitre(F.NumeroCours)  + S + "|              " + F.getCoefficients(F.NumeroCours) + "          |           " + Grade.getNote(numEtudiant)[c] + "           |");
                c++;

            }

            Console.WriteLine("-----------------------------------------------------------------------------\n" +
                              "\n                                       Moyen Generale : "+Grade.Moyen(numEtudiant)+
                              "\n\n                                              Mention : "+Grade.CalculerGrade(numEtudiant));
            Console.WriteLine("\n");



        }

       
         
        
       
    }
}
