using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.COEFFS_128.41")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.COEFFS_128.41")]
internal static partial class _41
{
	[FixedAddressValueType]
	private static InlineArray8_fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray8_fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray8_fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray8_fputil_DyadicFloat_kt2kd4 Value
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

	unsafe static _41()
	{
		Value = new InlineArrayBuilder<InlineArray8_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
		{
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -127,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 0L, -9223372036854775808L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -128,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3899075386890062161L, -5660435428506895957L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8698002800084809340L, -721156499326601917L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -132,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7117070760484837225L, -2064822672440296359L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -134,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1748631367195998695L, -7091661442265138866L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -137,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4173178487785724553L, -5853554456092112765L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -140,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1202827264700627332L, -6808165567494560342L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -144,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8844706467831160953L, -7320354865663587L })
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
