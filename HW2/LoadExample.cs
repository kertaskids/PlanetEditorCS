using UnityEngine;
using UnityEditor;
using System.Collections;

public class LoadExample {

	[MenuItem("PlanetEditor/Create Planet")]
	static void loadExample() {

		GameObject sphere = new GameObject ("Planet");
		//sphere.name = "Planet";
		sphere.AddComponent<MeshFilter>();
		sphere.AddComponent<MeshRenderer> ();
		sphere.GetComponent<MeshFilter>().mesh = new Mesh ();
		sphere.AddComponent<Planet> ();
	}
}

//references : 
