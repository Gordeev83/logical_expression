namespace logical_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите логическое выражение:");
                string expression = Console.ReadLine();

                bool result = EvaluateExpression(expression);
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат выражения.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }

        static bool EvaluateExpression(string expression)
        {
            string[] parts = expression.Split(' ');

            if (parts.Length != 3)
                throw new FormatException();

            int operand1 = int.Parse(parts[0]);
            int operand2 = int.Parse(parts[2]);
            string oper = parts[1];

            switch (oper)
            {
                case "<":
                    return operand1 < operand2;
                case ">":
                    return operand1 > operand2;
                case "<=":
                    return operand1 <= operand2;
                case ">=":
                    return operand1 >= operand2;
                case "==":
                    return operand1 == operand2;
                case "!=":
                    return operand1 != operand2;
                default:
                    throw new FormatException("Неверный оператор.");
            }
        }
    }
}
