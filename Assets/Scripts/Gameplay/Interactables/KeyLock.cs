using UnityEngine;

public class KeyLock : MonoBehaviour
{
    [SerializeField] private string requiredKey = "GoldenKey";
    [SerializeField] private GameObject doorToOpen;

    private void OnTriggerEnter(Collider collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();
        if (player != null && player.HasKey(requiredKey))
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        doorToOpen.SetActive(false);
        Debug.Log("Door unlocked!");
    }
}
