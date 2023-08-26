
using TMPro;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    private int room;
    [SerializeField] private Animator screenAnimator;

    [SerializeField] private GameObject leftArrow;
    [SerializeField] private GameObject rightArrow;
    
    [SerializeField] private TMP_Text leftArrowText;
    [SerializeField] private TMP_Text rightArrowText;
    private void Start()
    {
        screenAnimator = GetComponent<Animator>();

        room = 1;
        screenAnimator.SetInteger("room", room);
    }

    public void MoveScreen(int direction)
    {
        room += direction;
        screenAnimator.SetInteger("room", room);

        if (room == -1)
        {
            leftArrow.SetActive(false);
            leftArrowText.text = "";

            rightArrowText.text = "DOODLES";
        }

        if (room == 0)
        {
            leftArrow.SetActive(true);

            leftArrowText.text = "NOTEBOOK";
            rightArrowText.text = "SUSPECTS";
        }

        if (room == 1)
        {
            rightArrow.SetActive(true);

            leftArrowText.text = "DOODLES";
            rightArrowText.text = "CRIME INFO";
        }

        if (room == 2)
        {
            rightArrow.SetActive(false);
            rightArrowText.text = "";
            
            leftArrowText.text = "SUSPECTS";
        }
        
        
    }
}
