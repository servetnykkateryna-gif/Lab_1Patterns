namespace Lab_1Patterns.Structural
{
    public interface INoticeBoard { void ViewContracts(); }
    public class RealNoticeBoard : INoticeBoard { public void ViewContracts() => System.Console.WriteLine("Proxy: Displaying all monster contracts."); }
    public class NoticeBoardProxy : INoticeBoard
    {
        private RealNoticeBoard _board;
        public void ViewContracts()
        {
            System.Console.WriteLine("Proxy: Checking Witcher's reputation...");
            if (_board == null) _board = new RealNoticeBoard();
            _board.ViewContracts();
        }
    }
}