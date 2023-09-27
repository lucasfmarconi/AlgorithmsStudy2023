namespace AlgorithmsStudy2023.Tests;
public class BinarySearchTreeTests
{
    [Fact]
    public void Given_the_valid_binary_search_tree_method_should_return_true()
    {
        var givenTreeDictionary = new Dictionary<int, int[]>
        {
            {0, new []{1,2}},
            {1, new []{3,4}},
            {2, new []{5,6}}
        };

        var tree = CreateTree(givenTreeDictionary, 0);

        //This logic above is to convert any array theory inline data to a Linked List / tree
        var result = BinarySearchTree.IsBinarySearchTree(tree);
        Assert.True(result);
    }

    [Fact]
    public void Given_the_not_valid_binary_search_tree_method_should_return_false()
    {
        var givenTreeDictionary = new Dictionary<int, int[]>
        {
            {3, new []{1,4}},
            {1, new []{0,2}},
            {4, new []{5,6}}
        };

        var tree = CreateTree(givenTreeDictionary, 3);

        //This logic above is to convert any array theory inline data to a Linked List / tree
        var result = BinarySearchTree.IsBinarySearchTree(tree);
        Assert.False(result);
    }

    private static TreeNode CreateTree(Dictionary<int, int[]> mapping, int headValue)
    {
        var head = new TreeNode(headValue, null, null);
        var nodes = new Dictionary<int, TreeNode>();
        nodes[headValue] = head;
        foreach (var map in mapping)
        {
            var value = map.Value;
            var leftChild = new TreeNode(value[0], null, null);
            var rightChild = new TreeNode(value[1], null, null);
            nodes[value[0]] = leftChild;
            nodes[value[1]] = rightChild;
        }

        foreach (var map in mapping)
        {
            nodes[map.Key].Left = nodes[map.Value[0]];
            nodes[map.Key].Right = nodes[map.Value[1]];
        }
        return head;
    }
}
