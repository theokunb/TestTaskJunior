using testTask;

ITestTask myTask;
while (true)
{
    Console.WriteLine("1. Task 1\n2. Task 2\n3. Task 3\n4. exit");
    string? input = Console.ReadLine();


    if(int.TryParse(input,out int myCase))
    {
        switch (myCase)
        {
            case 1:
                {
                    myTask = new Task1();
                    break;
                }
            case 2:
                {
                    myTask = new Task2();
                    break;
                }
            case 3:
                {
                    myTask = new Task3();
                    break;
                }
            case 4:
                {
                    Environment.Exit(0);
                    continue;
                }
            default:
                {
                    Console.WriteLine("can not find selected task");
                    continue;
                }
        }
        myTask.SolveTask();

    }
}