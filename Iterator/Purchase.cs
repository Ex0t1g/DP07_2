using System.Collections;

namespace Iterator;

public class Purchase : IEnumerable<string> {
    public List Head { get; }

    public Purchase (List head) {
        Head = head;
    }

    public IEnumerator<string> GetEnumerator () {
        return new ListIterator (this);
    }
    IEnumerator IEnumerable.GetEnumerator () => GetEnumerator ();
}
