using UnityEngine;


class Page : MonoBehaviour
{
    [SerializeField] private Animator pageAnimator;

    private void Start()
    {
        pageAnimator = GetComponent<Animator>();
    }

    public void AnimateOut()
    {
        pageAnimator.SetTrigger("out");
    }

    public void AnimateIn()
    {
        pageAnimator.SetTrigger("in");
    }
}
