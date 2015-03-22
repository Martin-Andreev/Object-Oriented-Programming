package geometry3d;

public class Sphere extends SpaceShape {
	private double radius;

	public Sphere(Vertex3D v1, double radius) throws Exception {
		super(v1);
		this.setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) throws Exception {
		if (radius <= 0) {
			throw new Exception("Pyramid width must be positive number!");
		}
		
		this.radius = radius;
	}

	@Override
	public double calculateArea() {
		return 4 * Math.PI * Math.pow(this.radius, 2);
	}

	@Override
	public double calculateVolume() {
		return (4 * Math.PI * Math.pow(this.radius, 3)) / 3;
	}

	@Override
	public String toString() {
		return String.format("Sphere(%s), Radius: %.2f, Area: %.2f, Volume: %.2f",
				this.vertices.get(0), this.radius, this.calculateArea(), this.calculateVolume());
	}
}
