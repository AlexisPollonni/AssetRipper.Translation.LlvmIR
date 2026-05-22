using System.Runtime.CompilerServices;

namespace AssetRipper.Translation.LlvmIR.Runtime;

public static class InstructionHelper
{
	//TODO: move all these and atomics to a dedicated class
	public static bool BooleanAnd(bool left, bool right) => left && right;

	public static bool BooleanOr(bool left, bool right) => left || right;

	public static bool BooleanXor(bool left, bool right) => left ^ right;

	public static unsafe int AtomicCompareExchangeInt32(
		void* location,
		int value,
		int comparand,
		bool* exchanged
	)
	{
		int old = Interlocked.CompareExchange(ref *(int*)location, value, comparand);
		*exchanged = old == comparand;
		return old;
	}

	public static unsafe long AtomicCompareExchangeInt64(
		void* location,
		long value,
		long comparand,
		bool* exchanged
	)
	{
		long old = Interlocked.CompareExchange(ref *(long*)location, value, comparand);
		*exchanged = old == comparand;
		return old;
	}

	public static unsafe nint AtomicCompareExchangeIntPtr(
		void* location,
		nint value,
		nint comparand,
		bool* exchanged
	)
	{
		nint old = Interlocked.CompareExchange(ref *(nint*)location, value, comparand);
		*exchanged = old == comparand;
		return old;
	}

	public static unsafe int AtomicExchangeInt32(void* location, int value)
	{
		return Interlocked.Exchange(ref *(int*)location, value);
	}

	public static unsafe long AtomicExchangeInt64(void* location, long value)
	{
		return Interlocked.Exchange(ref *(long*)location, value);
	}

	public static unsafe nint AtomicExchangeIntPtr(void* location, nint value)
	{
		return Interlocked.Exchange(ref *(nint*)location, value);
	}

	public static unsafe int AtomicAddInt32(void* location, int value)
	{
		return AtomicUpdateInt32(location, value, static (left, right) => unchecked(left + right));
	}

	public static unsafe long AtomicAddInt64(void* location, long value)
	{
		return AtomicUpdateInt64(location, value, static (left, right) => unchecked(left + right));
	}

	public static unsafe nint AtomicAddIntPtr(void* location, nint value)
	{
		return AtomicUpdateIntPtr(location, value, static (left, right) => unchecked(left + right));
	}

	public static unsafe int AtomicSubInt32(void* location, int value)
	{
		return AtomicUpdateInt32(location, value, static (left, right) => unchecked(left - right));
	}

	public static unsafe long AtomicSubInt64(void* location, long value)
	{
		return AtomicUpdateInt64(location, value, static (left, right) => unchecked(left - right));
	}

	public static unsafe nint AtomicSubIntPtr(void* location, nint value)
	{
		return AtomicUpdateIntPtr(location, value, static (left, right) => unchecked(left - right));
	}

	public static unsafe int AtomicAndInt32(void* location, int value)
	{
		return AtomicUpdateInt32(location, value, static (left, right) => left & right);
	}

	public static unsafe long AtomicAndInt64(void* location, long value)
	{
		return AtomicUpdateInt64(location, value, static (left, right) => left & right);
	}

	public static unsafe nint AtomicAndIntPtr(void* location, nint value)
	{
		return AtomicUpdateIntPtr(location, value, static (left, right) => left & right);
	}

	public static unsafe int AtomicOrInt32(void* location, int value)
	{
		return AtomicUpdateInt32(location, value, static (left, right) => left | right);
	}

	public static unsafe long AtomicOrInt64(void* location, long value)
	{
		return AtomicUpdateInt64(location, value, static (left, right) => left | right);
	}

	public static unsafe nint AtomicOrIntPtr(void* location, nint value)
	{
		return AtomicUpdateIntPtr(location, value, static (left, right) => left | right);
	}

	public static unsafe int AtomicXorInt32(void* location, int value)
	{
		return AtomicUpdateInt32(location, value, static (left, right) => left ^ right);
	}

	public static unsafe long AtomicXorInt64(void* location, long value)
	{
		return AtomicUpdateInt64(location, value, static (left, right) => left ^ right);
	}

	public static unsafe nint AtomicXorIntPtr(void* location, nint value)
	{
		return AtomicUpdateIntPtr(location, value, static (left, right) => left ^ right);
	}

	private static unsafe int AtomicUpdateInt32(void* location, int value, Func<int, int, int> updater)
	{
		ref int target = ref *(int*)location;
		while (true)
		{
			int old = Volatile.Read(ref target);
			int updated = updater(old, value);
			int exchanged = Interlocked.CompareExchange(ref target, updated, old);
			if (exchanged == old)
			{
				return old;
			}
		}
	}

