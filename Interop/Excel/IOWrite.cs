﻿using System;

namespace Excel
{
	public class IOWrite
	{
		private DataStruct _data;

		public IOWrite (DataStruct data)
		{
		}

		public bool exportTable ()
		{
			try {
				
				//Междинни проверки

				return true;

			}catch{
			}

			return false;
		}
	

		public void addRow (DataRow _Row)
		{
			try {
			} catch {
			}
		}


		public void runFile ()
		{
			try {

				System.Diagnostics.Process.Start (getPath ());

			}catch{ 
			}
		
	}
		private string getPath ()
		{
			return System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "Table1.xlsx");
		}
	}

}




