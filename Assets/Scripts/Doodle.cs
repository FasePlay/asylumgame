using System.Collections.Generic;
using UnityEngine;

public class Doodle : MonoBehaviour
{
    public List<Tag> tags = new List<Tag>();
    
    public string note;
    public bool isEvidence = false;

    [SerializeField] private DoodlesManager doodlesManager;

    public void Start()
    {
        doodlesManager = GameObject.FindGameObjectWithTag("DoodleManager").GetComponent<DoodlesManager>();
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
}
