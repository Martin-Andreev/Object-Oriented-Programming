package models;

import enumerations.AgeRestriction;
import interfaces.Buyable;

public abstract class Product implements Buyable{
	private String name;
	private double price;
	private int quantity;
	private AgeRestriction ageRestriction;
	
	public Product(String name, double price, int quantity, AgeRestriction ageRestriction) 
			throws Exception {
		this.setName(name);
		this.setPrice(price);
		this.setQuantity(quantity);
		this.ageRestriction = ageRestriction;
	}
	
	public String getName() {
		return name;
	}
	
	public void setName(String name) throws Exception {
		if(name == null && name.isEmpty()){
			throw new Exception("Name cannot be null or empty!");			
		}
		
		this.name = name;
	}
	
	public double getPrice() {
		return price;
	}
	
	public void setPrice(double price) throws Exception {
		if (price < 0) {
			throw new Exception("Price cannot be negative number!");
		}
		
		this.price = price;
	}
	
	public int getQuantity() {
		return quantity;
	}
	
	public void setQuantity(int quantity) throws Exception {
		if (quantity < 0) {
			throw new Exception("Quantity cannot be negative number!");
		}
		
		this.quantity = quantity;
	}
	
	public AgeRestriction getAgeRestriction() {
		return ageRestriction;
	}
	
	
	
	
}
