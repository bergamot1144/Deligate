


TeamMember name1 = new TeamMember("Moisha");
TeamMember name2 = new TeamMember("Fred");
TeamMember name3 = new TeamMember("Rocco");

TeamEvent event1 = new TeamEvent
{
    EventName = "Fishing",
    EventTime = new DateTime(2024, 10, 5)
};
TeamEvent event2 = new TeamEvent
{
    EventName = "Obed",
    EventTime = new DateTime(2024, 06, 5)
};
TeamEvent event3 = new TeamEvent
{
    EventName = "Dancing",
    EventTime = new DateTime(2024, 07, 5)
};
event1.Notify += name1.RecieveNotification;
event1.Notify += name2.RecieveNotification;
event1.Notify += name3.RecieveNotification;

event2.Notify += name1.RecieveNotification;
event2.Notify += name2.RecieveNotification;
event2.Notify += name3.RecieveNotification;

event3.Notify += name1.RecieveNotification;
event3.Notify += name2.RecieveNotification;
event3.Notify += name3.RecieveNotification;

event1.InformMethod();
event2.InformMethod();
event3.InformMethod();







internal delegate void EventNotification(string Message);

class TeamEvent
{
    public string EventName { get; set; }
    public DateTime EventTime { get; set; }
    public EventNotification Notify { get; set; }

    public void InformMethod()
    {
        string message = $"Event {EventName} Date {EventTime}";
        Notify(message);
    }

}

public class TeamMember
{
    public string Name { get;  set; }


    public TeamMember(string Name)
    {
        this.Name = Name;
    }

    public void RecieveNotification(string message)
    {
        Console.WriteLine($"{Name} recieved {message}");
    }
}





