using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float max_speed;
    private Vector2 direction;
    public float currentSpeed = 0;
    public float acceleration;
    public float deceleration;
    public string lastPressed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
        move();
        attack();
    }
    private void move(){
        if(currentSpeed > max_speed){
            currentSpeed = max_speed;
        }
        if (currentSpeed < 0){
            currentSpeed = 0;
        }
        if(lastPressed == "W"){
            direction += Vector2.up;
        }
        if(lastPressed == "S"){
            direction += Vector2.down;
        }
        if(lastPressed == "A"){
            direction += Vector2.left;
        }
        if(lastPressed == "D"){
            direction += Vector2.right;
        }
        transform.Translate(direction.x * currentSpeed * Time.deltaTime, direction.y * currentSpeed * Time.deltaTime, 0);
    }

    private void getInput(){
        direction = Vector2.zero;
        if(Input.GetKey(KeyCode.W)){
            direction += Vector2.up;
            currentSpeed += acceleration * Time.deltaTime;
            lastPressed = "W";
        }
        if(Input.GetKey(KeyCode.S)){
            direction += Vector2.down;
            currentSpeed += acceleration * Time.deltaTime;
            lastPressed = "S";
        }
        if(Input.GetKey(KeyCode.A)){
            direction += Vector2.left;
            currentSpeed += acceleration * Time.deltaTime;
            transform.localScale = new Vector3(-1,1,1);
            lastPressed = "A";
        }
        if(Input.GetKey(KeyCode.D)){
            direction += Vector2.right;
            currentSpeed += acceleration * Time.deltaTime;
            transform.localScale = new Vector3(1,1,1);
            lastPressed = "D";
        }
        //check if no movement key is pressed
        if(!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && currentSpeed > 0){
            currentSpeed -= deceleration * Time.deltaTime;
        }

        //check if arrow keys are pressed
        if(Input.GetKey(KeyCode.UpArrow)){
            
        }
        if(Input.GetKey(KeyCode.DownArrow)){
        
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
        
        }
        if(Input.GetKey(KeyCode.RightArrow)){
        
        }
    }


}

