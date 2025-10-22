public class Node
{
    public object data;
    public Node next;
}
public class MyStack
{
    public Node top;
    public bool IsEmpty(){
        return top == null;
    }
    public void Push(object newdata){
        Node newnode = new Node();
        newnode.data = newdata;
        newnode.next = top;
        top = newnode;
    }
    public object Pop(){
        if (IsEmpty())
            return null;
        Node temp = top;
        top = top.next;
        return temp.data;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        MyStack stack = new MyStack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine(stack.IsEmpty());
        
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        Console.WriteLine(stack.IsEmpty());
    }
}