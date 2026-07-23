using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    [SerializeField] private string keyType = "GoldenKey";
    private bool pickedUp = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (pickedUp) return;

        PlayerController player = collision.GetComponent<PlayerController>();
        if (player != null)
        {
            pickedUp = true;
            player.AddKey(keyType);
            gameObject.SetActive(false);
            Debug.Log($"Key picked up: {keyType}");
        }
    }
}
