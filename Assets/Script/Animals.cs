using UnityEngine;

public class Animals : MonoBehaviour
{
    public string _name { get; set; }
    public string _info { get; set; }

    protected Animator anim;


    private void Start() => anim = GetComponent<Animator>();

    public virtual void DisplayText() => GameManager.instance.text.text = $"Name : {_name} \n Info : {_info}";
    public virtual void Play_anim() => anim.Play("Spin");


    public void _null() => GameManager.instance.text.text = "Name : \n Info : ";
}
