

// Add students to a class roster until there are no more students to add
// Display count of students in class

string? studentName = null;
List<string> students = new List<string>();

do
{
    Console.Write("Enter Student (Type \"done\" to stop): ");
    studentName = Console.ReadLine();

    if (!String.IsNullOrEmpty(studentName) && studentName.ToLower() != "done")
    {
        students.Add(studentName);
        Console.WriteLine("Student Added...");
    }
}
while (studentName.ToLower() != "done");

Console.WriteLine($"Total number of students entered is: {students.Count}");

