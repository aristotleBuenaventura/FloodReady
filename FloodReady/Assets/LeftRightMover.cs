using UnityEngine;

public class LeftRightMover : MonoBehaviour
{
    public GameObject[] objectsToMove;
    public int currentIndex = 0;
    public GameObject incrementButton;
    public GameObject decrementButton;
    AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        MoveObjects(); // Move objects to initial state
        sound = GetComponent<AudioSource>();
    }

    // Method to move objects according to the current index
    void MoveObjects()
    {
        // Disable all objects
        foreach (GameObject obj in objectsToMove)
        {
            obj.SetActive(false);
        }

        // Enable the object at currentIndex
        objectsToMove[currentIndex].SetActive(true);
    }

    // Method to increment the index and move objects to the right
    public void IncrementIndex()
    {
        currentIndex = (currentIndex + 1) % objectsToMove.Length;
        MoveObjects();
        sound.Play();
    }

    // Method to decrement the index and move objects to the left
    public void DecrementIndex()
    {
        currentIndex = (currentIndex - 1 + objectsToMove.Length) % objectsToMove.Length;
        MoveObjects();
        sound.Play();
    }

    
  
}
