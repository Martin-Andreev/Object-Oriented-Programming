package geometry2d;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import interfaces.PerimeterMeasurable;
import interfaces.AreaMeasurable;
import shape.Shape;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable{
	protected List<Vertex2D> vertices;

	public PlaneShape(Vertex2D ... vertices) {
		this.vertices = new ArrayList<Vertex2D>(Arrays.asList(vertices));
	}
}
