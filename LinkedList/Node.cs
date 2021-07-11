namespace DataStructures.LinkedList
{
    class Node<TNode>
    {  
        internal TNode value;
        internal Node<TNode> next;

        public Node(
               TNode value,
               Node<TNode> next = null
            )
        {
            this.value = value;
            this.next = next;
        }   
    }
}
