using System;
using System.Collections.Generic;

internal class Node 
{  
    internal int data;  
    internal Node next;  
    public Node(int d) 
    {  
        data = d;  
        next = null;  
    }  
} 
internal class DNode {  
    internal int data;  
    internal DNode prev;  
    internal DNode next;  
    public DNode(int d)
    {  
        data = d;  
        prev = null;  
        next = null;  
    }  
}  
internal class SingleLinkedList 
{  
    internal Node head;  
}  
internal class DoubleLinkedList 
{  
    internal DNode head;  
} 

// Insert data at start of the Linked List
internal void InsertFront(SingleLinkedList singlyList, int new_data) 
{    
    Node new_node = new Node(new_data);    
    new_node.next = singlyList.head;    
    singlyList.head = new_node;    
} 

// Insert data at start of the Linked List
internal void InsertFront(DoubleLinkedList doubleLinkedList, int data) 
{  
    DNode newNode = new DNode(data);  
    newNode.next = doubleLinkedList.head;  
    newNode.prev = null;  
    if (doubleLinkedList.head != null) {  
        doubleLinkedList.head.prev = newNode;  
    }  
    doubleLinkedList.head = newNode;  
} 

// Insert data at the end of Linked List
internal void InsertLast(SingleLinkedList singlyList, int new_data)    
{    
    Node new_node = new Node(new_data);    
    if (singlyList.head == null) {    
        singlyList.head = new_node;    
        return;    
    }    
    Node lastNode = GetLastNode(singlyList);    
    lastNode.next = new_node;    
} 

// Insert data at the end of Linked List
internal void InsertLast(DoubleLinkedList doubleLinkedList, int data) {  
    DNode newNode = new DNode(data);  
    if (doubleLinkedList.head == null) {  
        newNode.prev = null;  
        doubleLinkedList.head = newNode;  
        return;  
    }  
    DNode lastNode = GetLastNode(doubleLinkedList);  
    lastNode.next = newNode;  
    newNode.prev = lastNode;  
} 

//  traverse the list until we find the node with next as null 
//  and return that node as last node
internal Node GetLastNode(SingleLinkedList singlyList) {  
    Node temp = singlyList.head;  
    while (temp.next != null) {  
        temp = temp.next;  
    }  
    return temp;  
} 

// Insert data after a given node of Linked List
internal void InsertAfter(Node prev_node, int new_data)  
{  
    if (prev_node == null) {  
        Console.WriteLine("The given previous node Cannot be null");  
        return;  
    }  
    Node new_node = new Node(new_data);  
    new_node.next = prev_node.next;  
    prev_node.next = new_node;  
}  

// Insert data after a given node of Linked List
internal void InsertAfter(DNode prev_node, int data)  
{  
    if (prev_node == null) {  
        Console.WriteLine("The given prevoius node cannot be null");  
        return;  
    }  
    DNode newNode = new DNode(data);  
    newNode.next = prev_node.next;  
    prev_node.next = newNode;  
    newNode.prev = prev_node;  
    if (newNode.next != null) {  
        newNode.next.prev = newNode;  
    }  
}

// Delete a node from Linked List using a given key value  
internal void DeleteNodebyKey(SingleLinkedList singlyList, int key)  
{  
    Node temp = singlyList.head;  
    Node prev = null;  
    if (temp != null && temp.data == key) {  
        singlyList.head = temp.next;  
        return;  
    }  
    while (temp != null && temp.data != key) {  
        prev = temp;  
        temp = temp.next;  
    }  
    if (temp == null) {  
        return;  
    }  
    prev.next = temp.next;  
} 

// Delete a node from Linked List using a given key value 
internal void DeleteNodebyKey(DoubleLinkedList doubleLinkedList, int key)  
{  
    DNode temp = doubleLinkedList.head;  
    if (temp != null && temp.data == key) {  
        doubleLinkedList.head = temp.next;  
        doubleLinkedList.head.prev = null;  
        return;  
    }  
    while (temp != null && temp.data != key) {  
        temp = temp.next;  
    }  
    if (temp == null) {  
        return;  
    }  
    if (temp.next != null) {  
        temp.next.prev = temp.prev;  
    }  
    if (temp.prev != null) {  
        temp.prev.next = temp.next;  
    }  
} 

// Reversing a linked list. Last node will be the head node.
public void ReverseLinkedList(SingleLinkedList singlyList)  
{  
    Node prev = null;  
    Node current = singlyList.head;  
    Node temp = null;  
    while (current != null) {  
        temp = current.next;  
        current.next = prev;  
        prev = current;  
        current = temp;  
    }  
    singlyList.head = prev;  
}   