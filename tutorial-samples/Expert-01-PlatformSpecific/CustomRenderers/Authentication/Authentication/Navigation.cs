﻿using System;
using System.Collections.Generic;

namespace Authentication
{
	/// <summary>
	/// Navigation.
	/// </summary>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	public class Navigation
	{
		/// <summary>
		/// The samples.
		/// </summary>
		public static Dictionary<string,string> samples = new Dictionary<string,string>()
		{
			{ 
				"Login with Google OAuth2", 
				"Google OAuth2"
			},
			{ 
				"Login with Facebook OAuth2", 
				"Facebook OAuth2"
			},
			{ 
				"Login with Twitter OAuth1", 
				"Twitter OAuth1"
			},
			{ 
				"Login with Microsoft Live OAuth2", 
				"Microsoft Live OAuth2"
			},
			{ 
				"Login with Instagram OAuth2", 
				"Instagram OAuth2"
			},
			{ 
				"Login with LinkedIn OAuth1", 
				"LinkedIn OAuth1"
			},
			{ 
				"Login with LinkedIn OAuth2", 
				"LinkedIn OAuth2"
			},
		};


		public static Dictionary<string,string> Samples
		{
			get
			{
				return samples;
			}
			set
			{
				samples = value;
			}
		}

	}
}
