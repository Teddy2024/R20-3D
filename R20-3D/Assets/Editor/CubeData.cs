using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "newCube", menuName = "Teddy/ScriptableObject")]
public class CubeData : ScriptableObject
{
    [SerializeField] public List<DemoCubeData> DemoCubeDataList = new List<DemoCubeData>();
}

[System.Serializable]
public class DemoCubeData
{
    public string name;

    public Color color;
    public Sprite sprite;
    [TextArea(3,5)]
    public string description;

    public bool canTurn;
    public Vector3 turnAngle;
    public float turnTime;

    public bool canChangeColor;
    public Color[] changeColors;
    public float changeTime;
}