using System.Collections.Generic;
using UnityEngine;

public class Doodle : MonoBehaviour
{
    // public List<Tag> tags = new List<Tag>();
    [SerializeField] private GameLogic gameLogic;
    
    public string note;
    public bool isEvidence = false;

    [SerializeField] private DoodlesManager doodlesManager;

    public void Start()
    {
        doodlesManager = GameObject.FindGameObjectWithTag("DoodleManager").GetComponent<DoodlesManager>();
        gameLogic = GameObject.FindWithTag("Game").GetComponent<GameLogic>();
    }

    public void HighlightObject()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        Debug.Log("Pointer entered the doodle!");
    }

    public void DehighlightObject()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        Debug.Log("Pointer exited the doodle!");
    }

    public void SelectDoodle()
    {
        doodlesManager.ChangeDoodle(this);
    }

    public bool SetEvidence(bool isOn)
    {
        if (!isOn)
        {
            isEvidence = false;
            gameLogic.RemoveEvidence(this);
            return true;
        }

        try
        {
            gameLogic.AddEvidence(this);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
