using UnityEngine;

public class SnapPoint : MonoBehaviour
{
    private bool isOccupied = false; // Indicates whether this snap point is currently occupied

    // Getter method to check if the snap point is occupied
    public bool IsOccupied()
    {
        return isOccupied;
    }

    // Method to occupy the snap point
    public void Occupy()
    {
        isOccupied = true;
    }

    // Method to release the snap point
    public void Release()
    {
        isOccupied = false;
    }

    // Optionally, you can add more functionality here as needed
}
