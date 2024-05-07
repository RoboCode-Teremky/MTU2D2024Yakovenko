using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerInteraction: MonoBehaviour{
    [SerializeField] private int maxHP = 1;
    private int currentHP;
    void Start(){
        currentHP = maxHP;
    }
    public void TakeDamage(int damage){
        currentHP-=damage;
        if(currentHP<=0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}