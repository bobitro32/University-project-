using System;
using System.Text;

public class Tree

{
    private const int Count = 10;

    public class Node
    {
        public char Value;
        public Node? Left;
        public Node? Right;

        public Node(char value)
        {
            this.Value = value;
        }

    }


    private Node _root;
    public Tree()
    {
        _root = null;
    }

    public bool IsOperator(char c)
    {
        return (c == '&' || c == '|');
    }

    public string InfixToPostfix(string expression)
    {
        string postfix = "";
        MyStack<char> stack = new MyStack<char>();
        foreach (var symbol in expression)
        {
            if (Help.IsLetter(symbol) || symbol == '!')
            {
                postfix += symbol;
            }
            else if (IsOperator(symbol))
            {

                while (stack.Count > 0 && Precedence(stack.Peek()) >= Precedence(symbol))
                {

                    postfix += stack.Pop();
                }
                stack.Push(symbol);
            }
            else if (symbol == '(')
            {
                stack.Push(symbol);
            }
            else if (symbol == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    postfix += stack.Pop();
                }
                if (stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
            }
        }

        while (stack.Count > 0)
        {
            postfix += stack.Pop();
        }
        return postfix;
    }

    public int Precedence(char c)
    {
        switch (c)
        {
            case '&':
                return 2;
            case '|':
                return 1;

            default:
                return 0;
        }
    }



    public void BuildExpressinTree(string infix)
    {
        string postFix = InfixToPostfix(infix);


        MyStack<Node> stack = new MyStack<Node>();
        foreach (char c in postFix)
        {
            if (Help.IsLetter(c))
            {
                if (stack.Count > 0 && stack.Peek().Value == '!')
                {
                    var notNode = new Node(stack.Pop().Value);
                    notNode.Left = new Node(c);
                    stack.Push(notNode);
                    continue;
                }

                var treeNode = new Node(c);
                stack.Push(treeNode);

            }
            else if (c == '!')
            {
                var treeNode = new Node(c);
                stack.Push(treeNode);
            }
            else
            {
                var right = stack.Pop();
                var left = stack.Pop();
                var node = new Node(c) { Left = left, Right = right };
                stack.Push(node);
            }
        }

        _root = stack.Pop();

        // DEFINE func3(a, b, c, d): "a & (b | c) & !d"
    }




    public void Print()
    {
        LogicForPrinting(_root, 0);

    }




    static void LogicForPrinting(Node root, int indent = 0)
    {
        if (root == null) return;
        Console.Write(new string(' ', indent));
        Console.WriteLine(root.Value);
        LogicForPrinting(root.Left, indent + 2);
        LogicForPrinting(root.Right, indent + 2);
    }

}
