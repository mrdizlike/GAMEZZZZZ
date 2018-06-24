using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    private HeroMovement _Controller;
    private Animator _animator;

	void Start () {
        _Controller = GetComponentInParent<HeroMovement>();
        _animator = GetComponent<Animator>();  
	}
	
	void Update () {
        if (_Controller.returnAnim() == (int)HeroMovement.direction.front)
        {
            _animator.SetBool("goFront", true); return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.back)
        {
            _animator.SetBool("goBack", true);  return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.left)
        {
            _animator.SetBool("goLeft", true);  return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.right)
        {
            _animator.SetBool("goRight", true); return;
        }
        _animator.SetBool("goFront", false);
        _animator.SetBool("goBack", false);
        _animator.SetBool("goLeft", false);
        _animator.SetBool("goRight", false);
    }
}
