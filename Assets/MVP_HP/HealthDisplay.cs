using UnityEngine;
using HPTest;
using TMPro;
public class HealthDisplay : MonoBehaviour, IHealthDisplay
{
    [SerializeField] TextMeshProUGUI DisplayHP;
    public void Show(string message, bool isDanger)
    {
        DisplayHP.text = message;
        DisplayHP.color = isDanger ? Color.red : Color.white;

    }

    

}
