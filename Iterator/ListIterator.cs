using System.Collections;

namespace Iterator;

public class ListIterator : IEnumerator<string> {
    public Purchase Chain { get; }
    public bool HasStarted { get; set; } = false;
    public List? Link { get; set; }

    public ListIterator (Purchase chain) {
        Chain = chain;
        HasStarted = false;
    }

    public string Current => Link is null ? throw new NullReferenceException () : Link.Name;
    object IEnumerator.Current => Current;

    public bool MoveNext () {
        if (HasStarted) {
            if (Link is null) throw new NullReferenceException ();
            Link = Link.Next;
        }
        else {
            Link = Chain.Head;
            HasStarted = true;
        }
        return Link is not null;
    }

    public void Reset () {
        HasStarted = false;
        Link = null;
    }

    public void Dispose () { }
}
