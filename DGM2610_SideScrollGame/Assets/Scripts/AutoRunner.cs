using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//References: CatLikeCoding, with own generic modification.
//5 minutes of work/troubleshooting
public class AutoRunner : MonoBehaviour
{
    public FloatData HorizontalSpeed;
    
    public void Update()
    {
        transform.Translate(HorizontalSpeed.value * Time.deltaTime, 0F, 0F);
    }
}
