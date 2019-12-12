using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearchTreeRuntime : MonoBehaviour
{
    // Simple runtime printing of tree
    // In order traversal prints the values sorted
    void Start()
    {
        Node root = new Node(20);
        root.Insert(15);
        root.Insert(16);
        root.Insert(23);
        root.Insert(1);
        root.Insert(4);
        root.Insert(4);
        root.InOrderTraversal();
    }
}
