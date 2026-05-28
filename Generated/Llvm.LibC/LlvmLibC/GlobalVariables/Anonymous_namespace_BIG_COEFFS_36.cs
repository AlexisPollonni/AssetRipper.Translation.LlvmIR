using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110BIG_COEFFSE.36")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::BIG_COEFFS (.36)")]
internal static partial class Anonymous_namespace_BIG_COEFFS_36
{
	[FixedAddressValueType]
	private static InlineArray3_Fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray3_Fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray3_Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray3_Fputil_DyadicFloat_kt2kd4 Value
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

	unsafe static Anonymous_namespace_BIG_COEFFS_36()
	{
		Value = new InlineArrayBuilder<InlineArray3_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>
		{
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5360311714475845604L, -9223372036854339824L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2448331155046806610L, -6148914691236517187L })
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
