//interact in your terminal with "dotnet run" to execute

using System;

namespace TrueOrFalse
{
  class Program
  {
    static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Step 1 & 2: Declare questions and answers
      string[] questions = {
        "The sky is blue.",
        "C# is a programming language.",
        "The earth is flat.",
        "2 + 2 equals 4.",
        "Fish can fly."
      };

      bool[] answers = { true, true, false, true, false };

      // Step 3: Create empty responses array
      bool[] responses = new bool[questions.Length];

      // Step 4: Validate array lengths
      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Warning: Questions and answers do not match in length.");
      }

      // Step 5: Ask questions
      int askingIndex = 0;

      foreach (string question in questions)
      {
        // Step 7: Declare input variables
        string input;
        bool isBool = false;
        bool inputBool = false;

        // Step 8: Ask the question
        Console.WriteLine($"\n{question}");
        Console.WriteLine("True or False?");
        input = Console.ReadLine().ToLower();

        // Step 9: Check validity
        if (input == "true" || input == "false")
        {
          isBool = true;
        }

        // Step 11–12: Repeat input until valid
        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine().ToLower();

          if (input == "true" || input == "false")
          {
            isBool = true;
          }
        }

        // Step 13: Convert to bool
        if (input == "true")
        {
          inputBool = true;
        }
        else
        {
          inputBool = false;
        }

        // Step 14: Store user response
        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      // Step 16: Score the quiz
      int scoringIndex = 0;
      int score = 0;

      foreach (bool answer in answers)
      {
        bool response = responses[scoringIndex];

        // Step 19: Print result
        Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");

        // Step 20: Increase score
        if (response == answer)
        {
          score++;
        }

        // Step 21: Move to next
        scoringIndex++;
      }

      // Step 22: Final score
      Console.WriteLine($"\nYou got {score} out of {questions.Length} correct!");
    }
  }
}
