using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doodle : MonoBehaviour
{
    // public List<Tag> tags = new List<Tag>();
    [SerializeField] private GameLogic gameLogic;
    
    public string note;
    public bool isEvidence = false;

    [SerializeField] private DoodlesManager doodlesManager;
    private Image border;

    public void Start()
    {
        border = GetComponentInChildren<Image>();
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

        StartCoroutine(ClickOnDoodleAnimation());
        
    }


    private IEnumerator ClickOnDoodleAnimation()
    {
        border.color = new Color(255, 0, 0, 255);
        yield return new WaitForSeconds(0.1f);
        border.color = new Color(255, 255, 255, 255);
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
