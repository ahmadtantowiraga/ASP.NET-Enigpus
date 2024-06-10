class EnigpusView
{
    private IInventoryService inventoryService;
    public EnigpusView()
    {
        this.inventoryService = new InventoryServiceImpl();
    }
    public void ShowMenu()
    {
        while (true)
        {
            int menu;
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Main Menu");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book By Title");
                Console.WriteLine("3. Get All Book");
                Console.WriteLine("4. EXIT");
                menu = Utility.InputIntUtil("Input menu Option (1-4) : ");
                if (menu < 1 || menu > 4)
                {
                    Console.WriteLine("Masukan NO MENU yang benar (angka 1-4)");
                    Console.WriteLine("Tekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            if (menu == 4)
            {
                break;
            }
            else
            {
                switch (menu)
                {
                    case 1:
                        AddBookView();
                        break;
                    case 2:
                        SearchByTitle();
                        break;
                    case 3:
                        GetAllBookView();
                        break;
                }
            }
        }
    }
    public void AddBookView()
    {
        Console.WriteLine("The type of book you want to add:");
        Console.WriteLine("1. Novel");
        Console.WriteLine("2. Magazine");

        while (true)
        {
            int type = Utility.InputIntUtil("Input 1 to add Novel or Input 2 to Add Magazine: ");
            if (type == 1)
            {
                string title = Utility.InputString("Input Novel title: ");
                string publisher = Utility.InputString("Input the publisher: ");
                int publicationYear = Utility.InputIntUtil("Input publication year (Must be 4 characters): ");
                string writer = Utility.InputString("Input the Writer: ");
                Book book = new Novel(title, publicationYear, publisher, Convert.ToString(DateTime.UtcNow.Ticks), writer);
                inventoryService.AddBook(book);
                break;
            }
            else if (type == 2)
            {
                string title = Utility.InputString("Input Magazine title: ");
                string publisher= Utility.InputString("Input the publisher: ");
                int publicationYear = Utility.InputIntUtil("Input publication Year (Must be 4 characters): ");
                Book magazine = new Magazine(title, publicationYear, publisher, Convert.ToString(DateTime.UtcNow.Ticks));
                inventoryService.AddBook(magazine);
                break;
            }
            else
            {
                Console.WriteLine("The choice entered is incorrect. Please input again.");
            }
        }
    }
    public void SearchByTitle()
    {
        string title = Utility.InputString("Input the key title to search data: ");
        inventoryService.SearchBookByTitle(title);
    }
    public void GetAllBookView()
    {
        List<Book> books = inventoryService.GetAllBook();

        Console.WriteLine("Novel List:");
        string format1 = "{0,-20} {1,-30} {2,-30} {3,-30} {4,-30}";
        Console.WriteLine(string.Format(format1, "Novel Code", "Novel Title", "Novel Publisher", "Novel Publication Year", "Novel Writer"));

        foreach (var book in books)
        {
            if (book is Novel)
            {
                Novel novel = (Novel)book;
                Console.WriteLine(string.Format(format1, novel.Code, novel.Title, novel.Publisher, novel.PublicationYear, novel.Writter));
            }
        }

        Console.WriteLine();
        Console.WriteLine("Magazine List:");
        string format2 = "{0,-20} {1,-30} {2,-30} {3,-30}";
        Console.WriteLine(string.Format(format2, "Magazine Code", "Magazine Title", "Magazine Publisher", "Magazine Publication Year"));

        foreach (var book in books)
        {
            if (book is Magazine)
            {
                Magazine magazine = (Magazine)book;
                Console.WriteLine(string.Format(format2, magazine.Code, magazine.Title, magazine.Publisher, magazine.PublicationYear));
            }
        }
    }
}