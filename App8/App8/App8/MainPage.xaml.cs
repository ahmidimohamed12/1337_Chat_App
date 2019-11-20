﻿using System.ComponentModel;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Database.Http;
using Firebase.Database.Streaming;
using Firebase.Database.Offline;
using Xamarin.Forms;
using System;
using Newtonsoft.Json;
using App8.Model;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Converters;
using System.Linq;
namespace App8
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //FirebaseHelper firebaseHelper = new FirebaseHelper();

        public int imtappedfr = 0;

        public MainPage()
        {
            InitializeComponent();
            bb.Clicked += btn_click;
        
            tx1.Text = "Login";
            tx2.Text = "Password";
        }

      

        private void text_changed(object sender,EventArgs e)
        {
            tx2.IsPassword = true;
        }
      

        private async void btn_click(object sender, EventArgs e)
        {
            try
            {

                string log = tx1.Text.ToLower();
                string pas = tx2.Text.ToLower();
                var etudiants = await DataHelp.getalletudiant();
                var etu = (from a in etudiants
                           where a.login == log && a.password == pas
                           select a).FirstOrDefault();
                await DisplayAlert(etu.password, "ok", "ok");
                if (etu.password.Equals(pas))
                  await Navigation.PushModalAsync(new pageHome());
            }
            catch(Exception)
            {
                await DisplayAlert("ok","ok","ok");
            }
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            //await firebaseHelper.AddPerson(Convert.ToInt32(txtId.Text), txtName.Text);
            //txtId.Text = string.Empty;
            //txtName.Text = string.Empty;
            //await DisplayAlert("Success", "Person Added Successfully", "OK");
            //var allPersons = await firebaseHelper.GetAllPersons();
            //lstPersons.ItemsSource = allPersons;
        }

        private async void BtnRetrive_Clicked(object sender, EventArgs e)
        {
            //var person = await firebaseHelper.GetPerson(Convert.ToInt32(txtId.Text));
            //if (person != null)
            //{
            //    txtId.Text = person.PersonId.ToString();
            //    txtName.Text = person.Name;
            //    await DisplayAlert("Success", "Person Retrive Successfully", "OK");

            //}
            //else
            //{
            //    await DisplayAlert("Success", "No Person Available", "OK");
            //}

        }

        private async void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            //await firebaseHelper.UpdatePerson(Convert.ToInt32(txtId.Text), txtName.Text);
            //txtId.Text = string.Empty;
            //txtName.Text = string.Empty;
            //await DisplayAlert("Success", "Person Updated Successfully", "OK");
            //var allPersons = await firebaseHelper.GetAllPersons();
            //lstPersons.ItemsSource = allPersons;
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            //await firebaseHelper.DeletePerson(Convert.ToInt32(txtId.Text));
            //await DisplayAlert("Success", "Person Deleted Successfully", "OK");
            //var allPersons = await firebaseHelper.GetAllPersons();
            //lstPersons.ItemsSource = allPersons;
        
        }
}   
      
}

