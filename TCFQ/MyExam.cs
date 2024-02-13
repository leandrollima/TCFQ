using System.Text;
using TCFQ.CO;

namespace TCFQ.ConsoleApp
{
    internal class MyExam
    {
        ExamCO exam;
        ushort examId;
        ushort lines = 1; // calculate from Start();
        ushort columns = 4;
        public ushort Columns
        {
            get { return columns; }
            set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("It is not possible to assign a 0 or negative value to this property");
                }
                columns = value;

                lines = (ushort)Math.Ceiling((double)exam.Questions.Length / columns);
            }
        }

        public MyExam(ushort examId)
        {
            exam = new ExamCO(examId);
            this.examId = examId;
        }

        internal void Start()
        {
            lines = (ushort)Math.Ceiling((double)exam.Questions.Length / Columns);

            Console.WriteLine($"Exam {examId}:");
            Console.WriteLine("Enter an alternative for each question (1 to 39):");

            TypeUserAnswers(exam);
            Results(exam);

            Console.WriteLine();
        }

        void TypeUserAnswers(ExamCO exam)
        {
            for (int i = 0; i < exam.Questions.Length; i++)
            {
                bool nextQuestion = true;

                do
                {
                    Console.Write($"{(i + 1)}: ");
                    try
                    {
                        exam.Questions[i].UserAnswer = Console.ReadKey().KeyChar;
                        nextQuestion = true;
                    }
                    catch (Exception)
                    {
                        nextQuestion = false;
                        CleanLine();
                    }
                } while (!nextQuestion);

                Console.WriteLine();
            }
        }

        void Results(ExamCO exam)
        {
            Console.Clear();
            NewLine();

            StarLine();
            Console.Write(exam.LevelResult());
            StarLine();

            PrintAnswersResult();

            NewLine();
        }

        void CleanLine()
        {
            Console.Write("\r");
            Console.Write(new string(' ', Console.WindowWidth - 1));
            Console.Write("\r");
        }
        void StarLine(int lenght = 30)
        {
            Console.WriteLine(new string('*', lenght));
        }
        void NewLine()
        {
            Console.WriteLine(Environment.NewLine);
        }


        string AnswersResult()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    int index = i + j * lines;
                    if (index < exam.Questions.Length)
                    {
                        result.Append(GetResultAppend(exam.Questions[index]));
                    }
                }
                result.AppendLine();
            }

            return result.ToString();
        }

        string UserAnswers()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    int index = i + j * lines;
                    if (index < exam.Questions.Length)
                    {
                        result.Append(exam.Questions[index] + "\t");
                    }
                }
                result.AppendLine();
            }

            return result.ToString();
        }

        string CorrectAnswers()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    int index = i + j * lines;
                    if (index < exam.Questions.Length)
                    {
                        result.Append($"{exam.Questions[index].Number.ToString().PadLeft(2, '0')}. {exam.Questions[index].CorrectAnswer}" + "\t");
                    }
                }
                result.AppendLine();
            }

            return result.ToString();
        }

        void PrintAnswersResult()
        {
            Console.WriteLine();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int index = i + j * lines;
                    if (index < exam.Questions.Length)
                    {
                        PrintAnswer(exam.Questions[index]);
                    }
                }
                Console.WriteLine();
            }
        }

        string GetResultAppend(QuestionCO question)
        {
            string correctStr = $" - Correct: {question.CorrectAnswer} ";

            StringBuilder result = new StringBuilder();
            result.Append($"{question.Number.ToString().PadLeft(2, '0')}. ");

            if (question.IsCorrect)
            {
                correctStr = new string(' ', correctStr.Length);
            }

            result.Append($" {question.UserAnswer} ");
            result.Append($"{correctStr}" + "\t");

            return result.ToString();
        }

        void PrintAnswer(QuestionCO question)
        {
            Console.ResetColor();

            string correctStr = $" - Correct: {question.CorrectAnswer} ";

            Console.Write($"{question.Number.ToString().PadLeft(2, '0')}. ");

            if (question.IsCorrect)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                correctStr = new string(' ', correctStr.Length);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write($" {question.UserAnswer} ");
            Console.ResetColor();
            Console.Write($"{correctStr}" + "\t");
        }
    }
}
