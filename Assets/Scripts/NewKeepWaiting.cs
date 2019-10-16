using UnityEngine;

public class NewKeepWaiting : CustomYieldInstruction
{
    public override bool keepWaiting => !Input.anyKey;
}
