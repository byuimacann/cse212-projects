/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue {
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person) {
        _queue.Insert(_queue.Count, person); // Defect found. 
        //Insert point was at 0 (the beginning of the queue).
        //Changed 0 to _queue.Count so that the person is inserted at the end of the queue.
    }

    public Person Dequeue() {
        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty() {
        return Length == 0;
    }

    public override string ToString() {
        return $"[{string.Join(", ", _queue)}]";
    }
}