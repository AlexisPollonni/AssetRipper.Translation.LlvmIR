using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110BIG_COEFFSE.33")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::BIG_COEFFS (.33)")]
internal static partial class anonymous_namespace_BIG_COEFFS_33
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

	unsafe static anonymous_namespace_BIG_COEFFS_33()
	{
		Value = new InlineArrayBuilder<InlineArray4_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
		{
			new fputil_DyadicFloat_kt2kd4
			{
				sign = new anon_izyfb7
				{
					val = 1
				},
				exponent = -131,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7567108188315734397L, -2424105753120896601L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -130,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5142521911316697462L, -7764985193318123911L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = new anon_izyfb7
				{
					val = 1
				},
				exponent = -130,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3844854378368489872L, -2424105753122410091L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3844854378392706009L, -2424105753122410091L })
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
