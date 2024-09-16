namespace Iterator;

internal class Program {
    static void Main (string[] args) {
        List list1 = new List ("Тетрадь", null);
        List list2 = new List ("Карандаш", list1);
        List list3 = new List ("Ручка", list2);

        Purchase chain = new Purchase (list3);


        foreach (string product in chain)
            Console.WriteLine(product);
    }
}
