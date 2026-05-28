using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110BIG_COEFFSE.33")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::BIG_COEFFS (.33)")]
internal static partial class Anonymous_namespace_BIG_COEFFS_33
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

	unsafe static Anonymous_namespace_BIG_COEFFS_33()
	{
		Value = new InlineArrayBuilder<InlineArray4_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>
		{
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = new Anon_izyfb7
				{
					Val = 1
				},
				Exponent = -131,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7567108188315734397L, -2424105753120896601L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -130,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5142521911316697462L, -7764985193318123911L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = new Anon_izyfb7
				{
					Val = 1
				},
				Exponent = -130,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3844854378368489872L, -2424105753122410091L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3844854378392706009L, -2424105753122410091L })
					}
				}
			}
		};
		_ = Pointer;
	}
}
