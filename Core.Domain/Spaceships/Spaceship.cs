using System.Numerics;
using Common.Domain;
using Core.Domain.SharedKernel;

namespace Core.Domain.Spaceships;

public class Spaceship : AggregateRoot<SpaceshipId>
{
	private const float Friction = 0.1f;
	
	private Vector2 _position;
	private Vector2 _velocity;

	private Spaceship(SpaceshipId id, Vector2 position, Vector2 velocity) : base(id)
	{
		_position = position;
		_velocity = velocity;
	}

	public static Spaceship Create(Vector2 position)
	{
		return new Spaceship(
			SpaceshipId.Create(),
			position,
			Vector2.Zero
		);
	}

	public void SimulateStep(DeltaTime deltaTime)
	{
		IntegrateVelocity(deltaTime);
		ApplyFriction(deltaTime);
	}

	private void IntegrateVelocity(DeltaTime deltaTime)
	{
		var deltaVelocity = _velocity * deltaTime;
		_position += deltaVelocity;
	}

	private void ApplyFriction(DeltaTime deltaTime)
	{
		var ratio = 1.0f / (1.0f + (deltaTime * Friction));
		_velocity *= ratio;
	}
}