using System.Collections;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

//References: Tools provided in lesson.
//15 minutes of work/troubleshooting.
public class MoveAutomatic : MonoBehaviour
{
    private CharacterController _cc;
    private Vector3 _pos;

    public bool CanRun {get; set;}
    private WaitForFixedUpdate _fixed;

    public FloatData MoveSpeed, Gravity;
    
    
    public void Start()
    {
        _cc = GetComponent<CharacterController>();
    }

    private IEnumerator RunCoroutine()
    {
        _fixed = new WaitForFixedUpdate();
        yield return _fixed;
        
        while (CanRun)
        {
            yield return _fixed;
            
            _pos.x = MoveSpeed.value * Time.deltaTime;
            _pos.y = Gravity.value * Time.deltaTime;
            _cc.Move(_pos);
        }
    }
    
    public void BeginMoving()
    {
        CanRun = true;
        StartCoroutine(RunCoroutine());
    }

    public void StopMoving()
    {
        CanRun = false;
        StopCoroutine(RunCoroutine());
    }
    
}