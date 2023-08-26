using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspectPage : MonoBehaviour
{
    [SerializeField] private Page currentPage;
    [SerializeField] private Page hiddenPage;

    [SerializeField] private Button changePagesButton;

    private Animator animator;

    private void Start()
    {
        changePagesButton.onClick.AddListener(ChangePagesClick);
        animator = GetComponent<Animator>();
    }


    private void ChangePagesClick()
    {
        StartCoroutine(ChangePages());
    }

    public IEnumerator ChangePages()
    {
        currentPage.AnimateOut();
        yield return new WaitForSeconds(0.6f);
        hiddenPage.transform.SetSiblingIndex(1);
        currentPage.AnimateIn();

        (currentPage, hiddenPage) = (hiddenPage, currentPage);
    }

    public void AnimateIn()
    {
        animator.SetTrigger("in");
    }

    public void AnimateOut()
    {
        animator.SetTrigger("out");
    }
}