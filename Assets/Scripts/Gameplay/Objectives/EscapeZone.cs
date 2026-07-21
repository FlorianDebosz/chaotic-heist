using UnityEngine;
using Unity.Netcode;

public class EscapeZone : NetworkBehaviour
{
    private bool objectivePickedUp = false;
    
    private void OnTriggerEnter(Collider collision)
    {
        if (!objectivePickedUp) return;

        if (collision.GetComponent<PlayerController>() != null)
        {
            GameComplete();
        }
    }

    public void SetObjectivePickedUp(bool value)
    {
        objectivePickedUp = value;
    }

    private void GameComplete()
    {
        Debug.Log("Mission complete!");
    }
}
