using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {

    private Animator mAnimator;

	// Use this for initialization
	void Start () {
        mAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        mAnimator.SetFloat("vSpeed", Input.GetAxis("Vertical"));
	}
}
