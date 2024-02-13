namespace TCFQ.WF.Events.UserControls
{
    public class EventArgsFinishExam : EventArgs
    {
        public bool Finished { get; }
        public EventArgsFinishExam(bool finished)
        {
            Finished = finished;
        }
    }
}
