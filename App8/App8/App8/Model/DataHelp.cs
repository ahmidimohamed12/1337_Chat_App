using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Firebase.Database.Query;
using Firebase.Database.Http;
using Firebase.Database.Streaming;
using Firebase.Database.Offline;
using App8.Model;
using Firebase.Database;
using Xamarin.Forms;
using System.Threading.Tasks;
namespace App8.Model
{
    class DataHelp
    {
       public static FirebaseClient fb = new FirebaseClient("");

        //public async List<Etudiant> etudiant()
        //{

        //    return (await firebase
        //      .Child("Etudiant")
        //      .OnceAsync<Etudiant>()).Select(item => new Etudiant
        //      {
        //          login = item.Object.login,
        //          password = item.Object.password
        //      }).ToArray();
        //}
        public async Task AddPerson(string login, string password)
        {

            await fb
              .Child("Etudiant")
              .PostAsync(new Etudiant()
              { 
                  login = login.ToLower(),
                  password=password.ToLower() 
              });
        }
    }
}
