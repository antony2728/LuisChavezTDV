using UnityEngine;

public class Manager : MonoBehaviour
{
    [Header("Animation")]
    public Animator prefabAnim;

    [Header("Show Object")]
    public GameObject objectTurn;

    [Header("Change Position")]
    public Transform objectToMove;

    private bool callIn;
    private bool turnOn = true;
    private float minPosition = 0f;
    private float maxPosition = 20f;

    public void CallIn() 
    {
        callIn = !callIn;
        prefabAnim.Play(callIn ? "In" : "Out");
    }

    public void TurnObject() 
    {
        turnOn = !turnOn;
        objectTurn.SetActive(turnOn);
    }

    public void RandomPosition()
    {
        Vector3 newPosition = new Vector3(Random.Range(0, 5.477f), Random.Range(0.607f, 3), Random.Range(1.094f, 3.7f));
        objectToMove.position = newPosition;
    }
}
