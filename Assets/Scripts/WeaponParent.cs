using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponParent : MonoBehaviour
{
    [SerializeField] Animator swordAttackAnimation;
    [SerializeField] float delay = 0.3f;
    private bool attackBlocked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnSlash(InputValue value)
    {
        if (attackBlocked) return;
        swordAttackAnimation.SetTrigger("Attack");
        attackBlocked = true;
        StartCoroutine(DelayAttack());
    }

    private IEnumerator DelayAttack()
    {
        yield return new WaitForSeconds(delay);
        attackBlocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
