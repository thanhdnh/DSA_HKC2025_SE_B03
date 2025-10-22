public class Node
{
    public object data;
    public Node next;
}
public class MyStack
{
    public Node top;
    public bool IsEmpty()
    {
        return top == null;
    }
    public void Push(object newdata)
    {
        Node newnode = new Node();
        newnode.data = newdata;
        newnode.next = top;
        top = newnode;
    }
    public object Pop()
    {
        if (IsEmpty())
            return null;
        Node temp = top;
        top = top.next;
        return temp.data;
    }
    public object Peek()
    {
        if (IsEmpty())
            return null;
        return top.data;
    }
    public bool IsExist(object data)
    {
        MyStack tempstack = new MyStack();
        while (!IsEmpty())
        {
            object tempdata = Pop();
            tempstack.Push(tempdata);
            if (tempdata.Equals(data))
            {
                while (!tempstack.IsEmpty())
                    Push(tempstack.Pop());
                return true;
            }
        }
        while (!tempstack.IsEmpty())
            Push(tempstack.Pop());
        return false;
    }
    public void Swap(object a, object b)
    {
        if (IsExist(a) && IsExist(b))
        {
            MyStack tempstack = new MyStack();
            bool foundA = false, foundB = false;
            while (!IsEmpty())
            {
                object temp = Pop();
                if (temp.Equals(a))
                    foundA = true;
                if (temp.Equals(b))
                    foundB = true;
                tempstack.Push(temp);
                if (foundA && foundB)
                    break;
            }
            while (!tempstack.IsEmpty())
            {
                object tempdata = tempstack.Pop();
                if (tempdata.Equals(a))
                    Push(b);
                else if (tempdata.Equals(b))
                    Push(a);
                else
                    Push(tempdata);
            }
        }
        else
            return;
    }
}
public class Node2
{
    public Node2 prev, next;
    public object data;
}
public class MyQueue
{
    Node2 rear, front; 
    public bool IsEmpty()
    {
        return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
        Node2 n = new Node2();
        n.data = ele;
        if (rear == null)
        {
            rear = n; front = n;
        }
        else
        {
            rear.prev = n;
            n.next = rear; rear = n;
        }
    }
    public Node2 Dequeue()
    {
        if (front == null) return null;
        Node2 d = front;
        front = front.prev;
        if (front == null)
            rear = null;
        else
            front.next = null;
        return d;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        MyStack stack = new MyStack();
        stack.Push(10);
        stack.Push(20);//
        stack.Push(30);
        stack.Push(90);//
        stack.Push(70);
        */

        //Console.WriteLine(stack.IsEmpty());

        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Pop());

        //Console.WriteLine(stack.IsEmpty());
        //Console.WriteLine(stack.IsExist(20));
        //Console.WriteLine(stack.IsExist(90));
        //stack.Swap(20, 90);
        
    }
}