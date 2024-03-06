using UnityEngine;

public class Door : MonoBehaviour
{
    public string requiredKeyType;
    private bool isLocked = true;
    public Animator doorAnimator; // Reference to the door's animator component
    public float closeDelay = 3f; // Time delay before automatically closing the door

    private void Start()
    {
        doorAnimator = GetComponent<Animator>(); // Get the Animator component on start
    }

    public void UnlockDoor(string keyType)
    {
        if (isLocked && keyType == requiredKeyType)
        {
            Debug.Log("Door unlocked with key: " + keyType);
            isLocked = false;
            doorAnimator.SetBool("IsOpen", true); // Set the "IsOpen" parameter to true to play the door opening animation
            Invoke("CloseDoor", closeDelay); // Automatically call CloseDoor() after closeDelay seconds
        }
        else
        {
            Debug.Log("Wrong key or door already unlocked.");
        }
    }

    private void CloseDoor()
    {
        if (!isLocked)
        {
            doorAnimator.SetBool("IsOpen", false); // Set the "IsOpen" parameter to false to play the door closing animation
            isLocked = true;
        }
    }
}
