using TMPro;
using UnityEngine;

namespace ComboTest2 { 
    public class ComboDisplay : MonoBehaviour, IComboDisplay
    {
        [SerializeField] TextMeshProUGUI _label;

        public void Show(int combonum, ComboRank comborank)
        {
            _label.text = $"{combonum.ToString()} HITS! {comborank.ToString()}";
        }

        public void ShowComboEnd(int combonum, ComboRank comborank)
        {
            _label.text = $"FINISH! {combonum.ToString()}HITS 0 {comborank.ToString()}!";
        }
    }
}