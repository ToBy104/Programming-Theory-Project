
public class Herring : Animals
{
    public override void DisplayText()
    {
        _name = "Herring";
        _info = "Herring are forage fish, mostly belonging to the family of Clupeidae.";
        base.DisplayText();
    }

    public override void Play_anim() => anim.Play("Swim");
}
