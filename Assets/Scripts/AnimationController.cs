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
            _animator.SetBool("goFront", true);
            init(_Controller.returnAnim());
            return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.back)
        {
            _animator.SetBool("goBack", true);
            init(_Controller.returnAnim());
            return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.left)
        {
            _animator.SetBool("goLeft", true);
            init(_Controller.returnAnim());
            return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.right)
        {
            _animator.SetBool("goRight", true);
            init(_Controller.returnAnim());
            return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.DiagLeftBack)
        {
            _animator.SetBool("goDiagLeftBack", true);
            init(_Controller.returnAnim());
            return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.DiagLeftFront)
        {
            _animator.SetBool("goDiagLeftFront", true);
            init(_Controller.returnAnim());
            return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.DiagRightFront)
        {
            _animator.SetBool("goDiagRightFront", true);
            init(_Controller.returnAnim());
            return;
        }
        if (_Controller.returnAnim() == (int)HeroMovement.direction.DiagRightBack)
        {
            _animator.SetBool("goDiagRightBack", true);
            init(_Controller.returnAnim());
            return;
        }
        init(_Controller.returnAnim());
    }
    private void init(int num)
    {
        if (num != (int)HeroMovement.direction.front) { _animator.SetBool("goFront", false); }
        if (num != (int)HeroMovement.direction.back) { _animator.SetBool("goBack", false); }
        if (num != (int)HeroMovement.direction.right) { _animator.SetBool("goRight", false); }
        if (num != (int)HeroMovement.direction.left) { _animator.SetBool("goLeft", false); }
        if (num != (int)HeroMovement.direction.DiagLeftBack) { _animator.SetBool("goDiagLeftBack", false); }
        if (num != (int)HeroMovement.direction.DiagRightBack) { _animator.SetBool("goDiagRightBack", false); }
        if (num != (int)HeroMovement.direction.DiagLeftFront) { _animator.SetBool("goDiagLeftFront", false); }
        if (num != (int)HeroMovement.direction.DiagRightFront) { _animator.SetBool("goDiagRightFront", false); }
        return;
    }
}
