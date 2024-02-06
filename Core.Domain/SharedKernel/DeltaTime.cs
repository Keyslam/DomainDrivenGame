using Simcestry.Common.Domain;

namespace Core.Domain.SharedKernel;

public class DeltaTime(float value) : ValueObject<DeltaTime>
{
	private readonly float _value = value;

	public static implicit operator float(DeltaTime deltaTime) => deltaTime._value;

	protected override bool EqualsCore(DeltaTime other) => Math.Abs(other._value - _value) < float.Epsilon;
	protected override int GetHashCodeCore() => _value.GetHashCode();
}