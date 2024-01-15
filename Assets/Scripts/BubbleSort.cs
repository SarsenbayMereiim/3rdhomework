using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    public int[] numbers = { 78, 55, 45, 98, 13 };
    
    void Start()
    {
        BubbleSortArray(numbers);
        Debug.Log("Sorted numbers:"+string.Join(",", numbers));
    }

    
    public void BubbleSortArray(int[] nums) 
    {
        for (int i = nums.Length - 2; i>=0; i--)
        {
            for (int j = 0; j <=i; j++) 
            { 
              if (nums[j] == nums[j+1])
                {
                    int temp = nums[j + 1];
                    nums[j+1] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
}
