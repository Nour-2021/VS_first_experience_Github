using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_des_notes_des_etudiants
{ 
public class Cours
{
   //Definir les attribus
    public int  NumeroCours { get; set; }
    
    public int Code { get; set; }
    public static int CodeIncremente { get; set; }
    public string Titre { get; set; }
    public int Coefficient { get; set; }

        //cette liste va contenir outes les cours saisie 
    public static List<Cours> SerieCour { get; set; } = new List<Cours>();

        //definir constructeur qui prend juste le numero cours
        public Cours( int numeroCours) 
        {
            this.NumeroCours = numeroCours;
            
        }
        //definir constructeur qui prend toutes les attribu
        public Cours(int numeroCours ,string titre,int coefficient)

        {

            this.NumeroCours = numeroCours;
            CodeIncremente++;

            this.Code = CodeIncremente;
            this.Titre = titre;
            this.Coefficient = coefficient;
            
        }
        // methode pour ajouter un cours dans la liste serie cours(attribu)
        public static void AjouterCours(Cours c)
        {
             SerieCour.Add(c);
        }
        //methode pour recuperer un cours par son titre
        public Cours getCour(string titre)
        {
            foreach (Cours C in SerieCour)
            {
                if (C.Titre == titre)
                {
                    return C;
                }
            }
            return null;
        }
        //methode pour recuperer la Coefficient du cours on passant le numero cours comme parametre
        public int getCoefficients(int numeroCours)
        {
            foreach (Cours C in SerieCour)
            {
                if (C.NumeroCours == numeroCours)
                {
                    return C.Coefficient;
                }

            }
            return 0;

        }

        //methode pour recuperer le titre d'un cours  ,cette methode passe le numero cours comme parametre
        public string getTitre(int numeroCours)
        {
            foreach (Cours C in SerieCour)
            {
                if (C.NumeroCours == numeroCours)
                {
                    return C.Titre;
                }

            }
            return null;

        }
        //afficher toutes les cours du college
        public void AfficherCours()
        {
            foreach (Cours C in SerieCour)
            {
                Console.WriteLine("Numero Cours :"+this.NumeroCours+"\nTitre : "+this.Titre+"\nCoefficient : "+this.Coefficient);
                Console.WriteLine("*************************************************");
            }
            
        }
        //supprimer un cours du college
        public void DeleteCours(int numeroCours)
        {
            foreach (Cours C in SerieCour)
            {
                if (C.NumeroCours == numeroCours)
                {
                    SerieCour.Remove(C);break;
                }
            }
        }




    }
}
