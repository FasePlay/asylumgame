using System.Collections.Generic;
using UnityEngine;

public class DoodlesPageManager : MonoBehaviour
{
    [SerializeField] List<SuspectPage> suspects = new List<SuspectPage>();
    private SuspectPage currentSuspect;

    private void Start()
    {
        // Hide the pages
    }

    public void InvokePages(SuspectPage page)
    {
        // Hide current page
        // Animate entrance of a page
    }
}