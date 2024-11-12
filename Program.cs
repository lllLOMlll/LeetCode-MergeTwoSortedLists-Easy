class Program
{

  public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

//     public ListNode MergeTwoLists(ListNode list1, ListNode list2)
//     {
//         return null;
//     }

 public static void AfficherListe(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        
        // Création de la liste chaînée list1 = [1, 2, 4]
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));

        // Création de la liste chaînée list2 = [1, 3, 4]
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        // Affichage des deux listes
        Console.WriteLine("list1:");
        AfficherListe(list1);

        Console.WriteLine("\nlist2:");
        AfficherListe(list2);
        
        // Création des nœuds de la liste chaînée avec les valeurs 1 -> 2 -> 3
        ListNode node3 = new ListNode(3);
        ListNode node2 = new ListNode(2, node3);
        ListNode node1 = new ListNode(1, node2);

        // Affichage de la liste avant d'ajouter le nouveau nœud
        Console.WriteLine("Liste avant :");
        AfficherListe(node1);
        AfficherListe(node2);

        // Création d'un nouveau nœud avec la valeur 0
        ListNode newHead = new ListNode(0, node1); // Le nouveau nœud pointe vers le nœud existant (1)

        // Affichage de la liste après avoir ajouté le nouveau nœud au début
        Console.WriteLine("\nListe après ajout de 0 au début :");
        AfficherListe(newHead);

    }

}