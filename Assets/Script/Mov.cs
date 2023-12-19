using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Mov : MonoBehaviour
{
    public float speed;
    public float sprintSpeed;
    public LayerMask whatIsGround;
    public Transform checkGroundPosition;
    public Image StaminaBar;
    public float Stamina, MaxStamina;
    public float RunningStaminaCost;
    public float ChargeStaminaSpeed;
    private bool isGrounded;
    private float radiusCheck = 0.2f;
    
    Animator animator;

    public Rigidbody2D rb2D;
    private float x;
    private SpriteRenderer SpriteRenderer;
    private bool isSprinting = false;
    private Coroutine StaminaCharge;
    private Canvas staminaCanvas;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        staminaCanvas = StaminaBar.GetComponentInParent<Canvas>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(checkGroundPosition.position, radiusCheck, whatIsGround);
        animator.SetFloat("xVelocity", Mathf.Abs(rb2D.velocity.x));
        animator.SetFloat("yVelocity", rb2D.velocity.y);
    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift) && isGrounded && Stamina > 0)
        {
            Debug.Log("Shift Pressed");
            isSprinting = true;
            Stamina -= RunningStaminaCost * Time.deltaTime;
            if (Stamina < 0) Stamina = 0;
            StaminaBar.fillAmount = Stamina / MaxStamina;

            if (StaminaCharge != null)
            {
                StopCoroutine(StaminaCharge);
            }

            staminaCanvas.enabled = true;
            StaminaCharge = StartCoroutine(RechargeStamina());
        }
        else
        {
            isSprinting = false;
        }

        float currentSpeed = isSprinting ? sprintSpeed : speed;

        if (isGrounded)
        {
            rb2D.velocity = new Vector2(x * currentSpeed, rb2D.velocity.y);
        }

        if (x > 0)
        {
            SpriteRenderer.flipX = false;
        }
        else if (x < 0)
        {
            SpriteRenderer.flipX = true;
        }

        // Menetapkan parameter animator untuk animasi lari
        animator.SetBool("isSprinting", isSprinting);
    }

    private IEnumerator RechargeStamina()
    {
        yield return new WaitForSeconds(1f);

        while (Stamina < MaxStamina)
        {
            Stamina += ChargeStaminaSpeed / 10f;
            if (Stamina > MaxStamina) Stamina = MaxStamina;
            StaminaBar.fillAmount = Stamina / MaxStamina;
            staminaCanvas.enabled = true;
            yield return new WaitForSeconds(.1f);
        }
    }
}
