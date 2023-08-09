using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(MeshFilter))]
public class RoofTriangle : MonoBehaviour
{
    /*Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }*/

    void start()
    {
        //MakeMeshData();
        //CreateMesh();
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        Mesh mesh = GetComponent<MeshFilter>().mesh;

        mesh.Clear();

        // make changes to the Mesh by creating arrays which contain the new values
        mesh.vertices = new Vector3[] {new Vector3(0, 0, 0), new Vector3(0, 1, 0), new Vector3(1, 1, 0)};
        mesh.uv = new Vector2[] {new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 1)};
        mesh.triangles =  new int[] {0, 1, 2};
    }

    /*void MakeMeshData()
    {
        vertices = new Vector3[]{new Vector3(0, 0, 0), new Vector3(0, 0, 1), new Vector3(1, 0, 0)};
        triangles = new int[]{0, 1, 2};
    }

    void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }*/
}
