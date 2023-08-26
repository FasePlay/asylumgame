using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class DoodlesManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField noteInput;
    [SerializeField] private Toggle isEvidenceCheckbox;

    private Doodle currentDoodle;

    private Animator animator;

    private bool isOnScreen;


    private void Start()
    {
        animator = GetComponent<Animator>();
        isOnScreen = false;
    }

    public void ChangeDoodle(Doodle doodle)
    {
        if (!isOnScreen) AnimateIn();
        currentDoodle = doodle;
        noteInput.text = currentDoodle.note;
        isEvidenceCheckbox.isOn = currentDoodle.isEvidence;
    }

    public void InputNote()
    {
        currentDoodle.note = noteInput.text;
    }

    public void SetEvidence()
    {
        if (!currentDoodle.SetEvidence(isEvidenceCheckbox.isOn)) FailedToSetEvidence();
    }

    private void FailedToSetEvidence()
    {
        Debug.Log("Setting evidence wasn't possible! Probably too much evidences already or something");
        isEvidenceCheckbox.isOn = false;
    }

    public void AnimateOut()
    {
        animator.SetTrigger("out");
        isOnScreen = false;
        currentDoodle = null;
    }

    public void AnimateIn()
    {
        animator.SetTrigger("in");
        isOnScreen = true;
    }

    public bool IsOnScreen()
    {
        return isOnScreen;
    }
}
