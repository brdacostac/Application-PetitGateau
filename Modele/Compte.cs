using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Compte
    {
        /// <summary>
        /// represente identifiant de l'utilisateur
        /// </summary>
        public string Username
        {
            get { return username; }
            private set { username = value; }

        }
        public string username;

        /// <summary>
        /// represente le mot de passe du compte
        /// </summary>
        public string Password
        {
            get { return password; }
            private set { password = value; }

        }
        public string password;

        /// <summary>
        /// represente le sexe de l'utilisateur
        /// </summary>
        public char Sexe
        {
            get { return sexe; }
            private set { sexe = value; }

        }
        public char sexe;

        /// <summary>
        /// le chef associé au compte
        /// </summary>
        public Chef MonChef
        {
            get { return monChef; }
            private set { monChef = value; }

        }
        private Chef monChef;

        /// <summary>
        /// permet d'afficher les information d'un compte  
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
            return ($"Username : {username} \nPassword : {password} \nSexe: {sexe} \nMonChef: {monChef}");
        }

        /// <summary>
        /// constructeur de la classe  
        /// </summary>
        /// <param name="username">l'identifiant</param>
        /// <param name="password">le mot de passe</param>
        /// <param name="sexe">le sexe</param>
        /// <param name="monChef"></param>
        public Compte(string username, string password, char sexe)
        {
            Username = username;
            Password = password;
            Sexe = sexe;
            MonChef = new Chef();
        }

    }
}
