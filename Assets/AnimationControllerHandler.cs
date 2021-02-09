using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class AnimationControllerHandler : MonoBehaviour
{
    Animator myAnimator;

    [SerializeField] RuntimeAnimatorController boxer;
    [SerializeField] RuntimeAnimatorController knight;
    [SerializeField] RuntimeAnimatorController rockman;
    [SerializeField] RuntimeAnimatorController wizard;


    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ChangeAnimatorController();
    }

    public void ChangeToWizard()
    {
        myAnimator.runtimeAnimatorController = wizard;
    }

    public void ChangeToKnight()
    {
        myAnimator.runtimeAnimatorController = knight;
    }

    public void ChangeToRockman()
    {
        myAnimator.runtimeAnimatorController = rockman;
    }

    public void ChangeToBoxer()
    {
        myAnimator.runtimeAnimatorController = boxer;
    }
}
