// See https://aka.ms/new-console-template for more information

//Below code is showing violation for SRP because 
//the Jounal Class manages both the logic for managing journals and also 
//Persistance of data using files. Journal class have 2 responsibilities
//1. Managing journals
//2. Managing Data Persistance(File I/O)

/*using SRP.Problem;

Journal journal = new Journal();
journal.AddJournal("This is a test");
journal.AddJournal("Hopefully it will work");
journal.AddJournal("If it fail, I will try again");
journal.AddJournal("It Worked :)");

journal.RemoveJournal(2);
Console.WriteLine(journal.ToString());
journal.WriteToTextFile("JournalFile.txt");
*/

//New Journal Class in SRP.Solution namespace solved the above problem by 
//isolating the responsibilities in two seperate classes.
//Journal class will manage Journal related logic.
//Persistance class will manage the Data persistance using the File I/O

using SRP.Solution;

Journal journal = new Journal();
journal.AddJournal("This is a test");
journal.AddJournal("Hopefully it will work");
journal.AddJournal("If it fail, I will try again");
journal.AddJournal("It Worked :)");

journal.RemoveJournal(2);
Console.WriteLine(journal.ToString());

Persistence p = new Persistence();
p.WriteToTextFile(journal, "JournalFile.txt", true);





