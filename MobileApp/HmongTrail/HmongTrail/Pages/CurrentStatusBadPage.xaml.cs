﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HmongTrail.Pages
{
    public partial class CurrentStatusBadPage : ContentPage
    {
        public CurrentStatusBadPage()
        {
            InitializeComponent();
            
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
