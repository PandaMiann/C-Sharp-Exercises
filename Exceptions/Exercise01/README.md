# Task: Safe Number Divider

Write a C# program that:

- Asks the user to enter two integers.

- Tries to divide the first number by the second.

- Uses **`try`**/**`catch`** blocks to handle:

    - Invalid input (non-numeric values) → **`FormatException`**

    - Division by zero → **`DivideByZeroException`**

- Prints an appropriate message for each error, and does not crash.

## Example Run:

```
Enter the first number: 10
Enter the second number: 0
Error: You cannot divide by zero.
```

```
Enter the first number: abc
Enter the second number: 2
Error: Please enter a valid number.
```

```
Enter the first number: 20
Enter the second number: 4
Result: 5
```