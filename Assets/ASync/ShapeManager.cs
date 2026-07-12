using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private Shape[] _shapes;
    [SerializeField] GameObject _finishedText;

    public async void BeginTest()
    {
        _finishedText.SetActive(false);

        var tasks = new Task[_shapes.Length];

        for (int i = 0; i < _shapes.Length; i++)
        {
            //Debug.Log(i);
            tasks[i] = _shapes[i].RateForSeconds(i + 1 * i + 3);
        }

        await Task.WhenAll(tasks);

        _finishedText.SetActive(true);
    }



}
