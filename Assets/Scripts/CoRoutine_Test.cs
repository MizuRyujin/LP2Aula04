using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutine_Test : MonoBehaviour
{
    //Class variables
    private Coroutine coRouSayHello;

    // Start is called before the first frame update
    private void Start()
    {
        coRouSayHello = StartCoroutine(SayHello());
        StartCoroutine(CountTill30());
    }

    // Update is called once per frame
    private void Update()
    {

    }

    private IEnumerator SayHello()
    {
        WaitForSeconds wfs = new WaitForSeconds(4);

        while (true)
        {
            Debug.Log("Hello");
            yield return wfs;
        }
    }

    private IEnumerator CountTill30()
    {
        WaitForSeconds wfs = new WaitForSeconds(1);
        int n = 0;

        do
        {
            Debug.Log(n);
            n++;
            if (n > 30)
            {
                StopCoroutine(coRouSayHello);
            }
            yield return wfs;
        } while (n <= 30);
    }
}
