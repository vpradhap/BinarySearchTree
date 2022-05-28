using BinarySearchTree;

Console.WriteLine("\n\t\tBinary Search Tree Program");
BST<int> tree = new BST<int>(56);

int flag = 0;
while (flag == 0)
{
    Console.WriteLine("\n1 - Creating binary search tree");
    Console.WriteLine("2 - Inserting more elements and check size of BST");
    Console.Write("\nYour Pick : ");
    int pick = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nBinary search tree sequence");

    switch (pick)
    {
        case 1:
            tree.Insert(30);
            tree.Insert(70);
            Console.Write("\nInoder sequence    --> ");
            tree.Inorder();
            Console.Write("\nPreoder sequence   --> ");
            tree.Preorder();
            Console.Write("\nPostorder sequence --> ");
            tree.Postorder();
            Console.WriteLine();
            break;
        case 2:
            tree.Insert(30);
            tree.Insert(70);
            tree.Insert(22);
            tree.Insert(40);
            tree.Insert(60);
            tree.Insert(95);
            tree.Insert(11);
            tree.Insert(65);
            tree.Insert(3);
            tree.Insert(16);
            tree.Insert(63);
            tree.Insert(67);
            Console.Write("\nInoder sequence    --> ");
            tree.Inorder();
            Console.Write("\nPreoder sequence   --> ");
            tree.Preorder();
            Console.Write("\nPostorder sequence --> ");
            tree.Postorder();
            Console.WriteLine("\n");
            tree.Size(); 
            Console.WriteLine();
            break;
        default:
            flag = 1;
            Console.WriteLine("\nEnter valid number");
            break;
    }
}
