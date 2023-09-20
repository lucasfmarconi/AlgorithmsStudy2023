namespace AlgorithmsStudy2023;

//Linked List
public static class NthElement
{
    public static int ReturnNthValueFromEnd(Node headNode, int n)
    {
        var auxiliarList = new List<int>();

        while (headNode.Child != null)
        {
            var childValue = GetNodeValueWithChild(headNode);
            if (childValue == null)
                return 0;

            auxiliarList.Add(childValue.Value);
            headNode = headNode.Child;
        }
        
        auxiliarList.Add(headNode.Value);
        var nodesValueArray = auxiliarList.ToArray<int>();
        var desiredPosition = nodesValueArray.Length - n;

        if (desiredPosition < 0) 
            return 0;
        
        var nodeValue = nodesValueArray[desiredPosition..][0];
        return nodeValue;
    }

    private static int? GetNodeValueWithChild(Node? node)
    {
        if (node?.Child != null)
            GetNodeValueWithChild(node.Child);

        var nodeValue = node?.Value;
        return nodeValue;
    }
}

//Node def
public class Node
{
    public Node(int value, Node? child)
    {
        Value = value;
        Child = child;
    }

    public int Value { get; }
    public Node? Child { get; }
}
