using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyon : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("degisken_anim");
        }
    }
}
