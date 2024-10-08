using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
	public class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public int NumPages { get; set; }
		public int WordCount { get; set; }
		public string Publisher { get; set; }
		public int YearPublished { get; set; }
		public string Language { get; set; }
		public string Genre { get; set; }
		public int Onthepage { get; set; }
		public bool SizeofBook {  get; set; } 


		public int CalculateWordsPerPage()
		{
			if (NumPages > 0)
			{
				return (int)WordCount / NumPages;
			}
			else
			{
				Console.WriteLine("Кількість сторінок не може бути 0 або менше.");
				return 0;
			}
		}

		public bool IsLargeBook()
		{
			if (NumPages >= 500)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Властивість для геттера результату методу CalculateWordsPerPage
		public double WordsPerPage
		{
			get { return CalculateWordsPerPage(); }
		}


		// Властивість для геттера результату методу IsLargeBook
		public bool BigorSmall
		{
			get
			{
				return NumPages >= 500;
			}
		}


		// Конструктор за замовчуванням
		public Book() { }

		// Конструктор з усіма параметрами
		public Book(string title, string author, int numPages, int wordCount, string publisher, int yearPublished, 
			string language, string genre, int onthepage, bool sizeofbook)
		{
			Title = title;
			Author = author;
			NumPages = numPages;
			WordCount = wordCount;
			Publisher = publisher;
			YearPublished = yearPublished;
			Language = language;
			Genre = genre;
			Onthepage = onthepage; // Ініціалізуємо поле
			SizeofBook = sizeofbook;
		}
	}
}