	private static unsafe long AtomicUpdateInt64(
		void* location,
		long value,
		Func<long, long, long> updater
	)
	{
		ref long target = ref *(long*)location;
		while (true)
		{
			long old = Volatile.Read(ref target);
			long updated = updater(old, value);
			long exchanged = Interlocked.CompareExchange(ref target, updated, old);
			if (exchanged == old)
			{
				return old;
			}
		}
	}

	private static unsafe nint AtomicUpdateIntPtr(
		void* location,
		nint value,
		Func<nint, nint, nint> updater
	)
	{
		ref nint target = ref *(nint*)location;
		while (true)
		{
			nint old = Volatile.Read(ref target);
			nint updated = updater(old, value);
			nint exchanged = Interlocked.CompareExchange(ref target, updated, old);
			if (exchanged == old)
			{
				return old;
			}
		}
	}

	public static TTo BitCast<TFrom, TTo>(TFrom value)
		where TFrom : struct
		where TTo : struct
	{
		ArgumentOutOfRangeException.ThrowIfLessThan(
			Unsafe.SizeOf<TFrom>(),
			Unsafe.SizeOf<TTo>(),
			nameof(TFrom)
		);
		return Unsafe.As<TFrom, TTo>(ref value);
	}

	public static unsafe void VAStart(void** vaListPtr, ReadOnlySpan<nint> args)
	{
		*vaListPtr = args.ToPointer();
	}

	public static unsafe void** VAArg(void*** vaListPtr)
	{
		// This only works on platforms where va_list is just a pointer.

		// Get the current location.
		void** result = *vaListPtr;

		// Move the pointer to the next location.
		*vaListPtr = result + 1;

		return result;
	}

	public static unsafe void* Select(bool condition, void* trueValue, void* falseValue)
	{
		return condition ? trueValue : falseValue;
	}

	public static T Select<T>(bool condition, T trueValue, T falseValue)
	{
		return condition ? trueValue : falseValue;
	}

	public static TValue Select<TCondition, TValue, TValueElement>(
		TCondition condition,
		TValue trueValue,
		TValue falseValue
	)
		where TCondition : unmanaged, IInlineArray<bool>
		where TValue : unmanaged, IInlineArray<TValueElement>
		where TValueElement : unmanaged
	{
		if (TCondition.Length != TValue.Length)
		{
			throw new ArgumentException(
				$"Condition length ({TCondition.Length}) must match value length ({TValue.Length})."
			);
		}

		ReadOnlySpan<bool> conditionSpan = condition.AsReadOnlySpan<TCondition, bool>();
		ReadOnlySpan<TValueElement> trueValueSpan = trueValue.AsReadOnlySpan<
			TValue,
			TValueElement
		>();
		ReadOnlySpan<TValueElement> falseValueSpan = falseValue.AsReadOnlySpan<
			TValue,
			TValueElement
		>();

		TValue result = default;
		Span<TValueElement> resultSpan = result.AsSpan<TValue, TValueElement>();

		for (int i = 0; i < TCondition.Length; i++)
		{
			resultSpan[i] = conditionSpan[i] ? trueValueSpan[i] : falseValueSpan[i];
		}

		return result;
	}

	public static TElement ExtractElement<TBuffer, TElement>(this TBuffer buffer, int index)
		where TBuffer : struct, IInlineArray<TElement>
	{
		return buffer.AsReadOnlySpan<TBuffer, TElement>()[index];
	}

	public static TBuffer InsertElement<TBuffer, TElement>(
		this TBuffer buffer,
		TElement value,
		int index
	)
		where TBuffer : struct, IInlineArray<TElement>
	{
		buffer.AsSpan<TBuffer, TElement>()[index] = value;
		return buffer;
	}

	public static TResult ShuffleVector<TVector, TIndex, TResult, TElement>(
		TVector vector1,
		TVector vector2,
		TIndex indices
	)
		where TVector : struct, IInlineArray<TElement>
		where TIndex : struct, IInlineArray<int>
		where TResult : struct, IInlineArray<TElement>
		where TElement : unmanaged
	{
		ArgumentOutOfRangeException.ThrowIfNotEqual(TResult.Length, TIndex.Length);

		ReadOnlySpan<TElement> vector1Span = vector1.AsReadOnlySpan<TVector, TElement>();
		ReadOnlySpan<TElement> vector2Span = vector2.AsReadOnlySpan<TVector, TElement>();
		ReadOnlySpan<int> indexSpan = indices.AsReadOnlySpan<TIndex, int>();

		TResult result = default;
		Span<TElement> resultSpan = result.AsSpan<TResult, TElement>();

		for (int i = 0; i < TIndex.Length; i++)
		{
			int index = indexSpan[i];
			ArgumentOutOfRangeException.ThrowIfNegative(index);
			ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, TVector.Length * 2);

			resultSpan[i] =
				index < TVector.Length ? vector1Span[index] : vector2Span[index - TVector.Length];
		}

		return result;
	}
}
