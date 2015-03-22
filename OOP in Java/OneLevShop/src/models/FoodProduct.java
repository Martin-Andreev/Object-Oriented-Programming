package models;

import java.util.Date;
import java.util.concurrent.TimeUnit;

import enumerations.AgeRestriction;
import interfaces.Expirable;

public class FoodProduct extends Product implements Expirable {
	private Date expirationDate;
	
	public FoodProduct(String name, double price, int quantity, AgeRestriction ageRestriction, 
			Date expirationDate)
			throws Exception {
		super(name, price, quantity, ageRestriction);
		this.setExpirationDate(expirationDate);
	}

	@Override
	public Date getExpirationDate() {
		return this.expirationDate;
	}
	
	public void setExpirationDate(Date expirationDate) {
		this.expirationDate = expirationDate;
	}

	public double getPrice(){
		Date now = new Date();
		long daysToExpirationDate = daysBetweentDates(this.getExpirationDate(), now);
		if (daysToExpirationDate < 15) {
			return this.getPrice() * 0.7;
		}
		
		return super.getPrice();
	}

	public long daysBetweentDates(Date startDate, Date endDate){
		long diff = startDate.getTime() - endDate.getTime();
		long days = TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
		return days;
	}
}
