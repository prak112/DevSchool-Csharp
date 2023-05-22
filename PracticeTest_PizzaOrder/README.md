# Practice Exam - C#

## Task
 - Create an application where a user can order a pizza. 
 - In the application, the user chooses *any* number of toppings for the pizza
 - After choosing the user is asked for confirmation. 
 - User chooses to confirm the order or not, if order confirmed then requests for delivery address.
 - Finally, displays order details, price and delivery address.
 


## Workflow
### 1. User interface

* Ordering User interface has following elements : 
	* Title 
	* Chosen Toppings by user 
	* Topping Options
	* Instruction to add new Topping

* Order confirmation User interface has following elements :
	* Title
	* Order details
	* Price and Address

	
* User interface is updated after each selection

* **User Interface Example for Pizza Order:**

```
			---- Pizza Order ----

Chosen Toppings (updated after each selection)
1. Olive
2. Tuna

Topping Options:
1. Pepperoni
2. Mushroom
3. Cheddar
4. Chicken
5. Olive
6. Meat
7. Tuna  

Enter Topping choice (Enter a number between 1-7 to add Topping) :
1 2

Done Choosing? 
Confirm : Press 'k' | Cancel : Press 'x' | Modify : Press 'm'
```

* **User Interface Example for Pizza Order Confirmation:**
```
			---- Pizza Order Confirmation ----
Order:
Olive & Tuna topped Pizza

Address:
Sesame Street, 27 A 102

Price:
15 € (Pizza + 1-3 Toppings, 15 + 0)

		---- Thank you for your Order! See you soon :) ----
````


### 2. Pricing
* After User entered enough toppings (max limit = Total Toppings), User exits Toppings Menu by entering *"e"*. 
* Toppings chosen by the user are displayed and the price of the pizza is calculated as follows :
	* Pizza base price &emsp;- € 15 
	* 1-3 Toppings &emsp;&emsp;- € 15 + € 0
	* 4 Toppings cost &emsp;- € 15 + € 1 
	* 5 Toppings cost &emsp;- € 15 + € 2, so on.


### 3. Order Confirmation
* User is provided with following choices for confirming the order :
	* User confirms the order by entering &emsp;- *"k"*, or 
	* User cancels the order by entering  &emsp;&ensp;- *"x"*, or 
	* User modifies the order by entering &emsp;- *"m"*
* Above choices have following consequences :
	* If confirms &emsp;- User is asked for delivery address
	* If cancels, &emsp;&ensp;- User exits application
	* If modifies, &emsp;- User is redirected to Order page
* Price and Address are displayed with confirmed order details 


### 4. Classes
* Add classes "Topping" and "Pizza" to the application defined as follows :

```
Class Pizzeria:
	// Class consists of toppings available for User selection
	
	// Properties 
	enum Toppings <- ENUM structure of all available toppings


Class Customer :
	// Class consists of order details

	// Properties 
	List<Topping> Toppings <- LIST of toppings selected by the user
	decimal Price 

	// Methods 
	CalculatePrice() 
		> Calculates the price of a pizza with toppings and returns it as a decimal data type
	ConfirmOrder() 
		> Requests confirmation, 
		> if confirmed displays Order details with goodbye note, else clear user input and revert back to order page
		> If chooses to exit, displays goodbye note
```

## Task Output
* 
