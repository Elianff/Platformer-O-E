using UnityEngine;
using Unity.Cinemachine;

public class CameraFollowSwitch : MonoBehaviour
{
    public CinemachineCamera vcam;
    public Transform eury;
    public Transform orph;

    public void FollowEury()
    {
        vcam.Follow = eury.transform;
    }

    public void FollowOrph()
    {
        vcam.Follow = orph.transform;
    }
}