using UnityEngine;

public class Cylinder : Objects
{
	override protected void Rotation()
	{
		transform.Rotate(0, TurnY * 1.5f * Time.deltaTime, 0);
	}
}
