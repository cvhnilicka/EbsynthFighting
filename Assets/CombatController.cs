using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CombatController : MonoBehaviour
{
    Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        JabControl();
        HeavyControl();
    }

    void JabControl()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            Debug.Log("Jab");
            myAnimator.SetTrigger("Jab");
        }
    }

    void HeavyControl()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire2"))
        {
            myAnimator.SetTrigger("Heavy");
        }
    }
}
