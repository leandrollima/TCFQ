namespace TCFQ.CO
{
    public class QuestionCO
    {
        const string USER_ANSWER_EXCEPTION = "Only these letters {0} are acceptable.";

        char userAnswer;
        
        readonly char[] acceptableAnswers;

        public readonly ushort Number;
        public readonly ushort Point;
        public readonly char CorrectAnswer;
        public bool IsCorrect { get { return Char.ToUpper(UserAnswer) == Char.ToUpper(CorrectAnswer); } }

        public char UserAnswer
        {
            get { return userAnswer; }
            set
            {
                char upperCaseValue = char.ToUpper(value);

                if (acceptableAnswers.Contains(upperCaseValue))
                {
                    userAnswer = upperCaseValue;
                }
                else
                {
                    throw new ArgumentException(string.Format(USER_ANSWER_EXCEPTION, String.Join(',', acceptableAnswers)));
                }
            }
        }

        public QuestionCO(ushort number, ushort point, char correctAnswer, char[] acceptableAnswers)
        {
            Number = number;
            Point = point;
            CorrectAnswer = correctAnswer;
            this.acceptableAnswers = acceptableAnswers;
        }

        public override string ToString()
        {
            return $"{Number.ToString().PadLeft(2, '0')}.  {UserAnswer} ";
        }
    }
}
