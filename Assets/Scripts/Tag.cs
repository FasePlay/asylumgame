using System;
using UnityEngine;

[Serializable]
public class Tag
{
    public string name;
    public Color color;

    public Tag(string name, Color color)
    {
        if (name.Length > 30) throw new Exception();

        this.name = name;
        this.color = color;
    }
}
