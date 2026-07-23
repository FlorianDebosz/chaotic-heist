using UnityEngine;

public class PuzzleButton : MonoBehaviour
{
    [SerializeField] private ButtonPuzzle puzzle;
    private bool pressed = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (!pressed && collision.GetComponent<PlayerController>() != null)
        {
            pressed = true;
            puzzle.OnButtonpressed();
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
