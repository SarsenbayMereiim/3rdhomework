using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Character/CreateData")]
public class ChartData : ScriptableObject
{
    public List<SomeData> SomeDatas = new List<SomeData>();
}

[System.Serializable]

public class SomeData
{
    public int Count;
    public float Scale;
    public string Name;
    [SerializeField]
    private Color objectColor = Color.white;
    public Color ObjectColor
    {
        get { return objectColor; }
    }
    public List<GameObject> Items = new List<GameObject>();
}