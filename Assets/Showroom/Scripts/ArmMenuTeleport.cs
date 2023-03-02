using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ArmMenuTeleport : MonoBehaviour
{
    [Space]
    [SerializeField]
    private TeleportationProvider _teleportationProvider;

  
    public void Teleport(TeleportationAnchor destination)
    {
        Debug.Log("Teleport");
        TeleportRequest tr;
        tr.destinationRotation = destination.teleportAnchorTransform.rotation;
        tr.destinationPosition = destination.teleportAnchorTransform.position;
        tr.requestTime = 10f;
        tr.matchOrientation = destination.matchOrientation;

        _teleportationProvider.QueueTeleportRequest(tr);
    }
   
}
