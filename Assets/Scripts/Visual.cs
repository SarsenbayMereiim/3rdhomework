using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visual : MonoBehaviour
{
    public GameObject objectPrefab; 
    public BubbleSort bubbleSortScript; 
    int maxObjectsToCreate = 5;

    void Start()
    {
        bubbleSortScript.BubbleSortArray(bubbleSortScript.numbers);
        StartCoroutine(VisualizeSortedArray(bubbleSortScript.numbers));
    }

    IEnumerator VisualizeSortedArray(int[] sortedArray)
    {
        for (int i = 0; i < Mathf.Min(sortedArray.Length, maxObjectsToCreate); i++)
        {
            GameObject obj = Instantiate(objectPrefab, new Vector3(i * 2, 0, 0), Quaternion.identity);
            obj.name = sortedArray[i].ToString();

            
            yield return new WaitForSeconds(0.1f);
        }
    }
}
