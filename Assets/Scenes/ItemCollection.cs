using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{
	public class Item
    {

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.gameObject.CompareTag("Item"))
			{
				Destroy(collision.gameObject);


			}

		}

	}

	public class Character
    {
		private bool isDead; 

		public void Die()
        {
			isDead = false;
        }
    }
}
