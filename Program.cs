using System.Net.NetworkInformation;

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

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Nœud de départ pour simplifier la gestion de la tête
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        // Parcourir les deux listes tant qu'elles ne sont pas nulles
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        // Ajouter le reste de l'une des listes
        current.next = (list1 != null) ? list1 : list2;

        // Retourner la tête de la liste fusionnée
        return dummy.next;
    }

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

        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        ListNode listeTest1 = p.MergeTwoLists(list1, list2);
        AfficherListe(listeTest1);
        // // Création de la liste chaînée list1 = [1, 2, 4]
        // ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));

        // // Création de la liste chaînée list2 = [1, 3, 4]
        // ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        // // Affichage des deux listes
        // Console.WriteLine("list1:");
        // AfficherListe(list1);

        // Console.WriteLine("\nlist2:");
        // AfficherListe(list2);

        // // Création des nœuds de la liste chaînée avec les valeurs 1 -> 2 -> 3
        // ListNode node3 = new ListNode(3);
        // ListNode node2 = new ListNode(2, node3);
        // ListNode node1 = new ListNode(1, node2);

        // // Affichage de la liste avant d'ajouter le nouveau nœud
        // Console.WriteLine("Liste avant :");
        // AfficherListe(node1);
        // AfficherListe(node2);

        // // Création d'un nouveau nœud avec la valeur 0
        // ListNode newHead = new ListNode(0, node1); // Le nouveau nœud pointe vers le nœud existant (1)

        // // Affichage de la liste après avoir ajouté le nouveau nœud au début
        // Console.WriteLine("\nListe après ajout de 0 au début :");
        // AfficherListe(newHead);

        // // Création d'un nouveau nœud avec la valeur 0
        // ListNode newHead55 = new ListNode(55, node2); // Le nouveau nœud pointe vers le nœud existant (1)
        // Console.WriteLine("\nListe après l'ajout de 55 qui pointe vers node2");
        // AfficherListe(newHead55);

    }

}