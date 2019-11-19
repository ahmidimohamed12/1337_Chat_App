using System;
using System.Collections.Generic;
using System.Text;

namespace App8.Model
{
    class School
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Etudiant> Etudiants { get; set; }

       public School()
        {
            this.id++;
        
        }

    }
}
