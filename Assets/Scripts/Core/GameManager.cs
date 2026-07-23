using Unity.Netcode;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Vector3 spawnPosition = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Vector3 spawnPos = new Vector3(0, 1, 0);
        Instantiate(playerPrefab, spawnPos, Quaternion.identity);
    }
}
