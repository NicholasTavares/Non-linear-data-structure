namespace ABP {
    class ABP {
        private Node? _root;

        private void insertNode(Node node, int key) {
            if (key < node._key) {
                if (node._left == null) {
                    node._left = new Node(key);
                }
                else {
                    insertNode(node._left, key);
                }
            }
            else {
                if (node._right == null) {
                    node._right = new Node(key);
                }
                else {
                    insertNode(node._right, key);
                }
            }
        }

        public void insert(int key) {
            if (_root == null) {
                _root = new Node(key);
            }
            else {
                insertNode(_root, key);
            }
        }

        private bool searchNode(Node node, int key) {
            if (node == null) {
                return false;
            }

            if (key < node._key) {
                return searchNode(node._left, key);
            }
            else if (key > node._key) {
                return searchNode(node._right, key);
            }
            else {
                return true;
            }
        }

        public bool? search(int key) {
            if (_root == null) {
                return null;
            }
            return searchNode(_root, key);
        }

        private Node minNode(Node node) {
            Node current = node;
            while (current != null && current._left != null) {
                current = current._left;
            }
            return current;
        }

        public int? min() {
            if (_root == null) {
                return null;
            }
            return minNode(_root)._key;
        }

        private Node maxNode(Node node) {
            Node current = node;
            while (current != null && current._right != null) {
                current = current._right;
            }
            return current;
        }

        public int? max() {
            if (_root == null) {
                return null;
            }
            return maxNode(_root)._key;
        }

        private Node? removeNode(Node node, int key) {
            if (node == null) {
                return null;
            }

            if (key < node._key) {
                node._left = removeNode(node._left, key);
                return node;
            }
            else if (key > node._key) {
                node._right = removeNode(node._right, key);
                return node;
            }
            else {
                if (node._left == null && node._right == null) {
                    node = null;
                    return node;
                }

                if (node._left == null) {
                    node = node._right;
                    return node;
                }
                else if (node._right == null) {
                    node = node._left;
                    return node;
                }

                Node aux = minNode(node._right);
                node._key = aux._key;
                node._right = removeNode(node._right, aux._key);
                return node;
            }
        }

        public Node? remove(int key) {
            return removeNode(_root, key);
        }

        private void InOrderTraversal(Node? node, Action<int> callback) {
            if (node != null) {
                InOrderTraversal(node._left, callback);
                callback(node._key);
                InOrderTraversal(node._right, callback);
            }
        }

        public void TraverseInOrder(Action<int> callback) {
            Console.Write("[");
            InOrderTraversal(_root, callback);
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}