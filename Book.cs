namespace Seneca
{
    public enum GenreTypes
    {
        History,
        Fiction,
        Drama,
        Unknown
    }

    public class Book
    {
        private string ISBN;
        private string Title;
        private Author Author;
        private bool IsAudio;
        private string PublisherName;
        private int Year;
        private int NumberOfPages;
        private int AvailableCopies;

        public string GetISBN()
        {
            return ISBN;
        }

        public string GetTitle()
        {
            return Title;
        }

        public Author GetAuthor()
        {
            return Author;
        }

        public bool GetisAudio()
        {
            return IsAudio;
        }
        public string GetPublisherName()
        {
            return PublisherName;
        }

        public int GetYear()
        {
            return Year;
        }

        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }

        public int GetAvailableCopies()
        {
            return AvailableCopies;
        }

        public virtual GenreTypes GetGenre()
        {
            return GenreTypes.Unknown;//default genre of every book when there is none defined
        }

        public bool CreateBook(string isbn, string title, bool isAudio, string publisherName, int year, int numberOfPages, int availableCopies, Author author)
        {
            bool hasAllValidationsPassed = true;// set it based on if-conditions below

            // all validations go here except ISBN duplication - for this assignment, ISBN duplication check is being done outside this class (inside Library.cs)
            /*
             * all if conditions go here
             * if(my condition is not true) { hasAllValidationsPassed = false}
             */

            //Example (there might be more validations. this is just an example
            if(year <= 0)
            {
                hasAllValidationsPassed = false;
            }

            if (hasAllValidationsPassed)
            {
                this.ISBN = isbn;
                this.Title = title;
                this.Author = author;
                IsAudio = isAudio;
                PublisherName = publisherName;
                Year = year;
                NumberOfPages = numberOfPages;
                AvailableCopies = availableCopies;
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class History : Book
    {
        public override GenreTypes GetGenre()
        {
            return GenreTypes.History;
        }

    }

    public class Fiction : Book
    {
        List<string> charactersList;

        public Fiction()
        {
            this.charactersList = new List<string>();
        }

        public override GenreTypes GetGenre()
        {
            return GenreTypes.Fiction;
        }
        public List<string> GetFictionalCharacters()
        {
            return charactersList;
        }
        public void StoreFictionalCharacter(string characterName)
        {
            charactersList.Add(characterName);
        }
    }

    public class Drama : Book
    {
        public override GenreTypes GetGenre()
        {
            return GenreTypes.Drama;
        }
    }
}

