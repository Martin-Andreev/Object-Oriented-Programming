import java.sql.Date;

import models.Customer;
import models.FoodProduct;
import models.PurchaseManager;
import enumerations.AgeRestriction;

public class OneLevTester {
	public static void main(String[] args) {
		FoodProduct cigars;
		Customer pecata;
		Customer gopeto;
		
		try {
			cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400,
					AgeRestriction.ADULT, new Date(2013, 04, 12));
			pecata = new Customer("Pecata", 19, 30.00);
			gopeto = new Customer("Gopeto", 18, 0.44);
			PurchaseManager.ProcessPurchase(pecata, cigars);
			PurchaseManager.ProcessPurchase(gopeto, cigars);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}