using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    private int room;
    [SerializeField] private Animator screenAnimator;

    [SerializeField] private GameObject leftArrow;
    [SerializeField] private GameObject rightArrow;

    private void Start()
    {
        screenAnimator = GetComponent<Animator>();

        room = 1;
        rightArrow.SetActive(false);
        screenAnimator.SetInteger("room", room);
    }

    public void MoveScreen(int direction)
    {
        room += direction;
        screenAnimator.SetInteger("room", room);

        if (room == 0)
        {
            leftArrow.SetActive(true);
            rightArrow.SetActive(true);
        }
        if (room == -1) leftArrow.SetActive(false);
        if (room == 1) rightArrow.SetActive(false);
        
        
    }
}
