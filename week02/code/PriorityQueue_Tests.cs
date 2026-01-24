using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add itesm with different priorities (Low, Medium, High)
    // Expected Result: High, Medium, Low
    // Defect(s) Found: The loop condition 'index < _queue.Count - 1' caused the last item to be ignored.
    //2. The Dequeue method did not remove the item from the queue after finding it.
    public void TestPriorityQueue_HighestPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("High", 5);

        //1. Should return "High"
        var item = priorityQueue.Dequeue();
        Assert.AreEqual("High", item, "Expected High priority item first.");

        //2. Should return "Medium"
        item = priorityQueue.Dequeue();
        Assert.AreEqual("Medium", item, "Expected Medium priority item second.");

        //3. Should return "Low"
        item = priorityQueue.Dequeue();
        Assert.AreEqual("Low", item, "Expected Low priority item last.");
    }

    [TestMethod]
    // Scenario: Add multiple items with the SAME priority (10, 10, 10)
    // Expected Result: They should come out in the same order they were added (FIFO)
    // Defect(s) Found: 1. The comparison '>=' allowed later items with the same priority to be chosen first.
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);
        priorityQueue.Enqueue("Third", 10);

        //1. Should return "First"
        var item = priorityQueue.Dequeue();
        Assert.AreEqual("First", item, "Expected First item first.");

        //2. Should return "Second"
        item = priorityQueue.Dequeue();
        Assert.AreEqual("Second", item, "Expected Second item second.");

        //3. Should return "Third"
        item = priorityQueue.Dequeue();
        Assert.AreEqual("Third", item, "Expected Third item last.");
    }

    // Add more test cases as needed below.
}