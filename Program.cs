namespace ABP {
    class Program {
        static void Main(string[] args) {
            ABP binarySearchTree = new ABP();
            binarySearchTree.insert(10);
            binarySearchTree.insert(56);
            binarySearchTree.insert(8);
            binarySearchTree.insert(18);
            binarySearchTree.insert(2);
            binarySearchTree.insert(31);
            binarySearchTree.insert(42);

            binarySearchTree.TraverseInOrder(key => Console.Write($" {key} "));

            System.Console.WriteLine("Valor minimo: " + binarySearchTree.min());
            System.Console.WriteLine("Valor maximo: " + binarySearchTree.max());

            System.Console.WriteLine("Busca por valor existente : " + binarySearchTree.search(18));
            System.Console.WriteLine("Busca por valor inexistente : " + binarySearchTree.search(50));

            binarySearchTree.remove(2);
            binarySearchTree.remove(18);
            binarySearchTree.remove(56);
            binarySearchTree.remove(100);

            binarySearchTree.TraverseInOrder(key => Console.Write($" {key} "));

        }
    }
}