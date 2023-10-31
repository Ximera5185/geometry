using UnityEngine;

public class ChangesScale : MonoBehaviour
{
    [SerializeField] private float _speedChangesScale = 1;

    private void Update()
    {
        transform.localScale += new Vector3(_speedChangesScale * Time.deltaTime, _speedChangesScale * Time.deltaTime, _speedChangesScale * Time.deltaTime);
    }
}