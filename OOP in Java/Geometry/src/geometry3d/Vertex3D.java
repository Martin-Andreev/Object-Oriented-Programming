package geometry3d;

public class Vertex3D{
	private double x, y, z;
	
	public Vertex3D(double x, double y, double z) {
		super();
		this.setX(x);
		this.setY(y);
		this.setZ(z);
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

	public double getZ() {
		return z;
	}

	public void setZ(double z) {
		this.z = z;
	}
	
	@Override
	public String toString() {
		return String.format("(%.2f, %.2f, %.2f)", this.x, this.y, this.z);
	}
}
