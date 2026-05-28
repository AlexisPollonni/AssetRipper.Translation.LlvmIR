using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110BIG_COEFFSE.31")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::BIG_COEFFS (.31)")]
internal static partial class Anonymous_namespace_BIG_COEFFS_31
{
	[FixedAddressValueType]
	private static InlineArray4_Fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray4_Fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray4_Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_Fputil_DyadicFloat_kt2kd4 Value
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

	unsafe static Anonymous_namespace_BIG_COEFFS_31()
	{
		Value = new InlineArrayBuilder<InlineArray4_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>
		{
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -130,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9139919541661348187L, -3689348769723653225L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = new Anon_izyfb7
				{
					Val = 1
				},
				Exponent = -129,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4163425970308718250L, -9223372036854482768L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -129,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6160788120863886750L, -6148914691236517206L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = new Anon_izyfb7
				{
					Val = 1
				},
				Exponent = -128,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 0L, -9223372036854775808L })
					}
				}
			}
		};
		_ = Pointer;
	}
}
