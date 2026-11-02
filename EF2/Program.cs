#region program


namespace EventHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext context = new AppDbContext())
            {
                Console.WriteLine("EventHub Application");
                Console.WriteLine("Organizers: " + context.Organizers.Count());
                Console.WriteLine("Events: " + context.Events.Count());
                Console.WriteLine("Attendees: " + context.Attendees.Count());
            }
        }
    }
}
#endregion