package shape;

import interfaces.PerimeterMeasurable;

import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

import geometry2d.Vertex2D;
import geometry2d.Circle;
import geometry2d.Rectangle;
import geometry2d.Triangle;
import geometry2d.PlaneShape;
import geometry3d.Cuboid;
import geometry3d.SpaceShape;
import geometry3d.Sphere;
import geometry3d.SquarePyramid;
import geometry3d.Vertex3D;

public class GeometryTester {

	public static void main(String[] args) throws Exception {
		Triangle triangle = new Triangle(
				new Vertex2D(3, 2), 
				new Vertex2D(-12, -3), 
				new Vertex2D(3, 5));
		Rectangle rectangle = new Rectangle(new Vertex2D(4, 5.5), 7.2, 3);
		Circle circle = new Circle(new Vertex2D(4, 8.2), 3.25);
		SquarePyramid pyramid = new SquarePyramid(new Vertex3D(2, 1.5, 3.2), 4, 5);
		Sphere sphere = new Sphere(new Vertex3D(1, 2, 3), 3.5);
		Cuboid cuboid = new Cuboid(new Vertex3D(3, 5.1, 2.2), 1.4, 2, 4.5);
		Shape[] shapes = { triangle, rectangle, circle, pyramid, sphere, cuboid };
		
		for (Shape shape : shapes) {
			System.out.println(shape);
		}
		
		List<SpaceShape> spaceShapes = Arrays.asList(shapes).stream()
				.filter(s -> s instanceof SpaceShape)
				.map(s -> (SpaceShape)s)
				.filter(v -> v.calculateVolume() > 40).collect(Collectors.toList());
		
		System.out.println("\nShapes whose volume is over 40.00:");
		for (SpaceShape shape : spaceShapes) {
			System.out.println(shape);
		}
		Comparator<PerimeterMeasurable> comparatorByPerimeter = (
				PerimeterMeasurable s1, PerimeterMeasurable s2) -> {
			double diff = s1.calculatePerimeter() - s2.calculatePerimeter();
			if (diff < 0) {
				return -1;
			}

			if (diff > 0) {
				return 1;
			}

			return 0;
		};

		List<PerimeterMeasurable> SortedShapes = Arrays.asList(shapes).stream()
				.filter(s -> s instanceof PerimeterMeasurable)
				.map(s -> (PerimeterMeasurable) s)
				.sorted(comparatorByPerimeter)
				.collect(Collectors.toList());
		
		System.out.println("\nPlane shapes sorted by perimeter in ascending order");
		for (PerimeterMeasurable shape : SortedShapes) {
			System.out.println(shape);
		}
	}

}
