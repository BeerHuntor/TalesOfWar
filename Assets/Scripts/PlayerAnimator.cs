using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {
    
    private const string IS_WALKING = "isWalking";
    private const string HAS_WEAPON = "hasWeapon";

    [SerializeField] private Player player; 
    
    private Animator playerAnimator;

    private void Start() {
        playerAnimator = GetComponent<Animator>();
    }

    private void Update() {
        playerAnimator.SetBool(HAS_WEAPON, player.HasWeapon());
        playerAnimator.SetBool(IS_WALKING, player.IsWalking());
    }
}
