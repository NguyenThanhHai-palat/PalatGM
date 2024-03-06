using UnityEngine;

public class Key : MonoBehaviour
{
    public string keyType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            Door door = other.GetComponent<Door>();
            if (door != null)
            {
                door.UnlockDoor(keyType);
                Destroy(gameObject); // Destroy the key after unlocking the door
            }
        }
    }
}
