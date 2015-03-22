package models;

import enumerations.AgeRestriction;

public class Computer extends ElectronicsProduct {
	private static final int GUARANTEE_PERIOD = 24;
	
	public Computer(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod)
			throws Exception {
		super(name, price, quantity, ageRestriction, GUARANTEE_PERIOD);
	}
	
	public double getPrice(){
		if (this.getQuantity() > 1000) {
			return super.getPrice() * 0.95;
		}
		
		return this.getPrice();
	}
}
