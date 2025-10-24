using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float jumpSize = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Vector2 currentBirdPosition = birdRigidBody.linearVelocity;
            currentBirdPosition.y = jumpSize;
            birdRigidBody.linearVelocity = currentBirdPosition;
        }
    }
}
