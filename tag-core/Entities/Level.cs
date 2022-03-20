using tag_core.Utility;

namespace tag_core.Entities;

internal class Level
{
    internal string Name = "";
    internal List<string> Music = new();

    internal int SpawnIndex = 0;
    internal List<(Pos Position, Pos LookAt)> CheckPoints = new() { (new(0, 0, 0), new(0, 0, 0)) };

    internal Pos[] Lights = new Pos[5] { new Pos(0, 0, 0), new Pos(0, 0, 0), new Pos(0, 0, 0), new Pos(0, 0, 0), new Pos(0, 0, 0) };

    internal Pos DeathSpherePos = new(0, 0, 0);
    internal double DeathSphereRadius = 1000;

    internal string LightTagString()
    {
        if (Lights.Length > 5) throw new Exception("Level can't have more than 5 lights");
        if (Lights.Length < 1) throw new Exception("Level can't have less than 1 light");

        string lightOut = "";

        for (int i = 0; i < Lights.Length; i++)
        {
            lightOut += $@"<Light><Index value=""{i}"" />{Lights[i].TagString()}</Light>";
        }

        return lightOut;
    }

    internal string CheckpointTagString()
    {
        if (CheckPoints.Count < 1) return "";

        string checkpoints = "";

        for (int i = 0; i < CheckPoints.Count; i++)
        {
            checkpoints += $@"<CheckPoint>{(i == SpawnIndex ? "<First />" : "")}{CheckPoints[i].Position.TagString()}{CheckPoints[i].LookAt.TagString("LookAt")}</CheckPoint>";
        }

        return checkpoints;
    }

    internal string DeathSphereTagString()
    {
        return $@"<DeathSphere>{DeathSpherePos.TagString("Center")}<Radius value=""{DeathSphereRadius}"" /></DeathSphere>";
    }

    internal string MusicTagString()
    {
        if (Music.Count < 1) return "";

        string music = "<Music>";

        for (int i = 0; i < Music.Count; i++)
        {
            music += $@"<Song>{Music[i]}</Song>";
        }

        music += "</Music>";

        return music;
    }
}
