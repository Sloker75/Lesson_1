using UnityEngine;

public class ScriptToFollow : MonoBehaviour
{
    [SerializeField] private Transform objToFollow;
    private Vector3 deltaPos;

    void Start()
    {
        deltaPos = transform.position - objToFollow.position;
    }

    void Update()
    {
        transform.position = objToFollow.position + deltaPos;
    }
}
