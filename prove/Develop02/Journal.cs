using System.IO; 
class Journal {

    public List<List<string>> _entryList = new List<List<string>>(){};
    Entry newEntry = new Entry();
    public Journal () {
    }

    public void WriteEntry() {
        List<string> theEntry = new List<string>();
        string prompt = newEntry.getPrompt();
        Console.WriteLine(prompt);
        string curDate = newEntry.currentDate();
        string response = Console.ReadLine();
        theEntry.Add(curDate);
        theEntry.Add(prompt);
        theEntry.Add(response);

        _entryList.Add(theEntry);
        
    }

    public void DisplayEntry() {


        foreach (List<string> entry in _entryList){
            newEntry.displayEntry(entry[0], entry[1], entry[2]);



        }
    }

    public void LoadFile() {
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        


        foreach (string line in lines)
        {
            List<string> loadEntries = new List<string>();
            string[] parts = line.Split(",");



            string cdate = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            loadEntries.Add(cdate);
            loadEntries.Add(prompt);
            loadEntries.Add(response);



            _entryList.Add(loadEntries);


        }

    }

    public void SaveFile() {

        string fileName = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            foreach (List<string> entry in _entryList) {

                outputFile.WriteLine($"{entry[0]}, {entry[1]}, {entry[2]}");
            }
        }
    }

    
}