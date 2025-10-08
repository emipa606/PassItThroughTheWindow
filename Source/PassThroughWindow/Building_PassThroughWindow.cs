using RimWorld;
using Verse;

namespace PassThroughWindow;

public class Building_PassThroughWindow : Building_Storage
{
    public override void SpawnSetup(Map map, bool respawningAfterLoad)
    {
        base.SpawnSetup(map, respawningAfterLoad);
        Rotation = windowRotationAt(Position, map);
    }

    private static Rot4 windowRotationAt(IntVec3 loc, Map map)
    {
        var horizontalQuality =
            alignQualityAgainst(loc + IntVec3.East, map) + alignQualityAgainst(loc + IntVec3.West, map);
        var verticalQuality = alignQualityAgainst(loc + IntVec3.North, map) +
                              alignQualityAgainst(loc + IntVec3.South, map);

        // Default to North/South if the qualities are equal.
        return horizontalQuality >= verticalQuality ? Rot4.North : Rot4.East;
    }

    private static int alignQualityAgainst(IntVec3 c, Map map)
    {
        if (!c.InBounds(map))
        {
            return 0;
        }

        var thingList = c.GetThingList(map);
        foreach (var thing in thingList)
        {
            // Check if the Thing is a building categorized as a wall.
            if (thing.def.building?.isWall == true)
            {
                return 1; // Strong alignment with walls.
            }
        }

        return 0; // No alignment.
    }
}