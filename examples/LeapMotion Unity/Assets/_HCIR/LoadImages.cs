using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoadImages : MonoBehaviour
{
	private List<Texture2D> imageBuffer;
	public MeshRenderer quadMeshRenderer;
	public Material mat;

	public void Start()
	{
		imageBuffer = new List<Texture2D>();
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			LoadFolderImages();

			mat.mainTexture = imageBuffer[0];
			quadMeshRenderer.material = mat;
		}
	}

	private void LoadFolderImages()
	{
		string pathPrefix = @"file://";
		string pathImageAssets = @"D:\";
		string pathSmall = @"";
		string filename = @"photo";
		string fileSuffix = @".jpg";


		//create filename index suffix "001",...,"027" (could be "999" either)
		for (int i = 0; i < 1; i++)
		{
			string indexSuffix = "";
			float logIdx = Mathf.Log10(i + 1);

			if (logIdx < 1.0)
				indexSuffix += "00";
			else if (logIdx < 2.0)
				indexSuffix += "0";

			indexSuffix += (i + 1);
			string fullFilename = pathPrefix + pathImageAssets + pathSmall + filename + indexSuffix + fileSuffix;

			Debug.Log(fullFilename);

			WWW www = new WWW(fullFilename);
			Texture2D texTmp = new Texture2D(1024, 1024, TextureFormat.DXT1, false);

			//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
			www.LoadImageIntoTexture(texTmp);
			imageBuffer.Add(texTmp);
		}
	}
}
