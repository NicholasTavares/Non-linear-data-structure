namespace ABP {
    class Node {
        public int _key { get; set; }
        public Node? _left { get; set; }
        public Node? _right { get; set; }

        public Node(int key) {
            _key = key;
            _left = null;
            _right = null;
        }
    }
}