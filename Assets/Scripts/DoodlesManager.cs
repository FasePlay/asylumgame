using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DoodlesManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField noteInput;
    [SerializeField] private Toggle isEvidenceCheckbox;

    private Doodle _currentDoodle;
    //TODO:
    //tag manager

    public void ChangeDoodle(Doodle doodle)
    {
        // AnimateOutro()
        _currentDoodle = doodle;
        noteInput.text = _currentDoodle.note;
        isEvidenceCheckbox.isOn = _currentDoodle.isEvidence;
        // Change Tags
        // AnimateIntro()
    }

    public void InputNote()
    {
        _currentDoodle.note = noteInput.text;
    }

    public void SetEvidence()
    {
        _currentDoodle.isEvidence = isEvidenceCheckbox.isOn;
    }
}
