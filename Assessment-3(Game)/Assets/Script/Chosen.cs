using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chosen : MonoBehaviour
{
    public GameObject Panel;

    public void Open()
    {
        if(Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
                if(animator != null)
            {
                bool isChosen = animator.GetBool("Chosen");
                animator.SetBool("Chosen", !isChosen);
            }
        }
    }
}
