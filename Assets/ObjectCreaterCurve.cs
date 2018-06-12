using UnityEngine;

public class ObjectCreaterCurve : MonoBehaviour {

    [SerializeField]
    private GameObject createObject; // 生成するオブジェクト

    [SerializeField]
    private int itemCount = 20; // 生成するオブジェクトの数

    [SerializeField]
    private float length = 20f; // アイテムの広がる距離

    [SerializeField]
    private float expantion = 2f; // 高さ変動の拡大値

    [SerializeField]
    private float repeat = 2f; // 何周期するか


    // Use this for initialization
    void Start () {

        var unit = length / itemCount; // オブジェクトの配置間隔
        var oneCycle = 2.0f * Mathf.PI; // sin の周期は 2π

        for (var i = 0; i < itemCount; ++i)
        {

            var ratio = (float)i / itemCount; // 周期の位置 (1.0 = 100% の時 2π となる)

            var x = i * unit;
            var y = Mathf.Sin(ratio * oneCycle * repeat) * expantion;

            var position = new Vector3(x, y);

            Instantiate(
                createObject, 
                position, 
                Quaternion.identity, 
                transform
            );

        }

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
