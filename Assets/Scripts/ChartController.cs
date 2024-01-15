using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartController : MonoBehaviour
{
    public ChartData ChartData;

    // Update is called once per frame
    void Update()
    {
        if (ChartData.SomeDatas.Count > 0)
        {
            transform.localScale = new Vector3(ChartData.SomeDatas[0].Scale, ChartData.SomeDatas[0].Scale, ChartData.SomeDatas[0].Scale);

            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = ChartData.SomeDatas[0].ObjectColor;
            }
        }
    }
}
