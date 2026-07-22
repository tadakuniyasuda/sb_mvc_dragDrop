using UnityEngine;
using UnityEngine.InputSystem;

namespace ComboTest2 { 
    public class ComboTest2Runner : MonoBehaviour
    {
        ComboModel model;
        ComboDisplay view;
        ComboPresenter presenter;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            model = new ComboModel();
            view = GetComponent<ComboDisplay>();
            presenter = new ComboPresenter(model, view);        }

        // Update is called once per frame
        void Update()
        {
            if(Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                model.RegisterHit();
            }
            if (Keyboard.current.rKey.wasPressedThisFrame)
            {
                model.ComboEnd();
            }
        }

        void OnDestroy()
        {
            presenter?.Dispose();
        }
    }
}