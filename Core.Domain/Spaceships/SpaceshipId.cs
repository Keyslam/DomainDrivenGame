using Common.Domain;

namespace Core.Domain.Spaceships;

public class SpaceshipId : EntityId
{
	private SpaceshipId() : base()
	{
	}

	private SpaceshipId(Guid guid) : base(guid)
	{
		
	}

	public static SpaceshipId Create() => new SpaceshipId();
	public static SpaceshipId CreateByGuid(Guid guid) => new SpaceshipId(guid);
}