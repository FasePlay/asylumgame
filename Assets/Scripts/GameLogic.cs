using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private List<Doodle> johnEvidence = new List<Doodle>();
    
    [SerializeField] private List<Doodle> richardEvidence = new List<Doodle>();
    [SerializeField] private List<Doodle> aliceEvidence = new List<Doodle>();
    [SerializeField] private List<Doodle> thomasEvidence = new List<Doodle>();
    [FormerlySerializedAs("checkedEvidence")] [SerializeField] private List<Doodle> collectedEvidence = new List<Doodle>();

    [SerializeField] private Tooltip tooltip;

    [SerializeField] private SuspectsManager suspectsManager;

    [SerializeField] private int ending;
    // TODO: add endings
    // 1: John killer, sufficient evidence
    // 2: Not John, sufficient evidence
    // 3: Insufficient evidence
    // 4: easter egg

    public void AddEvidence(Doodle evidence)
    {
        if (collectedEvidence.Count >= 4) throw new Exception("There are already 5 evidences checked!");
        collectedEvidence.Add(evidence);
    }

    public void RemoveEvidence(Doodle evidence)
    {
        collectedEvidence.Remove(evidence);
    }

    public void Accuse()
    {
        Suspect accused = suspectsManager.currentSuspect;
        if (collectedEvidence.Count == 0)
        {
            tooltip.Show(
                "To accuse someone you have to have at least one evidence! Go through suspects' notes and find some evidence.");
            Debug.Log("To accuse someone you have to have at least one evidence! Go through suspects' notes and find some evidence.");
            return;
        }

        switch (accused.suspectName)
        {
            case "John":
                ending = CompareEvidence(johnEvidence) > 0 ? 1 : 3;
                break;
            
            case "Richard":
            case "Alice":
            case "Thomas":
                ending = CompareEvidence(richardEvidence) > 0 ? 2 : 3;
                break;
            
            default:
                ending = -1;
                break;
        }

        tooltip.Show("The ending is " + ending);
        Debug.Log("The ending is " + ending);
    }


    private int CompareEvidence(List<Doodle> listEvidence)
    {
        int compared = 0;
        foreach (Doodle d in collectedEvidence)
        {
            if (listEvidence.Contains(d)) compared++;
        }

        return compared;
    }

}
