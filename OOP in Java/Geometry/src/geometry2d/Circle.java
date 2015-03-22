package geometry2d;

public class Circle extends PlaneShape {
	private double radius;

	public Circle(Vertex2D center, double radius) throws Exception {
		super(center);
		this.setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) throws Exception {
		if (radius <= 0) {
			throw new Exception("Circle radius must be positive number!");
		}
		
		this.radius = radius;
	}

	public double calculatePerimeter() {
		return 2 * Math.PI * this.radius;
	}

	@Override
	public double calculateArea() {
		return Math.PI * Math.pow(this.radius, 2);
	}
	
	@Override
	public String toString() {
		return String.format("Circle(Center: %s), Radius: %.2f, Perimeter: %.2f, Area: %.2f",
				this.vertices.get(0), this.radius, this.calculatePerimeter(), this.calculateArea());
	}	
}
