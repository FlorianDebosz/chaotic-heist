using Unity.Netcode;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Vector3 spawnPosition = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(NetworkManager.Singleton.IsHost)
        {
            SpawnPlayers();
        }
    }

    private void SpawnPlayers()
    {
        foreach (var client in NetworkManager.Singleton.ConnectedClientsList)
        {
            Instantiate(playerPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
