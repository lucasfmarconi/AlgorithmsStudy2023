namespace AlgorithmsStudy2023;
public class BinarySearchTree
{
    public static bool IsBinarySearchTree(TreeNode headNodeTree)
    {
        if (headNodeTree.Left is null && headNodeTree.Right is null)
            return false;

        return CheckIfIsBinarySearch(headNodeTree.Left, headNodeTree.Value);
    }

    private static bool CheckIfIsBinarySearch(TreeNode headNodeTree, int headNodeValue)
    {
        if (headNodeTree.Left is null && headNodeTree.Right is null)
            return true;

        if (headNodeTree.Left?.Value < headNodeValue || headNodeTree.Right?.Value < headNodeValue)
            return false;

        return CheckIfIsBinarySearch(headNodeTree.Left, headNodeTree.Left.Value) && CheckIfIsBinarySearch(headNodeTree.Right, headNodeTree.Right.Value);
    }
}

public class TreeNode
{
    public int Value { get; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int value, TreeNode left, TreeNode right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

