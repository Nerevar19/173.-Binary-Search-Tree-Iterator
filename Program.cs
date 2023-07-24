using System.Xml.Linq;

namespace _173._Binary_Search_Tree_Iterator
{
    internal class Program
    {
        
  public class TreeNode
        {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
 
      public class BSTIterator
        {
            private int i;
            private List<int> list;
            public BSTIterator(TreeNode root)
            {
                
                list = new List<int>();
                list.Add(root.val - 1);
                LNRToList(root, list);
                i = 0;
            }

            public int Next()
            {

                return list[++i];
                
            }

            public bool HasNext()
            {
                return i + 1 < list.Count;
                
            }

            private void LNRToList(TreeNode node, List<int> list)
            {
                if (node == null)
                {
                    return;

                }
                LNRToList(node.left, list);
                list.Add(node.val);
                LNRToList(node.right, list);
                


                return;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}