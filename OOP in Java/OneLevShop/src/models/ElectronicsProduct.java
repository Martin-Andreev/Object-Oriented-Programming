package models;

import enumerations.AgeRestriction;

public abstract class ElectronicsProduct extends Product{
	private int guaranteePeriod;
	
	public ElectronicsProduct(String name, double price, int quantity, 
			AgeRestriction ageRestriction, int guaranteePeriod) throws Exception {
		super(name, price, quantity, ageRestriction);
		this.setGuaranteePeriod(guaranteePeriod);
	}

	public int getGuaranteePeriod() {
		return guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) throws Exception {
		if (guaranteePeriod < 0) {
			throw new Exception("Guarantee period cannot be negative number!");
		}
		
		this.guaranteePeriod = guaranteePeriod;
	}
}
