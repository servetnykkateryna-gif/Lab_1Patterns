namespace Lab_1Patterns.Behavioral
{
    public class NoticeMediator
    {
        public void Transmit(string msg) => System.Console.WriteLine($"Mediator: Передано повідомлення: {msg}");
    }
}