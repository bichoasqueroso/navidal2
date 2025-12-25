using UnityEngine;
using UnityEngine.EventSystems;

public class CajaInteractiva : MonoBehaviour, IPointerClickHandler
{
    private Animator animator;
    private bool abierta = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (abierta) return;

        abierta = true;
        animator.SetBool("isOpen", true);
    }
}
