using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Compte
    {
        public string Username
        {
            get { return username; }
            private set { username = value; }

        }
        public string username;

        public string Password
        {
            get { return password; }
            private set { password = value; }

        }
        public string password;

        public char Sexe
        {
            get { return sexe; }
            private set { sexe = value; }

        }
        public char sexe;

        public Chef MonChef
        {
            get { return monChef; }
            private set { monChef = value; }

        }
        private Chef monChef;

        public override string ToString()
        {
            
            return ($"Username : {username} \nPassword : {password} \nSexe: {sexe} \nMonChef: {monChef}");
        }

        public Compte(string username, string password, char sexe, Chef monChef)
        {
            this.username = username;
            this.password = password;
            this.sexe = sexe;
            this.monChef = monChef;
        }

    }
}
