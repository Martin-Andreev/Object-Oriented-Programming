package geometry2d;

public class Rectangle extends PlaneShape{
	private double width;
	private double height;
	
	public Rectangle(Vertex2D vertex, double width, double height) throws Exception {
		super(vertex);
		this.setWidth(width);
		this.setHeight(height);
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) throws Exception {
		if (width <= 0) {
			throw new Exception("Triangle width must be positive number!");
		}
		
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) throws Exception {
		if (height <= 0) {
			throw new Exception("Triangle width must be positive number!");
		}
		
		this.height = height;
	}

	@Override
	public double calculatePerimeter() {
		return 2 * (this.width + this.height);
	}

	@Override
	public double calculateArea() {
		return this.width * this.height;
	}
	
	@Override
	public String toString() {
		return String.format("Rectangle(%s, Width: %.2f, Height: %.2f, Perimeter: %.2f, Area: %.2f",
				this.vertices.get(0), this.width, this.height, this.calculatePerimeter(), this.calculateArea());
	}
}
