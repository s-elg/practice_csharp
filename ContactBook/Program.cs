namespace AdressbookApp;

public class AddressBook{

    static List<Contact> contacts = new List<Contact>();

    static void Main(string[] args){
        bool exit = false;
        while(!exit){
            Console.Clear();
            Console.WriteLine("####Address Book####");
            Console.WriteLine("1. View Contacts");
            Console.WriteLine("2. Add Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Exit");
            Console.Write("Please enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice){
                case 1:
                    ViewContacts();
                    break;
                case 2:
                    AddContact();
                    break;
                case 3:
                    EditContact();
                    break;
                case 4:
                    DeleteContact();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Please make a valid choice"); 
                    break;        
            }
        }
    }

    class Contact{
        public string fName { get; set; }
        public string lName { get; set; }
        public string Email { get; set; }

        public Contact(string fname, string lname, string email){
            fName = fname;
            lName = lname;
            Email = email;
        }
    }

    public static void ViewContacts(){
        Console.Clear();
        Console.WriteLine("####Contacts####");

        if(contacts.Count == 0) {
            Console.WriteLine("No data found");
        } else {
            for(int i = 0; i < contacts.Count; i++) {
                Console.WriteLine("Contact "+ (i + 1)+  ": " + contacts[i].fName + " " + contacts[i].lName + "/" + contacts[i].Email);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public static void AddContact() {
        Console.Clear();

        Console.Write("Please enter the name: ");
        string fname = Console.ReadLine();

        Console.Write("Please enter the surname: ");
        string lname = Console.ReadLine();

        Console.Write("Please enter the email: ");
        string email = Console.ReadLine();

        contacts.Add(new Contact(fname, lname, email));

        Console.WriteLine("Contact added successfully!");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public static void EditContact() {
        Console.Clear();

        Console.Write("Which contact do you want to edit?: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Please enter the name: ");
        string fname = Console.ReadLine();

        Console.Write("Please enter the surname: ");
        string lname = Console.ReadLine();

        Console.Write("Please enter the email: ");
        string email = Console.ReadLine();

        contacts[index] = new Contact(fname, lname, email);

        Console.WriteLine("Contact edited successfully!");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    public static void DeleteContact() {a
        Console.Clear();

        Console.Write("Which contact do you want to delete?: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        contacts.RemoveAt(index);

        Console.WriteLine("Contact deleted successfully!");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

}
