using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace CalculatorLibrary1
{
    public class Calculator
    {
        JsonWriter writer;
        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculatorlog.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }
        public double DoOperation(double N1, double N2, string op)
        {
            double result = double.NaN;
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(N1);
            writer.WritePropertyName("operand2");
            writer.WriteValue(N2);
            writer.WritePropertyName("Operations");

            switch (op)
            {
                case "+":
                    result = N1 + N2;
                    writer.WriteValue("+");
                    break;
                case "-":
                    result = N1 - N2;
                    writer.WriteValue("-");
                    break;
                case "*":
                    result = N1 * N2;
                    writer.WriteValue("*");
                    break;
                case "/":
                    if (N2 != 0)
                    {
                        result = N1 / N2;
                        writer.WriteValue("/");
                    }
                    break;
                default:
                    break;
            }
            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();

            return result;
        }

    }
}