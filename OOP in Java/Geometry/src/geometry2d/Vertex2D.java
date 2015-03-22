package geometry2d;

public class Vertex2D {
	private double x, y;
	
	public Vertex2D(double x, double y) {
		this.setX(x);
		this.setY(y);
	}
	
	public double getX() {
		return x;
	}
	
	public void setX(double x) {
		this.x = x;
	}
	public double getY() {
		return y;
	}
	public void setY(double y) {
		this.y = y;
	}
	
	public static double getDistance(Vertex2D v1, Vertex2D v2){
		double deltaX = v1.getX() - v2.getX();
		double deltaY = v1.getY() - v2.getY();
		double distance = Math.sqrt(Math.pow(deltaX, 2) + Math.pow(deltaY, 2));
		
		return distance;
	}
	
	@Override
	public String toString() {
		return String.format("(%.2f, %.2f)", this.x, this.y);
	}
}
