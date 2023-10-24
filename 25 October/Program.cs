//namespace _25_October;


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        List<Quiz> quizes = new List<Quiz>();
//        bool ExitProgram=false;
//        while (!ExitProgram)
//        { 

//            Console.WriteLine("-----------------------\r\n Welcome to Quiz world\r\n-----------------------");
//        Console.WriteLine("[1] Create new quiz\r\n[2] Solve a quiz\r\n[3] Show quizes\r\n[4] Quit");
//        int option = int.Parse(Console.ReadLine());
       
        
//            switch (option)
//            {
//                case 1:
//                    Console.WriteLine("Enter quiz name:");
//                    string QuizNameText = Console.ReadLine();
//                    Console.WriteLine("How many questions do you want to add?");
//                    int QuestionCount = int.Parse(Console.ReadLine());

//                    List<Question> questions = new List<Question>();

//                    for (int i = 0; i < QuestionCount; i++)
//                    {
//                        Console.WriteLine($"Enter question {i + 1} text:");
//                        string QuestionText = Console.ReadLine();
//                        {
//                            List<string> variants = new List<string>();
//                            for (int j = 0; j < 4; j++)
//                            {
//                                Console.WriteLine($"Enter variant {j + 1}:");
//                                string variant = Console.ReadLine();
//                                variants.Add(variant);

//                            }
//                            Console.WriteLine("Enter correct variant:");
//                            int correctVariant = int.Parse(Console.ReadLine());

//                            Question question = new Question(QuestionText, variants, correctVariant);
//                            questions.Add(question);

//                        }
//                    }
//                    Quiz quiz = new Quiz(QuizNameText, questions);
//                    quizes.Add(quiz);



//                    break;



//                case 2:
//                    Console.WriteLine("Select quiz");
//                    int quizId=int.Parse(Console.ReadLine())-1;
//                    var quiz1= quizes[quizId];
//                    int score = 0;
//                    foreach (var question in quiz1._questions)
//                    {
//                        Console.WriteLine(question.QuestionText);
//                        for (int i = 0; i < question._variants.Count; i++)
//                        {
//                            Console.WriteLine($"{i+1}) {question._variants[i]}");
//                        }
//                        Console.WriteLine("Your answer:");
//                        int answer=int.Parse(Console.ReadLine());
//                        if (answer == question.Correctvariant)
//                        {
//                            score++;
//                        }

//                        Console.WriteLine("-------------------------------------------");
//                    }
//                    Console.WriteLine($"Your score {score}/{quiz1._questions.Count}");



//                    break;
//                case 3:
//                    foreach (Quiz quiz2 in quizes)
//                    {
//                        Console.WriteLine($"Quiz name: {quiz2.QuizName}   |   Quiz Id: {quiz2.Id}");
//                    }
//                    break;
//                case 4:
//                    ExitProgram = true;
//                    break;



//            }
//        }
//    }
//}