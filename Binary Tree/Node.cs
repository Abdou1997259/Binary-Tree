

namespace Binary_Tree
{
    public class Node<T>
    {
        public T Item;
        public Node<T>? Left;
        public Node<T>? Right;

        public Node(T item) {
            Item = item;
            Left = null;
            Right = null;

        }

    }
    public class Tree<T> where T : IComparable<T>
    {
        public Node<T>? Root;
        public Tree()
        {
            Root = null;
        }
        public void InsertNode(T value)
        {
            if (Root == null)
                Root = new Node<T>(value);
            else
            {
                InserRecursivly(Root,value);    
            }
           

        }
        private void InserRecursivly(Node<T> current, T value)
        {
            if (value.CompareTo(current.Item) < 0)
            {
                if (current.Left == null)
                    current.Left = new Node<T>(value);
                else
                    InserRecursivly(current.Left, value);



            }
            else
            {
                if (value.CompareTo(current.Item) > 0)
                {
                    if (current.Right == null)
                        current.Right = new Node<T>(value);
                    else
                        InserRecursivly(current.Right, value);



                }

            }
          
        }
        public void PreOrderTraversal(Node<T>  node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Item);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);  
            }
        }
        public void InOrderTraversal(Node<T> node)
        {
            if(node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine(node.Item);
                InOrderTraversal(node.Right);
            }
        }
        public void PostOrderTraversal(Node<T> node)
        {
            if(node!= null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.WriteLine(node.Item);

            }
        }
        public bool Remove(T value)
        {
            return RemoveRecurively(ref Root, value);
        }
        public bool RemoveRecurively(ref Node<T> current,T value)
        {
            if (current == null)
            {
                return false;
            }
            if (value.CompareTo(current.Item)<0)
            {
                return RemoveRecurively(ref current.Left, value);

            }
            if (value.CompareTo(current.Item) > 0)
            {
                return RemoveRecurively(ref current.Right, value);

            }
            else
            {
                if(current.Left==null && current.Right == null)
                {
                    current = null;
                }
                else if (current.Left == null)
                {
                    current = current.Right;
                }
                else if (current.Right == null)
                {
                    current = current.Left;
                }
                else
                {
                    Node<T> successor = FindMin(current.Right);
                    current.Item = successor.Item;
                    RemoveRecurively(ref current.Right, successor.Item);
                    
                }
                return true;
            }


        }
        private Node<T> FindMin(Node<T> node)
        {
            while (node.Left != null)
            {
                node=node.Left;
            }
            return node;
        }
        public void LevelOrder(Node<T> Node)
        {
            if (Node == null)
                return;
            Queue<Node<T>> q= new Queue<Node<T>>();
            q.Enqueue(Node);
            while(q.Count > 0)
            {
                Node<T> curr = (Node<T>)q.Peek();
                Console.WriteLine(curr.Item);
                if (curr.Left != null)
                    q.Enqueue(curr.Left);
                if(curr.Right != null)
                    q.Enqueue(curr.Right);
                q.Dequeue();

            }
        }


    }
}
 