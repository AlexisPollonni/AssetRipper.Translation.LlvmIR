using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110BIG_COEFFSE.31")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::BIG_COEFFS (.31)")]
internal static partial class anonymous_namespace_BIG_COEFFS_31
{
	[FixedAddressValueType]
	private static InlineArray4_fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray4_fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray4_fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_fputil_DyadicFloat_kt2kd4 Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static anonymous_namespace_BIG_COEFFS_31()
	{
		Value = new InlineArrayBuilder<InlineArray4_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
		{
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -130,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9139919541661348187L, -3689348769723653225L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = new anon_izyfb7
				{
					val = 1
				},
				exponent = -129,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4163425970308718250L, -9223372036854482768L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -129,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6160788120863886750L, -6148914691236517206L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = new anon_izyfb7
				{
					val = 1
				},
				exponent = -128,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 0L, -9223372036854775808L })
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
