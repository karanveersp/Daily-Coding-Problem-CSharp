using System;
using System.Collections.Generic;

namespace DailyCode.BinaryTree
{
public class Node
{
    public Node Left { get; set; }
    public Node Right { get; set; }
    public string Val { get; set; }

    public Node(string val, Node left = null, Node right = null)
    {
        Val = val;
        Left = left;
        Right = right;
    }

    public static Node Deserialize(string s)
    {
       var arr = s.Split(" ");
       if (arr.Length == 0) {
           return null;
       }

       Node root = new Node(arr[0]);
       var q = new Queue<Node>();
       q.Enqueue(root);

       int i = 1;

       while (!(q.Count == 0))
       {
           Node n = q.Dequeue();
           if (n != null)
           {
               Node left = null;
               if (i < arr.Length && !arr[i].Equals("#")) {
                   left = new Node(arr[i]);
               }
               n.Left = left;
               q.Enqueue(left);
               i++;

               Node right = null;
               if (i < arr.Length && !arr[i].Equals("#")) {
                   right = new Node(arr[i]);
               }
               n.Right = right;
               q.Enqueue(right);
               i++;
           }
       } 

       return root;

    }

    public static string Serialize(Node root)
    {
        if(root == null)
        {
            return "#";
        }
        var s = new Queue<Node>();
        s.Enqueue(root);
        
        var res = new List<string>();
        while (!(s.Count == 0)) 
        {
            var n = s.Dequeue();
            if (n == null) {
                res.Add("#");
            }
            else {
                res.Add(n.Val);
                s.Enqueue(n.Left);
                s.Enqueue(n.Right);
            }
        }
        return string.Join(" ", res);
    }

    override public string ToString()
    {
        return $"{this.Val} (L: {this.Left}, R: {this.Right})";
    }
}
}