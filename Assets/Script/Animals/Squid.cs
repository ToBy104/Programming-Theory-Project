
public class Squid : Animals
{
    public override void DisplayText()
    {
        _name = "Squid";
        _info = "Squid are soft-bodied molluscs whose forms evolved to adopt an active predatory lifestyle.";
        base.DisplayText();
    }

    public override void Play_anim() => anim.Play("Swim");
}
