using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle2 : MonoBehaviour {

	public GameObject plane1;
	public GameObject plane3;
	public GameObject plane5;
	public GameObject plane7;
	public GameObject plane9;
	public GameObject plane11;
	public GameObject plane13;
	public GameObject plane15;
	public GameObject plane17;
	public GameObject plane19;
	public GameObject plane21;





	public Slider slider;

	public void Slider_Changed1(float newValue)
	{
		Vector3 pos = plane1.transform.position;
		pos.x = newValue;
		plane1.transform.position = pos;
	}

	public void Slider_Changed3(float newValue)
	{
		Vector3 pos = plane3.transform.position;
		pos.x = newValue;
		plane3.transform.position = pos;
	}

	public void Slider_Changed5(float newValue)
	{
		Vector3 pos = plane5.transform.position;
		pos.x = newValue;
		plane5.transform.position = pos;
	}

	public void Slider_Changed7(float newValue)
	{
		Vector3 pos = plane7.transform.position;
		pos.x = newValue;
		plane7.transform.position = pos;
	}

	public void Slider_Changed9(float newValue)
	{
		Vector3 pos = plane9.transform.position;
		pos.x = newValue;
		plane9.transform.position = pos;
	}
	public void Slider_Changed11(float newValue)
	{
		Vector3 pos = plane11.transform.position;
		pos.x = newValue;
		plane11.transform.position = pos;
	}

	public void Slider_Changed13(float newValue)
	{
		Vector3 pos = plane13.transform.position;
		pos.x = newValue;
		plane13.transform.position = pos;
	}

	public void Slider_Changed15(float newValue)
	{
		Vector3 pos = plane15.transform.position;
		pos.x = newValue;
		plane15.transform.position = pos;
	}

	public void Slider_Changed17(float newValue)
	{
		Vector3 pos = plane17.transform.position;
		pos.x = newValue;
		plane17.transform.position = pos;
	}

	public void Slider_Changed19(float newValue)
	{
		Vector3 pos = plane19.transform.position;
		pos.x = newValue;
		plane19.transform.position = pos;
	}

	public void Slider_Changed21(float newValue)
	{
		Vector3 pos = plane21.transform.position;
		pos.x = newValue;
		plane21.transform.position = pos;
	}



	public void Toggle_change1(bool newValue)
	{
		plane1.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change3(bool newValue)
	{
		plane3.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change5(bool newValue)
	{
		plane5.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change7(bool newValue)
	{
		plane7.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change9(bool newValue)
	{
		plane9.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change11(bool newValue)
	{
		plane11.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change13(bool newValue)
	{
		plane13.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change15(bool newValue)
	{
		plane15.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change17(bool newValue)
	{
		plane17.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change19(bool newValue)
	{
		plane19.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change21(bool newValue)
	{
		plane21.SetActive (newValue);
		slider.interactable=(newValue);
	}





}
