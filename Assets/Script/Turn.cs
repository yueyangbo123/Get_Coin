using UnityEngine;

namespace Script
{
    public class Turn : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            this.transform.Rotate(Vector3.up, Space.Self);
        }
    }
}