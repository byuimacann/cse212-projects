using System.ComponentModel.DataAnnotations.Schema;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        // var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1 
        // Scenario: Create a queue that includes data and priority rank and display the queue in FIFO order and the pet name with the highest priority rank.
        // Expected Result: [parrot (Pri:2), horse (Pri:4), cat (Pri:3), hamster (Pri:1), dog (Pri:5)] 
        //dog
        Console.WriteLine("Test 1");
        var pets = new PriorityQueue();
        pets.Enqueue("parrot", 2);
        pets.Enqueue("horse", 4);
        pets.Enqueue("cat", 3);
        pets.Enqueue("hamster", 1);
        pets.Enqueue("dog", 5);
        Console.WriteLine(pets);
        Console.WriteLine(pets.Dequeue());
        // Defect(s) Found: Index needs to iterate through the last item on the list. Changed 'for' loop operator from < to <= in the Dequeue().

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with two animals that have the same top priority ranking and display the animal with the highest priority that is closest to the front of the list. 
        // Expected Result: [elephant (Pri:3), koala (Pri:4), lamb (Pri:5), alligator (Pri:2), giraffe (Pri:5), rat (Pri:1), cat (Pri:2)] 
        //lamb
        Console.WriteLine("Test 2");
        var animals = new PriorityQueue();
        animals.Enqueue("elephant", 3);
        animals.Enqueue("koala", 4);
        animals.Enqueue("lamb", 5);
        animals.Enqueue("alligator", 2);
        animals.Enqueue("giraffe", 5);
        animals.Enqueue("rat", 1);
        animals.Enqueue("cat", 2);
        Console.WriteLine(animals);
        Console.WriteLine(animals.Dequeue());
        // Defect(s) Found: Animal closest to the back of the queue with the same top priority was returned instead of the one, with the same top priority ranking, that was closest to the front of the queue. Changed 'if' statement operator, in the Dequeue(), from >= to > to return the first top priority animal it iterates through instead of returning the last one. 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Run program with an empty list.
        // Expected Result: [] Error message will display ("The queue is empty.")
        Console.WriteLine("Test 3");
        var animals1 = new PriorityQueue();
        Console.WriteLine(animals1);
        Console.WriteLine(animals1.Dequeue());
        // Defect(s) Found: No defects found.

    }
}