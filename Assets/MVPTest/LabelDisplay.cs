using UnityEngine;
using TMPro;

public class LabelDisplay : MonoBehaviour, IDisplay
{
    [SerializeField] TMPro.TextMeshProUGUI _label;

    public void Show(string message)
    {
        _label.text = message;
    }
}
