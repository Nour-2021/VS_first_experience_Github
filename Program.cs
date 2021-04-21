using System;
using System.Collections.Generic;

namespace Gestion_des_notes_des_etudiants
{
    class Program
    {
        static void Main(string[] args)
        {
           //creer des etudiants
            Etudiant e1= new Etudiant("Yousfi", "Fouzia", 2536, "12,rue renault Gatineau" ,"2",3,"2021");
            Etudiant e2 = new Etudiant("Fethi", "Karima", 3687,"45,Rue Steve Gatineau ","5",1,"2021");
            Etudiant e3 = new Etudiant("Soltani", "Dounia", 8726, "68,Rue George Gatineau ", "3", 2, "2021");
            Etudiant e4 = new Etudiant("Yahi", "Mounia", 5417, "91,Rue Karl-s Gatineau ", "2", 1, "2021");
            Etudiant e5 = new Etudiant("Yousfi","Nour El Houda", 6934, "74,Rue Paradis Gatineau ", "4", 3, "2021");
            Etudiant e6 = new Etudiant("Salem", "Jihane", 5973, "75,Rue Victoire Gatineau ", "5", 2, "2021");
            Etudiant e7 = new Etudiant("Mazouz", "Zina", 9541, "52,Rue Daniel Gatineau ", "4", 3, "2021");
            Etudiant e8 = new Etudiant("Salem", "Mourad", 5129, "59,Rue Chemin Gatineau ", "3", 2, "2021");
            Etudiant e9 = new Etudiant("Joghlal", "Sofiane", 9183, "25,Rue Pays Gatineau ", "1", 1, "2021");
            Etudiant e10 = new Etudiant("Boumenjel", "Farid", 4596, "47,Rue Jardin Gatineau ", "4", 3, "2021");

            //Ajouter les etudiant au liste des etudiant du college
            Etudiant.AjouEtudiant(e1);
            Etudiant.AjouEtudiant(e2);
            Etudiant.AjouEtudiant(e3);
            Etudiant.AjouEtudiant(e4);
            Etudiant.AjouEtudiant(e5);
            Etudiant.AjouEtudiant(e6);
            Etudiant.AjouEtudiant(e7);
            Etudiant.AjouEtudiant(e8);
            Etudiant.AjouEtudiant(e9);
            Etudiant.AjouEtudiant(e10);
            

            //Creer des cours 
            Cours c1 = new Cours(25,"Science",2);
            Cours c2 = new Cours(54, "Math",3);
            Cours c3 = new Cours(39, "Langue",1);
            Cours c4 = new Cours(45, "Geography",1);
            Cours c5 = new Cours(32, "Physique", 3);
            Cours c6= new Cours(50, "Histoire", 1);
            Cours c7= new Cours(15, "Art", 1);
            Cours c8= new Cours(28, "phylosophie", 1);
            Cours c9= new Cours(48, "Sport", 1);
            Cours c10= new Cours(10, "Architecture", 2);
            Cours c11= new Cours(12, "Dessin", 1);
            Cours c12 = new Cours(61, "Mecanic", 2);
            Cours c13 = new Cours(33, "Electronic", 2);
            Cours c14 = new Cours(36, "Comptabilite", 2);
            Cours c15 = new Cours(82, "Gestion", 1);
            Cours c16 = new Cours(99, "Analyse", 1);
            Cours c17 = new Cours(79, "Finance", 2);
            Cours c18 = new Cours(88, "Lecture", 1);
            Cours c19 = new Cours(16, "Français", 1);
            Cours c20 = new Cours(55, "Statistique", 1);
            Cours c21 = new Cours(101, "Programmation", 2);
            Cours c22 = new Cours(100, "Reseau", 1);

            //Ajouter des cours a la liste des cours du college
            Cours.AjouterCours(c1);
            Cours.AjouterCours(c2);
            Cours.AjouterCours(c3);
            Cours.AjouterCours(c4);
            Cours.AjouterCours(c5);
            Cours.AjouterCours(c6);
            Cours.AjouterCours(c7);
            Cours.AjouterCours(c8);
            Cours.AjouterCours(c9);
            Cours.AjouterCours(c10);
            Cours.AjouterCours(c11);
            Cours.AjouterCours(c12);
            Cours.AjouterCours(c13);
            Cours.AjouterCours(c14);
            Cours.AjouterCours(c15);
            Cours.AjouterCours(c16);
            Cours.AjouterCours(c17);
            Cours.AjouterCours(c18);
            Cours.AjouterCours(c19);
            Cours.AjouterCours(c20);
            Cours.AjouterCours(c21);
            Cours.AjouterCours(c22);
            
            //Ajouter les notes des etudiant ,chaque etudiant a un certains nombre des cours

            Grade.AjouterNote(2536, 25, 18);
            Grade.AjouterNote(2536, 54, 15);
            Grade.AjouterNote(2536, 39, 16);
            Grade.AjouterNote(2536, 45, 14);

            Grade.AjouterNote(3687, 16, 15);
            Grade.AjouterNote(3687, 79, 16);
            Grade.AjouterNote(3687, 82, 13);
            Grade.AjouterNote(3687, 36, 17);

            Grade.AjouterNote(8726, 39, 18);
            Grade.AjouterNote(8726, 32, 15);
            Grade.AjouterNote(8726, 61, 12);
            Grade.AjouterNote(8726, 33, 11);

            Grade.AjouterNote(5417, 36, 16);
            Grade.AjouterNote(5417, 82, 17);
            Grade.AjouterNote(5417, 79, 14);
            Grade.AjouterNote(5417, 55, 18);

            Grade.AjouterNote(6934, 101, 18);
            Grade.AjouterNote(6934, 100, 16);
            Grade.AjouterNote(6934, 54, 19);
            Grade.AjouterNote(6934, 39, 15);

            Grade.AjouterNote(5973, 25, 13);
            Grade.AjouterNote(5973, 54, 11);
            Grade.AjouterNote(5973, 32, 10);
            Grade.AjouterNote(5973, 10, 12);

            Grade.AjouterNote(9541, 15, 16);
            Grade.AjouterNote(9541, 12, 16);
            Grade.AjouterNote(9541, 28, 14);
            Grade.AjouterNote(9541, 48, 15);

            Grade.AjouterNote(5129, 82, 12.5);
            Grade.AjouterNote(5129, 99, 13);
            Grade.AjouterNote(5129, 79, 17);
            Grade.AjouterNote(5129, 36, 15);

            Grade.AjouterNote(9183, 25, 17.5);
            Grade.AjouterNote(9183, 54, 14);
            Grade.AjouterNote(9183, 39, 12);
            Grade.AjouterNote(9183, 45, 13);

            Grade.AjouterNote(4596, 61, 13.5);
            Grade.AjouterNote(4596, 33, 15);
            Grade.AjouterNote(4596, 54, 11);
            Grade.AjouterNote(4596, 39, 16);



            //Afficher bulletin selon le numero d'etudiant

            Etudiant.AfficherBuletinEtudiant(8726);
            Etudiant.AfficherBuletinEtudiant(5417);










        }
    }
}
