using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Letter : MonoBehaviour
{
    
    [SerializeField] private int pages;
    private int currentPage = 1;

    [SerializeField] private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        if (currentPage != pages) animator.SetInteger("page", ++currentPage);
        else StartCoroutine(ExitScene());

    }

    private IEnumerator ExitScene()
    {
        animator.SetTrigger("exit");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);
    }
}
