using BinarySearchTree;

Console.WriteLine("\n\t\tBinary Search Tree Program");
BST<int> tree = new BST<int>(56);

int flag = 0;
while (flag == 0)
{
    Console.WriteLine("\n1 - Creating binary search tree");
    Console.Write("\nYour Pick : ");
    int pick = Convert.ToInt32(Console.ReadLine());
    switch (pick)
    {
        case 1:
            tree.Insert(30);
            tree.Insert(70);
            Console.WriteLine("\nBinary search tree sequence");
            Console.Write("\nInoder sequence    --> ");
            tree.Inorder();
            Console.Write("\nPreoder sequence   --> ");
            tree.Preorder();
            Console.Write("\nPostorder sequence --> ");
            tree.Postorder();
            Console.WriteLine();
            break;
        default:
            flag = 1;
            Console.WriteLine("\nEnter valid number");
            break;
    }
}
