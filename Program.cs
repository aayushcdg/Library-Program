namespace Seneca {
    public class Program
    {
        static void Main(string[] args)
        {
            #region Create history book
            // Create history book
            History history = new History();
            // let's set the properties of this object history
            Author authorHistory = new Author("authorName", "authorEmail");
            // For assignment 3, Library class will take care of ISBN duplication. logic may reside in AddBook function perhaps?
            bool wasBookCreationSuccessful = history.CreateBook("978-1-56619-909-4",
                                                                "myTitle",
                                                                true,
                                                                "myPublisher",
                                                                1999,
                                                                54,
                                                                899,
                                                                authorHistory);
            if(wasBookCreationSuccessful)
            {
                Console.WriteLine(history?.GetGenre());
            }

            #endregion
            #region Create fiction book
            Fiction fiction = new Fiction();
            // let's set the properties of this object fiction
            Author authorFiction = new Author("authorName2", "authorEmail2");
            // For assignment 3, Library class will take care of ISBN duplication. logic may reside in AddBook function perhaps?
            wasBookCreationSuccessful = fiction.CreateBook("978-1-67896-909-4",
                                                           "myTitle2",
                                                           true,
                                                           "myPublisher2",
                                                           -2000,
                                                           54,
                                                           899,
                                                           authorFiction);
            #endregion
        }
    }
}