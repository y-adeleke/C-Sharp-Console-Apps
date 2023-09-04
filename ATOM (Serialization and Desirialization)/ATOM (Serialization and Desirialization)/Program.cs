using System.Text.Json;

namespace ATOM__Serialization_and_Desirialization_;
class Program
{
    static void Main(string[] args)
    {
        //collection of atoms.
        List<Atom> atoms = Atom.CreateAtoms();
        //display all the item in the collection
        Console.WriteLine("\n displaying all the atoms object after calling the Atom.CreateAtoms() methods:");
        //IMPORTANT: i would use a for loop instead of foreach because the atoms list is too long
        //it would be better to display a few (10 atoms) so i can screenshot
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(atoms[i]);
        }
        Console.WriteLine();

        //single object of atom
        Atom singleAtom = atoms[0];
        //serializing a single atom to jsonformat and saving to a txt file
        Console.WriteLine("\n converting a single atom element to json and writing it to a txtfile:");
        WriteJson(singleAtom, "/Users/teejay/Desktop/singleatom.txt");
        //Deserialize the above file and display the resulting object.
        Console.WriteLine("\n desarializing the single atom object and displaying it:");
        ReadJson("/Users/teejay/Desktop/singleatom.txt");

        Console.WriteLine();
        //serializing the atom list to jsonformat and saving to a json file
        Console.WriteLine("\n converting the atom list element to json and writing it to a jsonfile:");
        WriteJson(atoms, "/Users/teejay/Desktop/atomcollection.json");
        //Deserialize the above file and display the resulting object.
        Console.WriteLine("\n desarializing the atom list object and displaying it:");
        ReadJsonCollection("/Users/teejay/Desktop/atomcollection.json");



        Console.ReadKey();

    }


    static void WriteJson(Atom atom, string filepath)
    {
        string jsonData = JsonSerializer.Serialize(atom);
        StreamWriter writer = new StreamWriter(filepath);
        writer.Write(jsonData);
        writer.Close();
        Console.WriteLine("done writing to file!");
    }

    static void WriteJson(List<Atom> atoms, string filepath)
    {
        string jsonData = JsonSerializer.Serialize(atoms);
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            writer.Write(jsonData);
        }
        Console.WriteLine("done writing to file!");
    }

    static void ReadJson(string filepath)
    {
        string jsonData;
        using (StreamReader reader = new StreamReader(filepath))
        {
            jsonData = reader.ReadToEnd();
        }
        Atom atom = JsonSerializer.Deserialize<Atom>(jsonData);
        Console.WriteLine(atom);
    }

    static void ReadJsonCollection(string filepath)
    {
        string jsonData;
        using (StreamReader reader = new StreamReader(filepath))
        {
            jsonData = reader.ReadToEnd();
        }
        List<Atom> atoms = JsonSerializer.Deserialize<List<Atom>>(jsonData);
        //IMPORTANT: i would use a for loop instead of foreach because the atoms list is too long
        //it would be better to display a few (10 atoms) so i can screenshot
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(atoms[i]);
        }
    }
}




