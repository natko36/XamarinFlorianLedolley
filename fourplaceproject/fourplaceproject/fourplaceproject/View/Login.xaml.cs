﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using fourplaceproject.ViewModel;
using Storm.Mvvm.Forms;

namespace fourplaceproject.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : BaseContentPage
	{
        
                
		public Login ()
		{
			InitializeComponent();
            BindingContext = new LoginViewModel(Navigation); 
		}
	}
}