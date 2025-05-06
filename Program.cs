using TechGatesOOPSession.Classes;
Tasks tasks = new Tasks();
AddTask addTask = new AddTask(tasks);
DeleteTask deleteTask = new DeleteTask(tasks);
UpdateTask updateTask = new UpdateTask(tasks);
ViewTask viewTask = new ViewTask(tasks);
while (true)
{
    int input;
    Console.WriteLine("Choose one option: ");
    Console.WriteLine("[1] Add task");
    Console.WriteLine("[2] Delete task");
    Console.WriteLine("[3] Update task");
    Console.WriteLine("[4] View task");
    Console.WriteLine("[other number] EXIT SAFELY!");
    Console.Write("=> ");
    if (int.TryParse(Console.ReadLine().ToLower(), out int result))
    {
        switch (result)
        {
            case 1:
                addTask.excute();
                break;
            case 2:
                deleteTask.excute();
                break;
            case 3:
                updateTask.excute(); 
                break;
            case 4:
                viewTask.excute();
                break;
            default:
                Console.WriteLine("safely EXIT!");
                return;

        }
    }
    else
    {
        Console.WriteLine("Choose correct option!");
    }
}
