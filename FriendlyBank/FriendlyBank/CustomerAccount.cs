﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public class CustomerAccount : Account
	{
		public override string RudeLetterString()
		{
			return "You are overdrawn";
		}
	}
}