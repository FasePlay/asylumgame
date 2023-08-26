using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Suspect : MonoBehaviour
{
    [SerializeField] public string suspectName;

    private string note;

    [SerializeField] private TMP_InputField cardNote;
    [SerializeField] private TMP_InputField notebookNote;

    public void SetNote()
    {
        cardNote.text = note;
    }
    public void ChangeCardNote()
    {
        note = cardNote.text;
        notebookNote.text = cardNote.text;
    }

    public void ChangeNotebookNote()
    {
        note = notebookNote.text;
        cardNote.text = notebookNote.text;
    }
}
