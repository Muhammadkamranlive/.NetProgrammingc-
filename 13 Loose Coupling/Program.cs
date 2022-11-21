using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
public interface ITask
{
    void Execute();
}
public interface IWorkFlow
{
    void Add(ITask task);
    void Remove(ITask task);
    IEnumerable<ITask> GetTasks();
}
public class WorkFlow : IWorkFlow
{
    private readonly List<ITask> _tasks;
    public WorkFlow()
    {
        _tasks = new List<ITask>();
    }
    public void Add(ITask task)
    {
        _tasks.Add(task);
    }

    public void Remove(ITask task)
    {
        _tasks.Remove(task);
    }
    public IEnumerable<ITask> GetTasks()
    {
        return _tasks;
    }
}
public class VideoUploader : ITask
{
    public void Execute()
    {
        Console.WriteLine("Video is Uploading");
    }
}
public class CallWebSerivice : ITask
{
    public void Execute()
    {
        Console.WriteLine("Calling Web Serivices");
    }
}
public class SendEmail : ITask
{
    public void Execute()
    {
        Console.WriteLine("Sending the Email ");
    }
}
public class ChangeStatus : ITask
{
    public void Execute()
    {
        Console.WriteLine("Changing the status of video Uploading");
    }
}
public class WorkFlowEngine
{
    public void Run(IWorkFlow workFlow)
    {
        foreach (ITask I in workFlow.GetTasks())
        {
            try
            {
                I.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
public class Program
{

    private static void Main(string[] args)
    {

        //interfaces for loose copling
        var workflow = new WorkFlow();
        workflow.Add(new VideoUploader());
        workflow.Add(new CallWebSerivice());
        workflow.Add(new ChangeStatus());
        var engine = new WorkFlowEngine();
        engine.Run(workflow);
    }
}