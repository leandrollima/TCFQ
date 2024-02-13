namespace TCFQ.WF.Events.UserControls
{
    public class EventArgsChangeQuestion : EventArgs
    {
        public ushort Question { get; }
        public EventArgsChangeQuestion(ushort question)
        {
            Question = question;
        }
    }
}
