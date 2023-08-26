using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoodlesPageManager : MonoBehaviour
{
    // [SerializeField] List<SuspectPage> suspects = new List<SuspectPage>();
    private SuspectPage currentSuspect;

    [SerializeField] private DoodlesManager doodlesManager;
    [SerializeField] private GameObject hint;

    private void Start()
    {
        currentSuspect = null;
    }

    public void InvokePages(SuspectPage suspect)
    {
        if (suspect == currentSuspect) return;
        if (currentSuspect is not null) currentSuspect.AnimateOut();
        if (doodlesManager.IsOnScreen()) doodlesManager.AnimateOut();
        if (hint is not null) Destroy(hint);
        
        suspect.AnimateIn();
        

        currentSuspect = suspect;
        // Hide current page
        // Animate entrance of a page
    }
}