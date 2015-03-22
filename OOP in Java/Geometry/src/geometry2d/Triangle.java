package geometry2d;

public class Triangle extends PlaneShape{
	public Triangle(Vertex2D v1, Vertex2D v2, Vertex2D v3){
		super(v1, v2, v3);
	}
	
	private double getSideC() {
		return Vertex2D.getDistance(this.vertices.get(2), this.vertices.get(0));
	}

	private double getSideB() {
		return Vertex2D.getDistance(this.vertices.get(1), this.vertices.get(2));
	}

	private double getSizeA() {
		return Vertex2D.getDistance(this.vertices.get(0), this.vertices.get(1));
	}
	
	@Override
	public double calculatePerimeter() {
		double sideA = getSizeA();
		double sideB = getSideB();
		double sideC = getSideC();
		double perimeter = sideA + sideB + sideC;
		
		return perimeter;
	}

	@Override
	public double calculateArea() {
		double sideA = getSizeA();
		double sideB = getSideB();
		double sideC = getSideC();
		double semiperimeter = (sideA + sideB + sideC) / 2;
		double area = Math.sqrt(semiperimeter * 
				(semiperimeter - sideA) * (semiperimeter * sideB) * (semiperimeter * sideC));
		return area;
	}
	
	public String toString(){
		return String.format("Triangle(%s, %s, %s), Perimeter: %.2f, Area: %.2f",
				this.vertices.get(0), this.vertices.get(1), this.vertices.get(2),
				this.calculatePerimeter(), this.calculateArea());
	}
}
