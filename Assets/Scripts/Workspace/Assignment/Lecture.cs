using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            //LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Node 1");
            linkedList.AddLast("Node 2");
            linkedList.AddFirst("Node 0");

            LinkedListNode<string> node1 = linkedList.Find("Node 1");
            Debug.Log(node1.Value);
            Debug.Log(node1.Next.Value);
            Debug.Log(node1.Previous.Value);
            Debug.Log("\n=========( 1 )=========\n");

            var firstNode = linkedList.First;
            var lastNode = linkedList.Last;
            Debug.Log(firstNode.Next);
            Debug.Log(lastNode.Next);
            Debug.Log("\n=========( 2 )=========\n");

            linkedList.AddAfter(node1, "Node 1.5");
            linkedList.AddBefore(node1, "Node 0.5");

            linkedList.RemoveFirst();
            linkedList.RemoveLast();
            linkedList.Remove("Node 1.5"); // Remove First one
            linkedList.Clear();
            foreach (var item in linkedList)
            {
                Debug.Log(item);
            }
            Debug.Log("\n=========( 3 )=========\n");
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();
            inv.Add("Potion", 5);
            inv.Add("Banana", 1);
            inv.Add("Apple", 10);

            inv["Apple"] = 0;
            inv["Apple1"] = 1; // if no key => Create new key

            int potion = inv["Potion"];
            Debug.Log($"Potion " + potion);

            bool hasPotion = inv.ContainsKey("Potion");
            Debug.Log($"hasPotion" + hasPotion);

            inv.Remove("Banana");
            Debug.Log("\n=========( 1 )=========\n");
            foreach (KeyValuePair<string, int> kvp in inv)
            {
                var key = kvp.Key;
                var value = kvp.Value;
                Debug.Log($"Key: {key} Has Value {value}");
            }
        }

        #endregion
    }
}
