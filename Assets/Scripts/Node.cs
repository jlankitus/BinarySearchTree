using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Node implementation for binary search tree
// Adapted from here: https://www.youtube.com/watch?v=oSWTXtMglKE
public class Node
{
    private Node _left;
    private Node _right;
    private readonly int _value;
    
    // Public constructor for creating new node
    // value is immutable after constructor assignment
    public Node(int value)
    {
        this._value = value;
    }

    // Insert nodes such that the left element is always less than the root
    // And the right is always greater than the root
    public void Insert(int value)
    {
        if (value <= _value)
        {
            if (_left == null)
            {
                _left = new Node(value);
            }
            else
            {
                _left.Insert(value);
            }
        }
        else
        {
            if (_right == null)
            {
                _right = new Node(value);
            }
            else
            {
                _right.Insert(value);
            }
        }
    }

    // Search the binary tree 
    public bool Contains(int value)
    {
        if (value == _value)
        {
            return true;
        }
        else if (value < _value)
        {
            if (_left == null)
            {
                return false;
            }
            else
            {
                return _left.Contains(value);
            }
        }
        else
        {
            if (_right == null)
            {
                return false;
            }
            else
            {
                return _right.Contains(value);
            }
        }
    }

    // Print the left, root, then right
    public void InOrderTraversal()
    {
        if (_left != null)
        {
            _left.InOrderTraversal();
        }
        
        Debug.Log(_value.ToString());
        
        if (_right != null)
        {
            _right.InOrderTraversal();
        }
    }
    
    // Retrieve the max value from the tree
    public static int GetMax(Node node)
    {
        while (node._right != null)
        {
            node = node._right;
        }
        return (node._value);
    }
    
    // Retrieve the min value from the tree
    public static int GetMin(Node node)
    {
        while (node._left != null)
        {
            node = node._left;
        }
        return (node._value);
    }
}
