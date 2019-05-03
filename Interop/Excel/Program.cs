using System;

namespace Excel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DataStruct data = new DataStruct ();
			IOWrite write = new IOWrite (data);

			//Набиране на данни в основната таблица
			data.addRow ("Фатме", "Черкез", "20");
			data.addRow ("Ибрахим", "Грошар", "23");

			//Проверка на таблица
			data.prinTable ();

			write.exportTable ();
			write.runFile ();
		}
	}
}
