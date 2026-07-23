using System;
using UnityEngine;

public class ButtonPuzzle : MonoBehaviour
{
    [SerializeField] private int requiredButtons = 3;
    private int buttonsPressed = 0;
    [SerializeField] private GameObject doorToOpen; 

    public void OnButtonpressed()
    {
        buttonsPressed++;
        Debug.Log($"Buttons pressed: {buttonsPressed}/{requiredButtons}");

        if (buttonsPressed >= requiredButtons)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        doorToOpen.SetActive(false);
        Debug.Log("Door opened!");
    }
}
