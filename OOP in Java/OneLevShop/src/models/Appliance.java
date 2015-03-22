package models;

import enumerations.AgeRestriction;

public class Appliance extends ElectronicsProduct {
private static final int GUARANTEE_PERIOD = 6;
	
	public Appliance(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod)
			throws Exception {
		super(name, price, quantity, ageRestriction, GUARANTEE_PERIOD);
	}
	
	public double getPrice(){
		if (this.getQuantity() < 50) {
			return super.getPrice() * 1.05;
		}
		
		return this.getPrice();
	}
}
