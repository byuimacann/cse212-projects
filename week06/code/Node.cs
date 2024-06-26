using System.ComponentModel;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {   
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
        if (value > Data) {    
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
            }
        }
    }   
    

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value < Data){
            if (Left is null)
                return false;    
            if (!Left.Contains(value))
                return false;    
        }
        if (value > Data){
            if (Right is null)
                return false;
            if (!Right.Contains(value))
                return false;
            }
        return true;
    }
    
  
     

    

    public int GetHeight() {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}