# Lab Assignment: String Concatenation Using Strategy Pattern

## Objective

The goal of this lab assignment is to give you hands-on experience with the Strategy design pattern and constructor injection in C#. You'll be working with a console application that uses different strategies to concatenate strings.

## Background

The Strategy pattern defines a family of algorithms, encapsulates each one of them, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

In the context of our application, we are implementing different strategies for string concatenation:

1. Using the + operator
2. Using `StringBuilder`
3. Using `string.Format`
4. Using string interpolation

Constructor injection is used to inject the strategy into the service class (`GreetingService`) that uses it.

![Strategy Pattern](StringConcatStrategyApp/lab.png)
## Instructions

1. Open the provided Visual Studio solution.
2. You will find several `TODO` comments in the code. These comments indicate what you need to implement or fix.

### `GreetingService` Class

Start by implementing the `GreetingService` class that takes an `IStringConcatStrategy` object as a constructor parameter (constructor injection). This class will have a method `DisplayGreeting` that uses the strategy to generate and display a greeting.

### Strategy Classes

Next, you will find several classes that implement the `IStringConcatStrategy` interface. Fill in the `GenerateGreeting` methods for these classes.

### `StringConcatStrategyFactory` Class

After that, open the `StringConcatStrategyFactory` class. You'll find a method that returns an instance of `IStringConcatStrategy`. Implement the switch-case logic in this factory method based on the choice provided.

### `UserInputValidator` Class

Then, open the `UserInputValidator` class and complete the `IsValidChoice` method. This class validates the user input for selecting a string concatenation strategy.

### `Main` Method

Finally, your last task is to uncomment and implement the section in the `Main` method inside the `Program` class. Here, you'll inject the selected strategy into the `GreetingService`.

### Unit Tests

Run the unit tests to confirm that your strategies are working as expected. You'll need to uncomment the tests and ensure they pass.

## Grading Criteria

- All `TODO` items are properly implemented.
- The program runs without errors.
- All unit tests pass.
- The code is clean and well-organized.

## Submission

Submit your complete Visual Studio solution with all implemented features and no build errors.

## Bonus

For extra points, implement additional string concatenation strategies and corresponding unit tests.

## Due Date

Submit your assignment by the due date provided by your instructor.

Happy coding!