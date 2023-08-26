using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private List<Doodle> evidences = new List<Doodle>();
    [FormerlySerializedAs("checkedEvidence")] [SerializeField] private List<Doodle> collectedEvidence = new List<Doodle>();

    [SerializeField] private Tooltip tooltip;

    [SerializeField] private int ending;
    // TODO: add endings

    public void AddEvidence(Doodle evidence)
    {
        if (collectedEvidence.Count >= 4) throw new Exception("There are already 5 evidences checked!");
        collectedEvidence.Add(evidence);
        
        if (evidences.Contains(evidence)) Debug.Log("Hey, it's in there!");
    }

    public void RemoveEvidence(Doodle evidence)
    {
        collectedEvidence.Remove(evidence);
    }

    public void Accuse()
    {
        if (collectedEvidence.Count == 0)
        {
            tooltip.Show(
                "To accuse someone you have to have at least one evidence! Go through suspects' notes and find some evidence.");
            return;
        }
        
        //TODO: ending
        
    }

}
