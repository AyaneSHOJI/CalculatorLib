namespace Packt
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a * b;
        }
    }
}


// p.163 How to do a Unit test ?
// Create a function, then Build CalculatorLib
// Add a new project from CalculatorLib project (DO NOT CREATE A NEW FOLDER), Choose "xUnit Test Project" type
// Right click on xUnit dependencies "Add Project Reference"
// Add CalculatorLib and click OK
// Build CalculatorLibUnitTests
// Write unit test as below
// Go to Test of main menu and "Run all tests"

// Writing unit tests
// Three parts 3A : Arrange, Act, Assert
// Arrange : declare and instantiate variables
// Act : execute the unit
// Assert : make assertions about the output
