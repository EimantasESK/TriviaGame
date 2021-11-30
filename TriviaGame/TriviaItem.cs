using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    class TriviaItem
    {
        private string Question;
        private string Answer;

        public TriviaItem(string triviaQuestion, string triviaAnswer)
        {
            Question = triviaQuestion;
            Answer = triviaAnswer;
        }
        public void AskQuestion()
        {
            // TODO: this should display the question, get a response,
            // and display correct answer.
            Console.WriteLine(Question);
            Console.Write("What is your answer? ");
            string playerAnswer = Console.ReadLine();
            Console.WriteLine($"Your answered: \"{playerAnswer}\".");
            Console.WriteLine($"The correct answer was: {Answer}");

        }
    }
}
