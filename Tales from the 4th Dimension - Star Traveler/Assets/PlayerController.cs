using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    public Transform initialPos;

    [SerializeField] float leftVariableValue;
    [SerializeField] float rightVariableValue;

    // Abstraction of Encapsulation
    #region Manual values validation

    // Encapsulation
    public float leftVariable
    {
        get { return leftVariableValue; }
        set
        {
            if (value == -3f)
            {
                leftVariable = value;
            }
            else
            {
                Debug.LogError("You cannot assign any other value! Do not change this!");
            }
        }
    }

    public float rightVariable
    {
        get { return rightVariableValue; }
        set
        {
            if (value == 11.65f)
            {
                rightVariable = value;

            } else
            {
                Debug.LogError("You cannot assign any other value! Do not change this!");
            }
        }
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Abstraction

        SideMovement();
    }


    void SideMovement()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Key down!");
            transform.DOKill();

            transform.DORotate(new Vector3(-3, 358.632f, 15), 1f);
            transform.DOMove(new Vector3(leftVariable, -1.5f, 17.6f), 1f);

        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Key Up!");
            transform.DOKill();

            transform.DORotate(new Vector3(-3, 358.632f, 0), 1f);
            transform.DOMove(new Vector3(4.3f, -1.5f, 17.6f), 1f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Key down!");
            transform.DOKill();

            transform.DORotate(new Vector3(-3, 358.632f, -15), 1f);
            transform.DOMove(new Vector3(rightVariable, -1.5f, 17.6f), 1f);

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Key Up!");
            transform.DOKill();

            transform.DORotate(new Vector3(-3, 358.632f, 0), 1f);
            transform.DOMove(new Vector3(4.3f, -1.5f, 17.6f), 1f);
        }
    }

    void PlayerAnim()
    {
        transform.DOMoveY(2f, 3f).OnComplete(PlayerAnimReset);
    }

    void PlayerAnimReset()
    {
        transform.DOMoveY(1.886101f, 3f).OnComplete(PlayerAnim);
    }
}
