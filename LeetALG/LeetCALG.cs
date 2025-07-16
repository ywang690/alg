using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetALG
{
    public class LeetCALG
    {
        public bool APITest()
        {
            bool _result = false;
            Console.WriteLine("happy new year");
            _result = true;
            return _result;
        }


        public int[] TwoSum(int[] nums, int target)
        {
            //int[] nums = new int[] { 2, 7, 11, 15 };
            int sum = 0;
            int[] PassNums = null;
            //bool 
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        PassNums = new int[2] { nums[i], nums[j] };
                    }
                    else
                    {
                        Console.WriteLine("failed");
                    }
                }
            }
            return PassNums;
        }

        //2. Add Two Numbers    Medium
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{

        //}

        //同類型
        //66. Plus One
        //2723.
        //227. Basic Calculator II
        //415.
        //67. Add Binary

        //擴展
        //224. Basic Calculator
        //394.
        //8. String to Integer (atoi)
        //12. Integer to Roman


        #region Tree
        //98. Validate Binary Search Tree
        public bool IsValidBST(TreeNode root)
        {
            bool _result = false;
            return _result;
        }
        //核心相關題目（直接用到類似邏輯）
        //700. Search in a Binary Search Tree   搜尋 BST 中某個值，理解 BST 性質
        //701. Insert into a Binary Search Tree     把一個值插入 BST，要維持 BST 特性
        //450. Delete Node in a BST     刪除 BST 裡的節點，同樣要確保仍是 BST
        //235. Lowest Common Ancestor of a BST      尋找 BST 中兩個節點的最近公共祖先，依賴 BST 的左右分布特性
        //530. Minimum Absolute Difference in BST   在 BST 中找兩個節點最小差值，需要中序遍歷（in-order traversal）

        //二、衍生更難版（需要進一步思考 BST 性質）
        //99. Recover Binary Search Tree    有兩個節點錯置，需要修復回合法的 BST
        //501. Find Mode in Binary Search Tree  找 BST 中出現最多次的元素，需要利用 in-order traversal
        //285. Inorder Successor in BST     找到 BST 中一個節點的中序後繼節點
        //426. Convert Binary Search Tree to Sorted Doubly Linked List      把 BST 轉成排序好的雙向鍊表，本質是中序遍歷
        //333. Largest BST Subtree      在一般二元樹中找到最大的 BST 子樹
        #endregion

    }

    //98. Validate Binary Search Tree
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

}
