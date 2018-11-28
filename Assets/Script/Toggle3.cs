using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Toggle3 : MonoBehaviour {

	public GameObject plane2;
	public GameObject plane4;
	public GameObject plane6;
	public GameObject plane8;
	public GameObject plane10;
	public GameObject plane12;
	public GameObject plane14;
	public GameObject plane16;
	public GameObject plane18;
	public GameObject plane20;
	public GameObject plane22;




	public Slider slider;

	public void Slider_Changed2(float newValue)
	{
		Vector3 pos = plane2.transform.position;
		pos.z = newValue;
		plane2.transform.position = pos;
	}

	public void Slider_Changed4(float newValue)
	{
		Vector3 pos = plane4.transform.position;
		pos.z = newValue;
		plane4.transform.position = pos;
	}

	public void Slider_Changed6(float newValue)
	{
		Vector3 pos = plane6.transform.position;
		pos.z = newValue;
		plane6.transform.position = pos;
	}

	public void Slider_Changed8(float newValue)
	{
		Vector3 pos = plane8.transform.position;
		pos.z = newValue;
		plane8.transform.position = pos;
	}

	public void Slider_Changed10(float newValue)
	{
		Vector3 pos = plane10.transform.position;
		pos.z = newValue;
		plane10.transform.position = pos;
	}
	public void Slider_Changed12(float newValue)
	{
		Vector3 pos = plane12.transform.position;
		pos.z = newValue;
		plane12.transform.position = pos;
	}

	public void Slider_Changed14(float newValue)
	{
		Vector3 pos = plane14.transform.position;
		pos.z = newValue;
		plane14.transform.position = pos;
	}

	public void Slider_Changed16(float newValue)
	{
		Vector3 pos = plane16.transform.position;
		pos.z = newValue;
		plane16.transform.position = pos;
	}

	public void Slider_Changed18(float newValue)
	{
		Vector3 pos = plane18.transform.position;
		pos.z = newValue;
		plane18.transform.position = pos;
	}

	public void Slider_Changed20(float newValue)
	{
		Vector3 pos = plane20.transform.position;
		pos.z = newValue;
		plane20.transform.position = pos;
	}

	public void Slider_Changed22(float newValue)
	{
		Vector3 pos = plane22.transform.position;
		pos.z = newValue;
		plane22.transform.position = pos;
	}



	public void Toggle_change2(bool newValue)
	{
		plane2.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change4(bool newValue)
	{
		plane4.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change6(bool newValue)
	{
		plane6.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change8(bool newValue)
	{
		plane8.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change10(bool newValue)
	{
		plane10.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change12(bool newValue)
	{
		plane12.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change14(bool newValue)
	{
		plane14.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change16(bool newValue)
	{
		plane16.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change18(bool newValue)
	{
		plane18.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change20(bool newValue)
	{
		plane20.SetActive (newValue);
		slider.interactable=(newValue);
	}

	public void Toggle_change22(bool newValue)
	{
		plane22.SetActive (newValue);
		slider.interactable=(newValue);
	}

}
