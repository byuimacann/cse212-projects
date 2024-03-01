using System.Dynamic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.Xml.XPath;


public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        
        List<double> multiples = new List<double>(length); // Create a new instance of a list named 'multiples' to hold the parameter specified int quantity of multiples (list length). The list length is passed in as a parameter.

        //Use a 'for' loop to iterate through the integers (1 - list length). Multiply integers and parameter number to get the multiple.Add the multiple to the new list names 'multiples'.
        for (int i = 1; i <= length; i++ )
        {
            double multiple = number * i;
            multiples.Add(multiple);  
        }
        
        return multiples.ToArray(); // Convert list to an array and return array to the call point in the Run() function above. Learned how to convert a list to an array via a Google search...info found at this webpage: https://www.google.com/search?q=how+do+i+convert+a+list+to+an+array&oq=how+do+i+convert+a+list+to+an+array&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIICAEQABgWGB4yCAgCEAAYFhgeMggIAxAAGBYYHjIICAQQABgWGB4yCAgFEAAYFhgeMggIBhAAGBYYHjIICAcQABgWGB4yCAgIEAAYFhge0gEJMTAzNTBqMGoxqAIAsAIA&sourceid=chrome&ie=UTF-8.
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        
        var data1 = data.GetRange(0, data.Count - amount); //Get range of data from the beginning of the data List at index position 0 through the last index position minus the amount the list will need to be moved. The amount moved is passed in as a parameter. Store this in its own variable.

        var data2 = data.GetRange(data.Count - amount, amount);//Get the remaining range of data that was not stored in the previous step. Store this in its own variable.

        data.AddRange(data2); //Add second stored data range to the end of the original data list.

        data.AddRange(data1); //Add first stored data range to the end of the original data list.

        data.RemoveRange(0,data.Count-data1.Count-data2.Count); //Remove first half of the original list. 

    }
}
