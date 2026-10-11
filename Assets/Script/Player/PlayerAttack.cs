using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] Animator _anim;
    int _crickcount = 0;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }


    private void OnMouseDown()
    {
        Debug.Log("ƒNƒŠƒbƒN‚³‚ê‚½");
        _crickcount ++;
        if(_crickcount >= 2)
        {
            _anim.Play("PlayerAttackAnimation");
            _crickcount = 0;
        }
    }
}
