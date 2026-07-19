using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class TilemapStuff : MonoBehaviour
{
    public Tilemap tilemap;
    public Transform highlight;

    public Tile flower;
    public CinemachineImpulseSource impulseSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector3Int cellPosition = tilemap.WorldToCell(mousePos);
        Vector3 pos = tilemap.GetCellCenterWorld(cellPosition);

        //Debug.Log(mousePos + "Cell Position" + cellPosition);
        highlight.position = cellPosition;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log(tilemap.GetTile(cellPosition));
            tilemap.SetTile(cellPosition, flower);
        }
    }
}
