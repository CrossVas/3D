using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update()
    {
        // X 키를 누르고 있는 동안 큐브를 X축 회전(프레임당 5도씩 회전)
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.Rotate(5, 0, 0);
        } 
        // Y 키를 누르고 있는 동안 큐브를 Y축 회전(프레임당 5도씩 회전)
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.Rotate(0, 5, 0);
        } 
        // Z 키를 누르고 있는 동안 큐브를 Z축 회전(프레임당 5도씩 회전)
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Rotate(0, 0, 5);   
        } 
        // Space 키를 누르면, 큐브의 회전 각도를 초기화(0, 0, 0)
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
