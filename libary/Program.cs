using libary;

Book book = new Book();

//This is info for the book class.
book.Title = "C# for beginners";
book.Author ="Charles Kirk";
book.ISBN = 12345678;
book.DisplayInfo();

// add a new book
Book book1 = new Book();

book1.Title = "C# for advanced";
book1.Author = "Big Stine";
book1.ISBN = 87654321;
book1.DisplayInfo();
