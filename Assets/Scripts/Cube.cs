public class Cube : Objects
{
	override protected void Rotation()
	{
		transform.Rotate(0, -turnY, 0);
	}
}
