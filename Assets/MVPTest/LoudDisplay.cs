using UnityEngine;

public class LoudDisplay : MonoBehaviour, IDisplay
{
    public void Show(string Value)
    {
        Debug.Log($"THE VALUE IS :{Value}!!");
    }
}
