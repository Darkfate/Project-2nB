using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public Camera m_kCamera;
	public Collider[] m_kTerrain;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Left click
		if (Input.GetMouseButtonDown(0))
		{
			Ray kRay = m_kCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit kRaycastHit;
			RaycastHit kTempRaycastHit;
			int iTerrainHit = 0;
			
			m_kTerrain[0].Raycast(kRay, out kRaycastHit, 9999);
			
			// Iterating for hit closest to camera
			for (int i = 0; i < m_kTerrain.Length; ++i)
			{
				m_kTerrain[i].Raycast(kRay, out kTempRaycastHit, 9999);
				if (kRaycastHit.point.y < kTempRaycastHit.point.y &&
				    kRaycastHit.point.x < kTempRaycastHit.point.x)
				{
					iTerrainHit = i;
					kRaycastHit = kTempRaycastHit;
				}
			}
			
			// If something was hit then move to that position
			if (kRaycastHit.point.y != 0 && kRaycastHit.point.x != 0)
			{
				this.transform.position = m_kTerrain[iTerrainHit].transform.position;
			}
			
		}
	}
}
