using System.Numerics;
using System.Numerics.Tensors;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Translation.LlvmIR.Runtime;

public static partial class NumericHelper
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Negate<T>(T x)
		where T : IUnaryNegationOperators<T, T>
	{
		return unchecked(-x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ShiftLeft<T>(T x, T y)
		where T : IShiftOperators<T, int, T>
	{
		return x << ConvertToInt32(y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ShiftRightArithmetic<T>(T x, T y)
		where T : IShiftOperators<T, int, T>
	{
		return x >> ConvertToInt32(y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ShiftRightLogical<T>(T x, T y)
		where T : IShiftOperators<T, int, T>
	{
		return x >>> ConvertToInt32(y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T BitwiseAnd<T>(T x, T y)
		where T : IBitwiseOperators<T, T, T>
	{
		return x & y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T BitwiseOr<T>(T x, T y)
		where T : IBitwiseOperators<T, T, T>
	{
		return x | y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T BitwiseXor<T>(T x, T y)
		where T : IBitwiseOperators<T, T, T>
	{
		return x ^ y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T CtPop<T>(T x)
		where T : unmanaged
	{
		long count = TensorPrimitives.PopCount(MemoryMarshal.AsBytes(new ReadOnlySpan<T>(ref x)));
		return ConvertFromInt32<T>((int)count);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T FShL<T>(T x, T y, T z)
		where T : unmanaged, IShiftOperators<T, int, T>, IBitwiseOperators<T, T, T>
	{
		// https://llvm.org/docs/LangRef.html#llvm-fshl-intrinsic
		// Funnel shift left
		int shiftLeft = ConvertToInt32(z) % (Unsafe.SizeOf<T>() * 8);
		int shiftRight = (Unsafe.SizeOf<T>() * 8) - shiftLeft;
		return (x << shiftLeft) | (y >>> shiftRight);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T FShR<T>(T x, T y, T z)
		where T : unmanaged, IShiftOperators<T, int, T>, IBitwiseOperators<T, T, T>
	{
		// https://llvm.org/docs/LangRef.html#llvm-fshr-intrinsic
		// Funnel shift right
		int shiftRight = ConvertToInt32(z) % (Unsafe.SizeOf<T>() * 8);
		int shiftLeft = (Unsafe.SizeOf<T>() * 8) - shiftRight;
		return (x >>> shiftRight) | (y << shiftLeft);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsOrdered<T>(T x, T y)
		where T : INumberBase<T>
	{
		return !IsUnordered(x, y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnordered<T>(T x, T y)
		where T : INumberBase<T>
	{
		return T.IsNaN(x) || T.IsNaN(y);
	}

	// Generic ordered float comparisons (used for non-native float types like Half)
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool FcmpOeq<T>(T x, T y)
		where T : IEqualityOperators<T, T, bool>, INumberBase<T> => !IsUnordered(x, y) && x == y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool FcmpOne<T>(T x, T y)
		where T : IEqualityOperators<T, T, bool>, INumberBase<T> => !IsUnordered(x, y) && x != y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool FcmpOgt<T>(T x, T y)
		where T : IComparisonOperators<T, T, bool>, INumberBase<T> => !IsUnordered(x, y) && x > y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool FcmpOge<T>(T x, T y)
		where T : IComparisonOperators<T, T, bool>, INumberBase<T> => !IsUnordered(x, y) && x >= y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool FcmpOlt<T>(T x, T y)
		where T : IComparisonOperators<T, T, bool>, INumberBase<T> => !IsUnordered(x, y) && x < y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool FcmpOle<T>(T x, T y)
		where T : IComparisonOperators<T, T, bool>, INumberBase<T> => !IsUnordered(x, y) && x <= y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrEquals<T>(T x, T y)
		where T : INumberBase<T>
	{
		return IsUnordered(x, y) || x == y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrNotEquals<T>(T x, T y)
		where T : INumberBase<T>
	{
		return IsUnordered(x, y) || x != y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrGreaterThan<T>(T x, T y)
		where T : INumberBase<T>, IComparisonOperators<T, T, bool>
	{
		return IsUnordered(x, y) || x > y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrGreaterThanOrEquals<T>(T x, T y)
		where T : INumberBase<T>, IComparisonOperators<T, T, bool>
	{
		return IsUnordered(x, y) || x >= y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrLessThan<T>(T x, T y)
		where T : INumberBase<T>, IComparisonOperators<T, T, bool>
	{
		return IsUnordered(x, y) || x < y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrLessThanOrEquals<T>(T x, T y)
		where T : INumberBase<T>, IComparisonOperators<T, T, bool>
	{
		return IsUnordered(x, y) || x <= y;
	}

	// Integer comparisons for non-native types (e.g. Int128 / UInt128)
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpEq<T>(T x, T y)
		where T : IEqualityOperators<T, T, bool> => x == y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpNe<T>(T x, T y)
		where T : IEqualityOperators<T, T, bool> => x != y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpSgt<T>(T x, T y)
		where T : IComparisonOperators<T, T, bool> => x > y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpSge<T>(T x, T y)
		where T : IComparisonOperators<T, T, bool> => x >= y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpSlt<T>(T x, T y)
		where T : IComparisonOperators<T, T, bool> => x < y;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpSle<T>(T x, T y)
		where T : IComparisonOperators<T, T, bool> => x <= y;

	// Unsigned comparisons: reinterpret Int128 -> UInt128 via Unsafe.BitCast
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpUgt<T>(T x, T y)
		where T : struct => Unsafe.BitCast<T, UInt128>(x) > Unsafe.BitCast<T, UInt128>(y);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpUge<T>(T x, T y)
		where T : struct => Unsafe.BitCast<T, UInt128>(x) >= Unsafe.BitCast<T, UInt128>(y);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpUlt<T>(T x, T y)
		where T : struct => Unsafe.BitCast<T, UInt128>(x) < Unsafe.BitCast<T, UInt128>(y);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IntCmpUle<T>(T x, T y)
		where T : struct => Unsafe.BitCast<T, UInt128>(x) <= Unsafe.BitCast<T, UInt128>(y);

	/// <summary>
	/// Truncate/zero-extend between two value types by copying the lower N bytes.
	/// Works for conversions between standard integers and non-standard inline-array integers.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static unsafe TTarget TruncOrZextToBytes<TSource, TTarget>(TSource source)
		where TSource : struct
		where TTarget : struct
	{
		TTarget result = default;
		uint copySize = (uint)Math.Min(Unsafe.SizeOf<TSource>(), Unsafe.SizeOf<TTarget>());
		Buffer.MemoryCopy(
			Unsafe.AsPointer(ref source),
			Unsafe.AsPointer(ref result),
			Unsafe.SizeOf<TTarget>(),
			copySize
		);
		return result;
	}

	/// <summary>
	/// Sign-extend from a non-standard inline-array integer to a larger type.
	/// sourceBits is the actual number of valid bits in TSource.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static unsafe TTarget SextToBytes<TSource, TTarget>(TSource source, int sourceBits)
		where TSource : struct
		where TTarget : struct
	{
		TTarget result = default;
		int srcSize = Unsafe.SizeOf<TSource>();
		Buffer.MemoryCopy(
			Unsafe.AsPointer(ref source),
			Unsafe.AsPointer(ref result),
			Unsafe.SizeOf<TTarget>(),
			srcSize
		);

		bool signBitSet =
			(
				((byte*)Unsafe.AsPointer(ref source))[(sourceBits - 1) / 8]
				& (1 << ((sourceBits - 1) & 7))
			) != 0;
		if (signBitSet)
		{
			byte* dst = (byte*)Unsafe.AsPointer(ref result);
			for (int i = srcSize; i < Unsafe.SizeOf<TTarget>(); i++)
				dst[i] = 0xFF;
			int bitInByte = sourceBits & 7;
			if (bitInByte != 0)
				dst[(sourceBits - 1) / 8] |= (byte)(0xFF << bitInByte);
		}
		return result;
	}
}
