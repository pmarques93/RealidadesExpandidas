using UnityEngine;

/// <summary>
/// Class used by marionette parent.
/// </summary>
public class MarionetteParent : MonoBehaviour
{
    // Limb disable
    private FixedJoint[] joints;
    private MarionetteControl[] marionetteControls;
    private bool collided;

    private void Awake()
    {
        joints = GetComponentsInChildren<FixedJoint>();
        marionetteControls = GetComponentsInChildren<MarionetteControl>();
    }

    public void WallCollide()
    {
        if (collided == false)
        {
            foreach (MarionetteControl marionetteControl in marionetteControls)
            {
                marionetteControl.gameObject.SetActive(false);
            }

            foreach (FixedJoint joint in joints)
            {
                joint.connectedBody = null;
            }

            collided = true;
        }
    }
}