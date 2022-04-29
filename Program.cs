
using SaveDataDemo;

var folder = Environment.CurrentDirectory;
var file = Path.Join(folder, "data.txt");

var fileManager = new FileManager(file);

List<Student> students = fileManager.LoadFile();
Console.Clear();
Console.WriteLine("{0} students loaded from file.", students.Count);


bool isQuit = false;

do
{
    Console.Write("Enter a to add, l to list and q to quit :>  ");
    var input = Console.ReadLine();

    switch (input)
    {
        case "a":
            Console.Clear();
            Console.Write("Enter students name, date of birth (e.g. John Doe, 2018/06/22) :> ");
            var studentEntry = Console.ReadLine();
            var entries = studentEntry.Split(",").ToList<string>();
            var name = entries[0];
            var dob = DateTime.Parse(entries[1]);
            students.Add(new Student(name, dob));
            Console.WriteLine("Student {0} has been added.", name);
            break;

        case "l":
            Console.Clear();
            Console.WriteLine("Students List");
            Console.WriteLine("==================");
            foreach (var student in students)
            {
                student.DisplayInfo();
            }
            Console.WriteLine();
            break;

        case "q":
            isQuit = true;
            //Save my data
            fileManager.SaveToFile(students);
            break;

        default:
            Console.WriteLine("Invalid Entry!");
            break;
    }

} while (!isQuit);

Console.WriteLine("Good bye!");

