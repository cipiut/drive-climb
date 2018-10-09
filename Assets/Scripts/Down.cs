using UnityEngine.EventSystems;
using UnityEngine;

public class Down : MonoBehaviour,IPointerUpHandler,IPointerDownHandler{
    public virtual void OnPointerDown(PointerEventData ped){
        CarController.input=-1;
    }
    public virtual void OnPointerUp(PointerEventData ped){
        CarController.input=0;
    }
}
