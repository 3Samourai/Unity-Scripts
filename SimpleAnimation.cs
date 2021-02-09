using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SimpleAnimation : MonoBehaviour
{
[SerializeField] private Sprite[] frameArray; 
private int currentFrame;
private float timer;
public float framerate = .1f;
private SpriteRenderer gameSprite;
void Start(){
    gameSprite = gameObject.GetComponent<SpriteRenderer>();
}
void Update(){
timer += Time.deltaTime;
if (timer >= framerate){
    timer -= framerate;
    currentFrame = (currentFrame + 1) % frameArray.Length;
    gameSprite.sprite = frameArray[currentFrame];
}
}
}
