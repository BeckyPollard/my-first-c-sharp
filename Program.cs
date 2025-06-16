// Learning C#
// Becky Pollard
// June 16 2025

using System.Xml.Linq;

namespace toronto_quiz_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName, userCourseCode;
            string userAnswer;

            int level;
            int points;
            int attempts1 = 4, attempts2 = 4, attempts3 = 4, attempts4 = 4;
            int score1 = 0, score2 = 0, score3 = 0, score4 = 0, totalScore = 0;

            double grade = 0.00;

            string q1 = "What year was the Toronto Necropolis cemetery established?" +
                "\n\tA) 1790" +
                "\n\tB) 1795" +
                "\n\tC) 1850" +
                "\n\tD) 1855";
            string q1success = "\nTHAT'S RIGHT!" +
                "\nThe Toronto Necropolis was established in 1850 with the intention to replace Potter's Field" +
                "\ncemetery, which was migrated to Toronto Necropolis between 1855-1875. That means in 2025 The" +
                "\nToronto Necropolis turned 175 years old!";

            string q2 = "\nIn 1874 a beautiful chapel was built at the entrance of the cemetery by Canadian architect" +
                "\nHenry Langley. What is the architectural style of that chapel known as?" +
                "\n\tA) Gothic Revival" +
                "\n\tB) Carpenter Gothic" +
                "\n\tC) Romanesque Revival" +
                "\n\tD) Richardsonian Romanesque";
            string q2success = "\nCORRECT!" + 
                "\nHenry Langley (who is buried in the Toronto Necropolis) designed the chapel, gates, and" +
                "\ncaretaker's lodge- all are great examples of gothic revival buildings in Toronto.";

            string q3 = "\nThere are many notable figures of Toronto's history buried in the cemetery. Of which has a" +
                "\nmajor street named after him?" +
                "\n\tA) Henry Dundas" +
                "\n\tB) George Yonge" +
                "\n\tC) John Graves Simcoe" +
                "\n\tD) Joseph Bloore";
            string q3success = "\nYOU GOT IT RIGHT!" +
                "\nJoseph Bloore (or Bloor) was an innkeeper, brewer, and land speculator in the 19th century" +
                "\nwho founded the Village of Yorkville. The portrait of him on Wikipedia is so scary looking.";

            string q4 = "\nIf the cemetery ever developed a zombie problem, which notable resident would likely be" +
                "\nresponsible for that?" +
                "\n\tA) John Carpenter" +
                "\n\tB) Lucio Fulci" +
                "\n\tC) Victor Halperin" +
                "\n\tD) George A Romero";
            string q4success = "\nTHAT'S SO CORRECT IT'S SCARY!" +
                "\nGeorge Andrew Romero Jr. was an American-Canadian film director. He was a pioneer of the horror" +
                "\nfilm genre, zombie films in particular. I've even seen some zombie-themed Halloween decorations" +
                "\nplaced at his grave by visitors in his honour.";

            // INTRO
            Console.WriteLine("You might need to adjust your console window's horizontal size to fit our trivia presentation." +
                "\nThe following bold line should comfortably fit on one line...\n"
            );
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.Write("Okay, looks good? Press any key to confirm... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("██████████████████████████████          BECKY PRESENTS         ██████████████████████████████");
            Console.WriteLine("██████████████████████████████ THE TORONTO C# QUIZ - EPISODE 1 ██████████████████████████████");
            Console.WriteLine("\n\n████████ ██   ██ ███████     ████████  ██████  ██████   ██████  ███    ██ ████████  ██████  \n   ██    ██   ██ ██             ██    ██    ██ ██   ██ ██    ██ ████   ██    ██    ██    ██ \n   ██    ███████ █████          ██    ██    ██ ██████  ██    ██ ██ ██  ██    ██    ██    ██ \n   ██    ██   ██ ██             ██    ██    ██ ██   ██ ██    ██ ██  ██ ██    ██    ██    ██ \n   ██    ██   ██ ███████        ██     ██████  ██   ██  ██████  ██   ████    ██     ██████  \n                                                                                            \n                                                                                            \n    ███    ██ ███████  ██████ ██████   ██████  ██████   ██████  ██      ██ ███████          \n    ████   ██ ██      ██      ██   ██ ██    ██ ██   ██ ██    ██ ██      ██ ██               \n    ██ ██  ██ █████   ██      ██████  ██    ██ ██████  ██    ██ ██      ██ ███████          \n    ██  ██ ██ ██      ██      ██   ██ ██    ██ ██      ██    ██ ██      ██      ██          \n    ██   ████ ███████  ██████ ██   ██  ██████  ██       ██████  ███████ ██ ███████          \n\n");
            Console.WriteLine("████████████████████████████ LEARNING ABOUT THE CITY AROUND YOU! ████████████████████████████\n");
            Console.Write("Press any key to begin! ");
            Console.ReadKey();
            Console.WriteLine("\n\nThank you for taking this quiz and learning more about Toronto's wonderful landmarks. For\n" +
                "episode 1, we're going to be learning all about THE TORONTO NECROPOLIS.\n\n" +
                "Located in downtown Toronto in the Cabbagetown neighbourhood, this cemetery houses over 50,000\n" +
                "graves and spans just over 18 acres of land. The old trees and wandering paths offer a quiet\n" +
                "and enjoyable stroll through Toronto's history. Let's get to know this part of Toronto!\n"
            );

            // INFO GATHERING STAGE
            Console.WriteLine("The quiz is starting! But first, let's learn a little more about YOU!");
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("\nHello " + userName + "! Please tell me your course code for the quiz. This will be your team's name.");
            Console.Write("Please enter your course code: ");
            userCourseCode = Console.ReadLine();
            Console.WriteLine("\nYou're on the " + userCourseCode + " team! Here we go!!");
            Console.WriteLine("\n\nRULES: To answer a question simply type the full answer or just enter the answer's letter." +
                "\nYou get 4 chances to answer a question. The more guesses you give the less points you'll get.\n\n");
            Console.Write("Press any key to START! ");
            Console.ReadKey();

            // QUESTION 1
            Console.WriteLine("\n\n█████████████████████████████████████████ QUESTION 1 ████████████████████████████████████████\n");
            Console.WriteLine(q1);

            points = 35;
            level = 1;
            // this would be a method/function if I could...
            for (int i = 4; i > 0; i--) // you only get 4 tries buddy
            {
                attempts1 = (i - 1 - 4) * -1;
                Console.Write("\n\tGuesses: " + i + "\n\tPlease enter your answer: ");
                userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "1850" || userAnswer == "c" || userAnswer == "3")
                {
                    // SUCCESS PATH
                    Console.WriteLine(q1success);
                    points = points - 10;
                    if (points < 0)
                    {
                        points = 0;
                    }
                    score1 = points;
                    Console.WriteLine("\nYOU EARNED " + score1 + " POINTS FOR QUESTION " + level + "!");
                    i = 0; // force exit loop
                }
                else
                {
                    Console.WriteLine("\tINCORRECT ANSWER!");
                    points = points - 10;
                    if (points < 0)
                    {
                        // FAIL PATH
                        points = 0;
                        score1 = points;
                        Console.WriteLine("\nNO MORE GUESSES!\nYOU EARNED " + score1 + " POINTS FOR QUESTION " + level + "!");
                    }
                }
            }
            Console.Write("\nPress any key to continue the quiz... ");
            Console.ReadKey();

            // QUESTION 2
            Console.WriteLine("\n\n█████████████████████████████████████████ QUESTION 2 ████████████████████████████████████████\n");
            Console.WriteLine(q2);

            points = 35;
            level = 2;
            for (int i = 4; i > 0; i--)
            {
                attempts2 = (i - 1 - 4) * -1;
                Console.Write("\n\tGuesses: " + i + "\n\tPlease enter your answer: ");
                userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "gothic revival" || userAnswer == "a" || userAnswer == "1")
                {
                    // SUCCESS PATH
                    Console.WriteLine(q2success);
                    points = points - 10;
                    if (points < 0)
                    {
                        points = 0;
                    }
                    score2 = points;
                    Console.WriteLine("\nYOU EARNED " + score2 + " POINTS FOR QUESTION " + level + "!");
                    i = 0; // force exit loop
                }
                else
                {
                    Console.WriteLine("\tINCORRECT ANSWER!");
                    points = points - 10;
                    if (points < 0)
                    {
                        // FAIL PATH
                        points = 0;
                        score2 = points;
                        Console.WriteLine("\nNO MORE GUESSES!\nYOU EARNED " + score2 + " POINTS FOR QUESTION " + level + "!");
                    }
                }
            }
            Console.Write("\nPress any key to continue the quiz... ");
            Console.ReadKey();

            // QUESTION 3
            Console.WriteLine("\n\n█████████████████████████████████████████ QUESTION 3 ████████████████████████████████████████\n");
            Console.WriteLine(q3);

            points = 35;
            level = 3;
            for (int i = 4; i > 0; i--)
            {
                attempts3 = (i - 1 - 4) * -1;
                Console.Write("\n\tGuesses: " + i + "\n\tPlease enter your answer: ");
                userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "joseph bloore" || userAnswer == "d" || userAnswer == "4")
                {
                    // SUCCESS PATH
                    Console.WriteLine(q3success);
                    points = points - 10;
                    if (points < 0)
                    {
                        points = 0;
                    }
                    score3 = points;
                    Console.WriteLine("\nYOU EARNED " + score3 + " POINTS FOR QUESTION " + level + "!");
                    i = 0; // force exit loop
                }
                else
                {
                    Console.WriteLine("\tINCORRECT ANSWER!");
                    points = points - 10;
                    if (points < 0)
                    {
                        // FAIL PATH
                        points = 0;
                        score3 = points;
                        Console.WriteLine("\nNO MORE GUESSES!\nYOU EARNED " + score3 + " POINTS FOR QUESTION " + level + "!");
                    }
                }
            }
            Console.Write("\nPress any key to continue the quiz... ");
            Console.ReadKey();

            // QUESTION 4
            Console.WriteLine("\n\n█████████████████████████████████████████ QUESTION 4 ████████████████████████████████████████\n");
            Console.WriteLine(q4);

            points = 35;
            level = 4;
            for (int i = 4; i > 0; i--)
            {
                attempts4 = (i - 1 - 4) * -1;
                Console.Write("\n\tGuesses: " + i + "\n\tPlease enter your answer: ");
                userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "george a romero" || userAnswer == "george romero" || userAnswer == "d" || userAnswer == "4")
                {
                    // SUCCESS PATH
                    Console.WriteLine(q4success);
                    points = points - 10;
                    if (points < 0)
                    {
                        points = 0;
                    }
                    score4 = points;
                    Console.WriteLine("\nYOU EARNED " + score4 + " POINTS FOR QUESTION " + level + "!");
                    i = 0; // force exit loop
                }
                else
                {
                    Console.WriteLine("\tINCORRECT ANSWER!");
                    points = points - 10;
                    if (points < 0)
                    {
                        // FAIL PATH
                        points = 0;
                        score4 = points;
                        Console.WriteLine("\nNO MORE GUESSES!\nYOU EARNED " + score4 + " POINTS FOR QUESTION " + level + "!");
                    }
                }
            }
            Console.Write("\n\nPress any key to finish the quiz! ");
            Console.ReadKey();

            Console.WriteLine("\n\n█████████████████████████████████████████ QUIZ END! █████████████████████████████████████████\n\n");

            totalScore = score1 + score2 + score3 + score4;
            if (totalScore != 0)
            {
                grade = ((double)totalScore / (double)100 * (double)100);
            }

            Console.WriteLine(
                "Thanks for playing the first episode of THE TORONTO C# QUIZ " + userName + "!" +
                "\nI hope you learned something new about THE TORONTO NECROPOLIS!" +
                "\n\nLet's see how you did with this quiz for team " + userCourseCode + "..."
            );
            Console.WriteLine(
                "\n\nQUIZ SUMMARY:" +
                    "\n\tQuiz taker: " + userName +
                    "\n\tQuiz team: " + userCourseCode +
                    "\n\tQuestions answered: 4" +
                    "\n\tTotal points gained: " + totalScore +
                    "\n\tKnowledge grade: " + grade + "%"
            );

            Console.Write("\nPress any key to continue... ");
            Console.ReadKey();

            Console.WriteLine(
                "\n\nANSWERS BREAKDOWN:" +
                    "\n\tQuestion 1:" +
                        "\n\t\tSubject: Toronto's Timeline" +
                        "\n\t\tQuestions attempts: " + attempts1 +
                        "\n\t\tTotal points gained: " + score1 +
                    "\n\tQuestion 2:" +
                        "\n\t\tSubject: Toronto's Architecture" +
                        "\n\t\tQuestions attempts: " + attempts2 +
                        "\n\t\tTotal points gained: " + score2 +
                    "\n\tQuestion 3:" +
                        "\n\t\tSubject: Toronto's People" +
                        "\n\t\tQuestions attempts: " + attempts3 +
                        "\n\t\tTotal points gained: " + score3 +
                    "\n\tQuestion 4:" +
                        "\n\t\tSubject: Toronto's People" +
                        "\n\t\tQuestions attempts: " + attempts4 +
                        "\n\t\tTotal points gained: " + score4
            );

            Console.Write("\nPress any key to continue... ");
            Console.ReadKey();
            Console.WriteLine("\n\n███████████████████████████████████ THANK YOU FOR PLAYING! ██████████████████████████████████\n\n\n\n");
            Console.ReadKey();
        }
    }
}
