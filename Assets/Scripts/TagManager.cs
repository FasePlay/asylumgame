using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{

    [SerializeField] private int maxTagAmount = 9; 
    private List<Tag> _tagList = new List<Tag>();

    public List<Color> availableColors = new List<Color>()
    {
        Color.black, Color.gray, Color.white, Color.blue, Color.cyan, Color.green, Color.magenta, Color.red,
        Color.yellow
    };
    public List<Color> usedColors = new List<Color>();
}
