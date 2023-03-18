using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private float moveSpeed = 6f;
    private bool hasWeapon;
    private bool isWalking;

    [SerializeField] private GameInputManager gameInputManager;
    // Update is called once per frame
    void Update() {
        HandleMovement();
    }

    private void HandleMovement() {
        Vector2 inputVector = gameInputManager.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, inputVector.y);

        float moveDistance = moveSpeed * Time.deltaTime; 
        
        transform.position += moveDir * moveDistance;
        
        isWalking = moveDir != Vector3.zero;

        float rotateSpeed = 20f;
        transform.Rotate(0f, 0f, 
            rotateSpeed * Time.deltaTime );

    }

    public bool HasWeapon() {
        return hasWeapon; 
    }

    public bool IsWalking() {
        return isWalking; 
    }
}
