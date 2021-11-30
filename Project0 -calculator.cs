// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Create construct to hold data, List for strict 
typing and no upper limit on size*/

List<string> expression = new List<string>();
Console.WriteLine("Welcome to the calculator, please follow instructions");

//Initialize and define exit variable for while loop
bool Done = false;
do
{
  Console.WriteLine("Please enter your expression separating each term with a space. When you are finished entering your expression, hit enter. When done, enter Done");
  string userInput = Console.ReadLine();
  string [] separated = userInput.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
  foreach (string item in separated)
  {
      expression.Add(item.ToLower());
  }
  if (expression.Contains("done"))
    {
        Done = true;
    }
    else
    {
        List<float> numericExpression = new List<float>();
        for (int n=0; n < (expression.Count - 1); n++)
        {
            
            bool parsable = Single.TryParse(expression[n], out float dummy);
            if (parsable)
            {
                
                numericExpression.Add(float.Parse(expression[n]));
                Console.WriteLine(numericExpression[n]);
            }
            else if (expression[n] == "+")
            {
                numericExpression.Add(+);
            }
            else if (expression[n] == "-")
            {
                numericExpression.Add(-);
            }
            else if (expression[n] == "/")
            {
                numericExpression.Add(/);
            }
            else if (expression[n] == "*")
            {
                numericExpression.Add(*);
            }
        }
        Console.WriteLine(numericExpression[0]);
        Console.WriteLine(numericExpression[1]);
        Console.WriteLine(numericExpression[2]);
    }
} while (Done != true);
