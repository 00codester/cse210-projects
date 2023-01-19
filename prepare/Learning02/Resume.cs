public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    public void DisplayResume()
    {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job jobType in _jobs)
            {
                jobType.DisplayJobDetails();
            }
    }
}