public class Cylinder : Objects
{
	override protected void Rotation()
	{
		transform.Rotate(0, turnY * 2, 0);
	}
}
