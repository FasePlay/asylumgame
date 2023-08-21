using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> pages;

    public void TurnPage(int page)
    {
        for (int i = 0; i < pages.Count; i++)
        {
            pages[i].SetActive(i + 1 == page);
        }
    }
}
