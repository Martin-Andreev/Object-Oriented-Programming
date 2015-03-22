package geometry3d;

public class SquarePyramid extends SpaceShape {
	private double height;
	private double width;
	private double slantHeight;

	public SquarePyramid(Vertex3D center, double width, double height) throws Exception {
		super(center);
		this.setHeight(height);
		this.setWidth(width);
	}
	
	public double getWidth() {
		return width;
	}

	public void setWidth(double width) throws Exception {
		if (width <= 0) {
			throw new Exception("Pyramid width must be positive number!");
		}
		
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) throws Exception {
		if (height <= 0) {
			throw new Exception("Pyramid width must be positive number!");
		}
		
		this.height = height;
	}
	
	public double calculateSlantHeight(){
		return Math.sqrt(Math.pow(this.height, 2) + (1 / 4) * 1);
	}

	@Override
	public double calculateArea() {
		double surface = Math.pow(this.getWidth(), 2) + 2 * this.getWidth()
				* Math.sqrt(Math.pow(this.getWidth(), 2) / 4 + Math.pow(this.getHeight(), 2));
		return surface;
	}

	@Override
	public double calculateVolume() {
		double volume = Math.pow(this.getWidth(), 2) * this.getHeight() / 3;
		return volume;
	}

	@Override
	public String toString() {
		return String.format("SquarePyramid(Center: %s), Width: %.2f, Height: %.2f, Area: %.2f, Volume: %.2f",
				this.vertices.get(0), this.width, this.height, this.calculateArea(), this.calculateVolume());
	}
	
	
}
