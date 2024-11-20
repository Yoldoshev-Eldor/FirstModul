namespace Lesson7_OOP
{


    internal class Program
    {

        static void Main(string[] texts)
        {
            List<Animal> animals = new List<Animal>();
            Animal firstAnimal = new Animal();
            firstAnimal.Name = "Tiger";
            firstAnimal.Meals = "Meat";
            firstAnimal.Habitat = "Hindiston";
            firstAnimal.Weight = 150;
            firstAnimal.BornYear = 2014;
            firstAnimal.PopularTypes = "Bengal Tigers";
            firstAnimal.WhichFamily = "Felidae";
            firstAnimal.AverageLifeSpan = "15 year";
            animals.Add(firstAnimal);
            firstAnimal.DisplayInfo();
            firstAnimal.Age();
            Animal secondAnimal = new Animal();
            secondAnimal.Name = "Elephant";
            secondAnimal.Meals = "Grass";
            secondAnimal.Habitat = "Hindiston";
            secondAnimal.Weight = 4600;
            secondAnimal.BornYear = 2007;
            secondAnimal.PopularTypes = "Drama";
            secondAnimal.WhichFamily = "Elephantidae";
            secondAnimal.AverageLifeSpan = "60 year";
            animals.Add(secondAnimal);
            secondAnimal.DisplayInfo();
            secondAnimal.Age();

            List<Book> books = new List<Book>();
            Book firstBook = new Book();
            firstBook.Name = "Otgan kunlar";
            firstBook.NumberOfPages = 500;
            firstBook.Genre = "romantic";
            firstBook.Author = "Abdulla qodiriy";
            firstBook.AuthorStyle = "\r\nAbdulla Qodiriy's writing style is characterized by its vivid realism, " +
                "deep emotional resonance, and exploration of social and cultural issues";
            firstBook.YearOfWriting = 1920;
            firstBook.Meaning = "About love";
            firstBook.Popularity = "very famous";
            firstBook.BookLanguage = "Uzbek";
            firstBook.Conclusion = "Overall, Otgan Kunlar is a profound reflection on the complexities of cultural " +
                "identity, tradition, and the human condition in the face of societal change.";
            books.Add(firstBook);
            firstBook.DisplayInfo();
           
            List<Computer> computers = new List<Computer>();
            Computer firstComputer = new Computer();
            firstComputer.Model = "Asus vivo book";
            firstComputer.Display = "HD";
            firstComputer.Ram = 16;
            firstComputer.Rom = 1;
            firstComputer.Cpu = "Core-i5";
            firstComputer.YearOfIssue = 2023;
            firstComputer.PeriodOfUse = "New";
            computers.Add(firstComputer);
            firstComputer.DisplayInfo();

            Computer secondComputer = new Computer();
            secondComputer.Model = "Victus";
            secondComputer.Display = "Amoled";
            secondComputer.Ram = 8; 
            secondComputer.Rom = 2;
            secondComputer.Cpu = "Ryzen 3";
            secondComputer.YearOfIssue = 2024;
            secondComputer.PeriodOfUse = "6 month";
            computers.Add(secondComputer);
            secondComputer.DisplayInfo();

            List<School> schools = new List<School>();
            School firstSchool = new School();
        }
    }

}


