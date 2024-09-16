namespace Iterator;

public class List {
    public string Name { get; }
    public List? Next { get; }

    public List (string name, List? next) {
        Name = name;
        Next = next;
    }

    public override string ToString () => Name;
}
