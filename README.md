# QuizGame
A simple quiz game built with C# and .NET

## Features
- 🎮 **Interactive Console Interface** - Clean and colorful UI with formatted output
- ❓ **Multiple-Choice Questions** - C# knowledge assessment with 4 answer options
- 📊 **Score Tracking** - Keep track of correct answers throughout the game
- ✅ **Input Validation** - Error handling for user input
- 🎯 **6 Pre-loaded Questions** - Questions covering C# fundamentals

## Getting Started

### Prerequisites
- .NET 8 SDK or later
- Visual Studio 2022 (or any C# compatible IDE)

### Installation
1. Clone the repository
2. Build the project
3.  Run the application


## How to Play
1. Launch the application
2. Answer each question by entering the number (1-4) corresponding to your choice
3. Receive immediate feedback on your answer
4. Press any key to proceed to the next question
5. View your final score at the end

## Question Topics
The quiz includes questions about:
- Using directives and namespaces
- Constants and const keyword
- Value types in C#
- Method overriding and virtual keyword
- Array declaration syntax
- Object-oriented programming basics

## Code Structure

### Quiz Class
Handles the main game flow:
- `StartGame()` - Initiates and manages the quiz session
- `SetQuestion()` - Displays questions with formatted output
- `GetUserChoice()` - Validates and retrieves user input

### Questions Class
Data model for quiz questions:
- `QuestionText` - The question content
- `Answers` - Array of answer options
- `CorrectAnswer` - Index of the correct answer
- `CheckCorrectAnswer()` - Validates user's answer

## Technologies
- **Language:** C# 12.0
- **Framework:** .NET 8
- **Platform:** Console Application

## License
This project is open source and available under the MIT License.

## Author
Panagiotis Giannou - [https://github.com/PanagiotisGia-prog]

Made with using C# and .NET 8
