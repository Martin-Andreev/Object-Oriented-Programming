package geometry3d;

import interfaces.AreaMeasurable;
import interfaces.VolumeMeasurable;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import shape.Shape;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable{
	protected List<Vertex3D> vertices;

	public SpaceShape(Vertex3D ... vertices) {
		this.vertices = new ArrayList<Vertex3D>(Arrays.asList(vertices));
	}
}
