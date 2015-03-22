package models;

import java.sql.Date;
import java.time.LocalDate;

import interfaces.Expirable;
import enumerations.AgeRestriction;

public abstract class PurchaseManager {
	public static void ProcessPurchase(Customer customer, Product product) throws Exception{
		checkForOutOfStock(product);
		checkForExpirationDate(product);
		checkForCustomerMoneyAmount(customer, product.getPrice());
		checkForCustomerPermission(customer, product.getAgeRestriction());
		double currentBalance = customer.getBalance() - product.getPrice();
		int currentQuantity = product.getQuantity() - 1;
		product.setQuantity(currentQuantity);
		customer.setBalance(currentBalance);
	}

	private static void checkForOutOfStock(Product product) {
		if (product.getQuantity() == 0) {
			throw new RuntimeException("There are not " + product.getName() + " in .");
		}
	}

	private static void checkForExpirationDate(Product product) {
		if (product instanceof Expirable) {
			Expirable expirableProduct = (Expirable)product;
			Date now = Date.valueOf(LocalDate.now());
			if (expirableProduct.getExpirationDate().before(now)) {
				throw new RuntimeException(product.getName() + " is past its date." );
			}
		}
	}

	private static void checkForCustomerMoneyAmount(Customer customer,
			double price) {
		if (customer.getBalance() < price) {
			throw new RuntimeException(customer.getName() + " balance is not enough to buy this product!");
		}
	}

	private static void checkForCustomerPermission(Customer customer,
			AgeRestriction ageRestriction) {
		if (ageRestriction == AgeRestriction.ADULT) {
			if (customer.getAge() < 18) {
				throw new RuntimeException(customer.getName() + " is too young to buy this product!" );
			}
		}
	}
}
