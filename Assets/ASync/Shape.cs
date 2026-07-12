using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class Shape : MonoBehaviour
{
    //public IEnumerator RateForSeconds(float duration)
    //{
    //    //Debug.Log(this.gameObject.name + "Rotating!");
    //    var end = Time.time + duration;
    //    while (Time.time < end)
    //    {
    //        {
    //            transform.Rotate(new Vector3(1, 1) * Time.deltaTime * 150);
    //            yield return null;
    //        }
    //    }
    //}

    public async Task RateForSeconds(float duration)
    {
        //await Task.Yield(100);
        //Debug.Log(this.gameObject.name + "Rotating!");
        var end = Time.time + duration;
        while (Time.time < end)
        {
            {
                transform.Rotate(new Vector3(1, 1) * Time.deltaTime * 150);
                await Task.Yield();
            }
        }
    }
}