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
       public FirebaseClient firebase = new FirebaseClient("https://project-655056407821009696.firebaseio.com/");
       //FirebaseHelper firebaseHelper = new FirebaseHelper();
        public MainPage()
        {
            InitializeComponent();
        }
      
    }
}

