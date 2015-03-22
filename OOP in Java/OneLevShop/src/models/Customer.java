package models;

public class Customer {
	private String name;
	private int age;
	private double balance;
	
	public Customer(String name, int age, double balance) throws Exception {
		this.setName(name);
		this.setAge(age);
		this.setBalance(balance);
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
	
	public int getAge() {
		return age;
	}
	
	public void setAge(int age) throws Exception {
		if (age < 0) {
			throw new Exception("Age cannot be negative number!");
		}
		
		this.age = age;
	}
	
	public double getBalance() {
		return balance;
	}
	
	public void setBalance(double balance) throws Exception {
		if (balance < 0) {
			throw new Exception("Age cannot be negative number!");
		}
		
		this.balance = balance;
	}
}
