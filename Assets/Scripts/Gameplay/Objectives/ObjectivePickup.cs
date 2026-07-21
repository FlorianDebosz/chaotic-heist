using UnityEngine;
using Unity.Netcode;

public class ObjectivePickup : NetworkBehaviour
{
    private bool isPickedUp = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (isPickedUp) return;

        if (collision.GetComponent<PlayerController>() != null)
        {
            PickupObjective();
        }
    }

    private void PickupObjective()
    {
        isPickedUp = true;
        gameObject.SetActive(false);
        Debug.Log("Objective picked up!");

        FindFirstObjectByType<EscapeZone>().SetObjectivePickedUp(true);
    }
}
