using UnityEngine;

public class ConsoleDisplay : MonoBehaviour, IDisplay
{
    public void Show(string message) => Debug.Log(message);
}
