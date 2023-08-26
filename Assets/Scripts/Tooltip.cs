using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    [SerializeField] private TMP_Text tooltipText;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Show(string message)
    {
        tooltipText.text = message;
        animator.SetTrigger("show");
        Debug.Log(message);
    }
}
