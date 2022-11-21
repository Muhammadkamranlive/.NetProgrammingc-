using System;

public class Manager
{
    List<worker> workers = new List<worker>();
    public string Name { get; set; }
    public void addWorkers(worker work)
    {
        workers.Add(work);
    }

}

public class SwipCard
{
    public string MadeCard { get; set; }
    public string MadeId { get; set; }
    public void Swip(Manager manager)
    {
        Console.WriteLine(manager.Name);
    }
}


public class worker
{
    public string Name { get; set; }
}

