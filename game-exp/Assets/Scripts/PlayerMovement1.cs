using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 targetPos;
    public float dashRange;
    public float speed;
    public Vector2 direction;
    public Vector2 directionHistory;
    public float lastHorizontalVector;
    public float lastVerticalVector;
    private Animator animator;
    private enum Facing { UP, DOWN, LEFT, RIGHT };
    private Facing FacingDir = Facing.DOWN;

    private void Start()
    {
        animator = GetComponent<Animator>();
        directionHistory = new Vector2(1, 0f);
    }
    void Update()
    {
        TakeInput();
        Move();

    }
    
    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (direction.x != 0 || direction.y != 0)
        {
            SetAnimatorMovement(directionHistory);
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }
    }

    private void TakeInput()
    {
        direction = Vector2.zero;

        if(Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
            FacingDir = Facing.UP;
        }
        if(Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
            FacingDir = Facing.LEFT;
        }
        if(Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
            FacingDir = Facing.DOWN;
        }
        if(Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
            FacingDir = Facing.RIGHT;
        }
        if (direction != Vector2.zero)
        {
            directionHistory = direction;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 currentPos = transform.position;
            targetPos = Vector2.zero;

            if (FacingDir == Facing.UP)
            {
                targetPos.y = 1;
            }
            else if (FacingDir == Facing.DOWN)
            {
                targetPos.y = -1;
            }
            else if (FacingDir == Facing.RIGHT)
            {
                targetPos.x = 1;
            }
            else if (FacingDir == Facing.LEFT)
            {
                targetPos.x = -1;
            }
            transform.Translate(targetPos * dashRange);
        }

    }

    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetLayerWeight(1, 1);
        animator.SetFloat("xDir", direction.x);
        animator.SetFloat("yDir", direction.y);
    }
}
