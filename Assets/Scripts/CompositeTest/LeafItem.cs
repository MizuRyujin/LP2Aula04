using UnityEngine;

public class LeafItem : AbstractItem
{
    public override float Weight { get; }

    public LeafItem(float weight)
    {
        Weight = weight;
    }
}
