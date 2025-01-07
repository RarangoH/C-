using System;
using System.Collections.Generic;
using System.Linq;

namespace planets
{
    public class DataPrinter
    {
        public static void PrintData<T>(IEnumerable<T> data)
        {
            if (data == null || !data.Any())
            {
                Console.WriteLine("No data to display.");
                return;
            }

            // Retrieve properties or fields dynamically
            var type = typeof(T);
            var properties = type.GetProperties();
            var fields = type.GetFields();

            var headers = properties.Select(p => p.Name).Concat(fields.Select(f => f.Name)).ToArray();

            // Prepare rows with dynamic data
            var rows = data.Select(item =>
            {
                var propertyValues = properties.Select(p => p.GetValue(item)?.ToString() ?? string.Empty);
                var fieldValues = fields.Select(f => f.GetValue(item)?.ToString() ?? string.Empty);
                return propertyValues.Concat(fieldValues).ToArray();
            }).ToArray();

            // Combine headers and rows
            var table = new[] { headers }.Concat(rows).ToArray();

            // Calculate column widths
            var columnWidths = CalculateColumnWidths(table);

            // Print table
            PrintSeparator(columnWidths);
            foreach (var row in table)
            {
                PrintRow(row, columnWidths);
                PrintSeparator(columnWidths);
            }
        }

        private static int[] CalculateColumnWidths(string[][] table)
        {
            int columnCount = table.Max(row => row.Length);
            var columnWidths = new int[columnCount];

            foreach (var row in table)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    columnWidths[i] = Math.Max(columnWidths[i], row[i].Length);
                }
            }

            return columnWidths;
        }

        private static void PrintRow(string[] row, int[] columnWidths)
        {
            string rowText = "|";
            for (int i = 0; i < row.Length; i++)
            {
                rowText += " " + row[i].PadRight(columnWidths[i]) + " |";
            }
            Console.WriteLine(rowText);
        }

        private static void PrintSeparator(int[] columnWidths)
        {
            string separator = "+";
            foreach (var width in columnWidths)
            {
                separator += new string('-', width + 2) + "+";
            }
            Console.WriteLine(separator);
        }
    }

}