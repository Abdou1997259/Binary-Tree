// See https://aka.ms/new-console-template for more information

using Binary_Tree;

Tree<int> tree=new Tree<int>();
tree.InsertNode(50);
tree.InsertNode(30);
tree.InsertNode(20);
tree.InsertNode(40);
tree.InsertNode(70);
tree.InsertNode(60);
tree.InsertNode(80);
Console.WriteLine("InOrder Traversal:");
tree.InOrderTraversal(tree.Root);
Console.WriteLine();

Console.WriteLine("PreOrder Traversal:");
tree.PreOrderTraversal(tree.Root);
Console.WriteLine();

Console.WriteLine("PostOrder Traversal:");
tree.PostOrderTraversal(tree.Root);
Console.WriteLine();
Console.WriteLine("level order");
tree.LevelOrder(tree.Root);
tree.Remove(50);
Console.WriteLine("After remove ");

Console.WriteLine("InOrder Traversal:");
tree.InOrderTraversal(tree.Root);
Console.WriteLine();

Console.WriteLine("PreOrder Traversal:");
tree.PreOrderTraversal(tree.Root);
Console.WriteLine();

Console.WriteLine("PostOrder Traversal:");
tree.PostOrderTraversal(tree.Root);
Console.WriteLine();

Console.WriteLine("Level Order");
tree.LevelOrder(tree.Root);
Console.ReadLine();
