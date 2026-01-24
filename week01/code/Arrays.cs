public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        //Plan:
        //1. Create a new array of 'number' with the size of 'length'.
        //2. Use a for loop to iterate through the array from index 0 to length - 1.
        //3. In each iteration, calculate the multiple.
        //   - The formula is: number * (index + 1)
        //4. Assign the calculated multiple to the current index of the array.
        //5. After the loop, return the filled array.

        //Step 1: Create the array
        double[] multiples = new double[length];

        //Step 2: Loop through the array
        for (int i = 0; i < length; i++)
        {
            //Step 3&4: Calculate the multiple and assign it to the array
            multiples[i] = number * (i + 1);
        }
        //Step 5: Return the filled array
        return multiples;

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        //Plan:
        //1.Determine where to split the list for rotation.
        //2. Get the last 'amount' elements to move to the front.
        //3. Get the remaining elements that will follow.
        //4. Clear the original list.
        //5. Add the two parts back to the list in the new order.
        

    }
}
