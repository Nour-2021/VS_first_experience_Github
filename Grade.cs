using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_des_notes_des_etudiants
{
   public  class Grade
    {
        //Definir les proprietes 
        public double Note { get; set; }
        public int NumeroCours { get; set; }
        public int NumeroInscription { get; set; }

        public static List<Grade> Points { get; set; } = new List<Grade>();
        //constructeur qui initialise toutes les attribus
        public Grade(int numeroEtudiant,int numeroCours,double note) 
        {
            this.Note = note;
            this.NumeroCours = numeroCours;
            this.NumeroInscription = numeroEtudiant;
        }
          //Ajouter une note du cours d'un etudiant
       public static void AjouterNote(int numeroEtudiant,int numeroCours, double note)
        {
            Grade c = new Grade(numeroEtudiant, numeroCours, note);
            Points.Add(c);
        }
        //afficher les notes de toutes les etudiants noté
        public static void AfficherNote()
        {
            foreach (Grade c in Points)
            {
                Console.WriteLine("Numero Etudiant : "+c.NumeroInscription+ "\nNumero Cours : "+c.NumeroCours+"\nNote : "+c.Note);
                Console.WriteLine("***********************************************************************");
            }

        }
        //cette methode vas retourné la liste des cours d'un etudiant saisie avec ses notes selon le numero etudiant passé dans parametre
        public static List<Cours> CoursEtudiant(int numeroEtudiant)
        {
            List<Cours> s = new List<Cours>();
            foreach (Grade c in Points)
            {
                if (c.NumeroInscription == numeroEtudiant)
                {
                    s.Add(new Cours(c.NumeroCours));
                }
            }
            return s;

        }
        //cette methode recupere toutes les note d'un etudiant par son numero qui est passé comme parametre
        public static List<double> getNote(int numEtudiant)
        {
            List<double> Notes = new List<double>();

            foreach (Grade x in Points)
            {
                if (x.NumeroInscription == numEtudiant)
                {
                    foreach (Cours c in CoursEtudiant(numEtudiant))
                    {
                        if (c.NumeroCours == x.NumeroCours)
                        {
                            Notes.Add(x.Note);

                        }
                    }
                }
            }
            return Notes;
        }
        //calculer la somme des notes d'un etudiant ,cette methode utilise le numero etudiant comme parametre
        //*cette methode parcourir la liste des cours d'un etudiant (on utilise une methode qui retourne la liste des cours d'un etudiant)
        //*cette methode calcule la somme on utilisant la methode qui recupere la liste des note d'un etudiant et la methode getCoefficient 
        //de la classe Cours
        public static double SommeNote(int numeroEtudiant)
        {
            double somme = 0;
            int C = 0;
            foreach (Cours c in CoursEtudiant(numeroEtudiant))
            {
                somme += getNote(numeroEtudiant)[C] *c.getCoefficients(c.NumeroCours);
                C++;
            }

            return somme;


        }

        //cette methode retourne la somme des coefficients des cours d'un etudiant selon son numero passé en parametre
        public static int AddCoefficient(int numeroEtudiant)
        {
            int sommeCoef = 0;
            foreach(Cours c in CoursEtudiant(numeroEtudiant))
            {
                
                sommeCoef += c.getCoefficients(c.NumeroCours);
            }
            return sommeCoef;
        }
        // cette methode retourna la moyen d'un etudiant selon son numero passé en parametre
        public static double Moyen(int numeroEtudiant)
        {
            double Moyen= SommeNote(numeroEtudiant) / AddCoefficient( numeroEtudiant);

            return Math.Round(Moyen*100)/100;
        }
        // cette methode retourne la mention d'un etudiant on utilisant le numero d'etudiant passé en parametre
        public static string CalculerGrade(int numEtudiant)
        {
            string Grade = "";

            if (Moyen(numEtudiant)*5 > 90 && Moyen(numEtudiant)*5 < 100) { Grade = "A+"; }
            else if (Moyen(numEtudiant)*5 > 85) { Grade = "A"; }
            else if (Moyen(numEtudiant)*5 > 80) { Grade = "A-"; }
            else if (Moyen(numEtudiant)*5 > 77) { Grade = "B+"; }
            else if (Moyen(numEtudiant)*5 > 74) { Grade = "B"; }
            else if (Moyen(numEtudiant)*5 > 70) { Grade = "B-"; }
            else if (Moyen(numEtudiant)*5 > 67) { Grade = "C+"; }
            else if (Moyen(numEtudiant)*5 > 64) { Grade = "C"; }
            else if (Moyen(numEtudiant)*5 > 60) { Grade = "C-"; }
            else if (Moyen(numEtudiant)*5 > 55) { Grade = "DR"; }
            else { Grade = "EC"; }
            return Grade;
        }
        
    }

    }

