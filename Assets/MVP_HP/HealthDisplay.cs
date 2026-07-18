using TMPro;
using UnityEngine;

namespace HPTest { 

    public class HealthDisplay : MonoBehaviour, IHealthDisplay
    {
        [SerializeField] TextMeshPro DisplayHP;


        public string Show(int health)
        {
             return health.ToString();

        }

        //public void Update()
        //{
        //    DisplayHP.text = Show(int );
        //}
        
    }

}