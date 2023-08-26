using System.Collections.Generic;
using UnityEngine;

public class SuspectsManager : MonoBehaviour
{
    [SerializeField] private List<Suspect> suspects = new List<Suspect>();
    private Suspect currentSuspect;

    private Animator suspectsManagerAnimator;
    [SerializeField] Animator suspectsAnimator;
    [SerializeField] private Animator infoCardAnimator;

    private void Start()
    {
        suspectsManagerAnimator = GetComponent<Animator>();
    }
    

    public void ShowManager(Suspect currentSuspect)
    {
        Debug.Log("Showing the manager and whatever");
        this.currentSuspect = currentSuspect;
        
        // hiding suspects
        suspectsAnimator.SetBool("isOut", true);
        suspectsAnimator.SetInteger("suspect", suspects.IndexOf(currentSuspect));
        
        //showing the manager
        infoCardAnimator.SetInteger("suspect", suspects.IndexOf(currentSuspect));
        suspectsManagerAnimator.SetBool("showManager", true);
        currentSuspect.SetNote();
    }

    public void HideManager()
    {
        Debug.Log("Hiding the manager!");
        currentSuspect = null;
        
        // hiding manager
        suspectsManagerAnimator.SetBool("showManager", false);
        
        // showing suspects
        suspectsAnimator.SetBool("isOut", false);
        
    }

    public void ChangeNote()
    {
        if (currentSuspect is not null) currentSuspect.ChangeCardNote();
    }
}
