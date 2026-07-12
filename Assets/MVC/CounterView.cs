using System;
using UnityEngine;
using UnityEngine.UI;

public class CounterView : MonoBehaviour
{
    public Button incrementButton;
    public Text countText;

    public event Action OnButtonClicked;

    void Start()
    {
        incrementButton.onClick.AddListener(() => OnButtonClicked?.Invoke());
    }

    public void UpdateDisplay(int count)
    {
        countText.text = count.ToString();
    }
}
