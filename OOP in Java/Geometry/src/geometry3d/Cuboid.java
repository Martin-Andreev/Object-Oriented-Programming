package geometry3d;

public class Cuboid extends SpaceShape{
	private double width;
	private double height;
	private double depth;
	
	public Cuboid(Vertex3D v1 , double width, double height, double depth) throws Exception {
		super(v1);
		this.setHeight(height);
		this.setWidth(width);
		this.setDepth(depth);
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) throws Exception {
		if (width <= 0) {
			throw new Exception("Cuboid width must be positive number!");
		}
		
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) throws Exception {
		if (height <= 0) {
			throw new Exception("Cuboid height must be positive number!");
		}
		
		this.height = height;
	}

	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) throws Exception {
		if (depth <= 0) {
			throw new Exception("Cuboid depth must be positive number!");
		}
		
		this.depth = depth;
	}

	@Override
	public double calculateArea() {
		double firstSideArea = this.width * this.height;
		double secondSideArea = this.width * this.depth;
		double thirdSideArea = this.depth * this.height;
		double cuboidArea = 2 * firstSideArea + 2 * secondSideArea + 2 * thirdSideArea;
		return cuboidArea;
	}

	@Override
	public double calculateVolume() {
		return this.depth * this.width * this.height;
	}

	@Override
	public String toString() {
		return String.format("Cuboid(%s), Widht: %.2f, Height: %.2f, Depth: %.2f, Area: %.2f, Volume: %.2f",
				this.vertices.get(0), this.width, this.height, this.depth,
				this.calculateArea(), this.calculateVolume());
	}
	
	
}
