using UnityEngine;
using UnityEngine.UI;

public class Dropper : MonoBehaviour
{

    [SerializeField] float dropTime = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    private void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    void Update()
    {
        DerrubarCaixa();
    }

    void DerrubarCaixa()
    {
        if (Time.time >= dropTime)
        {
            myRigidBody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
;
    }
}
