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
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Threading.Tasks;
namespace App8.Model
{
    static class DataHelp
    {
       public static FirebaseClient fb = new FirebaseClient("https://project-655056407821009696.firebaseio.com/");

        public static async Task<List<Etudiant>> getalletudiant()
        {

            return (await fb
              .Child("Etudiant")
              .OnceAsync<Etudiant>()).Select(item => new Etudiant
              {
                  login = item.Object.login,
                  password = item.Object.password
              }).ToList();
        }
        public  static  async Task<Etudiant> get_etudiant(string lg, string pr)
        {
            
            return (await fb
              .Child("Etudiant")
              .OnceAsync<Etudiant>()).Select(item => new Etudiant
              {
                  login = lg,
                  password = pr
              }).Single();
        }
        public static async Task AddPerson(string login, string password)
        {

            await fb
              .Child("Etudiant")
              .PostAsync(new Etudiant()
              { 
                  login = login.ToString(),
                  password=password.ToString() 
              });
        }
    }
}
